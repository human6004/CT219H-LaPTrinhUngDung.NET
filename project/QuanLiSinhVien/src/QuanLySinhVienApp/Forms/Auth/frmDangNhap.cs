using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeTai_QuanLySinhVien
{
    public partial class frmDangNhap : Office2007Form
    {
        private string tenDangNhap;
        private string maDangNhap;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                tenDangNhap = txtTenDangNhap.Text.Trim();
                maDangNhap = txtMauKhau.Text.Trim();

                if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(maDangNhap))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DangNhapHeThong(tenDangNhap, maDangNhap))
                {
                    frmChuongTrinh main = this.MdiParent as frmChuongTrinh;
                    if (main != null)
                    {
                        main.EnableMenu();
                    }

                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Close();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng. Vui lòng kiểm tra lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("đăng nhập", ex);
            }
        }

        public bool DangNhapHeThong(string tenDangNhap, string matKhau)
        {
            return AuthenticationService.ValidateUser(tenDangNhap, matKhau);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }
    }
}
