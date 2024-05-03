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
('1', '1', '1', 'Công ty', 'Tập đoàn công nghệ', '0123456789', 'Thành phố Hồ Chí Minh, Việt Nam', 'Mr. Lee', '+84 28 3811 0000', ' info@techcorp.com', 'Công nghệ thông tin, Phát triển phần mềm', 'Tech Corporation là công ty phát triển phần mềm hàng đầu chuyên về các ứng dụng doanh nghiệp. Chúng tôi cung cấp một môi trường làm việc năng động và cơ hội phát triển nghề nghiệp.'),
('2', 'financial_inc_admin', 'your_strong_password', 'Công ty', 'Financial Inc.', '9876543210', 'Hà Nội, Việt Nam', 'Ms. Nguyễn', '+84 24 3852 7777', 'liên hệ @financialinc.vn', 'Tài chính, Quản lý đầu tư', 'Financial Inc. là công ty dịch vụ tài chính uy tín cung cấp các giải pháp phân tích đầu tư, quản lý tài sản và lập kế hoạch tài chính.'),
('3', 'global_ent_admin', 'your_strong_password', 'Công ty', 'Doanh nghiệp toàn cầu', '1234567890', ' Singapore', 'Mr. Tan', '+65 6789 1234', 'globalent@globalent.com. sg', 'Tiếp thị, Thương mại điện tử', 'Global Enterprises là một tập đoàn đa quốc gia chuyên về hàng tiêu dùng và các giải pháp thương mại điện tử.'),
('4', 'startup_admin', 'your_strong_password', 'Công ty', 'Creative Labs', '0012345678', 'Đà Nẵng, Việt Nam', 'Ms. Linh', '+84 908 765 432', 'creativelabs@ dalat.com', 'Phát triển phần mềm, ứng dụng di động', 'Creative Labs là một công ty khởi nghiệp trẻ và sáng tạo đang phát triển các ứng dụng di động tiên tiến.'),
('5', 'ad_agency_admin', 'your_strong_password', 'Công ty', 'Đại lý AdMax', '1122334455', 'Cần Thơ, Việt Nam', 'Mr. David', '+84 723 567 890', 'admaxagency@ cantho.com.vn', 'Marketing, Quảng cáo, Thiết kế đồ họa', 'AdMax Agency là công ty quảng cáo trọn gói chuyên thực hiện các chiến dịch tiếp thị sáng tạo và phát triển thương hiệu.');

