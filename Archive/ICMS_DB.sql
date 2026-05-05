CREATE DATABASE ICMS_DB;
GO
USE ICMS_DB;
GO

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50),
    Password VARCHAR(50),
    FullName VARCHAR(100),
    Role VARCHAR(50),
    Status VARCHAR(20)
);

INSERT INTO Users VALUES ('admin','1234','Admin User','Administrator','Active');

CREATE TABLE Computers (
    ComputerID INT PRIMARY KEY IDENTITY(1,1),
    PCNumber VARCHAR(20),
    Status VARCHAR(20)
);

INSERT INTO Computers VALUES
('PC 01','Available'),('PC 02','Available'),('PC 03','Available'),('PC 04','Available'),('PC 05','Available'),
('PC 06','Available'),('PC 07','Available'),('PC 08','Available'),('PC 09','Available'),('PC 10','Available');

CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName VARCHAR(100),
    PCNumber VARCHAR(20),
    TimeIn DATETIME,
    TimeOut DATETIME,
    HoursUsed FLOAT,
    RatePerHour FLOAT,
    TotalAmount FLOAT
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100),
    Age INT,
    ContactNo VARCHAR(20),
    Email VARCHAR(100),
    Address VARCHAR(200)
);
