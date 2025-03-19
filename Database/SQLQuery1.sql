USE [Đồ án 1 : Quản lý cửa hàng máy tính]
go

-- Bảng chức vụ 
CREATE TABLE HeSoChucVu(
	IDChucVu CHAR(5) PRIMARY KEY not null,
	ChucVu NVARCHAR(50) not null,
	HeSoLuong INT DEFAULT 0
);
go

-- Bảng nhân viên
CREATE TABLE NhanVien(
    IDNhanvien CHAR(5) PRIMARY KEY not null,
    IDChucVu CHAR(5) not null,
    TenNhanVien NVARCHAR(200) not null,
    Gioitinh NVARCHAR(3) NOT NULL,
    Email VARCHAR(500) not null,
    NgaySinh date not null,
    SoDienThoai VARCHAR(10) not null,
    CCCD VARCHAR(30) not null,
    DiaChi NVARCHAR(500) not null,
	Anh VARBINARY(MAX) not null,
	FOREIGN KEY (IDChucVu) REFERENCES HeSoChucVu(IDChucVu)
);
go

-- Bảng tính lương
CREATE TABLE TinhLuong(
	IDTinhLuong CHAR(5) PRIMARY KEY not null,
	IDNhanvien CHAR(5) not null,
	IDChucVu CHAR(5) not null,
	LuongCoBan FLOAT DEFAULT 0,
	Thuong FLOAT DEFAULT 0,
	Phat FLOAT DEFAULT 0,
	TongLuong FLOAT DEFAULT 0,
	FOREIGN KEY(IDNhanvien) REFERENCES NhanVien(IDNhanvien),
	FOREIGN KEY(IDChucVu) REFERENCES HeSoChucVu(IDChucVu)
);
go

-- Bảng khách hàng
CREATE TABLE KhachHang(
	IDKhach CHAR(5) PRIMARY KEY not null,	
	TenKhach NVARCHAR(100) not null,
	GioiTinh NVARCHAR(5) not null,
	SoDienThoai VARCHAR(10) not null,
	CCCD VARCHAR(50) not null,
	Email VARCHAR(500) not null,
	DiaChi NVARCHAR(300) not null
);
go

-- Bảng nhà cung cấp
CREATE TABLE NhaCungCap(
	IDNhacung CHAR(5) PRIMARY KEY not null,
	TenNhacung NVARCHAR(200) not null,
	DiaChi NVARCHAR(300) not null,
	Email VARCHAR(500) not null,
	SoDienThoai VARCHAR(10) not null
);
go

-- Bảng hoá đơn bán
CREATE TABLE HoaDonBan(
	IDBan CHAR(5) PRIMARY KEY not null,
	IDKhach CHAR(5) not null,
	IDNhanvien CHAR(5) not null,
	NgayBan DATE not null,
	TongTien FLOAT DEFAULT 0,
	FOREIGN KEY(IDNhanvien) REFERENCES NhanVien(IDNhanvien),
	FOREIGN KEY(IDKhach) REFERENCES KhachHang(IDKhach),
);
go
-- Bảng hoá đơn nhập
CREATE TABLE HoaDonNhap(
	IDNhap CHAR(5) PRIMARY KEY not null,
	IDNhacung CHAR(5) not null,
	IDNhanvien CHAR(5) not null,
	NgayNhap DATE not null,
	TongThanhToan FLOAT DEFAULT 0,
	FOREIGN KEY(IDNhanvien) REFERENCES NhanVien(IDNhanvien),
	FOREIGN KEY(IDNhacung) REFERENCES NhaCungCap(IDNhacung)
);
go

-- Bảng danh mục
CREATE TABLE DanhMuc(
	IDMuc CHAR(5) PRIMARY KEY not null,
	TenDanhMuc NVARCHAR(50) not null
);
go

