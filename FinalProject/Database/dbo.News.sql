CREATE TABLE [dbo].[News] (
    [IdEmployee]    NVARCHAR (100) NOT NULL,
    [IdCV]          NVARCHAR (100) NOT NULL,
    [JobName]       NVARCHAR (MAX) NULL,
    [Experience]    NVARCHAR (MAX) NULL,
    [Location]      NVARCHAR (MAX) NULL,
    [Salary]        NVARCHAR (MAX) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Benefit]       NVARCHAR (MAX) NULL,
    [WorkTime]      NVARCHAR (MAX) NULL,
    PRIMARY KEY( IdEmployee, IdCV)
);