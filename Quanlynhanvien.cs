using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Quanlynhanvien : Form
    {
        // Dữ liệu tạm cho từng tab
        private List<NhanVien> dsNV = new List<NhanVien>();
        private List<HopDong> dsHD = new List<HopDong>();
        private List<ThanNhan> dsTN = new List<ThanNhan>();
        private List<DanhGia> dsDG = new List<DanhGia>();

        public Quanlynhanvien()
        {
            InitializeComponent();

            // Nhân viên
            btnThemNV.Click += BtnThemNV_Click;
            btnSuaNV.Click += BtnSuaNV_Click;
            btnXoaNV.Click += BtnXoaNV_Click;
            btnTimKiemNV.Click += BtnTimKiemNV_Click;

            // Hợp đồng
            btnThemHD.Click += BtnThemHD_Click;
            btnSuaHD.Click += BtnSuaHD_Click;
            btnXoaHD.Click += BtnXoaHD_Click;
            btnTimKiemHD.Click += BtnTimKiemHD_Click;

            // Thân nhân
            btnThemTN.Click += BtnThemTN_Click;
            btnSuaTN.Click += BtnSuaTN_Click;
            btnXoaTN.Click += BtnXoaTN_Click;
            btnTimKiemTN.Click += BtnTimKiemTN_Click;

            // Đánh giá
            btnThemDG.Click += BtnThemDG_Click;
            btnSuaDG.Click += BtnSuaDG_Click;
            btnXoaDG.Click += BtnXoaDG_Click;
            btnTimKiemDG.Click += BtnTimKiemDG_Click;
        }

        // --------- Nhân viên ---------
        private void BtnThemNV_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien();
            nv.MaNV = Prompt("Nhập mã nhân viên:");
            if (string.IsNullOrWhiteSpace(nv.MaNV)) return;
            nv.TenNV = Prompt("Nhập họ tên:");
            nv.SDT = Prompt("Nhập SĐT:");
            nv.MaCV = Prompt("Nhập mã chức vụ:");
            nv.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            nv.GioiTinh = Prompt("Nhập giới tính:");
            nv.CCCD = Prompt("Nhập CCCD:");
            nv.DiaChi = Prompt("Nhập địa chỉ:");
            dsNV.Add(nv);
            HienThiNV(nv);
        }
        private void BtnSuaNV_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            var nv = dsNV.Find(x => x.MaNV == ma);
            if (nv == null) { MessageBox.Show("Chọn nhân viên để sửa."); return; }
            nv.TenNV = Prompt("Sửa họ tên:", nv.TenNV);
            nv.SDT = Prompt("Sửa SĐT:", nv.SDT);
            nv.MaCV = Prompt("Sửa mã chức vụ:", nv.MaCV);
            nv.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            nv.GioiTinh = Prompt("Sửa giới tính:", nv.GioiTinh);
            nv.CCCD = Prompt("Sửa CCCD:", nv.CCCD);
            nv.DiaChi = Prompt("Sửa địa chỉ:", nv.DiaChi);
            HienThiNV(nv);
        }
        private void BtnXoaNV_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            var nv = dsNV.Find(x => x.MaNV == ma);
            if (nv == null) { MessageBox.Show("Chọn nhân viên để xoá."); return; }
            if (MessageBox.Show($"Xoá nhân viên {nv.TenNV}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsNV.Remove(nv); XoaNV();
            }
        }
        private void BtnTimKiemNV_Click(object sender, EventArgs e)
        {
            string ma = Prompt("Nhập mã nhân viên cần tìm:");
            var nv = dsNV.Find(x => x.MaNV == ma);
            if (nv != null) HienThiNV(nv);
            else MessageBox.Show("Không tìm thấy nhân viên.");
        }
        private void HienThiNV(NhanVien nv)
        {
            txtMaNV.Text = nv.MaNV; txtTenNV.Text = nv.TenNV; txtSDT.Text = nv.SDT; txtMaCV.Text = nv.MaCV;
            dtpNgaySinh.Value = DateTime.TryParse(nv.NgaySinh, out var d) ? d : DateTime.Now;
            txtGioiTinh.Text = nv.GioiTinh; txtCCCD.Text = nv.CCCD; txtDiaChi.Text = nv.DiaChi;
        }
        private void XoaNV()
        {
            txtMaNV.Text = ""; txtTenNV.Text = ""; txtSDT.Text = ""; txtMaCV.Text = "";
            dtpNgaySinh.Value = DateTime.Now; txtGioiTinh.Text = ""; txtCCCD.Text = ""; txtDiaChi.Text = "";
        }

        // --------- Hợp đồng lao động ---------
        private void BtnThemHD_Click(object sender, EventArgs e)
        {
            var hd = new HopDong();
            hd.MaHD = Prompt("Nhập mã hợp đồng:");
            if (string.IsNullOrWhiteSpace(hd.MaHD)) return;
            hd.LoaiHD = Prompt("Nhập loại hợp đồng:");
            hd.LuongCoBan = Prompt("Nhập lương cơ bản:");
            hd.NgayBatDau = dtpNgayBatDauHD.Value.ToString("yyyy-MM-dd");
            hd.NgayKetThuc = dtpNgayKetThucHD.Value.ToString("yyyy-MM-dd");
            dsHD.Add(hd);
            HienThiHD(hd);
        }
        private void BtnSuaHD_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text.Trim();
            var hd = dsHD.Find(x => x.MaHD == ma);
            if (hd == null) { MessageBox.Show("Chọn hợp đồng để sửa."); return; }
            hd.LoaiHD = Prompt("Sửa loại hợp đồng:", hd.LoaiHD);
            hd.LuongCoBan = Prompt("Sửa lương cơ bản:", hd.LuongCoBan);
            hd.NgayBatDau = dtpNgayBatDauHD.Value.ToString("yyyy-MM-dd");
            hd.NgayKetThuc = dtpNgayKetThucHD.Value.ToString("yyyy-MM-dd");
            HienThiHD(hd);
        }
        private void BtnXoaHD_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text.Trim();
            var hd = dsHD.Find(x => x.MaHD == ma);
            if (hd == null) { MessageBox.Show("Chọn hợp đồng để xoá."); return; }
            if (MessageBox.Show($"Xoá hợp đồng {hd.MaHD}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsHD.Remove(hd); XoaHD();
            }
        }
        private void BtnTimKiemHD_Click(object sender, EventArgs e)
        {
            string ma = Prompt("Nhập mã hợp đồng cần tìm:");
            var hd = dsHD.Find(x => x.MaHD == ma);
            if (hd != null) HienThiHD(hd);
            else MessageBox.Show("Không tìm thấy hợp đồng.");
        }
        private void HienThiHD(HopDong hd)
        {
            txtMaHD.Text = hd.MaHD; txtLoaiHD.Text = hd.LoaiHD; txtLuongCoBan.Text = hd.LuongCoBan;
            dtpNgayBatDauHD.Value = DateTime.TryParse(hd.NgayBatDau, out var d1) ? d1 : DateTime.Now;
            dtpNgayKetThucHD.Value = DateTime.TryParse(hd.NgayKetThuc, out var d2) ? d2 : DateTime.Now;
        }
        private void XoaHD()
        {
            txtMaHD.Text = ""; txtLoaiHD.Text = ""; txtLuongCoBan.Text = ""; dtpNgayBatDauHD.Value = DateTime.Now; dtpNgayKetThucHD.Value = DateTime.Now;
        }

        // --------- Thông tin thân nhân ---------
        private void BtnThemTN_Click(object sender, EventArgs e)
        {
            var tn = new ThanNhan();
            tn.MaThanNhan = Prompt("Nhập mã thân nhân:");
            if (string.IsNullOrWhiteSpace(tn.MaThanNhan)) return;
            tn.TenThanNhan = Prompt("Nhập tên thân nhân:");
            tn.QuanHe = Prompt("Nhập quan hệ:");
            tn.GioiTinh = Prompt("Nhập giới tính:");
            dsTN.Add(tn);
            HienThiTN(tn);
        }
        private void BtnSuaTN_Click(object sender, EventArgs e)
        {
            string ma = txtMaThanNhan.Text.Trim();
            var tn = dsTN.Find(x => x.MaThanNhan == ma);
            if (tn == null) { MessageBox.Show("Chọn thân nhân để sửa."); return; }
            tn.TenThanNhan = Prompt("Sửa tên thân nhân:", tn.TenThanNhan);
            tn.QuanHe = Prompt("Sửa quan hệ:", tn.QuanHe);
            tn.GioiTinh = Prompt("Sửa giới tính:", tn.GioiTinh);
            HienThiTN(tn);
        }
        private void BtnXoaTN_Click(object sender, EventArgs e)
        {
            string ma = txtMaThanNhan.Text.Trim();
            var tn = dsTN.Find(x => x.MaThanNhan == ma);
            if (tn == null) { MessageBox.Show("Chọn thân nhân để xoá."); return; }
            if (MessageBox.Show($"Xoá thân nhân {tn.TenThanNhan}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsTN.Remove(tn); XoaTN();
            }
        }
        private void BtnTimKiemTN_Click(object sender, EventArgs e)
        {
            string ma = Prompt("Nhập mã thân nhân cần tìm:");
            var tn = dsTN.Find(x => x.MaThanNhan == ma);
            if (tn != null) HienThiTN(tn);
            else MessageBox.Show("Không tìm thấy thân nhân.");
        }
        private void HienThiTN(ThanNhan tn)
        {
            txtMaThanNhan.Text = tn.MaThanNhan; txtTenThanNhan.Text = tn.TenThanNhan;
            txtQuanHeThanNhan.Text = tn.QuanHe; txtGioiTinhThanNhan.Text = tn.GioiTinh;
        }
        private void XoaTN()
        {
            txtMaThanNhan.Text = ""; txtTenThanNhan.Text = ""; txtQuanHeThanNhan.Text = ""; txtGioiTinhThanNhan.Text = "";
        }

        // --------- Đánh giá hiệu suất ---------
        private void BtnThemDG_Click(object sender, EventArgs e)
        {
            var dg = new DanhGia();
            dg.MaDanhGia = Prompt("Nhập mã đánh giá:");
            if (string.IsNullOrWhiteSpace(dg.MaDanhGia)) return;
            dg.NgayDanhGia = dtpNgayDanhGia.Value.ToString("yyyy-MM-dd");
            dg.XepLoai = Prompt("Nhập xếp loại:");
            dsDG.Add(dg);
            HienThiDG(dg);
        }
        private void BtnSuaDG_Click(object sender, EventArgs e)
        {
            string ma = txtMaDanhGia.Text.Trim();
            var dg = dsDG.Find(x => x.MaDanhGia == ma);
            if (dg == null) { MessageBox.Show("Chọn đánh giá để sửa."); return; }
            dg.NgayDanhGia = Prompt("Sửa ngày đánh giá:", dg.NgayDanhGia);
            dg.XepLoai = Prompt("Sửa xếp loại:", dg.XepLoai);
            HienThiDG(dg);
        }
        private void BtnXoaDG_Click(object sender, EventArgs e)
        {
            string ma = txtMaDanhGia.Text.Trim();
            var dg = dsDG.Find(x => x.MaDanhGia == ma);
            if (dg == null) { MessageBox.Show("Chọn đánh giá để xoá."); return; }
            if (MessageBox.Show($"Xoá đánh giá {dg.MaDanhGia}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsDG.Remove(dg); XoaDG();
            }
        }
        private void BtnTimKiemDG_Click(object sender, EventArgs e)
        {
            string ma = Prompt("Nhập mã đánh giá cần tìm:");
            var dg = dsDG.Find(x => x.MaDanhGia == ma);
            if (dg != null) HienThiDG(dg);
            else MessageBox.Show("Không tìm thấy đánh giá.");
        }
        private void HienThiDG(DanhGia dg)
        {
            txtMaDanhGia.Text = dg.MaDanhGia; dtpNgayDanhGia.Value = DateTime.TryParse(dg.NgayDanhGia, out var d) ? d : DateTime.Now; txtXepLoai.Text = dg.XepLoai;
        }
        private void XoaDG()
        {
            txtMaDanhGia.Text = ""; dtpNgayDanhGia.Value = DateTime.Now; txtXepLoai.Text = "";
        }

        // Hàm nhập liệu đơn giản
        private string Prompt(string text, string defaultValue = "")
        {
            using (var f = new InputBoxForm(text, defaultValue))
            {
                return f.ShowDialog() == DialogResult.OK ? f.InputText : "";
            }
        }

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabThongTinNV, tabHopDong, tabThanNhan, tabDanhGia;

        // Nhân viên
        private System.Windows.Forms.GroupBox grpSearchNV, grpEditNV;
        private System.Windows.Forms.Label lblSearchMaNV, lblSearchTenNV, lblMaNV, lblTenNV, lblSDT, lblMaCV, lblNgaySinh, lblGioiTinh, lblCCCD, lblDiaChi;
        private System.Windows.Forms.TextBox txtSearchMaNV, txtSearchTenNV, txtMaNV, txtTenNV, txtSDT, txtMaCV, txtGioiTinh, txtCCCD, txtDiaChi;

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click_1(object sender, EventArgs e)
        {

        }

        private void grpEditHD_Enter(object sender, EventArgs e)
        {

        }

        private void lblNgayKetThucHD_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayKetThucHD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDG_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btnThemNV, btnSuaNV, btnXoaNV, btnTimKiemNV;

        // Hợp đồng
        private System.Windows.Forms.GroupBox grpSearchHD, grpEditHD;
        private System.Windows.Forms.Label lblSearchMaHD, lblSearchLoaiHD, lblMaHD, lblLoaiHD, lblLuongCoBan, lblNgayBatDauHD, lblNgayKetThucHD;
        private System.Windows.Forms.TextBox txtSearchMaHD, txtSearchLoaiHD, txtMaHD, txtLoaiHD, txtLuongCoBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDauHD, dtpNgayKetThucHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Button btnThemHD, btnSuaHD, btnXoaHD, btnTimKiemHD;

        // Thân nhân
        private System.Windows.Forms.GroupBox grpSearchTN, grpEditTN;
        private System.Windows.Forms.Label lblSearchMaTN, lblSearchTenTN, lblMaThanNhan, lblTenThanNhan, lblQuanHeThanNhan, lblGioiTinhThanNhan;
        private System.Windows.Forms.TextBox txtSearchMaTN, txtSearchTenTN, txtMaThanNhan, txtTenThanNhan, txtQuanHeThanNhan, txtGioiTinhThanNhan;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.Button btnThemTN, btnSuaTN, btnXoaTN, btnTimKiemTN;

        // Đánh giá
        private System.Windows.Forms.GroupBox grpSearchDG, grpEditDG;
        private System.Windows.Forms.Label lblSearchMaDG, lblMaDanhGia, lblNgayDanhGia, lblXepLoai;
        private System.Windows.Forms.TextBox txtSearchMaDG, txtMaDanhGia, txtXepLoai;
        private System.Windows.Forms.DateTimePicker dtpNgayDanhGia;
        private System.Windows.Forms.DataGridView dgvDG;
        private System.Windows.Forms.Button btnThemDG, btnSuaDG, btnXoaDG, btnTimKiemDG;
    }

    // Các class dữ liệu
    public class NhanVien
    {
        public string MaNV, TenNV, SDT, MaCV, NgaySinh, GioiTinh, CCCD, DiaChi;
    }
    public class HopDong
    {
        public string MaHD, LoaiHD, LuongCoBan, NgayBatDau, NgayKetThuc;
    }
    public class ThanNhan
    {
        public string MaThanNhan, TenThanNhan, QuanHe, GioiTinh;
    }
    public class DanhGia
    {
        public string MaDanhGia, NgayDanhGia, XepLoai;
    }
}