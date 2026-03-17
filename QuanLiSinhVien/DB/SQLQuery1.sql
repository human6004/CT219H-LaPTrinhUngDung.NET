DELETE FROM KetQua;
DELETE FROM SinhVien;
DELETE FROM GiaoVien;
DELETE FROM MonHoc;
DELETE FROM NganhHoc;
DELETE FROM Lop;
DELETE FROM Khoa;
DELETE FROM Thongtinrieng;
DELETE FROM ChuyenMonGV;
DELETE FROM QuanLyNguoiDung;

INSERT INTO Khoa (Khoa_ID, TenKhoa)
VALUES 
('CNTT', N'kĩ thuật phần mềm (CLC)');

INSERT INTO Thongtinrieng (MaThongTin, thongtingiaovien1, thongtingiaovien2, thongtinsinhvien3, Dantoc, TonGiao)
VALUES
(1, N'', N'', N'', N'Kinh', N'Không'),
(2, N'', N'', N'', N'Kinh', N'Không'),
(3, N'', N'', N'', N'Kinh', N'Không'),
(4, N'', N'', N'', N'Kinh', N'Không'),
(5, N'', N'', N'', N'Kinh', N'Không'),
(6, N'', N'', N'', N'Kinh', N'Không'),
(7, N'', N'', N'', N'Kinh', N'Không'),
(8, N'', N'', N'', N'Kinh', N'Không'),
(9, N'', N'', N'', N'Kinh', N'Không'),
(10, N'', N'', N'', N'Kinh', N'Không'),
(11, N'', N'', N'', N'Kinh', N'Không'),
(12, N'', N'', N'', N'Kinh', N'Không'),
(13, N'', N'', N'', N'Kinh', N'Không'),
(14, N'', N'', N'', N'Kinh', N'Không'),
(15, N'', N'', N'', N'Kinh', N'Không'),
(16, N'', N'', N'', N'Kinh', N'Không'),
(17, N'', N'', N'', N'Kinh', N'Không'),
(18, N'', N'', N'', N'Kinh', N'Không'),
(19, N'', N'', N'', N'Kinh', N'Không'),
(20, N'', N'', N'', N'Kinh', N'Không'),
(21, N'', N'', N'', N'Kinh', N'Không'),
(22, N'', N'', N'', N'Kinh', N'Không'),
(23, N'', N'', N'', N'Kinh', N'Không'),
(24, N'', N'', N'', N'Kinh', N'Không'),
(25, N'', N'', N'', N'Kinh', N'Không');


INSERT INTO SinhVien
(SinhVien_ID, TenSinhVien, GioiTinh, NgaySinh, NoiSinh, NoiOHienTai, KhoaHoc, LyLich, ID_Lop, HinhAnh, MaThongTin)
VALUES
('B2303877', N'Nguyễn Quốc Khánh', 1, '2005-09-02', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 1),
('B2303895', N'Trịnh Hoàng Nam Phương', 1, '2005-10-25', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 2),
('B2303881', N'Hứa Thanh Long', 1, '2005-04-02', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 3),
('B2303875', N'Phạm Công Khanh', 1, '2005-04-02', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 4),
('B2303898', N'Nguyễn Thị Ngọc Quý', 0, '2005-06-23', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 5),
('B2303870', N'Phạm Nguyễn Thanh Huy', 1, '2005-10-23', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 6),
('B2303865', N'Nguyễn Phúc Duy', 1, '2005-08-22', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 7),
('B2303866', N'Trần Tấn Đạt', 1, '2005-11-12', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 8),
('B2303883', N'Nguyễn Vĩnh Nhật Minh', 1, '2005-12-11', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 9),
('B2303897', N'Nguyễn Thanh Quyền', 1, '2005-07-14', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 10),
('B2303882', N'Nguyễn Tấn Lợi', 1, '2005-03-19', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 11),
('B2303889', N'Lê Nguyễn Vĩnh Phát', 1, '2005-10-20', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 12),
('B2303874', N'Nguyễn Đức Khang', 1, '2005-11-09', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 13),
('B2303879', N'Tăng Hùng Kiệt', 1, '2005-02-18', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 14),
('B2303871', N'Võ Nhật Huy', 1, '2005-10-17', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 15),
('B2304067', N'Nguyễn Phúc Thuận Lợi', 1, '2005-08-21', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 16),
('B2303896', N'Lê Trần Huy Phước', 1, '2005-04-08', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 17),
('B2303904', N'Ngô Hùng Thịnh', 1, '2005-04-21', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 18),
('B2303894', N'Nguyễn Trọng Phúc', 1, '2005-06-30', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 19),
('B2303872', N'Nguyễn Ngọc Phương Huỳnh', 0, '2005-04-09', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 20),
('B2303903', N'Lý Gia Thịnh', 1, '2005-12-05', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 21),
('B2303900', N'Bùi Ngọc Tâm', 1, '2005-09-20', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 22),
('B2303887', N'Lê Thanh Nhã', 1, '2005-06-17', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 23),
('B2303863', N'Nguyễn Châu Nhựt Cần', 1, '2005-02-04', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 24),
('B2308203', N'Lê Trần Hiếu Nhân', 1, '2005-04-06', N'Cần Thơ', N'Cần Thơ', '2023-2027', N'', 'DI2396F2', '', 25);

