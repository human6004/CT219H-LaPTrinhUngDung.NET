using System;
using System.Linq;

namespace DeTai_QuanLySinhVien
{
    internal static class AuthenticationService
    {
        public static bool ValidateUser(string userName, string password)
        {
            using (QuanLySinhVienDataContext db = AppDatabase.CreateContext())
            {
                return db.QuanLyNguoiDungs.Any(
                    item => item.TenDangNhap == userName && item.MatKhau == password);
            }
        }

        public static bool ValidateAdmin(string userName, string password, string role)
        {
            string normalizedRole = NormalizeRole(role);

            using (QuanLySinhVienDataContext db = AppDatabase.CreateContext())
            {
                return db.QuanLyNguoiDungs
                    .Where(item => item.TenDangNhap == userName && item.MatKhau == password)
                    .AsEnumerable()
                    .Any(item => NormalizeRole(item.QuyenHan) == normalizedRole);
            }
        }

        public static string NormalizeRole(string value)
        {
            string normalized = (value ?? string.Empty).Trim().ToLowerInvariant();

            switch (normalized)
            {
                case "admin":
                    return "admin";
                case "member":
                case "menber":
                case "user":
                    return "user";
                default:
                    return normalized;
            }
        }
    }
}
