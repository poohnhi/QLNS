create database QLNS
go

use QLNS
go

create table LOGININFO
(
TenDangNhap varchar(10) PRIMARY KEY,
MatKhau varchar(32),
ChucVu varchar(5)
)
go

create table ADMININFO
(
TenDangNhap varchar(10) PRIMARY KEY,
HoTen nvarchar(30),
GioiTinh nvarchar(3),
DiaChi nvarchar(100),
SDT varchar(10),
CMND varchar(9),
NgaySinh date,
MucLuong int,
ViTri nvarchar(20),
CONSTRAINT TenDangNhapA_fk FOREIGN KEY (TenDangNhap)
REFERENCES LOGININFO(TenDangNhap)
)
go

create table USERINFO
(
TenDangNhap varchar(10) PRIMARY KEY,
HoTen nvarchar(30),
GioiTinh nvarchar(3),
DiaChi nvarchar(100),
SDT varchar(10),
CMND varchar(9),
NgaySinh date,
Email varchar(30),
DiemTichLuy int,
CONSTRAINT TenDangNhapU_fk FOREIGN KEY (TenDangNhap)
REFERENCES LOGININFO(TenDangNhap)
)
go

create table LOAISACH
(
MALOAI varchar(20) PRIMARY KEY, 
TENLOAI nvarchar(50)
)
go

create table NHAXUATBAN
(
MANXB varchar(5) PRIMARY KEY,
TENNXB nvarchar(20),
NGAYTL datetime,
DIACHI nvarchar(100)
)
go

create table SACH
(
MASACH varchar(5) PRIMARY KEY,
TENSACH nvarchar(50) UNIQUE,
NGAYIN datetime,
GIABAN int DEFAULT(50000),
LOAI varchar(20),
NXB varchar(5),
CONSTRAINT LOAI_fk FOREIGN KEY (LOAI)
REFERENCES LOAISACH(MALOAI),
CONSTRAINT NXB_fk FOREIGN KEY (NXB)
REFERENCES NHAXUATBAN(MANXB)
)
go

create table DONDATHANG 
(
MaDonHang varchar(20) PRIMARY KEY,
MaKhachHang varchar(10),
MASACH varchar(5),
GhiChu nvarchar(200),
CONSTRAINT MaKhachHang_fk FOREIGN KEY (MaKhachHang)
REFERENCES USERINFO(TenDangNhap),
CONSTRAINT MASACH_fk FOREIGN KEY (MASACH)
REFERENCES SACH(MASACH)
)
go

INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('poohnhi','123456','Admin')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('huyhoang','123456','Admin')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('socsoc','123456','Admin')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('hoangtien','123456','User')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('tutuan1506','123456','User')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('kimngan14','123456','User')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('caolong','123456','User')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('thanhquynh','123456','User')
INSERT INTO LOGININFO(TenDangNhap,MatKhau,ChucVu) VALUES ('ngocthuan','123456','User')


INSERT INTO ADMININFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,MucLuong,ViTri) VALUES 
('poohnhi',N'Nguyễn Ngọc Tuyết Nhi',N'Nữ',N'820/26 Nguyễn Kiệm P.3 Q.Gò Vấp TP.Hồ Chí Minh','0812081685','012345678','1999-08-02',15000000,N'Quản lí')

INSERT INTO ADMININFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,MucLuong,ViTri) VALUES
('socsoc',N'Nguyễn Quang Minh',N'Nam',N'252C Khu 3, Thị Trấn Đức Hòa TP.Long An','0123958277','012345617','1999-02-19',9000000,N'Quản lí')

INSERT INTO ADMININFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,MucLuong,ViTri) VALUES 
('huyhoang',N'Đoàn Huy Hoàng',N'Nam',N'18/7 Nguyễn Trãi P.5 Q.1 TP.Hồ Chí Minh','0818625635','028784621','1997-07-12',4000000,N'Thu ngân')

INSERT INTO USERINFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,Email,DiemTichLuy) VALUES 
('hoangtien',N'Hoàng Thị Kim Tiền',N'Nữ',N'15/6 Nguyễn Tri Phương P.5 Q.10 TP.Hồ Chí Minh','0816712768','025646113','1999-09-05','hoangtien1709@gmail.com',1500)

INSERT INTO USERINFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,Email,DiemTichLuy) VALUES 
('tutuan1506',N'Từ Hoàng Anh Tuấn',N'Nam',N'24/10 Đặng Thúc Vịnh Huyện Hóc Môn TP.Hồ Chí Minh','0961222134','025678190','1996-01-17','tutuanltk17@gmail.com',3200)

INSERT INTO USERINFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,Email,DiemTichLuy) VALUES 
('kimngan14',N'Hoàng Kim Ngân',N'Nữ',N'5/10 Sư Vạn Hạnh P.9 Q.10 TP.Hồ Chí Minh','0978245671','028716993','1999-07-19','nganhoangtoro19@gmail.com',1280)

INSERT INTO USERINFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,Email,DiemTichLuy) VALUES 
('caolong',N'Cao Hồ Hữu Long',N'Nam',N'16/7 Quang Trung Huyện Hóc Môn TP.Hồ Chí Minh','0837123456','025467819','1998-12-27','caolong1227@gmail.com',3000)

