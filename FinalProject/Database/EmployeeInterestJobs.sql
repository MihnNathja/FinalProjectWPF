CREATE TABLE [dbo].[EmployeeInterestJobs]
(
	[IdEmployee]	NVARCHAR (100) NOT NULL,
	[IdJob]			NVARCHAR (100) NOT NULL,
	PRIMARY KEY(IdEmployee, IdJob)
)