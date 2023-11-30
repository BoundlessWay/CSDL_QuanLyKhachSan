--Tao Data Base
Create database QUANLYKHACHSANDB;
Go

--Su Dung Data Base
Use QUANLYKHACHSANDB;
Go

--Drop Tat Ca Cac Bang va Foreign Key: Xoa luon database hoac chay script

--Tao Cac Bang (Tong cong co 20)
--1
Create Table PhieuGopY
(
	MaPhieu varchar(10) NOT NULL,
	NoiDung nvarchar(255),
	MucDoHaiLong int,
	ThoiGian datetime,
	MaKhachHang varchar(15),
	Primary Key (MaPhieu)
);

Create Table KhachHang
(
	Cccd varchar(15) NOT NULL,
	HoTen nvarchar(30),
	Sdt varchar(15),
	DiaChi nvarchar(100),
	Primary Key (Cccd)
);

Create Table PhieuDangKyPhong
(
	MaPhieuDangKy varchar(10) NOT NULL,
	MaKhachHang varchar(15),
	LoaiPhong nvarchar(30),
	SoNguoi int,
	TenDoan nvarchar(100),
	NgayDen datetime,
	SoDemLuuTru int,
	YeuCauDacBiet nvarchar(100),
	TienThanhToan30 int,
	TinhTrangThanhToan30 int -- 0 hoac 1,
	Primary Key (MaPhieuDangKy)
);

Create Table LichDatPhong
(
	MaPhieuDangKy varchar(10) NOT NULL,
	SoPhong varchar(10) NOT NULL,
	ThoiGianDat datetime,
	Primary Key (MaPhieuDangKy, SoPhong)
);

Create Table KhachHang_Phong
(
	MaKhachHang varchar(15) NOT NULL,
	SoPhong varchar(10) NOT NULL,
	ThoiGian datetime NOT NULL,
	Primary Key (MaKhachHang, SoPhong, ThoiGian)
);
--6
Create Table Phong
(
	SoPhong varchar(10) NOT NULL,
	SoNguoiToiDa int,
	LoaiPhong nvarchar(30),
	Gia int,
	TinhTrangPhong nvarchar(30),
	TinhTrangVeSinh nvarchar(30),
	Primary Key (SoPhong)
);

Create Table DangKyDichVu
(
	SoPhong varchar(10) NOT NULL,
	MaDichVu varchar(10) NOT NULL,
	ThoiGianBatDau datetime,
	ThoiGianKetThuc datetime,
	SoLuong int,
	NVLeTan varchar(10),
	NVBuongPhong varchar(10),
	Primary Key (SoPhong, MaDichVu, ThoiGianBatDau, ThoiGianKetThuc)
);

Create Table DichVu
(
	MaDichVu varchar(10) NOT NULL,
	TenDichVu nvarchar(100),
	MoTa nvarchar(100),
	Gia int,
	ViTri nvarchar(30),
	LoaiDichVu nvarchar(30),
	Primary Key (MaDichVu)
);

Create Table TourDuLich
(
	MaTour varchar(10) NOT NULL,
	DiaDiem nvarchar(100),
	Gia int,
	MoTa nvarchar(255),
	MaDoiTac varchar(10),
	Primary Key (MaTour)
);

Create Table DangKyTour
(
	SoPhong varchar(10) NOT NULL,
	MaTour varchar(10) NOT NULL,
	ThoiGianBatDau datetime,
	Primary Key (SoPhong, MaTour)
);

--11
Create Table DoiTac
(
	MaDoiTac varchar(10) NOT NULL,
	TenCongTy nvarchar(100),
	TenNguoiDaiDien nvarchar(30),
	DiaChi nvarchar(100),
	Email varchar(50),
	SDT varchar(15),
	Primary Key (MaDoiTac)
);

Create Table VatDung
(
	MaVatDung varchar(10) NOT NULL,
	Ten nvarchar(100),
	Gia int,
	Primary Key (MaVatDung)
);

