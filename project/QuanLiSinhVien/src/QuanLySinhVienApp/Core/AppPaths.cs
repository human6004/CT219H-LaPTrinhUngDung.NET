using System;
using System.IO;

namespace DeTai_QuanLySinhVien
{
    internal static class AppPaths
    {
        public static string BaseDirectory => AppDomain.CurrentDomain.BaseDirectory;

        public static string ImageDirectory => Path.Combine(BaseDirectory, "HinhAnh");

        public static void EnsureRuntimeFolders()
        {
            if (!Directory.Exists(ImageDirectory))
            {
                Directory.CreateDirectory(ImageDirectory);
            }
        }
    }
}
