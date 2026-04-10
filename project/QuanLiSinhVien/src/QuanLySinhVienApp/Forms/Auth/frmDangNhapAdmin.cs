using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeTai_QuanLySinhVien
{
    public partial class frmDangNhapAdmin : Office2007Form
    {
        private string tenDangNhap;
        private string matKhau;
        private string quyenHan;

        public frmDangNhapAdmin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text.Trim() == string.Empty ||
                    txtMatKhau.Text.Trim() == string.Empty ||
                    comboBoxQuyenHan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                tenDangNhap = txtTenDangNhap.Text.Trim();
                matKhau = txtMatKhau.Text.Trim();
                quyenHan = comboBoxQuyenHan.Text.Trim();

                if (DangNhapAdmin(tenDangNhap, matKhau, quyenHan))
                {
                    MessageBox.Show("Xin chào quản trị viên",
                                    "Đăng nhập thành công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    frmChuongTrinh main = this.MdiParent as frmChuongTrinh;
                    if (main != null)
                    {
                        MdiChildManager.ShowSingleChild<frmDanhSachNguoiDung>(main);
                    }
                    else
                    {
                        new frmDanhSachNguoiDung().Show();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng. Vui lòng kiểm tra lại",
                                    "Lỗi đăng nhập",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("đăng nhập quản trị", ex);
            }
        }

        public bool DangNhapAdmin(string TenDangNhap, string MatKhau, string QuyenHan)
        {
            return AuthenticationService.ValidateAdmin(TenDangNhap, MatKhau, QuyenHan);
        }

        private void frmDangNhapAdmin_Load(object sender, EventArgs e)
        {
            comboBoxQuyenHan.Items.Clear();
            comboBoxQuyenHan.Items.Add("admin");
            comboBoxQuyenHan.Items.Add("user");
            comboBoxQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhapAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