Create Table Phong_VatDung
(
	SoPhong varchar(10) NOT NULL,
	MaVatDung varchar(10) NOT NULL,
	SoLuong int,
	Primary Key (SoPhong, MaVatDung)
);

Create Table HoaDon
(
	MaHoaDon varchar(10) NOT NULL,
	SoPhong varchar(10),
	MaVoucher varchar(50),
	ThoiGian datetime,
	TongTien INT, --float hay int?
	TienCanThanhToan INT,
	MaBienBan varchar(10),
	NVLeTan varchar(10),
	TinhTrang NVARCHAR(30),
	Primary Key (MaHoaDon)
);

Create Table ChiTietHoaDon
(
	MaHoaDon varchar(10) NOT NULL,
	SoPhong varchar(10) NOT NULL,
	MaDichVu varchar(10) NOT NULL,
	SoLuong int,
	Primary Key (MaHoaDon, SoPhong, MaDichVu)
);
--16
Create Table Voucher
(
	MaVoucher varchar(50) NOT NULL,
	Ten nvarchar(100),
	ThoiGianHieuLuc datetime,
	GiaTri int,
	Primary Key (MaVoucher)
);

Create Table BienBanKiemTraPhong
(
	MaBienBan varchar(10) NOT NULL,
	SoPhong varchar(10),
	NVBuongPhong varchar(10),
	ThoiGian datetime,
	NhanXetChung nvarchar(255),
	Primary Key (MaBienBan)
);

Create Table ChiTietBienBanKiemTraPhong
(
	MaBienBan varchar(10) NOT NULL,
	MaVatDung varchar(10) NOT NULL,
	Primary Key (MaBienBan, MaVatDung)
);

Create Table NhanVien
(
	MaNhanVien varchar(10) NOT NULL,
	HoTen nvarchar(100),
	SDT varchar(15),
	Email varchar(50),
	DiaChi nvarchar(100),
	MucLuong int,
	LichLamViec nvarchar(255),
	LoaiNhanVien nvarchar(50),
	ThamNien int,
	Primary Key (MaNhanVien)
);

Create Table PhieuVanChuyen
(
	MaKhachHang varchar(15) NOT NULL,
	SoPhong varchar(10) NOT NULL,
	ThoiGian datetime NOT NULL,
	NVBellman varchar(10) NOT NULL,
	SoLuongHanhLy int,
	MoTa nvarchar (255),
	Primary Key (MaKhachHang, SoPhong, ThoiGian)
);

--------------------------------------------------
--Tao Khoa Ngoai (Tong cong co 27)

