using System;
using System.Windows.Forms;

namespace DeTai_QuanLySinhVien
{
    internal static class AppDatabase
    {
        public static string CurrentConnectionString
        {
            get { return Properties.Settings.Default.QuanLySinhVienConnectionString; }
        }

        public static bool Initialize()
        {
            return DatabaseBootstrap.Initialize();
        }

        public static QuanLySinhVienDataContext CreateContext()
        {
            return new QuanLySinhVienDataContext(CurrentConnectionString);
        }

        public static void ShowDatabaseError(string actionName, Exception ex)
        {
            string actionText = string.IsNullOrWhiteSpace(actionName) ? "thực hiện thao tác" : actionName.Trim();

            MessageBox.Show(
                "Không thể " + actionText + " do lỗi cơ sở dữ liệu.\n\n" + ex.Message,
                "Lỗi CSDL",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