SELECT * FROM Lop
INSERT INTO Lop (Lop_ID, TenLop, ID_Khoa)
VALUES 
('DI2396F2', N'DI2396F2', 'CNTT');

go
INSERT INTO QuanLyNguoiDung (TenDangNhap, MatKhau, QuyenHan)
VALUES 
('admin', '1', 'Admin'),
('nhan', '1', 'User');
end

INSERT INTO MonHoc (MonHoc_ID, TenMonHoc, SoTrinh, GiangVien)
VALUES
('CT101', N'Lập trình C#', 3, N'GV01'),
('CT102', N'Cơ sở dữ liệu', 3, N'GV01');

INSERT INTO GiaoVien (GiaoVien_ID, MaLop, MaThongTin, MaChuyenMon)
VALUES
('GV01', 'DI2396F2', 1, 1);

SELECT * FROM ChuyenMonGV;

INSERT INTO ChuyenMonGV (MaChuyenMon, TenChuyenMon)
VALUES (1, N'Lập trình');

INSERT INTO ChuyenMonGV (MaChuyenMon, TenChuyenMon)
VALUES
(4, N'Lập trình C#'),
(5, N'Cơ sở dữ liệu'),
(6, N'Mạng máy tính');

INSERT INTO Thongtinrieng 
(MaThongTin, thongtingiaovien1, thongtinsinhvien, thongtingiaovien2, thongtinsinhvien3, Dantoc, TonGiao)
VALUES
(26, N'', N'', N'', N'', N'Kinh', N'Không');

INSERT INTO GiaoVien (GiaoVien_ID, MaLop, MaThongTin, MaChuyenMon)
VALUES
('GV03', 'DI2396F2', 26, 1),
('GV02', 'DI2396F2', 26, 2);

INSERT INTO ChuyenMonGV (MaChuyenMon, TenChuyenMon)
VALUES 
(1, N'Lập trình C#'),
(2, N'Cơ sở dữ liệu');

SELECT * FROM ChuyenMonGV;


INSERT INTO NganhHoc (MaNganh, MaMonHoc)
VALUES
('CNTT', 'CT101'),
('CNTT', 'CT102');

INSERT INTO KetQua (ID_MonHoc, ID_SinhVien, LanThi, DiemThi, DiemTongKet)
SELECT 
'CT101',
SinhVien_ID,
1,
ROUND(RAND(CHECKSUM(NEWID())) * 10, 1),
ROUND(RAND(CHECKSUM(NEWID())) * 10, 1)
FROM SinhVien;


INSERT INTO KetQua (ID_MonHoc, ID_SinhVien, LanThi, DiemThi, DiemTongKet)
SELECT 
'CT102',
SinhVien_ID,
1,
ROUND(RAND(CHECKSUM(NEWID())) * 10, 1),
ROUND(RAND(CHECKSUM(NEWID())) * 10, 1)
FROM SinhVien;


INSERT INTO QuanLyNguoiDung (TenDangNhap, MatKhau, QuyenHan)
VALUES
('vy', '1', 'menber');