--1
alter table PhieuGopY add constraint FK_PhieuGopY_KhachHang foreign key (MaKhachHang) references KhachHang(Cccd);
Go
alter table PhieuDangKyPhong add constraint FK_PhieuDangKyPhong_KhachHang foreign key (MaKhachHang) references KhachHang(Cccd);
Go
alter table KhachHang_Phong add constraint FK_KhachHang_Phong_KhachHang foreign key (MaKhachHang) references KhachHang(Cccd);
Go
alter table PhieuVanChuyen add constraint FK_PhieuVanChuyen_KhachHang foreign key (MaKhachHang) references KhachHang(Cccd);
Go
alter table LichDatPhong add constraint FK_LichDatPhong_PhieuDangKyPhong foreign key (MaPhieuDangKy) references PhieuDangKyPhong(MaPhieuDangKy);
Go
--6
alter table LichDatPhong add constraint FK_LichDatPhong_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
alter table KhachHang_Phong add constraint FK_KhachHang_Phong_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
alter table DangKyDichVu add constraint FK_DangKyDichVu_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
alter table DangKyTour add constraint FK_DangKyTour_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
alter table Phong_VatDung add constraint FK_Phong_VatDung_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
--11
alter table ChiTietHoaDon add constraint FK_ChiTietHoaDon_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
alter table BienBanKiemTraPhong add constraint FK_BienBanKiemTraPhong_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
alter table DangKyDichVu add constraint FK_DangKyDichVu_DichVu foreign key (MaDichVu) references DichVu(MaDichVu);
Go
alter table ChiTietHoaDon add constraint FK_ChiTietHoaDon_DichVu foreign key (MaDichVu) references DichVu(MaDichVu);
Go
alter table DangKyTour add constraint FK_DangKyTour_TourDuLich foreign key (MaTour) references TourDuLich(MaTour);
Go
--16
alter table DoiTac add constraint FK_DoiTac_TourDuLich foreign key (MaDoiTac) references DoiTac(MaDoiTac);
Go
alter table TourDuLich add constraint FK_TourDuLich_DoiTac foreign key (MaDoiTac) references DoiTac(MaDoiTac);
Go
alter table ChiTietHoaDon add constraint FK_ChiTietHoaDon_HoaDon foreign key (MaHoaDon) references HoaDon(MaHoaDon);
Go
alter table HoaDon add constraint FK_HoaDon_Voucher foreign key (MaVoucher) references Voucher(MaVoucher);
Go
alter table Phong_VatDung add constraint FK_Phong_VatDung_VatDung foreign key (MaVatDung) references VatDung(MaVatDung);
Go
alter table ChiTietBienBanKiemTraPhong add constraint FK_ChiTietBienBanKiemTraPhong_VatDung foreign key (MaVatDung) references VatDung(MaVatDung);
Go
--21
alter table HoaDon add constraint FK_HoaDon_BienBanKiemTraPhong foreign key (MaBienBan) references BienBanKiemTraPhong(MaBienBan);
Go
alter table ChiTietBienBanKiemTraPhong add constraint FK_ChiTietBienBanKiemTraPhong_BienBanKiemTraPhong foreign key (MaBienBan) references BienBanKiemTraPhong(MaBienBan);
Go
alter table BienBanKiemTraPhong add constraint FK_BienBanKiemTraPhong_NhanVien foreign key (NVBuongPhong) references NhanVien(MaNhanVien);
Go
alter table HoaDon add constraint FK_HoaDon_NhanVien foreign key (NVLeTan) references NhanVien(MaNhanVien);
Go
alter table PhieuVanChuyen add constraint FK_PhieuVanChuyen_Phong foreign key (SoPhong) references Phong(SoPhong);
Go
--26
alter table DangKyDichVu add constraint FK_DangKyDichVu_NhanVien foreign key (NVLeTan) references NhanVien(MaNhanVien);
Go
alter table DangKyDichVu add constraint FK_DangKyDichVU_NhanVien2 foreign key (NVBuongPhong) references NhanVien(MaNhanVien);
Go

------------------------------------------------------
--Tao Du Lieu
--Khach Hang
insert into KhachHang values ('0001',N'Phạm Phước Bình','0815332778',null);
Go
insert into KhachHang values ('0002',N'Đào Duy Anh',null,null);
Go
insert into KhachHang values ('0003',N'Lê Vĩ Nguyên',null,null);
Go
insert into KhachHang values ('0004',N'Võ Đức Lợi',null,null);
Go
insert into KhachHang values ('0005',N'Nguyên',null,null);
Go
--Phong
insert into Phong values ('F101',1,N'Thường',250000, N'Phòng trống',null);
Go