-- Bảng máy tính
CREATE TABLE MatHang(
	IDMatHang CHAR(5) PRIMARY KEY not null,
	IDMuc CHAR(5) not null,
	Tenmathang NVARCHAR(200) not null,
	DonGia FLOAT DEFAULT 0 not null,
	BaoHanh NVARCHAR(10) not null,
	Anh VARBINARY(MAX) not null,
	SoLuong INT DEFAULT 0,
	ChiTiet NVARCHAR(500) not null,
	FOREIGN KEY(IDMuc) REFERENCES DanhMuc(IDMuc),
);
go

-- Bảng chi tiết hoá đơn nhập
CREATE TABLE CTNhap(
	IDChitietnhap CHAR(5) PRIMARY KEY not null,
	IDNhap CHAR(5) not null,
	IDMatHang CHAR(5) not null,
	SoLuong INT DEFAULT 0,
	DonGiaNhap FLOAT DEFAULT 0,
	ThanhTien FLOAT DEFAULT 0, 
	FOREIGN KEY(IDNhap) REFERENCES HoaDonNhap(IDNhap),
	FOREIGN KEY(IDMatHang) REFERENCES MatHang(IDMatHang)
);
go

-- Bảng chi tiết hoá đơn bán
CREATE TABLE CTBan(
	IDChitietBan CHAR(5) PRIMARY KEY not null,
	IDBan CHAR(5) not null,
	IDMatHang CHAR(5) not null,
	SoLuong INT DEFAULT 0,
	DonGiaXuat FLOAT DEFAULT 0,
	ThanhTien FLOAT DEFAULT 0, 
	FOREIGN KEY(IDBan) REFERENCES HoaDonBan(IDBan),
	FOREIGN KEY(IDMatHang) REFERENCES MatHang(IDMatHang)
);
go
-- Bảng tài khoản
CREATE TABLE TaiKhoan(
	TenDangNhap CHAR(5) PRIMARY KEY not null,
	IDChucVu CHAR(5) not null,
	MatKhau CHAR(50) not null,
	FOREIGN KEY(TenDangNhap) REFERENCES NhanVien(IDNhanvien) ,
	FOREIGN KEY(IDChucVu) REFERENCES HeSoChucVu(IDChucVu) 
);
go

--------------------------------------------------THỦ TỤC---------------------------------------------------
------------------------------------------------------------------------------------------------------------
-- Thủ tục tính tổng thanh toán ở bảng hoá đơn bán
CREATE PROCEDURE TinhTongTienChoHDB
    @IDBan varchar(10)
AS
BEGIN
    -- Tính tổng thành tiền từ bảng CTBan theo mã HDB
    DECLARE @TongTien FLOAT;
    SELECT @TongTien = SUM(ThanhTien)
    FROM CTBan
    WHERE IDBan = @IDBan;
    -- Cập nhật tổng tiền vào bảng HoaDonBan theo mã HDB
    UPDATE HoaDonBan
    SET TongTien = @TongTien
    WHERE IDBan = @IDBan;
END

-----------------------------------------------------------------------------------------------------------
-- Thủ tục tính tổng thanh toán ở bảng hoá đơn nhập
CREATE PROCEDURE TinhTongTienChoHDN
    @IDNhap varchar(10)
AS
BEGIN
    -- Tính tổng thành tiền từ bảng CTNhap
    DECLARE @ThanhTien FLOAT;
    SELECT @ThanhTien = SUM(ThanhTien)
    FROM CTNhap
    WHERE IDNhap = @IDNhap;
    -- Cập nhật tổng tiền vào bảng Hoá đơn nhập theo mã nhập
    UPDATE HoaDonNhap
    SET TongThanhToan = @ThanhTien
    WHERE IDNhap = @IDNhap;
END

-----------------------------------------------------------------------------------------------------------
-- Tạo phiếu nhập
CREATE PROCEDURE sp_HienThiPhieuNhap
    @IDNhap CHAR(5)
