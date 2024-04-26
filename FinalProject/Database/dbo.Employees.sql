CREATE TABLE [dbo].[Employees]
(
	[ID]                    NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName]              NVARCHAR(100) NOT NULL,
	[Password]              NVARCHAR(100) NOT NULL,
	[Type]                  NVARCHAR(50) NOT NULL,
    [EmployeeName]          NVARCHAR(50) NULL, 
    [Gender]                NCHAR(10) NULL, 
    [EmployeeLocation]      NVARCHAR(MAX) NULL, 
    [DateOfBirth]           DATETIME2 NULL, 
    [Phone]                 NCHAR(10) NULL, 
    [CCCD]                  NVARCHAR(50) NULL,
)
INSERT INTO Employees (ID, UserName, Password, Type, EmployeeName, Gender, EmployeeLocation, DateOfBirth, Phone, CCCD)
VALUES
('1', 'tech_emp', '123', 'Employee', 'John Walker', 'Male', 'Ho Chi Minh City, Vietnam', '1990-01-01', '8498765421', '123456789012345'),
('2', 'financial_inc_analyst1', '123', 'Employee', 'Jane Doe', 'Female', 'Ha Noi, Vietnam', '1985-07-15', '8424876542', '987654321098765'),
('3', 'global_ent_marketing1', '123', 'Employee', 'Michael Lee', 'Male', 'Da Nang, Vietnam', '1995-03-22', '4901234678', '543210987654321'),
('4', 'startup_dev1', '123', 'Employee', 'Alice Young', 'Female', 'Remote', '2000-11-10', '4937890134', '321098765432109'),
('5', 'ad_agency_designer1', '123', 'Employee', 'David Kim', 'Male', 'Can Tho, Vietnam', '1988-05-05', '8429567801', '765432109876543'),
('6', 'retail_store_sales1', '123', 'Employee', 'Sarah Nguyen', 'Female', 'HCMC, Vietnam', '1992-09-21', '8494123678', '109876543210987'),
('10', 'tech_solutions_support1', '123', 'Employee', 'Emily Park', 'Female', 'Ha Noi or Ho Chi Minh City', '1999-04-19', '8495679012', '109876543254321');