INSERT INTO USERINFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,Email,DiemTichLuy) VALUES
('thanhquynh',N'Đoàn Thanh Quỳnh',N'Nữ',N'280/17 Lê Lợi Huyện Hóc Môn TP.Hồ Chí Minh','0978264351','027891043','1980-12-27','alicedoan27@gmail.com',1500)

INSERT INTO USERINFO(TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,Email,DiemTichLuy) VALUES
('ngocthuan',N'Hoàng Xuân Ngọc Thuận',N'Nữ',N'18/45 Đặng Thúc Vịnh Huyện Hóc Môn TP.Hồ Chí Minh','0926789104','025678915','1985-02-16','thuanhoang0216@gmail.com',2500)


INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('CN', N'Châm ngôn')
INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('TT', N'Truyện tranh')
INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('VH', N'Văn học')
INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('KNS', N'Kỹ năng sống')
INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('TN', N'Thiếu nhi')
INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('MVB', N'Mẹ và bé')
INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('TS', N'Tiểu sử')
INSERT INTO LOAISACH(MALOAI,TENLOAI) VALUES ('TTH', N'Tiểu thuyết')


INSERT INTO NHAXUATBAN(MANXB,TENNXB,NGAYTL,DIACHI) VALUES ('KD',N'Kim Đồng', '1957-06-17', N'248 Cống Quỳnh, P. Phạm Ngũ Lão, Q.1, TP. Hồ Chí Minh')
INSERT INTO NHAXUATBAN(MANXB,TENNXB,NGAYTL,DIACHI) VALUES ('TRE',N'Trẻ', '1991-03-24', N'161B Lý Chính Thắng, Phường 7, Quận 3 , TP. Hồ Chí Minh')
INSERT INTO NHAXUATBAN(MANXB,TENNXB,NGAYTL,DIACHI) VALUES ('GD',N'Giáo dục', '1957-06-01', N'Số 81 Trần Hưng Đạo - Hoàn Kiếm - Hà Nội')
INSERT INTO NHAXUATBAN(MANXB,TENNXB,NGAYTL,DIACHI) VALUES ('TH',N'Tổng hợp', '1977-09-28', N'Số 62 Nguyễn Thị Minh Khai - Q.1 - TP.Hồ Chí Minh')
INSERT INTO NHAXUATBAN(MANXB,TENNXB,NGAYTL,DIACHI) VALUES ('TN',N'Thanh niên','1975-01-18',N'Số 62 Bà Triệu - Hoàn Kiếm - Hà Nội')
INSERT INTO NHAXUATBAN(MANXB,TENNXB,NGAYTL,DIACHI) VALUES ('DT',N'Dân trí','2009-08-10',N'Số 9 Hoàng Cầu - Đống Đa - Hà Nội')

INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('XXXX',N'Hãy chọn mã sách ','2019-02-03',0,'MVB','DT')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('A001',N'Truyện Kiều - Nguyễn Du','2019-02-03',90000,'VH','KD')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('A002',N'Doraemon Vol 1: Chú khủng long của Nobita','2017-09-02',25000,'TT','KD')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('A003',N'Thám tử lừng danh Conan - Tập 95','2017-08-18',15000,'TT','KD')

INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('B001',N'Kindaichi tập 29','2016-11-19',20000,'TT','TRE')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('B002',N'Tôi thấy hoa vàng trên cỏ xanh','2015-06-12',150000,'VH','TRE')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('B003',N'Tony buổi sáng-Trên đường băng','2017-04-19',55899,'TTH','TRE')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('B004',N'Ngồi khóc trên cây','2018-12-04',69899,'VH','TRE')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('B005',N'Chú chó nhỏ mang giỏ hoa hồng','2017-10-05',53840,'TTH','TRE')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('B006',N'Mắt biếc','2018-03-12',46679,'VH','TRE')

INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('C001',N'Danh ngôn Hồ Chí Minh','2010-03-08',75000,'CN','GD')

INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('D001',N'Đắc nhân tâm','2017-12-09',47877,'KNS','DT')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('D002',N'Nhớ và quên','2018-12-03',88000,'VH','TH')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('D003',N'Câu chuyện văn hóa','2019-02-19',120000,'VH','TH')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('D004',N'Sự sống bất tử','2019-03-27',98000,'VH','TH')

INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('E001',N'Gần bên con','2018-02-13',75600,'MVB','TN')
INSERT INTO SACH(MASACH,TENSACH,NGAYIN,GIABAN,LOAI,NXB) VALUES ('E002',N'Lời thì thầm của mẹ','2018-06-18',49000,'MVB','TN')

SELECT LOGININFO.TenDangNhap, MatKhau, ChucVu, HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,MucLuong,ViTri
FROM dbo.ADMININFO, dbo.LOGININFO
WHERE ADMININFO.TenDangNhap = LOGININFO.TenDangNhap


SELECT TenDangNhap, MatKhau, ChucVu
FROM dbo.LOGININFO


SELECT TenDangNhap, HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,Email,DiemTichLuy
FROM dbo.USERINFO

SELECT MASACH, TENSACH, NXB
FROM dbo.SACH
WHERE NXB = 'TRE'

