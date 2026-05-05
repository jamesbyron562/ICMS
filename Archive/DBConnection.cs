using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ICMS
{
    public static class DBConnection
    {
        // Returns a SqlConnection using a connection string named "ICMS".
        // Tries to read from ConfigurationManager if available at runtime (no compile-time dependency),
        // otherwise falls back to environment variables "ICMS" or "ICMS_CONN".
        public static SqlConnection GetConnection()
        {
            string connStr = GetConnectionStringFromConfig() ?? Environment.GetEnvironmentVariable("ICMS") ?? Environment.GetEnvironmentVariable("ICMS_CONN");
            if (string.IsNullOrWhiteSpace(connStr))
                throw new InvalidOperationException("Connection string 'ICMS' not found. Add a connection string named 'ICMS' to configuration, install the System.Configuration.ConfigurationManager package, or set the 'ICMS'/'ICMS_CONN' environment variable.");

            return new SqlConnection(connStr);
        }

        // Executes a scalar COUNT(*) query and returns the integer result.
        public static int GetCount(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                throw new ArgumentException("SQL cannot be null or empty.", nameof(sql));

            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value) return 0;
                    return Convert.ToInt32(result);
                }
            }
        }

        // Use reflection to attempt to read System.Configuration.ConfigurationManager without a compile-time dependency.
        private static string GetConnectionStringFromConfig()
        {
            var cs = ConfigurationManager.ConnectionStrings["ICMS"];
            if (cs != null && !string.IsNullOrWhiteSpace(cs.ConnectionString))
                return cs.ConnectionString;

            // fallback to appSettings key "ConnectionString" if connectionStrings entry is not present
            var app = ConfigurationManager.AppSettings["ConnectionString"];
            return app;
        }
    }
}
