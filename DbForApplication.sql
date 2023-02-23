USE [master]
GO

CREATE DATABASE [TestDb]
GO

USE [TestDb]
GO

CREATE TABLE [Counter]
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Value] INT NOT NULL,
	LastChange DATETIME NOT NULL,
	PickedDate DATE NULL
)
GO

INSERT INTO [Counter] ([Value], [LastChange])
VALUES
(1, GETDATE()),
(2, GETDATE());