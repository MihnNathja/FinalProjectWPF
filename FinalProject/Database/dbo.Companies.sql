CREATE TABLE [dbo].[Companies] (
    [ID]                NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName]          NVARCHAR(100) NOT NULL,
	[Password]          NVARCHAR(100) NOT NULL,
	[Type]              NVARCHAR(50) NOT NULL,
	[CompanyName]	    NVARCHAR (255) NULL,
    [Mst]               NVARCHAR (100) NOT NULL,
    [CompanyLocation]   NVARCHAR (255) NULL,
    [Boss]              NVARCHAR (100) NULL,
    [PhoneNumber]       NVARCHAR (100) NULL,
    [Email]             NVARCHAR (100) NULL,
    [Field]             NVARCHAR (100) NULL,
    [Description]       NVARCHAR (100) NULL,
);

 