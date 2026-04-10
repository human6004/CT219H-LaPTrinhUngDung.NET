using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeTai_QuanLySinhVien
{
    public partial class frmThemKetQuaHocTapSinhVien : Office2007Form
    {
        private readonly QuanLySinhVienDataContext db = AppDatabase.CreateContext();

        public frmThemKetQuaHocTapSinhVien(string maSV, string tenSV)
        {
            InitializeComponent();
            txtMaSV.Text = (maSV ?? string.Empty).Trim();
            txtTenSV.Text = (tenSV ?? string.Empty).Trim();
        }

        private void frmThemKetQuaHocTapSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                cbMonHoc.DataSource = db.MonHocs.OrderBy(item => item.TenMonHoc).ToList();
                cbMonHoc.DisplayMember = "TenMonHoc";
                cbMonHoc.ValueMember = "MonHoc_ID";
                cbMonHoc.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("nạp môn học", ex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKetQuaHocTap();
        }

        private void ThemKetQuaHocTap()
        {
            if (cbMonHoc.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtLanThi.Text) ||
                string.IsNullOrWhiteSpace(txtDiemThi.Text) ||
                string.IsNullOrWhiteSpace(txtDiemTKet.Text))
            {
                MessageBox.Show(
                    "Bạn cần điền đầy đủ thông tin kết quả học tập.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string maMonHoc = cbMonHoc.SelectedValue == null ? string.Empty : cbMonHoc.SelectedValue.ToString().Trim();
            string maSinhVien = txtMaSV.Text.Trim();

            int lanThi;
            double diemThi;
            double diemTongKet;

            if (!int.TryParse(txtLanThi.Text.Trim(), out lanThi) || lanThi <= 0)
            {
                MessageBox.Show("Lần thi phải là số nguyên dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLanThi.Focus();
                return;
            }

            if (!double.TryParse(txtDiemThi.Text.Trim(), out diemThi) || diemThi < 0 || diemThi > 10)
            {
                MessageBox.Show("Điểm thi phải nằm trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemThi.Focus();
                return;
            }

            if (!double.TryParse(txtDiemTKet.Text.Trim(), out diemTongKet) || diemTongKet < 0 || diemTongKet > 10)
            {
                MessageBox.Show("Điểm tổng kết phải nằm trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemTKet.Focus();
                return;
            }

            try
            {
                bool daTonTai = KetQuaService.KiemTraTonTai(db, maSinhVien, maMonHoc, lanThi);

                if (daTonTai)
                {
                    MessageBox.Show(
                        "Kết quả học tập của môn này ở lần thi này đã tồn tại.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                KetQua ketQua = new KetQua
                {
                    ID_MonHoc = maMonHoc,
                    ID_SinhVien = maSinhVien,
                    LanThi = lanThi,
                    DiemThi = diemThi,
                    DiemTongKet = diemTongKet
                };

                db.KetQuas.InsertOnSubmit(ketQua);
                db.SubmitChanges();

                MessageBox.Show(
                    "Thêm kết quả học tập thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("thêm kết quả học tập", ex);
            }
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gpThemKetQuaHocTap_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
