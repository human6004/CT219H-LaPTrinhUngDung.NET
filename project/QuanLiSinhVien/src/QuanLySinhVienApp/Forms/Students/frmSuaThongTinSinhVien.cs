using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeTai_QuanLySinhVien
{
    public partial class frmSuaThongTinSinhVien : Office2007Form
    {
        readonly string masv;
        public frmSuaThongTinSinhVien(string Lop_ID, string MaSV)
        {
            InitializeComponent();
            masv = MaSV;
            txtMaSV.Text = masv;
        }

        private readonly QuanLySinhVienDataContext db = AppDatabase.CreateContext();
        string hinhanh;

        private void frmSuaThongTinSinhVien_Load(object sender, EventArgs e)
        {
            AppPaths.EnsureRuntimeFolders();
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            StudentFormSupport.BindClassCombo(cbTenLop, db);

            var student = db.SinhViens.SingleOrDefault(SinhVien => SinhVien.SinhVien_ID == masv);
            if (student == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            hinhanh = student.HinhAnh;
            txtTenSV.Text = student.TenSinhVien;
            if (student.GioiTinh == 0)
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }

            datetimeNhapNgaySinh.Value = student.NgaySinh;
            txtNoiSinh.Text = student.NoiSinh;
            txtNoiOHienTai.Text = student.NoiOHienTai;
            txtKhoaHoc.Text = student.KhoaHoc;
            cbTenLop.SelectedValue = student.ID_Lop;
            cbTenLop.Tag = student.ID_Lop;
            txtLyLich.Text = student.LyLich;
            StudentFormSupport.LoadImage(picboxChonAnh, hinhanh);
        }

        private void SuaThongTinSinhVien()
        {
            try
            {
                int sex = rbNam.Checked ? 0 : 1;
                string tenSV = txtTenSV.Text.Trim();
                DateTime ngaySinh = datetimeNhapNgaySinh.Value.Date;
                string noiSinh = txtNoiSinh.Text.Trim();
                string noiOHienTai = txtNoiOHienTai.Text.Trim();
                string khoaHoc = txtKhoaHoc.Text.Trim();
                string maLop = StudentFormSupport.ResolveSelectedClassId(cbTenLop);
                string lyLich = txtLyLich.Text.Trim();

                SinhVien sv = db.SinhViens.Single(c => c.SinhVien_ID == masv);
                sv.TenSinhVien = tenSV;
                sv.GioiTinh = Convert.ToByte(sex);
                sv.NgaySinh = ngaySinh;
                sv.NoiSinh = noiSinh;
                sv.NoiOHienTai = noiOHienTai;
                sv.KhoaHoc = khoaHoc;
                sv.LyLich = lyLich;
                sv.ID_Lop = maLop;
                sv.HinhAnh = hinhanh;

                DialogResult dl = MessageBox.Show("BẠN CÓ MUỐN LƯU THAY ĐỔI KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    MessageBox.Show("SỬA THÀNH CÔNG", "THÔNG BÁO");
                }
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("sửa sinh viên", ex);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            StudentFormSupport.TryChooseImage(picboxChonAnh, ref hinhanh);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTinSinhVien();
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentFormSupport.UpdateSelectedClassTag(cbTenLop);
        }

        private void btnSuaKetQuaHocTap_Click(object sender, EventArgs e)
        {
            using (frmSuaKetQuaHocTapSinhVien f = new frmSuaKetQuaHocTapSinhVien(masv, txtTenSV.Text))
            {
                f.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaThongTinSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
