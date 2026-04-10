using System;
using System.Windows.Forms;

namespace DeTai_QuanLySinhVien
{
    public partial class frmChuongTrinh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmChuongTrinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableMenu();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
        }

        private void ShowSingleChild<T>() where T : Form, new()
        {
            MdiChildManager.ShowSingleChild<T>(this);
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmDanhSachSV>();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmDanhSachKhoa>();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmDanhSachLop>();
        }

        private void bntMonHoc_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmDanhSachMonHoc>();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmTimKiemSinhVien>();
        }

        private void rbitemBaoCao_Click(object sender, EventArgs e)
        {
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmBaoCao>();
        }

        public void EnableMenu()
        {
            ribbarThongTin.Enabled = true;
            ribbarBaoCao.Enabled = true;
            ribbarTimKiem.Enabled = true;
            ribbarTroGiup.Enabled = true;
        }

        public void DisableMenu()
        {
            ribbarThongTin.Enabled = false;
            ribbarBaoCao.Enabled = false;
            ribbarTimKiem.Enabled = false;
            ribbarTroGiup.Enabled = false;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MdiChildManager.CloseChildrenExcept(this, typeof(frmDangNhap), typeof(frmDangNhapAdmin));
            DisableMenu();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmDangNhap>();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmDangNhapAdmin>();
        }

        private void frmChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            ShowSingleChild<frmTroGiup>();
        }
    }
}
