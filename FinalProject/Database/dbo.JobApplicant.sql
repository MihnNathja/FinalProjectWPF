CREATE TABLE [dbo].[JobApplicant]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FullName] NVARCHAR(50) NULL, 
    [Gender] NCHAR(10) NULL, 
    [Address] NVARCHAR(MAX) NULL, 
    [Birthday] DATETIME2 NULL, 
    [Phone] NCHAR(10) NULL, 
    [CCCD] NVARCHAR(50) NULL,

)
