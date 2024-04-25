CREATE TABLE [dbo].[Jobs] (
	[Id]		    NVARCHAR (100) PRIMARY KEY NOT NULL,
    [JobName]       NVARCHAR (100) NULL,
    [CompanyName]   NVARCHAR (255) NULL,
    [Salary]        NVARCHAR (100) NULL,
    [JobLocation]   NVARCHAR (100) NULL,
    [Experience]    NVARCHAR (MAX) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Require]       NVARCHAR (MAX) NULL,
    [Right]         NVARCHAR (MAX) NULL,
    [WorkTime]      NVARCHAR (MAX) NULL,
);