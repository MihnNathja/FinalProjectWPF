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
--Tuyển dụng cho Công ty TNHH cung cấp văn phòng phẩm ABC (COMP001)

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB001_COMP001', N'Nhân viên bán hàng', N'Công ty TNHH cung cấp văn phòng phẩm ABC', N'Mức lương cạnh tranh', N'Hà Nội', N'Không yêu cầu kinh nghiệm', N'Bán hàng các mặt hàng văn phòng phẩm, tư vấn cho khách hàng', N'Chăm chỉ, cởi mở, kỹ năng giao tiếp tốt', N'Hoa hồng theo doanh số, bảo hiểm xã hội, thưởng tháng', N'Thứ 2 - thứ 7 (giờ hành chính)')

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB002_COMP001', N'Nhân viên quản lý kho', N'Công ty TNHH cung cấp văn phòng phẩm ABC', N'Mức lương cạnh tranh', N'Hà Nội', N'Yêu cầu 1 năm kinh nghiệm', N'Quản lý nhập - xuất kho hàng, giữ gìn hàng hóa', N'Tổ chức, kỷ luật, cẩn thận, chính xác', N'Bảo hiểm xã hội, phụ cấp ăn trưa, thưởng tháng', N'Thứ 2 - thứ 7 (giờ hành chính)')

--Tuyển dụng cho Công ty TNHH May mặc XYZ (COMP002)

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB001_COMP002', N'Thợ may gia công', N'Công ty TNHH May mặc XYZ', N'Lương theo năng suất', ' TP. Hồ Chí Minh', N'Ưu tiên kinh nghiệm', N'May các mẫu áo quần theo yêu cầu', N'Khéo tay, tỉ mỉ, chịu khó', N'Thu nhập cao theo năng suất, thưởng tháng', N'Thứ 2 - thứ 7 (có thể thỏa thuận)')

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB002_COMP002', N'Thiết kế thời trang', N'Công ty TNHH May mặc XYZ', N'Thỏa thuận', ' TP. Hồ Chí Minh', N'Yêu cầu 2 năm kinh nghiệm', N'Thiết kế các mẫu áo quần theo xu hướng thời trang', N'Bảng vẽ tay giỏi, am hiểu về thời trang', N'Môi trường làm việc năng động, sáng tạo, thưởng tháng', N'Thứ 2 - thứ 6 (giờ hành chính)')

--Tuyển dụng cho Siêu thị điện máy Thịnh Phát (COMP003)

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB001_COMP003', N'Nhân viên bán hàng', N'Siêu thị điện máy Thịnh Phạt', N'Mức lương cạnh tranh', N'Đà Nẵng', N'Không yêu cầu kinh nghiệm', N'Tư vấn và bán hàng điện máy, điện thoại', N'Chăm chỉ, cởi mở, kỹ năng giao tiếp tốt', N'Hoa hồng theo doanh số, bảo hiểm xã hội, thưởng tháng', N'Thứ 2 - thứ 7 (giờ hành chính)')

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB002_COMP003', N'Kỹ thuật viên sửa chữa', N'Siêu thị điện máy Thịnh Phát', N'Mức lương cạnh tranh', N'Đà Nẵng', N'Yêu cầu 1 năm kinh nghiệm', N'Sửa chữa điện máy, điện thoại tại nhà', N'Có chuyên môn về điện máy, cẩn thận, tỉ mỉ', N'Bảo hiểm xã hội, phụ cấp ăn trưa, thưởng tháng', N'Thứ 2 - thứ 7 (có thể làm thêm giờ)')

--Tuyển dụng cho Công ty CP Dịch vụ Vận chuyển Khánh Long (COMP004)

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB001_COMP004', N'Lái xe tải', N'Công ty CP Dịch vụ Vận chuyển Khánh Long', N'Lương theo chuyến', 'Cần Thơ', N'Có bằng lái xe tải hạng B', N'Lái xe vận chuyển hàng hóa đường bộ', N'Kinh nghiệm lái xe, cẩn thận, trách nhiệm', N'Lương cao theo chuyến, thưởng tháng', N'Có thể đi xa, làm việc theo ca')

INSERT INTO  [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB002_COMP004', N'Phụ xe', N'Công ty CP Dịch vụ Vận chuyển Khánh Long', N'Lương theo chuyến', 'Cần Thơ', N'Không yêu cầu kinh nghiệm', N'Hỗ trợ lái xe, bốc xếp hàng hóa', N'Chăm chỉ, chịu khó, sức khỏe tốt', N'Lương theo chuyến, thưởng tháng', N'Có thể đi xa, làm việc theo ca')

--Tuyển dụng cho Công ty Xây dựng Phát Đạt (COMP005)

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB001_COMP005', N'Kỹ sư xây dựng', N'Công ty Xây dựng Phát Đạt', N'Mức lương cạnh tranh', 'Biên Hòa', N'Yêu cầu 3 năm kinh nghiệm', N'Giám sát thi công công trình xây dựng', N'Có bằng cấp kỹ sư xây dựng, chuyên môn cao', N'Bảo hiểm xã hội, phụ cấp ăn trưa, thưởng tháng', N'Thứ 2 - thứ 7 (giờ hành chính)')

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB002_COMP005', N'Thợ xây dựng', N'Công ty Xây dựng Phát Đạt', N'Lương theo ngày', 'Biên Hòa', N'Không yêu cầu kinh nghiệm', N'Thi công các hạng mục xây dựng', N'Khỏe mạnh, chịu khó, làm việc nhóm tốt', N'Lương cao theo ngày, thưởng tháng', N'Thứ 2 - thứ 7 (có thể làm thêm giờ)')

--Tuyển dụng cho Cửa hàng Thực phẩm sạch Phương Anh (COMP006)

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB001_COMP006', N'Nhân viên bán hàng', N'Cửa hàng Thực phẩm sạch Phương Anh', N'Mức lương cạnh tranh', 'Vũng Tàu', N'Không yêu cầu kinh nghiệm', N'Bán thực phẩm tươi sống, tư vấn cho khách hàng', N'Chăm chỉ, cởi mở, kỹ năng giao tiếp tốt', N'Hoa hồng theo doanh số, bảo hiểm xã hội, thưởng tháng', N'Thứ 2 - thứ 7 (giờ hành chính)')

INSERT INTO [dbo].[Jobs] (Id, JobName, CompanyName, Salary, JobLocation, Experience, Description, Require, Benefit, WorkTime)
VALUES
('JOB002_COMP006', N'Nhân viên thu ngân', N'Cửa hàng Thực phẩm sạch Phương Anh', N'Mức lương cạnh tranh', 'Vũng Tàu', N'Không yêu cầu kinh nghiệm', N'Thu ngân, thanh toán cho khách hàng', N'Cẩn thận, trung thực, nhanh nhẹn', N'Bảo hiểm xã hội, thưởng tháng', N'Thứ 2 - thứ 7 (giờ hành chính)')

