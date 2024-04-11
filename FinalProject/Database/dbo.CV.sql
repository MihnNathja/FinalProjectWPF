CREATE TABLE [dbo].[CV] (
    [IdCV]           NCHAR (10)     NOT NULL,
	[CVTitle]        NVARCHAR (100) NULL,
    [Careergoals]    NVARCHAR (100) NULL,
    [Skill]          NVARCHAR (100) NULL,
    [Presenter]      NVARCHAR (50)  NULL,
    [Experience]     NVARCHAR (MAX) NULL,
    [Activitie]      NVARCHAR (MAX) NULL,
    [Certificate]    NVARCHAR (MAX) NULL,
    [Awards]         NVARCHAR (MAX) NULL,
    [AddInformation] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([IdCV] ASC)
);

