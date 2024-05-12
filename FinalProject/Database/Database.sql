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


CREATE TABLE [dbo].[ApplyCV] (
    [ID]        NVARCHAR (100) NOT NULL,
    [IdCV]      NVARCHAR (100) NOT NULL,
    [IdEmployee]NVARCHAR (100) NOT NULL,
    [ACCEPT]    BIT NULL,
    [Interview] Date NULL,
    [Confirm]   BIT NULL,
    PRIMARY KEY(ID, IdCV, IdEmployee)
);

CREATE TABLE [dbo].[CompanyInterestEmployees]
(
	[IdCompany]		NVARCHAR (100) NOT NULL,
	[IdEmployee]	NVARCHAR (100) NOT NULL,
	[IdCV]			NVARCHAR (100) NOT NULL,
	PRIMARY KEY([IdCompany], IdEmployee, IdCV)
)

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
('1', '1', N'Kỹ sư phần mềm - Nhật', N'Để có được vị trí kỹ sư phần mềm cấp cao và tận dụng kinh nghiệm của tôi để thiết kế, phát triển và triển khai các giải pháp phần mềm phức tạp.', N'Ngôn ngữ lập trình (Java, Python, C++), Mẫu thiết kế phần mềm, Giải quyết vấn đề, Làm việc nhóm', N'John Walker', N'Phát triển và duy trì các ứng dụng doanh nghiệp cho Tech Corp, sử dụng các phương pháp Agile.', N'Được hướng dẫn cho các nhà phát triển cấp dưới tại chương trình đào tạo mã hóa.' , N'Cử nhân Khoa học về Khoa học Máy tính', N'Chưa được trao giải thưởng nào, nhưng có động lực cao và ham học hỏi.', N'Hào hứng đóng góp cho một môi trường đổi mới và phát triển nhanh.'),
('2', '2', N'Data Analyst - Quế', N'Để đảm bảo vai trò nhà phân tích dữ liệu nơi tôi có thể sử dụng các kỹ năng phân tích và kiến ​​thức tài chính của mình để tạo ra những hiểu biết sâu sắc có giá trị về kinh doanh.', N'Phân tích dữ liệu (Excel, SQL) , Lập mô hình tài chính, Trực quan hóa dữ liệu (Tableau)', N'Jane Doe', N'Thực hiện phân tích dữ liệu tài chính chuyên sâu cho Financial Inc., xác định xu hướng và đề xuất chiến lược đầu tư.', N'Tình nguyện làm gia sư kiến ​​thức tài chính. dành cho cộng đồng có hoàn cảnh khó khăn.', N'Thạc sĩ Quản trị Kinh doanh (MBA) chuyên ngành Tài chính', N'Nhân viên của Tháng tại Financial Inc. (Q3 2023)', N'Có tính tổ chức cao và sở hữu kỹ năng giao tiếp xuất sắc.');

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
('1', '1', '1', 'Employee', 'John Walker', 'Male', 'Ho Chi Minh City, Vietnam', '1990-01-01', '8498765421', '123456789012345'),
('2', 'financial_inc_analyst1', '123', 'Employee', 'Jane Doe', 'Female', 'Ha Noi, Vietnam', '1985-07-15', '8424876542', '987654321098765'),
('3', 'global_ent_marketing1', '123', 'Employee', 'Michael Lee', 'Male', 'Da Nang, Vietnam', '1995-03-22', '4901234678', '543210987654321'),
('4', 'startup_dev1', '123', 'Employee', 'Alice Young', 'Female', 'Remote', '2000-11-10', '4937890134', '321098765432109'),
('5', 'ad_agency_designer1', '123', 'Employee', 'David Kim', 'Male', 'Can Tho, Vietnam', '1988-05-05', '8429567801', '765432109876543'),
('6', 'retail_store_sales1', '123', 'Employee', 'Sarah Nguyen', 'Female', 'HCMC, Vietnam', '1992-09-21', '8494123678', '109876543210987')