AS
BEGIN
    SELECT
        HD.IDNhap ,
		MH.IDMatHang,
		MH.Tenmathang ,
		NCC.IDNhacung,
		NCC.TenNhacung ,
		CTN.DonGiaNhap ,
		CTN.SoLuong ,
		CTN.ThanhTien,
		HD.TongThanhToan ,
		HD.NgayNhap ,
		NV.TenNhanVien ,
		NV.IDNhanvien 
    FROM HoaDonNhap HD
    INNER JOIN CTNhap CTN ON HD.IDNhap = CTN.IDNhap
    INNER JOIN MatHang MH ON CTN.IDMatHang = MH.IDMatHang
	INNER JOIN NhaCungCap NCC ON HD.IDNhacung = NCC.IDNhacung
	INNER JOIN NhanVien NV ON HD.IDNhanvien = NV.IDNhanvien
    WHERE HD.IDNhap = @IDNhap
END;

----------------------------------------------------------------------------------------------------
--Tạo phiếu bán
CREATE PROCEDURE sp_HienThiPhieuBan
    @IDBan CHAR(5)
AS
BEGIN
    SELECT
        HD.IDBan ,
		MH.IDMatHang,
		MH.Tenmathang ,
		KH.IDKhach,
		KH.TenKhach,
		CTB.DonGiaXuat ,
		CTB.SoLuong ,
		CTB.ThanhTien,
		HD.TongTien ,
		HD.NgayBan ,
		NV.TenNhanVien,
		NV.IDNhanvien
    FROM HoaDonBan HD
    INNER JOIN CTBan CTB ON HD.IDBan = CTB.IDBan
    INNER JOIN MatHang MH ON CTB.IDMatHang = MH.IDMatHang
	INNER JOIN KhachHang KH ON HD.IDKhach = KH.IDKhach
	INNER JOIN NhanVien NV ON HD.IDNhanvien = NV.IDNhanvien
    WHERE HD.IDBan = @IDBan
END;
--------------------------------------------------------------------------------------------------
-- Thủ tục tính tổng lương cho nhân viên
CREATE PROCEDURE sp_TinhTongLuong
    @LuongCoBan float,
    @HeSoLuong int,
    @Thuong float,
    @Phat float,
    @IDTinhLuong char(5)
AS
BEGIN
    -- Cập nhật tổng lương cho mỗi nhân viên
    UPDATE TinhLuong
    SET TongLuong = @LuongCoBan * @HeSoLuong + @Thuong - @Phat
    WHERE IDTinhLuong = @IDTinhLuong;

    -- Trả về tổng lương đã cập nhật
    SELECT TongLuong FROM TinhLuong WHERE IDTinhLuong = @IDTinhLuong;
END

----------------------------------------------------------------------------------------------------------------
-- Thủ tục tăng số lượng mặt hàng ở bảng mặt hàng
-- áp dụng khi nhập hàng thành công hoặc huỷ đơn hàng bán
CREATE PROCEDURE SoLuongTang
    @ProductID CHAR(5),
    @Quantity INT
AS
BEGIN
    UPDATE MatHang
    SET SoLuong = SoLuong + @Quantity
    WHERE IDMatHang = @ProductID;
END

------------------------------------------------------------------------------------------------------------------
-- Thủ tục giảm số lượng mặt hàng ở bảng mặt hàng
-- Áp dụng khi bán hàng thành công hoặc huỷ đơn hàng nhập
CREATE PROCEDURE SoLuongGiam
    @ProductID CHAR(5),
    @Quantity INT
AS
BEGIN
    UPDATE MatHang
    SET SoLuong = SoLuong - @Quantity
    WHERE IDMatHang = @ProductID;
END

