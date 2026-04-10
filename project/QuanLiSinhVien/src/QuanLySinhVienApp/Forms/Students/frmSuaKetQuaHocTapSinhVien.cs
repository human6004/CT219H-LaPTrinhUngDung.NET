using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeTai_QuanLySinhVien
{
    public partial class frmSuaKetQuaHocTapSinhVien : Office2007Form
    {
        private readonly string masv;
        private readonly string tensv;
        private readonly QuanLySinhVienDataContext db = AppDatabase.CreateContext();

        private bool dangNapDuLieu;
        private int lanThiGoc = -1;

        public frmSuaKetQuaHocTapSinhVien(string maSV, string tenSV)
        {
            InitializeComponent();

            masv = (maSV ?? string.Empty).Trim();
            tensv = (tenSV ?? string.Empty).Trim();

            txtMaSV.Text = masv;
            txtTenSV.Text = tensv;
        }

        private void frmSuaKetQuaHocTapSinhVien_Load(object sender, EventArgs e)
        {
            NapDanhSachMonHocDaCoKetQua();
        }

        private void NapDanhSachMonHocDaCoKetQua()
        {
            try
            {
                dangNapDuLieu = true;

                List<MonHoc> monHocDaCoKetQua = KetQuaService.LayDanhSachMonHocDaCoKetQua(db, masv);

                cbMonHoc.DataSource = null;
                cbMonHoc.DisplayMember = "TenMonHoc";
                cbMonHoc.ValueMember = "MonHoc_ID";
                cbMonHoc.DataSource = monHocDaCoKetQua;

                bool coKetQua = monHocDaCoKetQua.Count > 0;
                cbMonHoc.Enabled = coKetQua;
                txtLanThi.Enabled = coKetQua;
                txtDiemThi.Enabled = coKetQua;
                txtDiemTKet.Enabled = coKetQua;
                btnSua.Enabled = coKetQua;

                if (!coKetQua)
                {
                    XoaThongTinKetQua();
                    MessageBox.Show(
                        "Sinh viên này chưa có kết quả học tập nào để sửa.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                cbMonHoc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("nạp kết quả học tập", ex);
            }
            finally
            {
                dangNapDuLieu = false;
            }

            HienThiLenTextBox();
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangNapDuLieu || cbMonHoc.SelectedIndex == -1 || cbMonHoc.SelectedValue == null)
            {
                return;
            }

            HienThiLenTextBox();
        }

        private void HienThiLenTextBox()
        {
            try
            {
                string maMonHoc = LayMaMonHocDangChon();
                if (string.IsNullOrEmpty(maMonHoc))
                {
                    XoaThongTinKetQua();
                    return;
                }

                KetQua ketQua = KetQuaService.LayKetQuaMoiNhat(db, masv, maMonHoc);

                if (ketQua == null)
                {
                    XoaThongTinKetQua();
                    MessageBox.Show(
                        "Không tìm thấy kết quả học tập của sinh viên cho môn học đang chọn.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                lanThiGoc = ketQua.LanThi;
                txtLanThi.Text = ketQua.LanThi.ToString();
                txtDiemThi.Text = ketQua.DiemThi.ToString("0.##");
                txtDiemTKet.Text = ketQua.DiemTongKet.ToString("0.##");
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("hiển thị kết quả học tập", ex);
            }
        }

        private string LayMaMonHocDangChon()
        {
            object selectedValue = cbMonHoc.SelectedValue;
            if (selectedValue == null || selectedValue is System.Data.DataRowView)
            {
                return string.Empty;
            }

            return selectedValue.ToString().Trim();
        }

        private void XoaThongTinKetQua()
        {
            lanThiGoc = -1;
            txtLanThi.Clear();
            txtDiemThi.Clear();
            txtDiemTKet.Clear();
        }

        private void SuaKetQuaHocTap()
        {
            if (cbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Bạn chưa chọn môn để sửa điểm.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (lanThiGoc < 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu kết quả học tập hợp lệ để sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string maMonHoc = LayMaMonHocDangChon();
            if (string.IsNullOrEmpty(maMonHoc))
            {
                MessageBox.Show(
                    "Không xác định được môn học đang chọn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int lanThiMoi;
            double diemThiMoi;
            double diemTongKetMoi;

            if (!int.TryParse(txtLanThi.Text.Trim(), out lanThiMoi) || lanThiMoi <= 0)
            {
                MessageBox.Show(
                    "Lần thi phải là số nguyên dương.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtLanThi.Focus();
                return;
            }

            if (!double.TryParse(txtDiemThi.Text.Trim(), out diemThiMoi))
            {
                MessageBox.Show(
                    "Điểm thi không hợp lệ.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDiemThi.Focus();
                return;
            }

            if (!double.TryParse(txtDiemTKet.Text.Trim(), out diemTongKetMoi))
            {
                MessageBox.Show(
                    "Điểm tổng kết không hợp lệ.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDiemTKet.Focus();
                return;
            }

            if (diemThiMoi < 0 || diemThiMoi > 10 || diemTongKetMoi < 0 || diemTongKetMoi > 10)
            {
                MessageBox.Show(
                    "Điểm phải nằm trong khoảng từ 0 đến 10.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KetQua ketQua = KetQuaService.LayKetQuaTheoLanThi(db, masv, maMonHoc, lanThiGoc);

                if (ketQua == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy kết quả học tập cần sửa.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (lanThiMoi != lanThiGoc)
                {
                    bool trungLanThi = KetQuaService.KiemTraTonTai(db, masv, maMonHoc, lanThiMoi);

                    if (trungLanThi)
                    {
                        MessageBox.Show(
                            "Lần thi này đã tồn tại cho môn học đang chọn.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    ketQua.LanThi = lanThiMoi;
                }

                ketQua.DiemThi = diemThiMoi;
                ketQua.DiemTongKet = diemTongKetMoi;

                DialogResult xacNhan = MessageBox.Show(
                    "Bạn có chắc muốn sửa kết quả học tập không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (xacNhan != DialogResult.Yes)
                {
                    return;
                }

                db.SubmitChanges();
                lanThiGoc = ketQua.LanThi;

                MessageBox.Show(
                    "Sửa kết quả học tập thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                AppDatabase.ShowDatabaseError("sửa kết quả học tập", ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaKetQuaHocTap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gpSuaKetQuaHocTap_Click(object sender, EventArgs e)
        {
        }

        private void frmSuaKetQuaHocTapSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