insert into Phong values ('F102',1,N'Thường',250000, N'Phòng trống', N'Cần vệ sinh');
Go
insert into Phong values ('F103',2,N'Thường',300000, N'Phòng trống', N'Cần vệ sinh');
Go
insert into Phong values ('F111',2,N'Cao Cấp',500000, N'Phòng trống', N'Cần vệ sinh');
Go
insert into Phong values ('F205',4,N'Cao Cấp',600000, N'Phòng trống', N'Cần vệ sinh');
Go
insert into Phong values ('F221',2,N'Cao Cấp',500000, N'Phòng trống', N'Cần vệ sinh');
Go
insert into Phong values ('F501',1,N'Vip',2500000, N'Phòng trống', N'Cần vệ sinh');
Go
insert into Phong values ('F414',2,N'Vip',300000, N'Phòng trống', N'Cần vệ sinh');
Go
insert into Phong values ('F777',4,N'Vip',1000000, N'Phòng trống', N'Cần vệ sinh');
Go
--Dich Vu
insert into DichVu values ('DV001',N'Karaoke',N'Cung cấp phòng hát Karaoke 8 người trong 2 giờ.',500000,'F320',N'Dịch vụ đăng ký');
Go
insert into DichVu values ('DV002',N'Hồ bơi',N'Cung cấp hồ bơi 100m^2 trong 2 giờ.',300000,'Khuông viên A ngoài trời',N'Dịch vụ đăng ký');
Go
insert into DichVu values ('DV003',N'Sân tennis',N'Cung cấp sân đánh tennis theo dành cho lên tới 4 người.',250000,N'Khuông viên B ngoài trời',N'Dịch vụ đăng ký');
Go
insert into DichVu values ('DV004',N'Đặt chỗ nướng BBQ tại ban công khách sạn (có cung cấp đồ sống)',N'Cung cấp khu vực rộng rãi, thoáng mát với khung cảnh xinh đẹp.',1200000,N'Ban công tầng 5',N'Dịch vụ đăng ký');
Go
insert into DichVu values ('DV011',N'Set ăn sáng nhà hàng 1 người',N'Đặt đồ ăn sáng phần 1 người, đồ ăn sẽ được mang tới phòng.',100000,N'Tại phòng',N'Dịch vụ đặt mua');
Go
insert into DichVu values ('DV012',N'Giặt ủi quần áo',N'Mỗi ngày sẽ có nhân viên mang quần áo của phòng đi giặt',50000,N'Tại phòng',N'Dịch vụ đăng ký');
Go
insert into DichVu values ('DV013',N'Set ăn trưa nhà hàng 1 người',N'Đặt đồ ăn trưa phần 1 người, đồ ăn sẽ được mang tới phòng.',120000,N'Tại phòng',N'Dịch vụ đặt mua');
Go
insert into DichVu values ('DV020',N'Dịch vụ massage cho 1 người',N'*Mô tả massage*.',40000,N'Phòng F220',N'Dịch vụ đăng ký');
Go

--Doi Tac
insert into DoiTac values ('DT001',N'Trevako',N'CEO Trevako',null,null,null);
insert into DoiTac values ('DT002',N'Trevako',N'CEO Trevako',null,null,null);
insert into DoiTac values ('DT003',N'Trevako',N'CEO Trevako',null,null,null);
insert into DoiTac values ('DT004',N'Trevako',N'CEO Trevako',null,null,null);
Go

--Tour Du Lich
insert into TourDuLich values ('T001',N'Một nơi nào đó nổi tiếng 1',780000,null,'DT001');
Go
insert into TourDuLich values ('T002',N'Một nơi nào đó nổi tiếng 2 Một nơi nào đó nổi tiếng 2 Một nơi nào đó nổi tiếng 2',780000,null,'DT002');
Go
insert into TourDuLich values ('T003',N'Một nơi nào đó nổi tiếng 3',780000,null,'DT003');
Go
insert into TourDuLich values ('T004',N'Một nơi nào đó nổi tiếng 4',780000,null,'DT004');
Go

--Voucher
insert into Voucher values ('V001',N'Mừng Quốc tế phụ nữ', '2023/12/01', 40000);
Go
insert into Voucher values ('V002',N'Giáng sinh vui vẻ', '2024/01/05', 50000);
Go
insert into Voucher values ('V003',N'Lazada săn sale', '2023/07/07', 60000);
Go

--Vat Dung
insert into VatDung values ('VD001',N'Giường gỗ', 2500000);
Go
insert into VatDung values ('VD002',N'Giường vip', 5000000);
Go
insert into VatDung values ('VD003',N'Ghế gỗ', 1000000);
Go
insert into VatDung values ('VD004',N'Khăn tắm', 300000);
Go
insert into VatDung values ('VD005',N'Tủ đồ', 2000000);
Go

