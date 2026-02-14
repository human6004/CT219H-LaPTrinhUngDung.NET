using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeTai_QuanLySinhVien
{
    public partial class frmDangNhapAdmin : DevComponents.DotNetBar.Office2007Form
    {
        string tenDangNhap;
        string matKhau;
        string quyenHan;

        public frmDangNhapAdmin()
        {
            InitializeComponent();
        }

        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // ✅ THÊM KIỂM TRA RỖNG
            if (txtTenDangNhap.Text.Trim() == "" ||
                txtMatKhau.Text.Trim() == "" ||
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

            // ✅ SỬA CHỖ NÀY (đổi từ txtQuyenHan sang comboBoxQuyenHan)
            quyenHan = comboBoxQuyenHan.Text;

            if (DangNhapAdmin(tenDangNhap, matKhau, quyenHan))
            {
                MessageBox.Show("Xin Chào Admin",
                                "Đăng Nhập Thành Công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                frmDanhSachNguoiDung f = new frmDanhSachNguoiDung();
                f.Show();
            }
            else
            {
                MessageBox.Show("Thông Tin Đăng Nhập Không Đúng. Vui Lòng Kiểm Tra Lại",
                                "Lỗi Đăng Nhập",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // ❗ GIỮ NGUYÊN HÀM NÀY
        public bool DangNhapAdmin(string TenDangNhap, string MatKhau, string QuyenHan)
        {
            var ktDangNhap = from QuanLyNguoiDung in db.QuanLyNguoiDungs
                             where QuanLyNguoiDung.TenDangNhap == TenDangNhap
                             && QuanLyNguoiDung.MatKhau == MatKhau
                             && QuanLyNguoiDung.QuyenHan == QuyenHan
                             select QuanLyNguoiDung;

            return ktDangNhap.Any();   // tối ưu hơn foreach
        }

        private void frmDangNhapAdmin_Load(object sender, EventArgs e)
        {
            // ✅ GIỮ PHẦN NÀY
            comboBoxQuyenHan.Items.Add("admin");
            comboBoxQuyenHan.Items.Add("member");

            comboBoxQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhapAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?",
                                              "Thông báo !!",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button1);

            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
