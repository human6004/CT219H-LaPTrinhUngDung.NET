using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;

namespace DeTai_QuanLySinhVien
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        string tenDangNhap;
        string maDangNhap;

        string connStr = @"Data Source=NHAN;Initial Catalog=QuanLySinhVien;User ID=sa;Password=Nhan060405@;TrustServerCertificate=True";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tenDangNhap = txtTenDangNhap.Text.Trim();
            maDangNhap = txtMauKhau.Text.Trim();

            if (DangNhapHeThong(tenDangNhap, maDangNhap) == true)
            {
                frmChuongTrinh Main = (frmChuongTrinh)this.MdiParent;
                Main.EnableMenu();
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                this.Close();
            }
            else
                MessageBox.Show("Thông Tin Đăng Nhập Không Đúng.Vui Lòng Kiểm Tra Lại", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool DangNhapHeThong(string TenDangNhap, string MatKhau)
        {
            using (QuanLySinhVienDataContext db = new QuanLySinhVienDataContext(connStr))
            {
                var ktDangNhap = from QuanLyNguoiDung in db.QuanLyNguoiDungs
                                 where QuanLyNguoiDung.TenDangNhap == TenDangNhap
                                 && QuanLyNguoiDung.MatKhau == MatKhau
                                 select QuanLyNguoiDung;

                return ktDangNhap.Any();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}