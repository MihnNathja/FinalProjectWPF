﻿CREATE TABLE [dbo].[Jobs] (
	[Id]		    NVARCHAR (100) PRIMARY KEY NOT NULL,
    [JobName]       NVARCHAR (100) NULL,
    [CompanyName]   NVARCHAR (255) NULL,
    [Salary]        NVARCHAR (100) NULL,
    [JobLocation]   NVARCHAR (100) NULL,
    [Experience]    NVARCHAR (MAX) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Require]       NVARCHAR (MAX) NULL,
    [Benefit]       NVARCHAR (MAX) NULL,
    [WorkTime]      NVARCHAR (MAX) NULL,
);
INSERT INTO Jobs (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('1', 'Software Engineer', 'Tech Corporation', 'Competitive Salary (Negotiable)', 'Ho Chi Minh City, Vietnam (Flexible/Remote Possible)', '2+ years of experience in software development (Java, Python, C++ preferred)', 'Develop, maintain, and implement complex software solutions utilizing Agile methodologies. Work collaboratively with a team of engineers to design and deliver high-quality software products.', 'Strong programming skills, problem-solving abilities, and experience in object-oriented programming. Excellent communication and teamwork skills. A passion for innovation and continuous learning.', 'Competitive salary and benefits package, health insurance, professional development opportunities, dynamic work environment.', 'Full-time (Flexible hours possible)'),
('2', 'Data Analyst', 'Financial Inc.', 'Attractive Salary + Bonus', 'Ha Noi, Vietnam', '3+ years of experience in data analysis (Excel, SQL preferred), Financial Modeling', 'Perform in-depth financial data analysis to identify trends and generate valuable business insights. Recommend investment strategies and support financial decision-making.', 'Strong analytical skills, proficiency in data analysis tools (Excel, SQL), and financial modeling techniques. Excellent communication and presentation skills. Ability to work independently and as part of a team.', 'Competitive salary and benefits package, health insurance, bonus opportunities, career development programs.', 'Full-time (40 hours per week)'),
('3', 'Marketing Manager', 'Global Enterprises', 'Competitive Salary + Performance Bonus', 'Singapore', '5+ years of marketing experience with a proven track record of success. Experience in digital marketing and e-commerce strategies a plus.', 'Lead and manage a high-performing marketing team to develop and execute successful marketing campaigns. Drive brand awareness and achieve profitable growth for the company.', 'Strong leadership skills, experience in developing and implementing marketing strategies, excellent communication and interpersonal skills. In-depth knowledge of digital marketing channels and e-commerce trends.', 'Competitive salary and benefits package, health insurance, bonus opportunities, relocation assistance (if applicable).', 'Full-time (40 hours per week)'),
('4', 'Mobile App Developer', 'Creative Labs', 'Competitive Salary + Stock Options', 'Da Nang, Vietnam (Remote Possible)', '2+ years of experience in mobile app development (React Native, Flutter preferred)', 'Develop and maintain innovative mobile applications for various platforms. Contribute to a fast-paced and collaborative work environment.', 'Strong programming skills in mobile app development frameworks (React Native, Flutter). Experience in UI/UX design a plus. Excellent communication and teamwork skills.', 'Competitive salary and benefits package, health insurance, stock options, flexible work arrangements (remote possible).', 'Full-time (Flexible hours possible)'),
('5', 'Graphic Designer', 'AdMax Agency', 'Competitive Salary + Benefits', 'Can Tho, Vietnam', '3+ years of experience in graphic design (Adobe Photoshop, Illustrator preferred)', 'Develop creative and visually appealing graphic design materials for marketing campaigns and branding initiatives.', 'Strong proficiency in graphic design software (Adobe Photoshop, Illustrator). Experience in marketing and branding principles a plus. Excellent communication and collaboration skills.', 'Competitive salary and benefits package, health insurance, professional development opportunities, creative work environment.', 'Full-time (40 hours per week)');
