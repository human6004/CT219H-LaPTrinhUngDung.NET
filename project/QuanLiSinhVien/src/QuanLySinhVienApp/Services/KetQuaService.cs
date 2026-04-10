using System;
using System.Collections.Generic;
using System.Linq;

namespace DeTai_QuanLySinhVien
{
    internal static class KetQuaService
    {
        public static List<MonHoc> LayDanhSachMonHocDaCoKetQua(QuanLySinhVienDataContext db, string maSinhVien)
        {
            string maSV = (maSinhVien ?? string.Empty).Trim();

            HashSet<string> danhSachMaMon = new HashSet<string>(
                db.KetQuas
                  .Where(item => item.ID_SinhVien.Trim() == maSV)
                  .Select(item => item.ID_MonHoc.Trim())
                  .ToList(),
                StringComparer.OrdinalIgnoreCase);

            return db.MonHocs
                .ToList()
                .Where(item => danhSachMaMon.Contains(item.MonHoc_ID.Trim()))
                .OrderBy(item => item.TenMonHoc)
                .ToList();
        }

        public static KetQua LayKetQuaMoiNhat(QuanLySinhVienDataContext db, string maSinhVien, string maMonHoc)
        {
            string maSV = (maSinhVien ?? string.Empty).Trim();
            string maMH = (maMonHoc ?? string.Empty).Trim();

            return db.KetQuas
                .Where(item => item.ID_SinhVien.Trim() == maSV && item.ID_MonHoc.Trim() == maMH)
                .OrderByDescending(item => item.LanThi)
                .FirstOrDefault();
        }

        public static KetQua LayKetQuaTheoLanThi(QuanLySinhVienDataContext db, string maSinhVien, string maMonHoc, int lanThi)
        {
            string maSV = (maSinhVien ?? string.Empty).Trim();
            string maMH = (maMonHoc ?? string.Empty).Trim();

            return db.KetQuas.SingleOrDefault(item =>
                item.ID_SinhVien.Trim() == maSV &&
                item.ID_MonHoc.Trim() == maMH &&
                item.LanThi == lanThi);
        }

        public static bool KiemTraTonTai(QuanLySinhVienDataContext db, string maSinhVien, string maMonHoc, int lanThi)
        {
            string maSV = (maSinhVien ?? string.Empty).Trim();
            string maMH = (maMonHoc ?? string.Empty).Trim();

            return db.KetQuas.Any(item =>
                item.ID_SinhVien.Trim() == maSV &&
                item.ID_MonHoc.Trim() == maMH &&
                item.LanThi == lanThi);
        }
    }
}
