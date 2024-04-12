CREATE TABLE [dbo].[Companies] (
    [ID] INT PRIMARY KEY NOT NULL,
	[CompanyName]		 VARCHAR (255) NULL,
    [Mst]        VARCHAR (100) NOT NULL,
    [CompanyLocation] VARCHAR (255) NULL,
    [Boss ]      VARCHAR (100) NULL,
    [PhoneNumber]    VARCHAR (100) NULL
);

INSERT INTO Companies (ID, CompanyName, Mst, CompanyLocation, Boss, PhoneNumber) VALUES (1, 'FPT', '123', 'HCM', 'NVA', '0123456789');