--Nhan Vien
insert into NhanVien values ('NV001',N'Bình Phạm Phước',null,'0123654789',null,15000000,null,N'Lễ tân',10);
Go
insert into NhanVien values ('NV002',N'Bình Phước Phạm',null,'0321654789',null,10000000,null,N'Buồng phòng',5);
Go
insert into NhanVien values ('NV003',N'Phạm Bình Phước',null,'0123654987',null,8000000,null,N'Nhân viên vệ sinh',2);
Go
insert into NhanVien values ('NV004',N'Phước Bình Phạm',null,'0321456987',null,12000000,null,N'Bellman',7);
Go

---------------------------------------------------------------------------
Create Table TaiKhoanNguoiDung
(
	TaiKhoan NVARCHAR(100) PRIMARY KEY,
	TenHienThi NVARCHAR(100) NOT NULL DEFAULT N'Nguyên',
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	--TYPE INT NOT NULL DEFAULT 0 -- 1: Admin && 0: Staff
);
Go

--Tai khoan nguoi dung
insert into TaiKhoanNguoiDung values(N'NV001', N'Bình', N'1');
insert into TaiKhoanNguoiDung values(N'NV002', N'Phạm', N'1');
insert into TaiKhoanNguoiDung values(N'NV003', N'Phước', N'1');
Go

--Phieu dang ky phong
INSERT INTO PhieuDangKyPhong VALUES('P001', '0003', N'Cao Cấp', 2, NULL, '2023-07-01 10:30:00', 2, NULL, 300000, 1);
INSERT INTO PhieuDangKyPhong VALUES('P002', '0002', N'Thường', 1, NULL, '2023-07-01 10:30:00', 2, NULL, 150000, 1);

INSERT INTO KhachHang_Phong VALUES('0003', 'F111', '2023-07-03 10:30:00');
INSERT INTO KhachHang_Phong VALUES('0002', 'F103', '2023-07-03 10:30:00');
go

-- Procedure Login
CREATE PROC USP_Login
@Username NVARCHAR(100), @Password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM TaiKhoanNguoiDung WHERE TaiKhoan = @Username AND MatKhau = @Password
END
Go

-- Procedure Lấy danh sách vật dụng trong phòng
CREATE PROC USP_GetItemList
@Sophong VARCHAR(10)
AS 
BEGIN	
	select * from VatDung vd, Phong_VatDung p where p.MaVatDung = vd.MaVatDung and p.SoPhong = @Sophong; 
END
GO

-- Procedure Lấy danh sách phòng
CREATE PROC USP_GetRoomList
AS SELECT * FROM PHONG
GO

-- Procedure Lấy thông tin thuê phòng
CREATE PROC USP_GetInfoPhong
@Sophong VARCHAR(10)
AS 
BEGIN
	SELECT KH.HoTen AS "Tên khách hàng", P.LoaiPhong AS "Loại phòng thuê", P.SoNguoi AS "Số người", P.TenDoan AS "Tên đoàn", P.NgayDen AS "Ngày đến", P.SoDemLuuTru AS "Số đêm lưu trú", P.YeuCauDacBiet AS "Yêu cầu đặt biệt", P.TienThanhToan30 AS "Số tiền thanh toán trước (30%)", P.TinhTrangThanhToan30 AS "Tình trạng thanh toán"
	FROM KHACHHANG KH, PHIEUDANGKYPHONG P, KHACHHANG_PHONG KB
	WHERE KH.Cccd = P.MaKhachHang AND P.MaKhachHang = KB.MaKhachHang AND KB.SoPhong = @Sophong;
END
GO

-- Procedure Cập nhật tình trang phòng thành Đợi kiểm tra
CREATE PROC USP_UpdateStatusPhong
@Sophong VARCHAR(10)
AS 
BEGIN
	UPDATE PHONG SET TinhTrangPhong = N'Đợi kiểm tra' WHERE SOPHONG = @Sophong; 
END
GO

