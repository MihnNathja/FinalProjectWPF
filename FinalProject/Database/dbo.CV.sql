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

INSERT INTO CV (IdCV, ID, CVTitle, Careergoals, Skill, Presenter, Experience, Activitie, Certificate, Awards, AddInformation)
VALUES
('CV-001', 'EMP-001', 'Software Engineer - John Walker', 'To obtain a senior software engineer position and leverage my experience to design, develop, and implement complex software solutions.', 'Programming Languages (Java, Python, C++), Software Design Patterns, Problem-solving, Teamwork', 'John Walker', 'Developed and maintained enterprise applications for Tech Corp, utilizing Agile methodologies. 3 years of experience.', 'Mentored junior developers at a coding bootcamp.', 'Bachelor of Science in Computer Science', 'None awarded yet, but highly motivated and eager to learn.', 'Excited to contribute to a fast-paced and innovative environment.'),
('CV-002', 'EMP-002', 'Data Analyst - Jane Doe', 'To secure a data analyst role where I can utilize my analytical skills and financial knowledge to generate valuable business insights.', 'Data Analysis (Excel, SQL), Financial Modeling, Data Visualization (Tableau)', 'Jane Doe', 'Performed in-depth financial data analysis for Financial Inc., identifying trends and recommending investment strategies. 5 years of experience.', 'Volunteered as a financial literacy tutor for underprivileged communities.', 'Master of Business Administration (MBA) with a specialization in Finance', 'Employee of the Month at Financial Inc. (Q3 2023)', 'Highly organized and possess excellent communication skills.');
