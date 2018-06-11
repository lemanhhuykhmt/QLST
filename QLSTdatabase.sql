

CREATE DATABASE QLST
go
USE QLST
go


CREATE TABLE NhanVien
(
	MaNV int IDENTITY(1,1),
	TenNV nvarchar(100) not null,
	SDT nvarchar(11),
	GioiTinh nvarchar(5) not null,
	NgaySinh Date DEFAULT getdate(),
	Luong float,
	Primary Key (MaNV)
)

go

CREATE TABLE SanPham
(
	MaSP int IDENTITY(1,1),
	TenSP nvarchar(50) not null,
	MaLoaiSP int,
	DonGia float not null,
	DonViDo nvarchar(10) not null,
	HSD Date DEFAULT getdate(),
	NSX Date DEFAULT getdate(),
	SoLuong int,
	ConDung bit DEFAULT 1,
	Primary Key (MaSP)
)
go
CREATE TABLE LoaiSP
(
	MaLoaiSP int IDENTITY(1,1),
	TenLoaiSP nvarchar(50) not null,
	MaMH int,
	Primary Key (MaLoaiSP)
)
go
create table MatHang
(
	MaMH int IDENTITY(1,1),
	TenMH nvarchar(50) not null,
	Primary Key (MaMH)
)
CREATE TABLE KhachHang
(
	MaKH int IDENTITY(1,1),
	TenKH nvarchar(50),
	DiaChi nvarchar(100),
	SDT nvarchar(11),
	Primary Key (MaKH)
)
go
CREATE TABLE HoaDonBan
(
	MaHDB int IDENTITY(1,1),
	MaNV int,
	MaKH int,
	TrangThai int,
	NgayLap DateTime DEFAULT getdate(),
	MaKM int DEFAULT null,
	ThanhToan float,
	Primary Key (MaHDB)
)
go
CREATE TABLE DanhSachBan
(
	MaHDB int,
	MaSP int,
	SoLuong int not null,
	GiaTien float not null,
	Primary Key (MaHDB, MaSP)
)
go


create table KhuyenMai
(
	MaKM int IDENTITY(1,1),
	TenKM nvarchar(50),
	GiaTri float not null,
	LoaiKM int not null,-- 1 - %, 2 - nghìn
	NgayBD Date,
	NgayKT Date,
	Primary Key (MaKM)
)

--2, Khoá ngoại




-- Bảng SanPham
ALTER TABLE SanPham ADD CONSTRAINT FK_SanPham_LoaiSP FOREIGN KEY (MaLoaiSP) REFERENCES LoaiSP(MaLoaiSP)
-- Bảng LoaiSP
ALTER TABLE LoaiSP ADD CONSTRAINT FK_LoaiSP_MatHang FOREIGN KEY (MaMH) REFERENCES MatHang(MaMH)
-- Bảng MatHang
-- Bảng KhachHang
-- Bảng HoaDonBan
ALTER TABLE HoaDonBan ADD CONSTRAINT FK_HoaDonBan_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
ALTER TABLE HoaDonBan ADD CONSTRAINT FK_HoaDonBan_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
ALTER TABLE HoaDonBan ADD CONSTRAINT FK_HoaDonBan_KhuyenMai FOREIGN KEY (MaKM) REFERENCES KhuyenMai(MaKM)
-- Bảng DanhSachBan
ALTER TABLE DanhSachBan ADD CONSTRAINT FK_DanhSachBan_HoaDonBan FOREIGN KEY (MaHDB) REFERENCES HoaDonBan(MaHDB)
ALTER TABLE DanhSachBan ADD CONSTRAINT FK_DanhSachBan_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)


go
--3, Thêm dữ liệu


