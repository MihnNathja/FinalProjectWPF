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
('EMP-001', 'tech_emp', 'your_strong_password', 'Employee', 'John Walker', 'Male', 'Ho Chi Minh City, Vietnam', '1990-01-01', '8498765421', '123456789012345'),
('EMP-002', 'financial_inc_analyst1', 'your_strong_password', 'Employee', 'Jane Doe', 'Female', 'Ha Noi, Vietnam', '1985-07-15', '8424876542', '987654321098765'),
('EMP-003', 'global_ent_marketing1', 'your_strong_password', 'Employee', 'Michael Lee', 'Male', 'Da Nang, Vietnam', '1995-03-22', '4901234678', '543210987654321'),
('EMP-004', 'startup_dev1', 'your_strong_password', 'Employee', 'Alice Young', 'Female', 'Remote', '2000-11-10', '4937890134', '321098765432109'),
('EMP-005', 'ad_agency_designer1', 'your_strong_password', 'Employee', 'David Kim', 'Male', 'Can Tho, Vietnam', '1988-05-05', '8429567801', '765432109876543'),
('EMP-006', 'retail_store_sales1', 'your_strong_password', 'Employee', 'Sarah Nguyen', 'Female', 'HCMC, Vietnam', '1992-09-21', '8494123678', '109876543210987'),
('EMP-010', 'tech_solutions_support1', 'your_strong_password', 'Employee', 'Emily Park', 'Female', 'Ha Noi or Ho Chi Minh City', '1999-04-19', '8495679012', '109876543254321');
