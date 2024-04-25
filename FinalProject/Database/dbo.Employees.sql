CREATE TABLE [dbo].[Employees]
(
	[ID]                    NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName]              NVARCHAR(100) NOT NULL,
	[Password]              NVARCHAR(100) NOT NULL,
	[Type]                  NVARCHAR(50) NOT NULL,
    [EmployeeName]          NVARCHAR(50) NULL, 
    [Gender]                NCHAR(10) NULL, 
    [EmployeeLocation]      NVARCHAR(MAX) NULL, 
    [DateOfBirth]           DATETIME2 NULL, 
    [Phone]                 NCHAR(10) NULL, 
    [CCCD]                  NVARCHAR(50) NULL,
)
