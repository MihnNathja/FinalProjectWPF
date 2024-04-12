CREATE TABLE [dbo].[Employees]
(
	[ID] INT PRIMARY KEY REFERENCES Users(ID) NOT NULL,
    [FullName] NVARCHAR(50) NULL, 
    [Gender] NCHAR(10) NULL, 
    [Address] NVARCHAR(MAX) NULL, 
    [Birthday] DATETIME2 NULL, 
    [Phone] NCHAR(10) NULL, 
    [CCCD] NVARCHAR(50) NULL,
)
