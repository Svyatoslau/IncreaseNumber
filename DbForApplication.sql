USE [master]
GO

CREATE DATABASE [testdb]
GO

USE [testdb]
GO

CREATE TABLE [Counter]
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Value] INT NOT NULL,
	LastChange DATETIME NOT NULL,
	PickedDate DATE NULL
)