CREATE TABLE [dbo].[Employees]
(
	[ID] NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName] VARCHAR(100) NOT NULL,
	[Password] VARCHAR(100) NOT NULL,
	[Type] VARCHAR(50) NOT NULL,
    [EmployeeName] NVARCHAR(50) NULL, 
    [Gender] NCHAR(10) NULL, 
    [EmployeeLocation] NVARCHAR(MAX) NULL, 
    [DateOfBirth] DATETIME2 NULL, 
    [Phone] NCHAR(10) NULL, 
    [CCCD] NVARCHAR(50) NULL,
)

INSERT INTO [dbo].[Employees] (ID, UserName, Password, Type, EmployeeName, Gender, EmployeeLocation, DateOfBirth, Phone, CCCD)
VALUES
  ('1', 'techEmp', '123', 'Employee', 'John Walker', 'Male', 'Ho Chi Minh City', '1990-01-01', '8498765421', '123456789012345'),
  ('2', 'financial_inc_analyst1', '123', 'Employee', 'Jane Doe', 'Female', 'Ha Noi', '1985-07-15', '8424876542', '987654321098765'),
  ('3', 'global_ent_marketing1', '123', 'Employee', 'Michael Lee', 'Male', 'Da Nang', '1995-03-22', '4901234678', '543210987654321'),
  ('4', 'startup_dev1', '123', 'Employee', 'Alice Young', 'Female', 'Remote', '2000-11-10', '4937890134', '321098765432109'),
  ('5', 'ad_agency_designer1', '123', 'Employee', 'David Kim', 'Male', 'Can Tho', '1988-05-05', '8429567801', '765432109876543'),
  ('6', 'retail_store_sales1', '123', 'Employee', 'Sarah Nguyen', 'Female', 'HCMC', '1992-09-21', '8494123678', '109876543210987'),
  ('7', 'ecommerce_platform_cs1', '123', 'Employee', 'Charles Nguyen', 'Male', 'Flexible Location', '1998-12-25', '4234567890', '987654321054321'),
  ('8', 'consulting_firm_ba1', '123', 'Employee', 'Mary Tran', 'Female', 'Ha Noi', '1987-02-14', '8491756310', '543210987610987'),
  ('9', 'media_company_writer1', '123', 'Employee', 'Robert Brown', 'Male', 'Remote or Ho Chi Minh City', '1993-08-08', '8421234678', '321098765476543'),
  ('10', 'tech_solutions_support1', '123', 'Employee', 'Emily Park', 'Female', 'Ha Noi or Ho Chi Minh City', '1999-04-19', '8495679012', '109876543254321');