-- Bảng KhachHang
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Nguyễn Văn Minh', N'Ngọc Thuỵ Long Biên Hà Nội', '0975141782')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Bùi Kim Quyên', N'ngõ 81 Tổ 12 Mậu Lương,P.Kiến Hưng,Q.Hà Đông' , '0982527982')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Võ An Phước', N'nhà số 14 ngách 18 ngõ 111 Triều Khúc,Hà Nội', '0917749254')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Phạm Nguyễn Quỳnh Trân', N'nhà số 7 ngõ 122 /2 đường Kim Giang,P.Đại Kim,Hoàng Mai,Hà Nội', '0973776072')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Võ Minh Thư', N'số 18 ngõ 54 Phùng Khoang,Nam Từ Liêm,Hà Nội', '0904770053')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Nguyễn Thế Vinh', N'nhà số 29 ngách 10 ngõ 2 Hoàng Liệt,P.Hoàng Liệt,Hoàng Mai', '0974880788')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Lê Minh Vương', N'16 ngách242/74 Minh Khai, Hoàng Mai, Hà Nội', '0983888611')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Trương Gia Mẫn', N'số 36 trường lâm, long biên, Hà nội', '0984603663')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Châu Thị Kim Anh', N'số nhà 29/ngõ 76/ ngách 32/hẻm 25 An Dương, Tây Hồ, Hà Nội', '0986375176')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Cao Minh Hiền', N'Ngõ 52/28 Tô Ngọc Vân, phường Quảng An, Tây Hồ, Hà Nội', '0914770545')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Võ Thị Tuyết Vân', N'Phòng 504, tòa B, chung cư Golden Land, 275 Nguyễn Trãi, Thanh Xuân, Hà Nội', '0986253482')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Doãn Phan Trung Hải', N'số 33/89 ngõ Thịnh Quang, Đống Đa, Hà Nội', '0944545232')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Nguyễn Minh Châu', N'3A ngõ 264/17 Âu Cơ, Nhật Tân, Tây Hồ', '0912644784')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Nguyễn Thạch Giang', N'ngõ 362 đường Giải Phóng, phường Thịnh Liệt, quận Hoàng Mai', '01668890843')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Trần Thị Kim  Ngân', N'tổ 7 Huyền Kỳ, phường Phú Lãm, quận Hà Đông, Hà Nội', '01634229954')
INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES (N'Huỳnh Kim Hoàng', N'số nhà 11 ngõ 76 An Dương, Tây Hồ, Hà Nội', '01672377922')
go
-- Bảng MatHang
INSERT INTO MatHang(TenMH)
VALUES(N'Thực Phẩm') -- 1
INSERT INTO MatHang(TenMH)
VALUES(N'Đồ Gia Dụng') --2
INSERT INTO MatHang(TenMH)
VALUES(N'Trang Phục') --3
INSERT INTO MatHang(TenMH)
VALUES(N'Sách') --4

go
-- LoaiSP
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Bánh Mì', 1)--1
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Hải Sản', 1)-- 2
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Đồ Hộp', 1)--3
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Dụng Cụ Nấu Ăn', 2)--4
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Đồ Điện Tử', 2)--5
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Đồ Trẻ Em', 3)--6
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Vải Tấm', 3)--7
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Sách Khoa Học', 4)--8
INSERT INTO LoaiSP(TenLoaiSP, MaMH)
VALUES(N'Truyện Thiếu Nhi', 4)--9
go
-- Bảng SanPham
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Bánh Mì Gậy', 10000, N'Cái', '2017-10-14', '2017-10-15', 200, 1)--1
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Bánh Mì Gối Thường', 9000, N'Cái', '2017-10-13', '2017-10-15', 50, 1)--2
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Bánh Mì Đen', 5000, N'Cái', '2017-10-20', '2017-10-21', 40, 1)--3
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Cua Hoàng Đế', 2000000, N'Kg', '2017-10-12', '2017-10-17', 20, 2)--4
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Tôm Hùm', 40000, N'kg', '2017-9-20', '2017-9-26', 15, 2)--5
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Kem Hộp', 100000, N'Hộp', '2017-10-20', '2017-10-26', 100, 3)--6
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Pate Đóng Hộp', 20000, N'Hộp', '2017-10-11', '2017-10-17', 400, 3)--7
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Chảo Chống Dính', 150000, N'Cái', '2017-10-20', '2019-10-21', 10, 4)--8
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Bát Sứ', 200000, N'Hộp', '2017-10-22', '2020-10-24', 20, 4)--9
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Tủ Lạnh Tosiba', 16000000, N'Chiếc', '2017-10-20', '2020-10-25', 4, 5)--10
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Iphone X', 24000000, N'Chiếc', '2017-10-12', '2019-10-17', 5, 5)--11
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'TiVi SamSung', 16500000, N'Chiếc', '2017-9-20', '2021-9-26', 15, 5)--12
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Lego Lắp Ghép', 100000, N'Bộ', '2017-10-20', '2018-10-30', 10, 6)--13
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Búp Bê', 150000, N'Hộp', '2017-10-11', '2018-10-17', 5, 6)--14
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Vải Cao Cấp', 200000, N'Mét', '2017-10-20', '2019-10-21', 400, 7)--15
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Vải Hoa', 20000, N'Mét', '2017-10-22', '2018-10-24', 2000, 7)--16
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Nguyên Lý Cơ Bản Máy Học', 50000, N'Quyển', '2017-10-20', '2019-10-25', 10, 8)--17
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Trái Đất Quanh Ta', 40000, N'Quyển', '2017-10-12', '2017-10-17', 20, 8)--18
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'Doreamon', 16000, N'Quyển', '2017-9-20', '2017-9-26', 100, 9)--19
INSERT INTO SanPham (TenSP, DonGia, DonViDo, NSX, HSD, SoLuong, MaLoaiSP)
VALUES (N'One Piece', 1000000, N'Bộ', '2017-10-20', '2017-10-26', 1, 9)--20




