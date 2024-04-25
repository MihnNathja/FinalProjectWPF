CREATE TABLE [dbo].[CV] (
    [IdCV]           NVARCHAR (100)  NOT NULL,
    [ID]             NVARCHAR (100) NOT NULL,
	[CVTitle]        NVARCHAR (MAX) NULL,
    [Careergoals]    NVARCHAR (MAX) NULL,
    [Skill]          NVARCHAR (MAX) NULL,
    [Presenter]      NVARCHAR (MAX)  NULL,
    [Experience]     NVARCHAR (MAX) NULL,
    [Activitie]      NVARCHAR (MAX) NULL,
    [Certificate]    NVARCHAR (MAX) NULL,
    [Awards]         NVARCHAR (MAX) NULL,
    [AddInformation] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([IdCV] ASC)
);

