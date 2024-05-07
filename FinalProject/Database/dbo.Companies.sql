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
('1', '1', '1', 'Company', N'Tập đoàn công nghệ', '0123456789', N'Thành phố Hồ Chí Minh, Việt Nam', N'Mr. Lee', '+84 28 3811 0000', N'info@techcorp.com', N'Công nghệ thông tin, Phát triển phần mềm', N'Tech Corporation là công ty phát triển phần mềm hàng đầu chuyên về các ứng dụng doanh nghiệp. Chúng tôi cung cấp một môi trường làm việc năng động và cơ hội phát triển nghề nghiệp.'),
('2', 'financial_inc_admin', 'your_strong_password', 'Company', N'Financial Inc.', '9876543210', N'Hà Nội, Việt Nam', N'Ms. Nguyễn', '+84 24 3852 7777', N'liên hệ @financialinc.vn', N'Tài chính, Quản lý đầu tư', N'Financial Inc. là công ty dịch vụ tài chính uy tín cung cấp các giải pháp phân tích đầu tư, quản lý tài sản và lập kế hoạch tài chính.'),
('3', 'global_ent_admin', 'your_strong_password', 'Company', N'Doanh nghiệp toàn cầu', '1234567890', N'Singapore', N'Mr. Tan', '+65 6789 1234', N'globalent@globalent.com. sg', N'Tiếp thị, Thương mại điện tử', N'Global Enterprises là một tập đoàn đa quốc gia chuyên về hàng tiêu dùng và các giải pháp thương mại điện tử.'),
('4', 'startup_admin', 'your_strong_password', 'Company', N'Creative Labs', '0012345678', N'Đà Nẵng, Việt Nam', N'Ms. Linh', '+84 908 765 432', N'creativelabs@ dalat.com', N'Phát triển phần mềm, ứng dụng di động', N'Creative Labs là một công ty khởi nghiệp trẻ và sáng tạo đang phát triển các ứng dụng di động tiên tiến.'),
('5', 'ad_agency_admin', 'your_strong_password', 'Company', N'Đại lý AdMax', '1122334455', N'Cần Thơ, Việt Nam', N'Mr. David', '+84 723 567 890', N'admaxagency@ cantho.com.vn', N'Marketing, Quảng cáo, Thiết kế đồ họa', N'AdMax Agency là công ty quảng cáo trọn gói chuyên thực hiện các chiến dịch tiếp thị sáng tạo và phát triển thương hiệu.');

