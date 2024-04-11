CREATE TABLE [dbo].[CV]
(
	[IdCV] INT IDENTITY(1,1) PRIMARY KEY, 
    [Careergoals] NVARCHAR(MAX) NULL, 
    [Skill] NVARCHAR(MAX) NULL, 
    [Presenter] NVARCHAR(50) NULL, 
    [Experience] NVARCHAR(MAX) NULL, 
    [Activitie] NVARCHAR(MAX) NULL, 
    [Certificate] NVARCHAR(MAX) NULL, 
    [Awards] NVARCHAR(MAX) NULL, 
    [AddInformation] NVARCHAR(MAX) NULL
)
