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
('01', '1', 'Software Engineer - John Walker', 'To obtain a senior software engineer position and leverage my experience to design, develop, and implement complex software solutions.', 'Programming Languages (Java, Python, C++), Software Design Patterns, Problem-solving, Teamwork', 'John Walker', 'Developed and maintained enterprise applications for Tech Corp, utilizing Agile methodologies. 3 years of experience.', 'Mentored junior developers at a coding bootcamp.', 'Bachelor of Science in Computer Science', 'None awarded yet, but highly motivated and eager to learn.', 'Excited to contribute to a fast-paced and innovative environment.');

INSERT INTO CV (IdCV, ID, CVTitle, Careergoals, Skill, Presenter, Experience, Activitie, Certificate, Awards, AddInformation)
VALUES
('02', '2', 'Data Analyst - Jane Doe', 'To secure a data analyst role where I can utilize my analytical skills and financial knowledge to generate valuable business insights.', 'Data Analysis (Excel, SQL), Financial Modeling, Data Visualization (Tableau)', 'Jane Doe', 'Performed in-depth financial data analysis for Financial Inc., identifying trends and recommending investment strategies. 5 years of experience.', 'Volunteered as a financial literacy tutor for underprivileged communities.', 'Master of Business Administration (MBA) with a specialization in Finance', 'Employee of the Month at Financial Inc. (Q3 2023)', 'Highly organized and possess excellent communication skills.');

INSERT INTO CV (IdCV, ID, CVTitle, Careergoals, Skill, Presenter, Experience, Activitie, Certificate, Awards, AddInformation)
VALUES
('03', '3', 'Marketing Manager - Michael Lee', 'To lead and manage a high-performing marketing team, driving brand awareness and achieving profitable growth for the company.', 'Marketing Strategies, Social Media Marketing, Content Marketing, Campaign Management', 'Michael Lee', 'Developed and executed successful marketing campaigns for Global Enterprises, resulting in a 20% increase in website traffic. 7 years of experience.', 'Led a team of volunteers to organize a fundraising event for a local charity.', 'Bachelor of Arts in Marketing', 'Awarded "Marketing Campaign of the Year" at Global Enterprises (2022)', 'A creative and results-oriented marketing professional with a passion for building brands.');

INSERT INTO CV (IdCV, ID, CVTitle, Careergoals, Skill, Presenter, Experience, Activitie, Certificate, Awards, AddInformation)
VALUES
('04', '4', 'Web Developer - Alice Young', 'To become a full-stack developer and contribute to the development of innovative web applications.', 'Web Development (HTML, CSS, JavaScript, React)', 'Alice Young', 'Built and maintained responsive web applications for various clients as a freelance developer. 2 years of experience.', 'Contributed to open-source web development projects on GitHub.', 'Bachelor of Science in Information Technology', 'None awarded yet, but actively participating in online coding challenges.', 'Highly motivated and eager to learn new technologies.');


INSERT INTO CV (IdCV, ID, CVTitle, Careergoals, Skill, Presenter, Experience, Activitie, Certificate, Awards, AddInformation)
VALUES
('05', '5', 'Graphic Designer - David Kim', 'To secure a graphic designer position in a creative agency and contribute to the creation of visually appealing and impactful designs.', 'Graphic Design Software (Adobe Photoshop, Illustrator), Branding, Marketing Materials Design', 'David Kim', 'Designed logos, brochures, and social media graphics for Advertising Agency. 5 years of experience.', 'Participated in local design competitions and exhibitions.', 'Bachelor of Fine Arts in Graphic Design', 'Won "Best Logo Design" award at a local design competition (2022)', 'A detail-oriented and passionate designer with a strong sense of aesthetics.');