-- Procedure Lấy những dịch vụ mà phòng đó đã đăng ký trong thời gian thuê
CREATE PROC USP_GetDVFromPhong
@Sophong VARCHAR(10)
AS 
BEGIN
	SELECT DV.TenDichVu AS "Tên dịch vụ", DV.Gia AS "Tiền dịch vụ", DK.SoLuong AS"Số lượng", DK.ThoiGianBatDau AS "Thời gian đăng ký"
	FROM DANGKYDICHVU DK, DICHVU DV
	WHERE DK.MADICHVU = DV.MADICHVU AND DK.SOPHONG = @Sophong; 
END
GO

-- Function Tính tiền dịch vụ của phòng (dịch vụ bao gồm dv buồng phòng và của lễ tân)
CREATE FUNCTION TinhTien (@Sophong VARCHAR(4))
RETURNS INT
AS
BEGIN
    DECLARE @tienphong INT;
    DECLARE @tiendichvu INT;
	DECLARE @tongtien INT;

    -- Lấy giá tiền phòng từ bảng PHONG
    SELECT @tienphong = GIA
    FROM PHONG
    WHERE sophong = @Sophong;

	SET @tienphong = @tienphong*0.7
	
	;WITH DVSUDUNG AS (SELECT DV.TenDichVu, DV.Gia, DK.SoLuong
					   FROM DANGKYDICHVU DK, DICHVU DV
					   WHERE DK.MADICHVU = DV.MADICHVU AND DK.SOPHONG = @Sophong)

    -- Lấy giá tiền dịch vụ từ bảng DICHVU
    SELECT @tiendichvu = SUM(DV.Gia*DV.SoLuong)
	FROM DVSUDUNG DV

	if (@tiendichvu IS NULL)
		SET @tiendichvu = 0;

    -- Tính tổng tiền
    SET @tongtien = @tienphong + @tiendichvu;
	
	RETURN @tongtien;
END
GO
--Vat dung cua phong
insert into Phong_VatDung values ('F101', 'VD001', 1);
GO
insert into Phong_VatDung values ('F101', 'VD003', 1);
GO
insert into Phong_VatDung values ('F101', 'VD004', 2);
GO
insert into Phong_VatDung values ('F101', 'VD005', 1);
GO
insert into Phong_VatDung values ('F102', 'VD001', 1);
GO
insert into Phong_VatDung values ('F102', 'VD003', 1);
GO
insert into Phong_VatDung values ('F102', 'VD004', 2);
GO
insert into Phong_VatDung values ('F102', 'VD005', 1);
GO
insert into Phong_VatDung values ('F103', 'VD001', 1);
GO
insert into Phong_VatDung values ('F103', 'VD003', 2);
GO
insert into Phong_VatDung values ('F103', 'VD004', 3);
GO
insert into Phong_VatDung values ('F103', 'VD005', 1);
GO
--Cao cap
insert into Phong_VatDung values ('F111', 'VD002', 1);
GO
insert into Phong_VatDung values ('F111', 'VD003', 3);
GO
insert into Phong_VatDung values ('F111', 'VD004', 4);
GO
insert into Phong_VatDung values ('F111', 'VD005', 1);
GO
insert into Phong_VatDung values ('F205', 'VD002', 2);
GO
insert into Phong_VatDung values ('F205', 'VD003', 4);
GO
insert into Phong_VatDung values ('F205', 'VD004', 6);
GO
insert into Phong_VatDung values ('F205', 'VD005', 2);
GO
insert into Phong_VatDung values ('F221', 'VD002', 2);
GO
insert into Phong_VatDung values ('F221', 'VD003', 4);
GO
insert into Phong_VatDung values ('F221', 'VD004', 4);
GO
insert into Phong_VatDung values ('F221', 'VD005', 2);
GO
--VIP
insert into Phong_VatDung values ('F501', 'VD002', 1);
GO
insert into Phong_VatDung values ('F501', 'VD003', 2);
GO
insert into Phong_VatDung values ('F501', 'VD004', 3);
GO
insert into Phong_VatDung values ('F501', 'VD005', 1);
GO
insert into Phong_VatDung values ('F414', 'VD002', 1);
GO
insert into Phong_VatDung values ('F414', 'VD003', 4);
GO
insert into Phong_VatDung values ('F414', 'VD004', 4);
GO
insert into Phong_VatDung values ('F414', 'VD005', 1);
GO
insert into Phong_VatDung values ('F777', 'VD002', 4);
GO
insert into Phong_VatDung values ('F777', 'VD003', 4);
GO
insert into Phong_VatDung values ('F777', 'VD004', 8);
GO
insert into Phong_VatDung values ('F777', 'VD005', 2);
GO

