using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DeTai_QuanLySinhVien
{
    internal static class StudentFormSupport
    {
        public static void BindClassCombo(ComboBox comboBox, QuanLySinhVienDataContext db)
        {
            comboBox.DataSource = db.Lops.ToList();
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "Lop_ID";
            comboBox.SelectedIndex = -1;
            comboBox.Tag = null;
        }

        public static void UpdateSelectedClassTag(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1 || comboBox.SelectedValue == null)
            {
                return;
            }

            comboBox.Tag = comboBox.SelectedValue.ToString();
        }

        public static string ResolveSelectedClassId(ComboBox comboBox)
        {
            if (comboBox.SelectedValue != null)
            {
                return comboBox.SelectedValue.ToString();
            }

            return Convert.ToString(comboBox.Tag);
        }

        public static bool TryChooseImage(PictureBox pictureBox, ref string imageFileName)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image files (*.BMP,*.JPG,*.JPEG,*.PNG)|*.bmp;*.jpg;*.jpeg;*.png";
                dialog.InitialDirectory = AppPaths.ImageDirectory;

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                AppPaths.EnsureRuntimeFolders();

                string sourcePath = dialog.FileName;
                imageFileName = Path.GetFileName(sourcePath);
                string destinationPath = Path.Combine(AppPaths.ImageDirectory, imageFileName);

                if (!string.Equals(sourcePath, destinationPath, StringComparison.OrdinalIgnoreCase))
                {
                    File.Copy(sourcePath, destinationPath, true);
                }

                SetImage(pictureBox, destinationPath);
                return true;
            }
        }

        public static void LoadImage(PictureBox pictureBox, string imageFileName)
        {
            string safeFileName = imageFileName ?? string.Empty;
            string fullPath = Path.Combine(AppPaths.ImageDirectory, safeFileName);

            if (string.IsNullOrWhiteSpace(imageFileName) || !File.Exists(fullPath))
            {
                ClearImage(pictureBox);
                return;
            }

            SetImage(pictureBox, fullPath);
        }

        public static void ClearImage(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }

            pictureBox.Image = null;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private static void SetImage(PictureBox pictureBox, string fullPath)
        {
            Image image = LoadImageWithoutLock(fullPath);

            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }

            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private static Image LoadImageWithoutLock(string fullPath)
        {
            byte[] bytes = File.ReadAllBytes(fullPath);
            using (MemoryStream memory = new MemoryStream(bytes))
            using (Image source = Image.FromStream(memory))
            {
                return new Bitmap(source);
            }
        }
    }
}
