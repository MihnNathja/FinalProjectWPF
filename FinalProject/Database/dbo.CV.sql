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