CREATE TABLE [dbo].[Jobs] (
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
('1', N'Kỹ sư phần mềm', N'FPT SoftWare', N'Mức lương cạnh tranh (Thỏa thuận)', N'Thành phố Hồ Chí Minh, Việt Nam (Linh hoạt/Có thể từ xa)', N'Hơn 2 năm kinh nghiệm trong phát triển phần mềm (Java, Ưu tiên Python, C++)', N'Phát triển, duy trì và triển khai các giải pháp phần mềm phức tạp sử dụng các phương pháp Agile. Cộng tác làm việc với nhóm kỹ sư để thiết kế và cung cấp các sản phẩm phần mềm chất lượng cao.', N'Kỹ năng lập trình vững vàng, khả năng giải quyết vấn đề, và kinh nghiệm lập trình hướng đối tượng. Kỹ năng giao tiếp và làm việc nhóm tốt. Đam mê đổi mới và học hỏi không ngừng.', N'Mức lương và phúc lợi cạnh tranh, bảo hiểm y tế, cơ hội phát triển nghề nghiệp, môi trường làm việc năng động.', N'Toàn thời gian (Linh hoạt). số giờ có thể)'), 
('2', N'Nhà phân tích dữ liệu', N'Financial Inc.', N'Mức lương + thưởng hấp dẫn', N'Hà Nội, Việt Nam', N'3+ năm kinh nghiệm trong phân tích dữ liệu (ưu tiên Excel, SQL ), Lập mô hình tài chính', N'Thực hiện phân tích dữ liệu tài chính chuyên sâu để xác định xu hướng và tạo ra những hiểu biết có giá trị về kinh doanh. Đề xuất các chiến lược đầu tư và hỗ trợ việc ra quyết định tài chính.', N'Kỹ năng phân tích mạnh mẽ, thành thạo các công cụ phân tích dữ liệu (Excel, SQL) và kỹ thuật lập mô hình tài chính. Khả năng giao tiếp và kĩ năng thuyết trình tuyệt vời. Khả năng làm việc độc lập và theo nhóm.', N'Gói lương và phúc lợi cạnh tranh, bảo hiểm y tế, cơ hội thưởng, chương trình phát triển nghề nghiệp.', N'Toàn thời gian (40 giờ mỗi tuần)'), 
('3', N'Giám đốc tiếp thị', N'Doanh nghiệp toàn cầu', N'Mức lương cạnh tranh + Tiền thưởng hiệu suất', N'Nước ngoài', N'Hơn 5 năm kinh nghiệm tiếp thị với thành tích thành công đã được chứng minh. Kinh nghiệm trong tiếp thị kỹ thuật số và thương mại điện tử chiến lược là một điểm cộng.', N'Dẫn dắt và quản lý nhóm tiếp thị hiệu suất cao để phát triển và thực hiện các chiến dịch tiếp thị thành công và đạt được mức tăng trưởng lợi nhuận cho công ty.', N'Kỹ năng lãnh đạo mạnh mẽ, kinh nghiệm phát triển và thực hiện các chiến lược tiếp thị, kỹ năng giao tiếp và giao tiếp cá nhân xuất sắc. Kiến thức chuyên sâu về các kênh tiếp thị kỹ thuật số và xu hướng thương mại điện tử.', N'Gói phúc lợi và mức lương cạnh tranh, bảo hiểm y tế, cơ hội thưởng, hỗ trợ di chuyển (nếu có).', N'Toàn thời gian (40). giờ mỗi tuần)'),
('4', N'Nhà phát triển ứng dụng di động', N'Phòng thí nghiệm sáng tạo', N'Mức lương cạnh tranh + Tùy chọn cổ phiếu', N'Đà Nẵng, Việt Nam (Có thể từ xa)', N'Hơn 2 năm kinh nghiệm phát triển ứng dụng di động (React Native, Flutter được ưu tiên)', N'Phát triển và duy trì các ứng dụng di động sáng tạo cho nhiều nền tảng khác nhau. Đóng góp vào môi trường làm việc có nhịp độ nhanh và hợp tác.', N'Kỹ năng lập trình vững chắc trong các khung phát triển ứng dụng di động (React Native, Flutter). một điểm cộng. Kỹ năng giao tiếp và làm việc nhóm xuất sắc.', N'Gói lương và phúc lợi cạnh tranh, bảo hiểm y tế, lựa chọn cổ phiếu, sắp xếp công việc linh hoạt (có thể từ xa).', N'Toàn thời gian (có thể có giờ linh hoạt)'),
('5' , N'Nhà thiết kế đồ họa', N'Đại lý AdMax', N'Mức lương cạnh tranh + Phúc lợi', N'Cần Thơ, Việt Nam', N'3 năm kinh nghiệm trở lên trong thiết kế đồ họa (ưu tiên Adobe Photoshop, Illustrator)', N'Phát triển đồ họa sáng tạo và hấp dẫn về mặt hình ảnh tài liệu thiết kế cho các chiến dịch tiếp thị và sáng kiến ​​xây dựng thương hiệu.', N'Thành thạo phần mềm thiết kế đồ họa (Adobe Photoshop, Illustrator). Có kinh nghiệm về các nguyên tắc tiếp thị và xây dựng thương hiệu là một lợi thế. Kỹ năng giao tiếp và hợp tác xuất sắc.', N'Mức lương và phúc lợi cạnh tranh, bảo hiểm y tế, cơ hội phát triển nghề nghiệp, môi trường làm việc sáng tạo.', N'Toàn thời gian (40 giờ mỗi tuần)');


CREATE TABLE [dbo].[News] (
    [IdEmployee]    NVARCHAR (100) NOT NULL,
    [IdCV]          NVARCHAR (100) NOT NULL,
    [JobName]       NVARCHAR (MAX) NULL,
    [Experience]    NVARCHAR (MAX) NULL,
    [Location]      NVARCHAR (MAX) NULL,
    [Salary]        NVARCHAR (MAX) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Benefit]       NVARCHAR (MAX) NULL,
    [WorkTime]      NVARCHAR (MAX) NULL,
    PRIMARY KEY( IdEmployee, IdCV)
);