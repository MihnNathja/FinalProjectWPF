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

 INSERT INTO [dbo].[Companies] (ID, UserName, Password, Type, CompanyName, Mst, CompanyLocation, Boss, PhoneNumber, Email, Field, Description)
VALUES
('COMP001', '1', '1', 'Company', N'Công ty TNHH cung cấp văn phòng phẩm ABC', '0123456789', 'Hà Nội', 'Trần Văn Bình', '0987654321', 'abccompany@gmail.com', 'Văn phòng phẩm', 'Chuyên cung cấp các thiết bị văn phòng chất lượng cao'),
('COMP002', 'user02', 'password02', 'Company', N'Công ty TNHH May mặc XYZ', '9876543210', ' TP. Hồ Chí Minh', 'Nguyễn Thị Hà', '0123456789', 'xyzcompany@hotmail.com', 'May mặc', 'Chuyên sản xuất quần áo thời trang theo xu hướng'),
('COMP003', 'user03', 'password03', 'Company', 'Siêu thị điện máy Thịnh Phát', '1234567890', 'Đà Nẵng', 'Lê Văn Nam', '0987654321', 'thinhphat@company.com', 'Điện máy, Điện thoại', 'Cung cấp các thiết bị điện máy và điện thoại chính hãng'),
('COMP004', 'user04', 'password04', 'Company', 'Công ty CP Dịch vụ Vận chuyển Khánh Long', '2345678901', 'Cần Thơ', 'Trương Thụy Vy', '0123456789', 'khanhlongcompany@domain.vn', 'Vận chuyển', 'Dịch vụ vận chuyển hàng hóa đường bộ trên toàn quốc'),
('COMP005', 'user05', 'password05', 'Company', 'Công ty Xây dựng Phát Đạt', '3456789012', 'Biên Hòa', 'Dương Văn Mạnh', '0987654321', 'phatdatconstruction@gmail.com', 'Xây dựng', 'Chuyên thi công xây dựng dân dụng và công nghiệp'),
('COMP006', 'user06', 'password06', 'Company', 'Cửa hàng Thực phẩm sạch Phương Anh', '4567890123', 'Vũng Tàu', 'Nguyễn Thị Lan', '0123456789', 'phuonganhfoods@mail.com', 'Thực phẩm', 'Cung cấp các thực phẩm tươi sống, sạch'),
('COMP007', 'user07', 'password07', 'Company', 'Công ty TNHH Sản xuất Giày Thể thao Nam Anh', '5678901234', 'Bắc Ninh', 'Phạm Minh Hiếu', '0987654321', 'namanhsport@company.net', 'Giày dép', 'Chuyên sản xuất giày thể thao chất lượng cao'),
('COMP008', 'user08', 'password08', 'Company', 'Nhà cung cấp thiết bị y tế Bình An', '6789012345', 'Hải Phòng', 'Bùi Thị Hoa', '0123456789', 'binhanmedical@yahoo.com', 'Y tế', 'Cung cấp các thiết bị y tế uy tín')
