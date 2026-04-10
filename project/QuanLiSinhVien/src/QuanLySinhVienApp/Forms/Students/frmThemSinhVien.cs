using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeTai_QuanLySinhVien
{
    public partial class frmThemSinhVien : Office2007Form
    {
        public frmThemSinhVien()
        {
            InitializeComponent();
        }

        private string hinhanh = string.Empty;
        private readonly QuanLySinhVienDataContext db = AppDatabase.CreateContext();

        private void gpThemSinhVien_Click(object sender, EventArgs e)
        {
        }

        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            AppPaths.EnsureRuntimeFolders();
            StudentFormSupport.BindClassCombo(cbTenLop, db);

            txtMaSV.Text = string.Empty;
            txtMaSV.MaxLength = 20;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            StudentFormSupport.TryChooseImage(picboxChonAnh, ref hinhanh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            if (maSV == string.Empty ||
                txtTenSV.Text.Trim() == string.Empty ||
                txtNoiSinh.Text.Trim() == string.Empty ||
                txtNoiOHienTai.Text.Trim() == string.Empty ||
                txtLyLich.Text.Trim() == string.Empty ||
                cbTenLop.SelectedIndex == -1 ||
                txtKhoaHoc.Text.Trim() == string.Empty ||
                (!rbNam.Checked && !rbNu.Checked))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin sinh viên trước khi thêm mới.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraMaSinhVienBiTrung(maSV))
            {
                MessageBox.Show("Mã sinh viên bị trùng, mời bạn nhập lại.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            ThemSinhVien();
        }

        private void ThemSinhVien()
        {
            try
            {
                int sex = rbNam.Checked ? 0 : 1;
                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                DateTime ngaySinh = datetimeNhapNgaySinh.Value.Date;
                string noiSinh = txtNoiSinh.Text.Trim();
                string noiOHienTai = txtNoiOHienTai.Text.Trim();
                string khoaHoc = txtKhoaHoc.Text.Trim();
                string maLop = StudentFormSupport.ResolveSelectedClassId(cbTenLop);
                string lyLich = txtLyLich.Text.Trim();

                if (string.IsNullOrWhiteSpace(maLop))
                {
                    MessageBox.Show("Bạn chưa chọn lớp hợp lệ.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (KiemTraMaSinhVienBiTrung(maSV))
                {
                    MessageBox.Show("Mã sinh viên bị trùng, mời bạn nhập lại.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                    txtMaSV.SelectAll();
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "BẠN CÓ MUỐN THÊM THÔNG TIN SINH VIÊN KHÔNG?",
                    "THÔNG BÁO",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                SinhVien sv = new SinhVien
                {
                    SinhVien_ID = maSV,
                    TenSinhVien = tenSV,
                    GioiTinh = Convert.ToByte(sex),
                    NgaySinh = ngaySinh,
                    NoiSinh = noiSinh,
                    NoiOHienTai = noiOHienTai,
                    KhoaHoc = khoaHoc,
                    LyLich = lyLich,
                    ID_Lop = maLop,
                    HinhAnh = string.IsNullOrWhiteSpace(hinhanh) ? null : hinhanh
                };

                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO");
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("thêm sinh viên", ex);
            }
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentFormSupport.UpdateSelectedClassTag(cbTenLop);
        }

        private void picboxChonAnh_Click(object sender, EventArgs e)
        {
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            // Không kiểm tra trùng khi đang gõ.
        }

        private bool KiemTraMaSinhVienBiTrung(string maSV)
        {
            maSV = maSV.Trim().ToLower();
            return db.SinhViens.Any(s => s.SinhVien_ID.Trim().ToLower() == maSV);
        }

        private void btnThemKetQuaHocTap_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == string.Empty ||
                txtTenSV.Text.Trim() == string.Empty ||
                txtNoiSinh.Text.Trim() == string.Empty ||
                txtNoiOHienTai.Text.Trim() == string.Empty ||
                txtLyLich.Text.Trim() == string.Empty ||
                cbTenLop.SelectedIndex == -1 ||
                txtKhoaHoc.Text.Trim() == string.Empty ||
                (!rbNam.Checked && !rbNu.Checked))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin về sinh viên!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmThemKetQuaHocTapSinhVien f =
                    new frmThemKetQuaHocTapSinhVien(txtMaSV.Text.Trim(), txtTenSV.Text.Trim());
                f.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}