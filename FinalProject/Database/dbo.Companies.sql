CREATE TABLE [dbo].[Companies] (
    [ID]                NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName]          VARCHAR(100) NOT NULL,
	[Password]          VARCHAR(100) NOT NULL,
	[Type]              VARCHAR(50) NOT NULL,
	[CompanyName]	    VARCHAR (255) NULL,
    [Mst]               VARCHAR (100) NOT NULL,
    [CompanyLocation]   VARCHAR (255) NULL,
    [Boss]             VARCHAR (100) NULL,
    [PhoneNumber]       VARCHAR (100) NULL
);
