CREATE TABLE [dbo].[Jobs] (
	[Id]		    NVARCHAR (100) PRIMARY KEY NOT NULL,
    [JobName]       VARCHAR (100) NULL,
    [CompanyName]   VARCHAR (255) NULL,
    [Salary]        VARCHAR (100) NULL,
    [JobLocation]   VARCHAR (100) NULL
);

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation)
VALUES
  ('01', 'Software Engineer', 'Technology Corp', 'Negotiable', 'Ho Chi Minh City'),
  ('02', 'Data Analyst', 'Financial Inc.', 'VND 30,000,000 - 40,000,000', 'Ha Noi'),
  ('03', 'Marketing Manager', 'Global Enterprises', 'Competitive', 'Da Nang'),
  ('04', 'Web Developer', 'Startup Company', 'USD 50,000 - 70,000', 'Remote'),
  ('05', 'Graphic Designer', 'Advertising Agency', 'VND 15,000,000 - 20,000,000', 'Can Tho'),
  ('06',  'Sales Representative', 'Retail Store', 'Commission-based', 'HCMC or Da Nang'),
  ('07', 'Customer Service Specialist', 'E-commerce Platform', 'VND 12,000,000 - 15,000,000', 'Flexible Location'),
  ('08', 'Business Analyst', 'Consulting Firm', 'Attractive Package', 'Ha Noi or Da Nang'),
  ('09', 'Content Writer', 'Media Company', 'VND 20,000,000 - 25,000,000', 'Remote or Ho Chi Minh City'),
  ('10', 'IT Support Specialist', 'Tech Solutions', 'VND 18,000,000 - 22,000,000', 'Ha Noi or Ho Chi Minh City');