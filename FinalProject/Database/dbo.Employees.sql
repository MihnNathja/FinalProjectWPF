CREATE TABLE [dbo].[Employees]
(
	[ID] NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName] VARCHAR(100) NOT NULL,
	[Password] VARCHAR(100) NOT NULL,
	[Type] VARCHAR(50) NOT NULL,
    [EmployeeName] NVARCHAR(50) NULL, 
    [Gender] NCHAR(10) NULL, 
    [EmployeeLocation] NVARCHAR(MAX) NULL, 
    [DateOfBirth] DATETIME2 NULL, 
    [Phone] NCHAR(10) NULL, 
    [CCCD] NVARCHAR(50) NULL,
)
