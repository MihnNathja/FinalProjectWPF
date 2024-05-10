CREATE TABLE [dbo].[CompanyInterestEmployees]
(
	[IdCompany]		NVARCHAR (100) NOT NULL,
	[IdEmployee]	NVARCHAR (100) NOT NULL,
	[IdCV]			NVARCHAR (100) NOT NULL,
	PRIMARY KEY([IdCompany], IdEmployee, IdCV)
)