-- Bảng NhanVien
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Vũ Bình', N'Nam', '1987-12-22', 1300, '0988992518')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Đặng Thị Quế Anh', N'Nữ', '1991-1-16', 2300, '01682562472')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Lê Thị Nhật Phương', N'Nữ', '1994-5-4', 1500, '0912029889')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Lê Thị Sang Giàu', N'Nữ', '1990-9-5', 1000, '0973152724')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Trần Tú Anh', N'Nam', '1989-11-15', 3500, '01265558169')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'La Bảo Minh', N'Nam', '1986-5-26', 2000, '01223444945')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Thị Đào', N'Nữ', '1987-1-29', 1600, '0935611126')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Võ Hùng Anh', N'Nam', '1980-4-4', 1500, '0973753259')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Lê Thị Thảo', N'Nữ', '1992-10-21', 1800, '0933029135')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Hồ Thị Kiều', N'Nữ', '1988-4-15', 2100, '01217221021')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Ngọc Phương Trâm', N'Nữ', '', 1400, '06503820328')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Võ Trần Phú Quý', N'Nam', '1989-1-9', 1500, '0948881449')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Hoàng Nhân', N'Nam', '1990-9-24', 1600, '0942600799')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Thị Hoa', N'Nữ', '1986-4-2', 2010, '01257542074')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Lê Văn Khuyên', N'Nam', '1995-12-30', 2200, '0918035895')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Đinh Hồ Tiến Dũng', N'Nam', '1987-10-31', 1700, '01656364757')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Văn Đức', N'Nam', '1994-5-20', 3000, '0939849458')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Thị Loan', N'Nữ', '1997-6-3', 1300, '0903918485')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Ngô Đình Chiến', N'Nam', '1988-9-2', 1000, '01656364757')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Ngọc Tuấn', N'Nam', '1989-4-2', 1800, '01633871544')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Nguyễn Quang Huy', N'Nam', '1994-10-21', 2000, '0917326426')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Phan Thị Kim Phượng', N'Nữ', '1989-8-13', 1600, '0925048498')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Trần Minh Hiếu', N'Nam', '1995-1-1', 1900, '0907094345')
INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh, Luong, SDT)
VALUES (N'Lê Đình Thắng', N'Nam', '1984-6-22', 2000, '0916438487')


