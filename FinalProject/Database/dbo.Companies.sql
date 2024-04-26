CREATE TABLE [dbo].[Companies] (
    [ID]                NVARCHAR (100) PRIMARY KEY NOT NULL,
    [UserName]          NVARCHAR(100) NOT NULL,
	[Password]          NVARCHAR(100) NOT NULL,
	[Type]              NVARCHAR(50) NOT NULL,
	[CompanyName]	    NVARCHAR (255) NULL,
    [Mst]               NVARCHAR (100) NOT NULL,
    [CompanyLocation]   NVARCHAR (255) NULL,
    [Boss]              NVARCHAR (100) NULL,
    [PhoneNumber]       NVARCHAR (100) NULL,
    [Email]             NVARCHAR (MAX) NULL,
    [Field]             NVARCHAR (MAX) NULL,
    [Description]       NVARCHAR (MAX) NULL,
);
INSERT INTO Companies (ID, UserName, Password, Type, CompanyName, Mst, CompanyLocation, Boss, PhoneNumber, Email, Field, Description)
VALUES
('COMP-001', '1', '1', 'Company', 'Tech Corporation', '0123456789', 'Ho Chi Minh City, Vietnam', 'Mr. Lee', '+84 28 3811 0000', 'info@techcorp.com', 'Information Technology, Software Development', 'Tech Corporation is a leading software development company specializing in enterprise applications. We offer a dynamic work environment and opportunities for professional growth.'),
('COMP-002', 'financial_inc_admin', 'your_strong_password', 'Company', 'Financial Inc.', '9876543210', 'Ha Noi, Vietnam', 'Ms. Nguyen', '+84 24 3852 7777', 'contact@financialinc.vn', 'Finance, Investment Management', 'Financial Inc. is a reputable financial services company offering investment analysis, wealth management, and financial planning solutions.'),
('COMP-003', 'global_ent_admin', 'your_strong_password', 'Company', 'Global Enterprises', '1234567890', 'Singapore', 'Mr. Tan', '+65 6789 1234', 'globalent@globalent.com.sg', 'Marketing, E-commerce', 'Global Enterprises is a multinational corporation specializing in consumer goods and e-commerce solutions. We operate in various countries across Southeast Asia.'),
('COMP-004', 'startup_admin', 'your_strong_password', 'Company', 'Creative Labs', '0012345678', 'Da Nang, Vietnam', 'Ms. Linh', '+84 908 765 432', 'creativelabs@dalat.com', 'Software Development, Mobile Apps', 'Creative Labs is a young and innovative startup developing cutting-edge mobile applications. We foster a collaborative and fast-paced work environment.'),
('COMP-005', 'ad_agency_admin', 'your_strong_password', 'Company', 'AdMax Agency', '1122334455', 'Can Tho, Vietnam', 'Mr. David', '+84 723 567 890', 'admaxagency@cantho.com.vn', 'Marketing, Advertising, Graphic Design', 'AdMax Agency is a full-service advertising agency specializing in creative marketing campaigns and brand development.');

