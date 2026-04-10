using System;
using System.Windows.Forms;

namespace DeTai_QuanLySinhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppPaths.EnsureRuntimeFolders();
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            if (!AppDatabase.Initialize())
            {
                return;
            }

            Application.Run(new frmChuongTrinh());
        }
    }
}