-- Bảng KhuyenMai  -- 1 - %, 2 - nghìn
INSERT INTO KhuyenMai (TenKM, GiaTri, LoaiKM, NgayBD, NgayKT)
VALUES (N'Tiếp Sức U23', 10, 1, '2018-1-11', '2018-2-11')--1
INSERT INTO KhuyenMai (TenKM, GiaTri, LoaiKM, NgayBD, NgayKT)
VALUES (N'Hello Summer', 10, 1, '2017-2-11', '2017-2-11')--2
INSERT INTO KhuyenMai (TenKM, GiaTri, LoaiKM, NgayBD, NgayKT)
VALUES (N'Black Friday', 20000, 2, '2017-2-11', '2017-2-11')--3
INSERT INTO KhuyenMai (TenKM, GiaTri, LoaiKM, NgayBD, NgayKT)
VALUES (N'Chủ Nhật Mua Sắm', 20, 1, '2017-2-11', '2017-2-11')--4
INSERT INTO KhuyenMai (TenKM, GiaTri, LoaiKM, NgayBD, NgayKT)
VALUES (N'Khuyến Mãi Ngày Vàng', 10, 1, '2017-2-11', '2017-2-11')--5
INSERT INTO KhuyenMai (TenKM, GiaTri, LoaiKM, NgayBD, NgayKT)
VALUES (N'Phát Tài Phát Lộc', 15, 1, '2017-2-11', '2017-2-11')--6
go

-- Bảng HoaDonBan--1,5,7,8,12,17,18,20,22(mã nhân viên bán hàng)
INSERT INTO HoaDonBan(MaNV, MaKH, NgayLap, TrangThai, MaKM, ThanhToan)
VALUES (5, 1, '2017-2-11', 1, null, 2250000)--1
INSERT INTO HoaDonBan(MaNV, MaKH, NgayLap, TrangThai, MaKM, ThanhToan)
VALUES (12, 2, '2018-3-1', 1, 1, 370000)--2
INSERT INTO HoaDonBan(MaNV, MaKH, NgayLap, TrangThai, MaKM, ThanhToan)
VALUES (17, 3, '2017-2-10', 1, null, 1027000)--3
INSERT INTO HoaDonBan(MaNV, MaKH, NgayLap, TrangThai, MaKM, ThanhToan)
VALUES (7, 4, '2017-12-11', 2, null, 330000)--4


-- Bảng DanhSachBan --DanhSachBan(mã hoá đơn bán, mã sản phẩm, số lượng, mã km, giá tiền)

INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (1, 1, 10, 100000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (1, 4, 1, 2000000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (1, 8, 1, 150000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (2, 3, 2, 10000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (2, 5, 4, 160000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (2, 9, 1, 200000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (3, 2, 3, 27000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (3, 20, 1, 1000000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (4, 1, 3, 30000)
INSERT INTO DanhSachBan(MaHDB, MaSP, SoLuong, GiaTien)
VALUES (4, 8, 2, 300000)




--thêm vào bảng NhanVien --NhanVien (mã nv, tên nv,sdt, giới tính, ngày sinh, lương )
go
CREATE PROC themnv(@hoten nvarchar(100), @gioitinh nvarchar(5), @ngaysinh date, @luong float, @sdt varchar(11))
AS
BEGIN
	IF(@luong < 0) return -- nếu lương nhỏ hơn 0 thì bỏ
	INSERT INTO NhanVien (TenNV, GioiTinh, NgaySinh, Luong, SDT) -- nếu ổn thì thêm
	VALUES (@hoten, @gioitinh, @ngaysinh, @luong, @sdt)
	--PRINT'Đã thêm thành công'
END
-- sửa lương của 1 nv
go
create PROC suanv (@manv int, @hoten nvarchar(100), @gioitinh nvarchar(5), @ngaysinh date, @sdt varchar(11), @luong float) -- sửa lương của 1 nv
AS
BEGIN
	if(@manv not in (select MaNV from NhanVien)) return
	if(len(@hoten) > 0)
	begin
		UPDATE NhanVien
		SET TenNV = @hoten 	
		WHERE MaNV = @manv
	end
	if((YEAR(@ngaysinh) - 1900) > 0)
	begin
		UPDATE NhanVien
		SET NgaySinh = @ngaysinh
		WHERE MaNV = @manv
	end
	if(len(@sdt) > 0)
	begin
		UPDATE NhanVien
		SET SDT = @sdt
		WHERE MaNV = @manv
	end
	if(len(@gioitinh) > 0)
	begin
		UPDATE NhanVien
		SET GioiTinh = @gioitinh
		WHERE MaNV = @manv
	end
	if(@luong > 0)
	begin
		UPDATE NhanVien
		SET Luong = @luong
		WHERE MaNV = @manv
	end
END
-- xóa 1 nv
go
CREATE PROC xoanv(@manv int) -- xóa 1 nv
AS
BEGIN
	if(@manv not in (select MaNV from Nhanvien)) return
	if(@manv in (select MaNV from HoaDonNhap)) -- nếu nv có trong hóa đơn nhập , thì chuyển về null
	begin
		UPDATE HoaDonNhap
		SET MaNV = null
		WHERE MaNV = @manv
	end
	if(@manv in (select MaNV from HoaDonBan)) -- nếu nv có trong hóa đơn bán , thì chuyển về null
	begin
		UPDATE HoaDonBan
		SET MaNV = null
		WHERE MaNV = @manv
	end
	if(@manv in (select MaNV from Account)) -- nếu nv có acc thì xóa acc luôn, vì trường MaNV trong bảng Account là not null (để not null vì 1 acc k thể tồn tại nếu k có nv dùng)
	begin
		-- gọi hàm xóa account
		DELETE Account
		WHERE MaNV = @manv
	end
	
	DELETE NhanVien -- xóa hết các ràng buộc liên quan đến mã nv này rồi thì xóa thôi
	WHERE MaNV = @manv
END
go

-- Bảng SanPham
--SanPham(mã sp, tên sp, mã loại sp, đơn giá, đơn vị đo, hsd, nsx, sl, condung)
Create proc themsp(@tensp nvarchar(50), @loaisp int, @dongia float, @donvido nvarchar(10), @hsd Date, @nsx Date, @soluong int)
as
begin
	if(@loaisp not in (select MaLoaiSP from LoaiSP)) return
	if(@dongia < 0) return
	if(DATEDIFF(DAYOFYEAR, @nsx, @hsd) <= 0) return
	if(@soluong < 0) return
	INSERT INTO SanPham(TenSP, MaLoaiSP, DonGia, DonViDo, HSD, NSX, SoLuong)
	VALUES (@tensp, @loaisp, @dongia, @donvido, @hsd, @nsx, @soluong)
end
go
Create proc suasp(@masp int, @tensp nvarchar(50), @loaisp int, @dongia float, @donvido nvarchar(10), @hsd Date, @nsx Date, @soluong int) 
as 
begin
	if(@masp not in (select MaSP from SanPham)) return
	if(len(@tensp) > 0)
	begin
		Update SanPham
		Set TenSP = @tensp
		Where MaSP = @masp	
	end
	if((@loaisp is not null) and (@loaisp in (select MaLoaiSP from LoaiSP)))
	begin
		Update SanPham
		Set MaLoaiSP = @loaisp
		Where MaSP = @masp	
	end
	if(@dongia is not null)
	begin
		Update SanPham
		Set DonGia = @dongia
		Where MaSP = @masp	
	end
	if(len(@donvido) > 0)
	begin
		Update SanPham
		Set DonViDo = @donvido
		Where MaSP = @masp	
	end
	if(@hsd is not null)
	begin
		Update SanPham
		Set HSD = @hsd
		Where MaSP = @masp	
	end
	if(@nsx is not null)
	begin
		Update SanPham
		Set NSX = @nsx
		Where MaSP = @masp	
	end
	if(@soluong is not null)
	begin
		Update SanPham
		Set SoLuong = @soluong
		Where MaSP = @masp	
	end
end

go
Create proc xoasp(@masp int)--DanhSachBan, ThanhPhan
as
begin
	if(@masp not in (select MaSP from SanPham)) return
	--if(@masp in (select MaSP from DanhSachBan))
	
	update SanPham
	set ConDung = 0
	Where MaSP = @masp
end


go
--Bảng LoaiSP(mã loại sp, tên loại sp, mã mh)
create proc themlsp(@tenlsp nvarchar(50), @mamh int)
as
begin
	if(@mamh not in (select MaMH from MatHang)) return
	INSERT INTO LoaiSP (TenLoaiSP, MaMH)
	VALUES (@tenlsp, @mamh)
end

go
create proc sualsp(@malsp int, @tenlsp nvarchar(50))
as
begin
	update LoaiSP
	set TenLoaiSP = @tenlsp
	where MaLoaiSP = @malsp
end
go

create proc xoalsp(@malsp int)
as 
begin
	if(@malsp not in (select MaLoaiSP from LoaiSP)) return
	if(@malsp in (select MaLoaiSP from SanPham))
	begin
		update SanPham
		set MaLoaiSP = NULL
		where MaLoaiSP = @malsp
	end
	delete LoaiSP where MaLoaiSP = @malsp
end

go

go
--Bảng HoaDonBan
/*
MaHDB int IDENTITY(1,1),
	MaNV int,
	MaKH int,
	TrangThai int,
	NgayLap DateTime DEFAULT getdate(),
*/
create proc themhdb(@makh int, @manv int, @ngaylap Datetime, @makm int, @trangthai int, @thanhtoan float)
as
begin
	declare @kh int
	if(@makh = 0)
	begin
		set @kh = null
	end
	else
	begin
		set @kh = @makh
	end
	declare @nv int
	if(@manv = 0)
	begin
		set @nv = null
	end
	else
	begin
		set @nv = @manv
	end
	declare @km int
	if(@makm = 0)
	begin
		set @km = null
	end
	else
	begin
		set @km = @makm
	end
	if(@makh not in (select MaKH from KhachHang) and @makh != 0) return
	if(@manv not in (select MaNV from NhanVien) and @manv != 0) return
	if(@makm not in (select MaKM from KhuyenMai) and @makm != 0) return
	if(@trangthai != 1 and @trangthai != 2 and @trangthai != 3 and @trangthai != 4) return
	if((YEAR(@ngaylap) - 1900) <= 0) return
	INSERT INTO HoaDonBan (MaKH, MaNV, NgayLap, MaKM, TrangThai, ThanhToan)
	VALUES (@kh, @nv, @ngaylap, @km, @trangthai, @thanhtoan)
end
go
create proc suahdb(@mahdb int, @makh int, @manv int, @makm int, @trangthai int, @thanhtoan float)
as 
begin
	if(@mahdb not in (select MaHDB from HoaDonBan)) return
	if(@manv not in (select MaNV from NhanVien) and @manv != 0) return
	if(@makh not in (select MaKH from KhachHang) and @makh != 0) return
	if(@makm not in (select MaKM from KhuyenMai) and @makm != 0) return
	if(@trangthai = 1 or @trangthai = 2 or @trangthai = 3 or @trangthai = 4)
	begin
		update HoaDonBan
		set TrangThai = @trangthai
		where MaHDB = @mahdb
	end
	if(@manv != 0)
	begin
		UPDATE HoaDonBan
		SET MaNV = @manv 	
		WHERE MaHDB = @mahdb
	end
	else 
	begin 
		UPDATE HoaDonBan
		SET MaNV = null 	
		WHERE MaHDB = @mahdb
	end
	if(@makh != 0)
	begin
		UPDATE HoaDonBan
		SET MaKH = @makh 	
		WHERE MaHDB = @mahdb
	end
	else 
	begin 
		UPDATE HoaDonBan
		SET MaKH = null 	
		WHERE MaHDB = @mahdb
	end
	if(@makm != 0)
	begin
		UPDATE HoaDonBan
		SET MaKM = @makm 	
		WHERE MaHDB = @mahdb
	end
	else 
	begin 
		UPDATE HoaDonBan
		SET MaKM = null 	
		WHERE MaHDB = @mahdb
	end
	
	if(@thanhtoan > 0)
	begin 
		update HoaDonBan
		set ThanhToan = @thanhtoan
		where MaHDB = @mahdb
	end
end
go
create proc xoahdb(@mahdb int)
as
begin
	if(@mahdb not in (select MaHDB from HoaDonBan)) return
	
	delete DanhSachBan where MaHDB = @mahdb
	delete HoaDonBan where MaHDB = @mahdb
end

go




go
--Bảng DanhSachBan
create proc themdsb (@mahdb int, @masp int, @soluong int, @giatien float)
as 
begin
	if(@mahdb not in (select MaHDB from HoaDonBan)) return
	if(@masp not in (select MaSP from SanPham)) return
	if(@giatien < 0) return
	if(@soluong < 0 )return
	INSERT INTO DanhSachBan (MaHDB, MaSP, SoLuong, GiaTien)
	VALUES (@mahdb, @masp, @soluong, @giatien)
end


go
create proc suadsb(@mahdb int, @masp int, @soluong int, @giatien float)
as 
begin
	if(@mahdb not in (select MaHDB from DanhSachBan)) return
	if(@masp not in (select MaSP from SanPham)) return
	if(@soluong < 0 or @giatien < 0) return
	
	update DanhSachBan 
	set SoLuong = @soluong
	where MaHDB = @mahdb and MaSP = @masp
	update DanhSachBan
	set GiaTien = @giatien
	where MaHDB = @mahdb and MaSP = @masp
end

go
create proc xoadsb(@mahdb int, @masp int)
as
begin
	delete DanhSachBan
	where MaHDB = @mahdb and MaSP = @masp
end
go
create proc xoadsb_all(@mahdb int)
as
begin
	delete DanhSachBan
	where MaHDB = @mahdb
end

go


--bảng KhachHang

create proc themkh(@ten nvarchar(50), @diachi nvarchar(100), @sdt nvarchar(11))
as 
begin
	INSERT INTO KhachHang (TenKH, DiaChi, SDT)
	VALUES (@ten, @diachi, @sdt)
end
go
create proc suakh(@makh int, @ten nvarchar(50), @diachi nvarchar(100), @sdt nvarchar(11))
as
begin
	if(len(@ten) > 0)
	begin
		update KhachHang
		set TenKH = @ten
		where MaKH = @makh
	end
	if(len(@diachi) > 0)
	begin
		update KhachHang
		set DiaChi = @diachi
		where MaKH = @makh
	end
	if(len(@sdt) > 0)
	begin
		update KhachHang
		set SDT = @sdt
		where MaKH = @makh
	end
end

go
create proc xoakh(@makh int)
as
begin
	if(@makh not in (select MaKH from KhachHang)) return
	if(@makh in (select MaKH from HoaDonBan))
	begin 
		update HoaDonBan
		set MaKH = NULL
		where MaKH = @makh
	end
	delete KhachHang where MaKH = @makh
end

go

create proc themkm(@tenkm nvarchar(50), @giatri float, @loai int, @ngaybd date, @ngaykt date)
as
begin
	if((DATEDIFF(DAYOFYEAR, @ngaybd, @ngaykt) <= 0)) return
	if(@giatri < 0) return
	if(@loai != 1 and @loai != 2) return
	Insert into KhuyenMai(TenKM, GiaTri, LoaiKM, NgayBD, NgayKT)
	VALUES (@tenkm, @giatri, @loai, @ngaybd, @ngaykt)
end
go

create proc suakm(@makm int, @giatri float)
as 
begin
	if(@makm not in (select MaKM from KhuyenMai)) return
	if(@giatri < 0) return
	declare @loai int
	select @loai = LoaiKM from KhuyenMai where MaKM = @makm
	if(@loai = 1)
	begin
		if(@giatri > 100) return
	end
	Update KhuyenMai 
	set GiaTri = @giatri
	where MaKM = @makm
end

go
create proc xoakm(@makm int)
as 
begin
	if(@makm not in (select MaKM from KhuyenMai)) return
	update HoaDonBan 
	set MaKM = null
	where MaKM = @makm
	
	delete KhuyenMai
	where MaKM = @makm
end
go


go
create proc themmh (@ten nvarchar(50))
as 
begin 
	if(len(@ten) > 0)
	begin
		insert into MatHang(TenMH)
		values (@ten)
	end
end
go
create proc suamh (@ma int, @ten nvarchar(50))
as
begin
	if(len(@ten) > 0)
	begin
		update MatHang set TenMH = @ten where MaMH = @ma
	end
end
go
go
create proc xoamh (@ma int)
as
begin
	if(@ma not in (select MaMH from MatHang)) return
	if(@ma in (select MaMH from LoaiSP))
	begin
		declare @malsp int
		declare ma_cursor cursor for select MaLoaiSP from LoaiSP where MaMH = @ma
		open ma_cursor
		while 0 = 0	
		begin 
			fetch next from ma_cursor
			into @malsp 
			if(@@fetch_status <> 0) break
			exec xoalsp @malsp
		end
		close ma_cursor
		deallocate ma_cursor
	end
	delete MatHang where MaMH = @ma
end