-------------------------------------------------------------------------------------------------------------------------
--Thủ tục thống kê doanh thu theo từng ngày trong khoảng thời gian fromdate và todate
CREATE PROCEDURE ThongKeDoanhThu
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SELECT
	-- Định dạng format cho date, hiển thị ra tất cả các ngày trong khoảng fromdate và todate
        FORMAT(AllDates.Date, 'dd-MM-yyyy') AS 'Từ ngày',
        @ToDate AS [Đến ngày],       
		-- tỉnh tổng tiền ở HDB và HDN 
        SUM(HDB.TongTien) AS N'Tổng bán',
        SUM(HDN.TongThanhToan) AS N'Tổng nhập',
        SUM(HDB.TongTien - HDN.TongThanhToan) AS N'Tổng lãi',
		-- Đếm số lượng hoá đơn (Distinct làm cho giá trị không bị trùng lặp nhau)
        COUNT(DISTINCT HDB.TongTien) AS 'Số lượng hóa đơn bán',
        COUNT(DISTINCT HDN.TongThanhToan) AS 'Số lượng hóa đơn nhập'
    FROM (
        SELECT DATEADD(DAY, number, @FromDate) AS Date
        FROM master.dbo.spt_values
        WHERE type = 'P' -- Loại bỏ tất cả số nguyên trong date
            AND DATEADD(DAY, number, @FromDate) <= @ToDate-- chỉ lấy ra số nguyên là ngày trong date 
    ) AS AllDates
	-- lấy ra ngày bán và ngày nhập trong khoảng fromdate và todate
    LEFT JOIN HoaDonBan HDB ON AllDates.Date = HDB.ngayBan
    LEFT JOIN HoaDonNhap HDN ON AllDates.Date = HDN.NgayNhap
	-- Điều kiện hiển thị : chỉ hiển thị những ngày có hoá đơn nhập hoặc hoá đơn bán trong formdate và to date
    WHERE (HDB.NgayBan IS NOT NULL OR HDN.ngayNhap IS NOT NULL)
	-- Nhóm tất cả dữ liệu cùng ngày nhau , không quan tâm đến thời gian
    GROUP BY FORMAT(AllDates.Date, 'dd-MM-yyyy')
	-- Sắp xếp kết quả theo ngày trong Fromdate và todate
    ORDER BY FORMAT(AllDates.Date, 'dd-MM-yyyy');
END

------------------------------------------------------------------------------------------------------------------
-- Top 5 mặt hàng bán chạy nhất
CREATE PROCEDURE HangBanChay
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
	SELECT TOP 5
	-- Lấy ra top 5 mặt hàng có số lượng bán chạy nhắt
		MH.IDMatHang AS 'Mã mặt hàng',
	    MH.Tenmathang AS 'Tên mặt hàng',
		SUM(CTB.SoLuong) AS N'Số lượng bán'
		FROM MatHang MH
		INNER JOIN CTBan CTB ON MH.IDMatHang = CTB.IDMatHang
		INNER JOIN HoaDonBan HDB ON CTB.IDBan = HDB.IDBan
		-- chỉ hiển thị mặt hàng có ngày bán nằm trong fromdate và todate
		WHERE HDB.ngayBan BETWEEN @FromDate AND @ToDate
		-- gom nhóm các cột có dữ liệu giá trị trùng nhau
		GROUP BY MH.IDMatHang, MH.Tenmathang
		-- Sắp xếp kết quả theo thứ tự giảm dần
		ORDER BY SUM(CTB.SoLuong) DESC;
END

-------------------------------------------------------------------------------------------------------------------
-- Số lượng tồn kho
CREATE PROCEDURE HangTonKho
AS
BEGIN
	SELECT
		MH.IDMatHang AS 'Mã mặt hàng',
	    MH.Tenmathang AS 'Tên mặt hàng',
		-- tính tổng số lượng của mặt hàng
	    MH.SoLuong AS N'Số lượng tồn kho'
		FROM MatHang MH
		-- thống kê những mặt hàng có trong bảng mặt hàng , kết nối tương ứng với mặt hàng trong bảng CTBan
		LEFT JOIN CTBan CTB ON MH.IDMatHang = CTB.IDMatHang
		LEFT JOIN HoaDonBan HDB ON CTB.IDBan = HDB.IDBan
		-- gom nhóm các cột, nhóm cột có dữ liệu trùng nhau
		GROUP BY MH.IDMatHang, MH.Tenmathang, MH.SoLuong;
END

----------------------------------------------------------------------------------------------------------------------------
-- Đổi mật khẩu 
CREATE PROCEDURE DoiMatKhau
    @TenDangNhap CHAR(5),
    @newPassword NVARCHAR(50)
AS
BEGIN
    UPDATE TaiKhoan
    SET MatKhau = @newPassword
    WHERE TenDangNhap = @TenDangNhap
END
GO