-- Procedure Kiểm tra voucher có tồn tại
CREATE PROC USP_KiemtraVoucher
@mavoucher varchar(50)
AS
BEGIN
	SELECT * FROM VOUCHER WHERE MAVOUCHER = @mavoucher
END;
Go

-- Procedure Lấy những vật dụng bị hư bao gồm tên và giá
CREATE PROC USP_LoadVDH
@mabienban varchar(50)
AS
BEGIN
	SELECT VD.Ten AS "Tên", VD.Gia AS "Giá"
	FROM ChiTietBienBanKiemTraPhong CT, VATDUNG VD, BIENBANKIEMTRAPHONG BB
	WHERE CT.MaVatDung = VD.MaVatDung  AND BB.MaBienBan = CT.MaBienBan AND BB.MaBienBan = @mabienban;
END;
Go

-- Procedure Tính tiền những vật dụng bị hư
CREATE FUNCTION TinhTienVatDungHu (@mabienban VARCHAR(5))
RETURNS INT
AS
BEGIN
	DECLARE @tienvatdung INT;
    DECLARE @tongtien INT;
	SET @tongtien = 0;
	
	;WITH VATDUNGHU AS (SELECT VD.Ten, VD.Gia
					   FROM ChiTietBienBanKiemTraPhong CT, VATDUNG VD, BIENBANKIEMTRAPHONG BB
					   WHERE CT.MaVatDung = VD.MaVatDung  AND BB.MaBienBan = CT.MaBienBan AND BB.MaBienBan = @mabienban)

    -- Lấy giá tiền dịch vụ từ bảng DICHVU
    SELECT @tienvatdung = SUM(VD.Gia)
	FROM VATDUNGHU VD

	if (@tienvatdung IS NULL)
		SET @tienvatdung = 0;
	
	SET @tongtien = @tongtien + @tienvatdung

	RETURN @tongtien;
END
Go

-- Procedure Cập nhật tình trạng hóa đơn
CREATE PROC USP_UpdateStatusHoaDon
@mahoadon VARCHAR(10)
AS 
BEGIN
	UPDATE HOADON SET TINHTRANG = N'Đã thanh toán' WHERE MAHOADON = @mahoadon; 
END
GO

-- Procedure Cập nhật tình trạng phòng và tình trạng vệ sinh sau khi Checkout
CREATE PROC USP_UpdatePhong
@sophong VARCHAR(10)
AS 
BEGIN
	UPDATE PHONG SET TINHTRANGPHONG = N'Phòng trống', TINHTRANGVESINH = N'Cần vệ sinh' WHERE SOPHONG = @sophong; 
END
GO

-- Procedure Lấy những mã DichVu mà phòng đã sử dụng
CREATE PROC USP_GetMaDVFromPhong
@Sophong VARCHAR(10)
AS 
BEGIN
	SELECT DV.MaDichVu
	FROM DANGKYDICHVU DK, DICHVU DV
	WHERE DK.MADICHVU = DV.MADICHVU AND DK.SOPHONG = @Sophong; 
END
GO

-- Procedure Cập nhật lại tình trạng phòng là Đã vệ sinh
CREATE PROC USP_UpdateCleanStatusPhong @sophong varchar(10)
AS UPDATE PHONG SET TinhTrangVeSinh = N'Đã vệ sinh' WHERE SOPHONG = @sophong
GO