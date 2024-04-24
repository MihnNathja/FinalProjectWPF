CREATE TABLE [dbo].[Companies] (
    [ID]                NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName]          VARCHAR(100) NOT NULL,
	[Password]          VARCHAR(100) NOT NULL,
	[Type]              VARCHAR(50) NOT NULL,
	[CompanyName]	    VARCHAR (255) NULL,
    [Mst]               VARCHAR (100) NOT NULL,
    [CompanyLocation]   VARCHAR (255) NULL,
    [Boss]             VARCHAR (100) NULL,
    [PhoneNumber]       VARCHAR (100) NULL
);

INSERT INTO [dbo].[Companies] (ID, UserName, Password, Type, CompanyName, Mst, CompanyLocation, Boss, PhoneNumber)
VALUES
  ('1', 'techcorp_admin', '123', 'Technology', 'Technology Corp', 'MST-00001', 'Ho Chi Minh City', 'John Doe', '+84 28 1234 5678'),
  ('2', 'financial_inc_admin', '123', 'Finance', 'Financial Inc.', 'MST-00002', 'Ha Noi', 'Jane Smith', '+84 24 3456 7890'),
  ('3', 'global_enterprises_admin', '123', 'Consulting', 'Global Enterprises', 'MST-00003', 'Da Nang', 'Michael Lee', '+84 90 5678 1234'),
  ('4', 'startup_company_admin', '123', 'Startup', 'Startup Company', 'MST-00004', 'Remote', 'David Kim', '+84 98 7654 3210'),
  ('5', 'advertising_agency_admin', '123', 'Marketing', 'Advertising Agency', 'MST-00005', 'Can Tho', 'Sarah Nguyen', '+84 29 9876 5432'),
  ('6', 'retail_store_admin', '123', 'Retail', 'Retail Store', 'MST-00006', 'HCMC or Da Nang', 'Charles Nguyen', '+84 93 1234 7856'),
  ('7', 'ecommerce_platform_admin', '123', 'E-commerce', 'E-commerce Platform', 'MST-00007', 'Flexible Location', 'Mary Tran', '+84 25 5678 9012'),
  ('8', 'consulting_firm_admin', '123', 'Consulting', 'Consulting Firm', 'MST-00008', 'Ha Noi or Da Nang', 'Robert Brown', '+84 91 7856 3214'),
  ('9', 'media_company_admin', '123', 'Media', 'Media Company', 'MST-00009', 'Remote or Ho Chi Minh City', 'Emily Park', '+84 27 3210 5678'),
  ('10', 'tech_solutions_admin', '123', 'Technology', 'Tech Solutions', 'MST-00010', 'Ha Noi or Ho Chi Minh City', 'Lisa Davis', '+84 94 9012 7836');
