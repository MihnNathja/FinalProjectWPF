CREATE TABLE [dbo].[ApplyCV] (
    [ID]        NVARCHAR (100) NOT NULL,
    [IdCV]      NVARCHAR (100) NOT NULL,
    [IdEmployee]NVARCHAR (100) NOT NULL,
    [ACCEPT]    BIT NULL,
    [Interview] DateTime NULL,
    [Confirm]   BIT NULL,
    PRIMARY KEY(ID, IdCV, IdEmployee)
);
