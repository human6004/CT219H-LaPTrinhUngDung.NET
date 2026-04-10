using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT_WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new @operator());
            Application.Run(new DoiKieuChu());
            //Application.Run(new DongHoDemNguoc());
            //Application.Run(new ChucMungNamMoi());
            //Application.Run(new BuomBay());
        }
    }
}
