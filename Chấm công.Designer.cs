using System.Data;
using System.Data.SqlClient;

namespace CHAMCONG
{
    partial class Form1
    {
        private string connectionString = "Server=DESKTOP-8EJT5AJ;Database=QuanLyNhanSu;Trusted_Connection=True;";
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            chấmCôngToolStripMenuItem = new ToolStripMenuItem();
            tiềnThưởngToolStripMenuItem = new ToolStripMenuItem();
            tiềnPhạtToolStripMenuItem = new ToolStripMenuItem();
            tạmỨngToolStripMenuItem = new ToolStripMenuItem();
            lươngToolStripMenuItem = new ToolStripMenuItem();
            panelchamCong = new Panel();
            groupBox2 = new GroupBox();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            GioCheckout = new Label();
            GioCheckin = new Label();
            NgayLam = new Label();
            txtSoGio = new TextBox();
            SoGio = new Label();
            txtMaNV = new TextBox();
            MaNV = new Label();
            txtMaCC = new TextBox();
            MaCC = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtchamCong1 = new TextBox();
            MaChamCong1 = new Label();
            panelTienThuong = new Panel();
            groupBox3 = new GroupBox();
            MaThuong1 = new Label();
            txtmathuong1 = new TextBox();
            MaNhanVien1 = new Label();
            txtMaNhanVien1 = new TextBox();
            dataGridView2 = new DataGridView();
            groupBox4 = new GroupBox();
            MaThuong = new Label();
            txtMaThuong2 = new TextBox();
            MaNV1 = new Label();
            txtMaNV3 = new TextBox();
            NDThuong = new Label();
            txtNDThuong = new TextBox();
            NgayNhan = new Label();
            datimeNgayNhan = new DateTimePicker();
            SoTienNhan = new Label();
            txtSoTienNhan = new TextBox();
            btnThem1 = new Button();
            btnSua1 = new Button();
            btnXoa1 = new Button();
            btnHuy1 = new Button();
            panelTienPhat = new Panel();
            groupBox5 = new GroupBox();
            MaPhat1 = new Label();
            txtMaPhat1 = new TextBox();
            MaNhanVienPhat1 = new Label();
            txtMaNhanVienPhat1 = new TextBox();
            dataGridView3 = new DataGridView();
            groupBox6 = new GroupBox();
            MaPhat = new Label();
            txtMaPhat2 = new TextBox();
            MaNVPhat = new Label();
            txtMaNVPhat = new TextBox();
            NDPhat = new Label();
            txtNDPhat = new TextBox();
            NgayPhat = new Label();
            dateNgayPhat = new DateTimePicker();
            SoTienPhat = new Label();
            txtSoTienPhat = new TextBox();
            btnThemPhat = new Button();
            btnSuaPhat = new Button();
            btnXoaPhat = new Button();
            btnHuyPhat = new Button();
            panelTamUng = new Panel();
            groupBox7 = new GroupBox();
            MaUngLuong1 = new Label();
            txtMaUngLuong1 = new TextBox();
            MaNhanVienUng1 = new Label();
            txtMaNhanVienUng1 = new TextBox();
            dataGridView4 = new DataGridView();
            groupBox8 = new GroupBox();
            MaUngLuong = new Label();
            txtMaUngLuong2 = new TextBox();
            MaNVUng = new Label();
            txtMaNVUng = new TextBox();
            LyDoUng = new Label();
            txtLyDoUng = new TextBox();
            NgayUng = new Label();
            dateNgayUng = new DateTimePicker();
            SoTienUng = new Label();
            txtSoTienUng = new TextBox();
            btnThemUng = new Button();
            btnSuaUng = new Button();
            btnXoaUng = new Button();
            btnHuyUng = new Button();
            panelLuong = new Panel();
            groupBox9 = new GroupBox();
            MaLuong1 = new Label();
            txtMaLuong1 = new TextBox();
            MaNhanVienLuong1 = new Label();
            txtMaNhanVienLuong1 = new TextBox();
            dataGridView5 = new DataGridView();
            groupBox10 = new GroupBox();
            MaLuong = new Label();
            txtMaLuong2 = new TextBox();
            MaNVLuong = new Label();
            txtMaNVLuong = new TextBox();
            ThangNam = new Label();
            dateThangNam = new DateTimePicker();
            TongLuong = new Label();
            txtTongLuong = new TextBox();
            ThucLinh = new Label();
            txtThucLinh = new TextBox();
            btnThemLuong = new Button();
            btnSuaLuong = new Button();
            btnXoaLuong = new Button();
            btnHuyLuong = new Button();
            menuStrip1.SuspendLayout();
            panelchamCong.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panelTienThuong.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            panelTienPhat.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox6.SuspendLayout();
            panelTamUng.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            groupBox8.SuspendLayout();
            panelLuong.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chấmCôngToolStripMenuItem, tiềnThưởngToolStripMenuItem, tiềnPhạtToolStripMenuItem, tạmỨngToolStripMenuItem, lươngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1636, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chấmCôngToolStripMenuItem
            // 
            chấmCôngToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            chấmCôngToolStripMenuItem.Size = new Size(156, 36);
            chấmCôngToolStripMenuItem.Text = "Chấm công";
            chấmCôngToolStripMenuItem.Click += chấmCôngToolStripMenuItem_Click;
            // 
            // tiềnThưởngToolStripMenuItem
            // 
            tiềnThưởngToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            tiềnThưởngToolStripMenuItem.Name = "tiềnThưởngToolStripMenuItem";
            tiềnThưởngToolStripMenuItem.Size = new Size(165, 36);
            tiềnThưởngToolStripMenuItem.Text = "Tiền thưởng";
            tiềnThưởngToolStripMenuItem.Click += tiềnThưởngToolStripMenuItem_Click;
            // 
            // tiềnPhạtToolStripMenuItem
            // 
            tiềnPhạtToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            tiềnPhạtToolStripMenuItem.Name = "tiềnPhạtToolStripMenuItem";
            tiềnPhạtToolStripMenuItem.Size = new Size(135, 36);
            tiềnPhạtToolStripMenuItem.Text = "Tiền phạt";
            tiềnPhạtToolStripMenuItem.Click += tiềnPhạtToolStripMenuItem_Click;
            // 
            // tạmỨngToolStripMenuItem
            // 
            tạmỨngToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            tạmỨngToolStripMenuItem.Name = "tạmỨngToolStripMenuItem";
            tạmỨngToolStripMenuItem.Size = new Size(129, 36);
            tạmỨngToolStripMenuItem.Text = "Tạm ứng";
            tạmỨngToolStripMenuItem.Click += tạmỨngToolStripMenuItem_Click;
            // 
            // lươngToolStripMenuItem
            // 
            lươngToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            lươngToolStripMenuItem.Size = new Size(101, 36);
            lươngToolStripMenuItem.Text = "Lương";
            lươngToolStripMenuItem.Click += lươngToolStripMenuItem_Click;
            // 
            // panelchamCong
            // 
            panelchamCong.Controls.Add(groupBox2);
            panelchamCong.Controls.Add(dataGridView1);
            panelchamCong.Controls.Add(groupBox1);
            panelchamCong.Dock = DockStyle.Fill;
            panelchamCong.Location = new Point(0, 40);
            panelchamCong.Name = "panelchamCong";
            panelchamCong.Size = new Size(1636, 835);
            panelchamCong.TabIndex = 0;
            panelchamCong.TabStop = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(GioCheckout);
            groupBox2.Controls.Add(GioCheckin);
            groupBox2.Controls.Add(NgayLam);
            groupBox2.Controls.Add(txtSoGio);
            groupBox2.Controls.Add(SoGio);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(MaNV);
            groupBox2.Controls.Add(txtMaCC);
            groupBox2.Controls.Add(MaCC);
            groupBox2.Location = new Point(12, 492);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1612, 262);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thêm/ Sửa thông tin";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1395, 191);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1395, 139);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1395, 87);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1395, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(901, 177);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(400, 39);
            dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(901, 117);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(400, 39);
            dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(901, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 14;
            // 
            // GioCheckout
            // 
            GioCheckout.AutoSize = true;
            GioCheckout.Location = new Point(682, 182);
            GioCheckout.Name = "GioCheckout";
            GioCheckout.Size = new Size(166, 32);
            GioCheckout.TabIndex = 12;
            GioCheckout.Text = "Giờ checkout: ";
            // 
            // GioCheckin
            // 
            GioCheckin.AutoSize = true;
            GioCheckin.Location = new Point(682, 122);
            GioCheckin.Name = "GioCheckin";
            GioCheckin.Size = new Size(150, 32);
            GioCheckin.TabIndex = 10;
            GioCheckin.Text = "Giờ checkin: ";
            // 
            // NgayLam
            // 
            NgayLam.AutoSize = true;
            NgayLam.Location = new Point(682, 62);
            NgayLam.Name = "NgayLam";
            NgayLam.Size = new Size(128, 32);
            NgayLam.TabIndex = 8;
            NgayLam.Text = "Ngày làm: ";
            // 
            // txtSoGio
            // 
            txtSoGio.Location = new Point(265, 179);
            txtSoGio.Name = "txtSoGio";
            txtSoGio.Size = new Size(264, 39);
            txtSoGio.TabIndex = 7;
            // 
            // SoGio
            // 
            SoGio.AutoSize = true;
            SoGio.Location = new Point(46, 182);
            SoGio.Name = "SoGio";
            SoGio.Size = new Size(94, 32);
            SoGio.TabIndex = 6;
            SoGio.Text = "Số giờ: ";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(265, 119);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(264, 39);
            txtMaNV.TabIndex = 5;
            // 
            // MaNV
            // 
            MaNV.AutoSize = true;
            MaNV.Location = new Point(46, 122);
            MaNV.Name = "MaNV";
            MaNV.Size = new Size(173, 32);
            MaNV.TabIndex = 4;
            MaNV.Text = "Mã nhân viên: ";
            // 
            // txtMaCC
            // 
            txtMaCC.Location = new Point(265, 59);
            txtMaCC.Name = "txtMaCC";
            txtMaCC.Size = new Size(264, 39);
            txtMaCC.TabIndex = 3;
            // 
            // MaCC
            // 
            MaCC.AutoSize = true;
            MaCC.Location = new Point(46, 62);
            MaCC.Name = "MaCC";
            MaCC.Size = new Size(185, 32);
            MaCC.TabIndex = 2;
            MaCC.Text = "Mã chấm công: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1612, 334);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtchamCong1);
            groupBox1.Controls.Add(MaChamCong1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1612, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txtchamCong1
            // 
            txtchamCong1.Location = new Point(265, 46);
            txtchamCong1.Name = "txtchamCong1";
            txtchamCong1.Size = new Size(264, 39);
            txtchamCong1.TabIndex = 1;
            // 
            // MaChamCong1
            // 
            MaChamCong1.AutoSize = true;
            MaChamCong1.Location = new Point(46, 49);
            MaChamCong1.Name = "MaChamCong1";
            MaChamCong1.Size = new Size(185, 32);
            MaChamCong1.TabIndex = 0;
            MaChamCong1.Text = "Mã chấm công: ";
            // 
            // panelTienThuong
            // 
            panelTienThuong.Controls.Add(groupBox3);
            panelTienThuong.Controls.Add(dataGridView2);
            panelTienThuong.Controls.Add(groupBox4);
            panelTienThuong.Dock = DockStyle.Fill;
            panelTienThuong.Location = new Point(0, 40);
            panelTienThuong.Name = "panelTienThuong";
            panelTienThuong.Size = new Size(1636, 835);
            panelTienThuong.TabIndex = 1;
            panelTienThuong.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(MaThuong1);
            groupBox3.Controls.Add(txtmathuong1);
            groupBox3.Controls.Add(MaNhanVien1);
            groupBox3.Controls.Add(txtMaNhanVien1);
            groupBox3.Location = new Point(12, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1606, 112);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // MaThuong1
            // 
            MaThuong1.AutoSize = true;
            MaThuong1.Location = new Point(46, 53);
            MaThuong1.Name = "MaThuong1";
            MaThuong1.Size = new Size(145, 32);
            MaThuong1.TabIndex = 0;
            MaThuong1.Text = "Mã thưởng: ";
            // 
            // txtmathuong1
            // 
            txtmathuong1.Location = new Point(237, 46);
            txtmathuong1.Name = "txtmathuong1";
            txtmathuong1.Size = new Size(236, 39);
            txtmathuong1.TabIndex = 1;
            // 
            // MaNhanVien1
            // 
            MaNhanVien1.AutoSize = true;
            MaNhanVien1.Location = new Point(590, 44);
            MaNhanVien1.Name = "MaNhanVien1";
            MaNhanVien1.Size = new Size(173, 32);
            MaNhanVien1.TabIndex = 2;
            MaNhanVien1.Text = "Mã nhân viên: ";
            // 
            // txtMaNhanVien1
            // 
            txtMaNhanVien1.Location = new Point(781, 37);
            txtMaNhanVien1.Name = "txtMaNhanVien1";
            txtMaNhanVien1.Size = new Size(236, 39);
            txtMaNhanVien1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 131);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(1606, 390);
            dataGridView2.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(MaThuong);
            groupBox4.Controls.Add(txtMaThuong2);
            groupBox4.Controls.Add(MaNV1);
            groupBox4.Controls.Add(txtMaNV3);
            groupBox4.Controls.Add(NDThuong);
            groupBox4.Controls.Add(txtNDThuong);
            groupBox4.Controls.Add(NgayNhan);
            groupBox4.Controls.Add(datimeNgayNhan);
            groupBox4.Controls.Add(SoTienNhan);
            groupBox4.Controls.Add(txtSoTienNhan);
            groupBox4.Controls.Add(btnThem1);
            groupBox4.Controls.Add(btnSua1);
            groupBox4.Controls.Add(btnXoa1);
            groupBox4.Controls.Add(btnHuy1);
            groupBox4.Location = new Point(12, 530);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1597, 240);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thêm/ Sửa thông tin";
            // 
            // MaThuong
            // 
            MaThuong.AutoSize = true;
            MaThuong.Location = new Point(46, 54);
            MaThuong.Name = "MaThuong";
            MaThuong.Size = new Size(145, 32);
            MaThuong.TabIndex = 2;
            MaThuong.Text = "Mã thưởng: ";
            // 
            // txtMaThuong2
            // 
            txtMaThuong2.Location = new Point(249, 47);
            txtMaThuong2.Name = "txtMaThuong2";
            txtMaThuong2.Size = new Size(236, 39);
            txtMaThuong2.TabIndex = 3;
            // 
            // MaNV1
            // 
            MaNV1.AutoSize = true;
            MaNV1.Location = new Point(46, 109);
            MaNV1.Name = "MaNV1";
            MaNV1.Size = new Size(173, 32);
            MaNV1.TabIndex = 10;
            MaNV1.Text = "Mã nhân viên: ";
            // 
            // txtMaNV3
            // 
            txtMaNV3.Location = new Point(250, 102);
            txtMaNV3.Name = "txtMaNV3";
            txtMaNV3.Size = new Size(236, 39);
            txtMaNV3.TabIndex = 11;
            // 
            // NDThuong
            // 
            NDThuong.AutoSize = true;
            NDThuong.Location = new Point(46, 162);
            NDThuong.Name = "NDThuong";
            NDThuong.Size = new Size(212, 32);
            NDThuong.TabIndex = 12;
            NDThuong.Text = "Nội dung thưởng: ";
            // 
            // txtNDThuong
            // 
            txtNDThuong.Location = new Point(251, 155);
            txtNDThuong.Name = "txtNDThuong";
            txtNDThuong.Size = new Size(236, 39);
            txtNDThuong.TabIndex = 13;
            // 
            // NgayNhan
            // 
            NgayNhan.AutoSize = true;
            NgayNhan.Location = new Point(599, 47);
            NgayNhan.Name = "NgayNhan";
            NgayNhan.Size = new Size(143, 32);
            NgayNhan.TabIndex = 14;
            NgayNhan.Text = "Ngày nhận: ";
            // 
            // datimeNgayNhan
            // 
            datimeNgayNhan.Location = new Point(803, 45);
            datimeNgayNhan.Name = "datimeNgayNhan";
            datimeNgayNhan.Size = new Size(400, 39);
            datimeNgayNhan.TabIndex = 19;
            // 
            // SoTienNhan
            // 
            SoTienNhan.AutoSize = true;
            SoTienNhan.Location = new Point(599, 102);
            SoTienNhan.Name = "SoTienNhan";
            SoTienNhan.Size = new Size(162, 32);
            SoTienNhan.TabIndex = 16;
            SoTienNhan.Text = "Số tiền nhận: ";
            // 
            // txtSoTienNhan
            // 
            txtSoTienNhan.Location = new Point(803, 95);
            txtSoTienNhan.Name = "txtSoTienNhan";
            txtSoTienNhan.Size = new Size(236, 39);
            txtSoTienNhan.TabIndex = 17;
            // 
            // btnThem1
            // 
            btnThem1.Location = new Point(1388, 25);
            btnThem1.Name = "btnThem1";
            btnThem1.Size = new Size(150, 46);
            btnThem1.TabIndex = 18;
            btnThem1.Text = "Thêm";
            btnThem1.UseVisualStyleBackColor = true;
            // 
            // btnSua1
            // 
            btnSua1.Location = new Point(1388, 77);
            btnSua1.Name = "btnSua1";
            btnSua1.Size = new Size(150, 46);
            btnSua1.TabIndex = 20;
            btnSua1.Text = "Sửa";
            btnSua1.UseVisualStyleBackColor = true;
            // 
            // btnXoa1
            // 
            btnXoa1.Location = new Point(1388, 129);
            btnXoa1.Name = "btnXoa1";
            btnXoa1.Size = new Size(150, 46);
            btnXoa1.TabIndex = 21;
            btnXoa1.Text = "Xoá";
            btnXoa1.UseVisualStyleBackColor = true;
            // 
            // btnHuy1
            // 
            btnHuy1.Location = new Point(1388, 182);
            btnHuy1.Name = "btnHuy1";
            btnHuy1.Size = new Size(150, 46);
            btnHuy1.TabIndex = 22;
            btnHuy1.Text = "Huỷ";
            btnHuy1.UseVisualStyleBackColor = true;
            // 
            // panelTienPhat
            // 
            panelTienPhat.Controls.Add(groupBox5);
            panelTienPhat.Controls.Add(dataGridView3);
            panelTienPhat.Controls.Add(groupBox6);
            panelTienPhat.Dock = DockStyle.Fill;
            panelTienPhat.Location = new Point(0, 40);
            panelTienPhat.Name = "panelTienPhat";
            panelTienPhat.Size = new Size(1636, 835);
            panelTienPhat.TabIndex = 2;
            panelTienPhat.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(MaPhat1);
            groupBox5.Controls.Add(txtMaPhat1);
            groupBox5.Controls.Add(MaNhanVienPhat1);
            groupBox5.Controls.Add(txtMaNhanVienPhat1);
            groupBox5.Location = new Point(12, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1606, 112);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm";
            // 
            // MaPhat1
            // 
            MaPhat1.AutoSize = true;
            MaPhat1.Location = new Point(46, 53);
            MaPhat1.Name = "MaPhat1";
            MaPhat1.Size = new Size(108, 32);
            MaPhat1.TabIndex = 0;
            MaPhat1.Text = "Mã phạt:";
            // 
            // txtMaPhat1
            // 
            txtMaPhat1.Location = new Point(237, 46);
            txtMaPhat1.Name = "txtMaPhat1";
            txtMaPhat1.Size = new Size(236, 39);
            txtMaPhat1.TabIndex = 1;
            // 
            // MaNhanVienPhat1
            // 
            MaNhanVienPhat1.AutoSize = true;
            MaNhanVienPhat1.Location = new Point(590, 44);
            MaNhanVienPhat1.Name = "MaNhanVienPhat1";
            MaNhanVienPhat1.Size = new Size(166, 32);
            MaNhanVienPhat1.TabIndex = 2;
            MaNhanVienPhat1.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVienPhat1
            // 
            txtMaNhanVienPhat1.Location = new Point(781, 37);
            txtMaNhanVienPhat1.Name = "txtMaNhanVienPhat1";
            txtMaNhanVienPhat1.Size = new Size(236, 39);
            txtMaNhanVienPhat1.TabIndex = 3;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 131);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 82;
            dataGridView3.Size = new Size(1606, 390);
            dataGridView3.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(MaPhat);
            groupBox6.Controls.Add(txtMaPhat2);
            groupBox6.Controls.Add(MaNVPhat);
            groupBox6.Controls.Add(txtMaNVPhat);
            groupBox6.Controls.Add(NDPhat);
            groupBox6.Controls.Add(txtNDPhat);
            groupBox6.Controls.Add(NgayPhat);
            groupBox6.Controls.Add(dateNgayPhat);
            groupBox6.Controls.Add(SoTienPhat);
            groupBox6.Controls.Add(txtSoTienPhat);
            groupBox6.Controls.Add(btnThemPhat);
            groupBox6.Controls.Add(btnSuaPhat);
            groupBox6.Controls.Add(btnXoaPhat);
            groupBox6.Controls.Add(btnHuyPhat);
            groupBox6.Location = new Point(12, 530);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1597, 240);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Thêm/ Sửa thông tin";
            // 
            // MaPhat
            // 
            MaPhat.AutoSize = true;
            MaPhat.Location = new Point(46, 54);
            MaPhat.Name = "MaPhat";
            MaPhat.Size = new Size(108, 32);
            MaPhat.TabIndex = 2;
            MaPhat.Text = "Mã phạt:";
            // 
            // txtMaPhat2
            // 
            txtMaPhat2.Location = new Point(249, 47);
            txtMaPhat2.Name = "txtMaPhat2";
            txtMaPhat2.Size = new Size(236, 39);
            txtMaPhat2.TabIndex = 3;
            // 
            // MaNVPhat
            // 
            MaNVPhat.AutoSize = true;
            MaNVPhat.Location = new Point(46, 109);
            MaNVPhat.Name = "MaNVPhat";
            MaNVPhat.Size = new Size(166, 32);
            MaNVPhat.TabIndex = 10;
            MaNVPhat.Text = "Mã nhân viên:";
            // 
            // txtMaNVPhat
            // 
            txtMaNVPhat.Location = new Point(250, 102);
            txtMaNVPhat.Name = "txtMaNVPhat";
            txtMaNVPhat.Size = new Size(236, 39);
            txtMaNVPhat.TabIndex = 11;
            // 
            // NDPhat
            // 
            NDPhat.AutoSize = true;
            NDPhat.Location = new Point(46, 162);
            NDPhat.Name = "NDPhat";
            NDPhat.Size = new Size(175, 32);
            NDPhat.TabIndex = 12;
            NDPhat.Text = "Nội dung phạt:";
            // 
            // txtNDPhat
            // 
            txtNDPhat.Location = new Point(251, 155);
            txtNDPhat.Name = "txtNDPhat";
            txtNDPhat.Size = new Size(236, 39);
            txtNDPhat.TabIndex = 13;
            // 
            // NgayPhat
            // 
            NgayPhat.AutoSize = true;
            NgayPhat.Location = new Point(599, 47);
            NgayPhat.Name = "NgayPhat";
            NgayPhat.Size = new Size(130, 32);
            NgayPhat.TabIndex = 14;
            NgayPhat.Text = "Ngày phạt:";
            // 
            // dateNgayPhat
            // 
            dateNgayPhat.Location = new Point(803, 45);
            dateNgayPhat.Name = "dateNgayPhat";
            dateNgayPhat.Size = new Size(400, 39);
            dateNgayPhat.TabIndex = 19;
            // 
            // SoTienPhat
            // 
            SoTienPhat.AutoSize = true;
            SoTienPhat.Location = new Point(599, 102);
            SoTienPhat.Name = "SoTienPhat";
            SoTienPhat.Size = new Size(149, 32);
            SoTienPhat.TabIndex = 16;
            SoTienPhat.Text = "Số tiền phạt:";
            // 
            // txtSoTienPhat
            // 
            txtSoTienPhat.Location = new Point(803, 95);
            txtSoTienPhat.Name = "txtSoTienPhat";
            txtSoTienPhat.Size = new Size(236, 39);
            txtSoTienPhat.TabIndex = 17;
            // 
            // btnThemPhat
            // 
            btnThemPhat.Location = new Point(1388, 25);
            btnThemPhat.Name = "btnThemPhat";
            btnThemPhat.Size = new Size(150, 46);
            btnThemPhat.TabIndex = 18;
            btnThemPhat.Text = "Thêm";
            btnThemPhat.UseVisualStyleBackColor = true;
            // 
            // btnSuaPhat
            // 
            btnSuaPhat.Location = new Point(1388, 77);
            btnSuaPhat.Name = "btnSuaPhat";
            btnSuaPhat.Size = new Size(150, 46);
            btnSuaPhat.TabIndex = 20;
            btnSuaPhat.Text = "Sửa";
            btnSuaPhat.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhat
            // 
            btnXoaPhat.Location = new Point(1388, 129);
            btnXoaPhat.Name = "btnXoaPhat";
            btnXoaPhat.Size = new Size(150, 46);
            btnXoaPhat.TabIndex = 21;
            btnXoaPhat.Text = "Xoá";
            btnXoaPhat.UseVisualStyleBackColor = true;
            // 
            // btnHuyPhat
            // 
            btnHuyPhat.Location = new Point(1388, 182);
            btnHuyPhat.Name = "btnHuyPhat";
            btnHuyPhat.Size = new Size(150, 46);
            btnHuyPhat.TabIndex = 22;
            btnHuyPhat.Text = "Huỷ";
            btnHuyPhat.UseVisualStyleBackColor = true;
            // 
            // panelTamUng
            // 
            panelTamUng.Controls.Add(groupBox7);
            panelTamUng.Controls.Add(dataGridView4);
            panelTamUng.Controls.Add(groupBox8);
            panelTamUng.Dock = DockStyle.Fill;
            panelTamUng.Location = new Point(0, 40);
            panelTamUng.Name = "panelTamUng";
            panelTamUng.Size = new Size(1636, 835);
            panelTamUng.TabIndex = 3;
            panelTamUng.Visible = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(MaUngLuong1);
            groupBox7.Controls.Add(txtMaUngLuong1);
            groupBox7.Controls.Add(MaNhanVienUng1);
            groupBox7.Controls.Add(txtMaNhanVienUng1);
            groupBox7.Location = new Point(12, 13);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1606, 112);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Tìm kiếm";
            // 
            // MaUngLuong1
            // 
            MaUngLuong1.AutoSize = true;
            MaUngLuong1.Location = new Point(46, 53);
            MaUngLuong1.Name = "MaUngLuong1";
            MaUngLuong1.Size = new Size(171, 32);
            MaUngLuong1.TabIndex = 0;
            MaUngLuong1.Text = "Mã ứng lương:";
            // 
            // txtMaUngLuong1
            // 
            txtMaUngLuong1.Location = new Point(237, 46);
            txtMaUngLuong1.Name = "txtMaUngLuong1";
            txtMaUngLuong1.Size = new Size(236, 39);
            txtMaUngLuong1.TabIndex = 1;
            // 
            // MaNhanVienUng1
            // 
            MaNhanVienUng1.AutoSize = true;
            MaNhanVienUng1.Location = new Point(590, 44);
            MaNhanVienUng1.Name = "MaNhanVienUng1";
            MaNhanVienUng1.Size = new Size(166, 32);
            MaNhanVienUng1.TabIndex = 2;
            MaNhanVienUng1.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVienUng1
            // 
            txtMaNhanVienUng1.Location = new Point(781, 37);
            txtMaNhanVienUng1.Name = "txtMaNhanVienUng1";
            txtMaNhanVienUng1.Size = new Size(236, 39);
            txtMaNhanVienUng1.TabIndex = 3;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(12, 131);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 82;
            dataGridView4.Size = new Size(1606, 390);
            dataGridView4.TabIndex = 2;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(MaUngLuong);
            groupBox8.Controls.Add(txtMaUngLuong2);
            groupBox8.Controls.Add(MaNVUng);
            groupBox8.Controls.Add(txtMaNVUng);
            groupBox8.Controls.Add(LyDoUng);
            groupBox8.Controls.Add(txtLyDoUng);
            groupBox8.Controls.Add(NgayUng);
            groupBox8.Controls.Add(dateNgayUng);
            groupBox8.Controls.Add(SoTienUng);
            groupBox8.Controls.Add(txtSoTienUng);
            groupBox8.Controls.Add(btnThemUng);
            groupBox8.Controls.Add(btnSuaUng);
            groupBox8.Controls.Add(btnXoaUng);
            groupBox8.Controls.Add(btnHuyUng);
            groupBox8.Location = new Point(12, 530);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1597, 240);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Thêm/ Sửa thông tin";
            // 
            // MaUngLuong
            // 
            MaUngLuong.AutoSize = true;
            MaUngLuong.Location = new Point(46, 54);
            MaUngLuong.Name = "MaUngLuong";
            MaUngLuong.Size = new Size(171, 32);
            MaUngLuong.TabIndex = 2;
            MaUngLuong.Text = "Mã ứng lương:";
            // 
            // txtMaUngLuong2
            // 
            txtMaUngLuong2.Location = new Point(249, 47);
            txtMaUngLuong2.Name = "txtMaUngLuong2";
            txtMaUngLuong2.Size = new Size(236, 39);
            txtMaUngLuong2.TabIndex = 3;
            // 
            // MaNVUng
            // 
            MaNVUng.AutoSize = true;
            MaNVUng.Location = new Point(46, 109);
            MaNVUng.Name = "MaNVUng";
            MaNVUng.Size = new Size(166, 32);
            MaNVUng.TabIndex = 10;
            MaNVUng.Text = "Mã nhân viên:";
            // 
            // txtMaNVUng
            // 
            txtMaNVUng.Location = new Point(250, 102);
            txtMaNVUng.Name = "txtMaNVUng";
            txtMaNVUng.Size = new Size(236, 39);
            txtMaNVUng.TabIndex = 11;
            // 
            // LyDoUng
            // 
            LyDoUng.AutoSize = true;
            LyDoUng.Location = new Point(46, 162);
            LyDoUng.Name = "LyDoUng";
            LyDoUng.Size = new Size(76, 32);
            LyDoUng.TabIndex = 12;
            LyDoUng.Text = "Lý do:";
            // 
            // txtLyDoUng
            // 
            txtLyDoUng.Location = new Point(251, 155);
            txtLyDoUng.Name = "txtLyDoUng";
            txtLyDoUng.Size = new Size(236, 39);
            txtLyDoUng.TabIndex = 13;
            // 
            // NgayUng
            // 
            NgayUng.AutoSize = true;
            NgayUng.Location = new Point(599, 47);
            NgayUng.Name = "NgayUng";
            NgayUng.Size = new Size(124, 32);
            NgayUng.TabIndex = 14;
            NgayUng.Text = "Ngày ứng:";
            // 
            // dateNgayUng
            // 
            dateNgayUng.Location = new Point(803, 45);
            dateNgayUng.Name = "dateNgayUng";
            dateNgayUng.Size = new Size(400, 39);
            dateNgayUng.TabIndex = 19;
            // 
            // SoTienUng
            // 
            SoTienUng.AutoSize = true;
            SoTienUng.Location = new Point(599, 102);
            SoTienUng.Name = "SoTienUng";
            SoTienUng.Size = new Size(143, 32);
            SoTienUng.TabIndex = 16;
            SoTienUng.Text = "Số tiền ứng:";
            // 
            // txtSoTienUng
            // 
            txtSoTienUng.Location = new Point(803, 95);
            txtSoTienUng.Name = "txtSoTienUng";
            txtSoTienUng.Size = new Size(236, 39);
            txtSoTienUng.TabIndex = 17;
            // 
            // btnThemUng
            // 
            btnThemUng.Location = new Point(1388, 25);
            btnThemUng.Name = "btnThemUng";
            btnThemUng.Size = new Size(150, 46);
            btnThemUng.TabIndex = 18;
            btnThemUng.Text = "Thêm";
            btnThemUng.UseVisualStyleBackColor = true;
            // 
            // btnSuaUng
            // 
            btnSuaUng.Location = new Point(1388, 77);
            btnSuaUng.Name = "btnSuaUng";
            btnSuaUng.Size = new Size(150, 46);
            btnSuaUng.TabIndex = 20;
            btnSuaUng.Text = "Sửa";
            btnSuaUng.UseVisualStyleBackColor = true;
            // 
            // btnXoaUng
            // 
            btnXoaUng.Location = new Point(1388, 129);
            btnXoaUng.Name = "btnXoaUng";
            btnXoaUng.Size = new Size(150, 46);
            btnXoaUng.TabIndex = 21;
            btnXoaUng.Text = "Xoá";
            btnXoaUng.UseVisualStyleBackColor = true;
            // 
            // btnHuyUng
            // 
            btnHuyUng.Location = new Point(1388, 182);
            btnHuyUng.Name = "btnHuyUng";
            btnHuyUng.Size = new Size(150, 46);
            btnHuyUng.TabIndex = 22;
            btnHuyUng.Text = "Huỷ";
            btnHuyUng.UseVisualStyleBackColor = true;
            // 
            // panelLuong
            // 
            panelLuong.Controls.Add(groupBox9);
            panelLuong.Controls.Add(dataGridView5);
            panelLuong.Controls.Add(groupBox10);
            panelLuong.Dock = DockStyle.Fill;
            panelLuong.Location = new Point(0, 40);
            panelLuong.Name = "panelLuong";
            panelLuong.Size = new Size(1636, 835);
            panelLuong.TabIndex = 4;
            panelLuong.Visible = false;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(MaLuong1);
            groupBox9.Controls.Add(txtMaLuong1);
            groupBox9.Controls.Add(MaNhanVienLuong1);
            groupBox9.Controls.Add(txtMaNhanVienLuong1);
            groupBox9.Location = new Point(12, 13);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(1606, 112);
            groupBox9.TabIndex = 0;
            groupBox9.TabStop = false;
            groupBox9.Text = "Tìm kiếm";
            // 
            // MaLuong1
            // 
            MaLuong1.AutoSize = true;
            MaLuong1.Location = new Point(46, 53);
            MaLuong1.Name = "MaLuong1";
            MaLuong1.Size = new Size(122, 32);
            MaLuong1.TabIndex = 0;
            MaLuong1.Text = "Mã lương:";
            // 
            // txtMaLuong1
            // 
            txtMaLuong1.Location = new Point(237, 46);
            txtMaLuong1.Name = "txtMaLuong1";
            txtMaLuong1.Size = new Size(236, 39);
            txtMaLuong1.TabIndex = 1;
            // 
            // MaNhanVienLuong1
            // 
            MaNhanVienLuong1.AutoSize = true;
            MaNhanVienLuong1.Location = new Point(590, 44);
            MaNhanVienLuong1.Name = "MaNhanVienLuong1";
            MaNhanVienLuong1.Size = new Size(166, 32);
            MaNhanVienLuong1.TabIndex = 2;
            MaNhanVienLuong1.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVienLuong1
            // 
            txtMaNhanVienLuong1.Location = new Point(781, 37);
            txtMaNhanVienLuong1.Name = "txtMaNhanVienLuong1";
            txtMaNhanVienLuong1.Size = new Size(236, 39);
            txtMaNhanVienLuong1.TabIndex = 3;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeight = 46;
            dataGridView5.Location = new Point(12, 131);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 82;
            dataGridView5.Size = new Size(1606, 390);
            dataGridView5.TabIndex = 2;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(MaLuong);
            groupBox10.Controls.Add(txtMaLuong2);
            groupBox10.Controls.Add(MaNVLuong);
            groupBox10.Controls.Add(txtMaNVLuong);
            groupBox10.Controls.Add(ThangNam);
            groupBox10.Controls.Add(dateThangNam);
            groupBox10.Controls.Add(TongLuong);
            groupBox10.Controls.Add(txtTongLuong);
            groupBox10.Controls.Add(ThucLinh);
            groupBox10.Controls.Add(txtThucLinh);
            groupBox10.Controls.Add(btnThemLuong);
            groupBox10.Controls.Add(btnSuaLuong);
            groupBox10.Controls.Add(btnXoaLuong);
            groupBox10.Controls.Add(btnHuyLuong);
            groupBox10.Location = new Point(12, 530);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(1597, 240);
            groupBox10.TabIndex = 3;
            groupBox10.TabStop = false;
            groupBox10.Text = "Thêm/ Sửa thông tin";
            // 
            // MaLuong
            // 
            MaLuong.AutoSize = true;
            MaLuong.Location = new Point(46, 54);
            MaLuong.Name = "MaLuong";
            MaLuong.Size = new Size(122, 32);
            MaLuong.TabIndex = 0;
            MaLuong.Text = "Mã lương:";
            // 
            // txtMaLuong2
            // 
            txtMaLuong2.Location = new Point(249, 47);
            txtMaLuong2.Name = "txtMaLuong2";
            txtMaLuong2.Size = new Size(236, 39);
            txtMaLuong2.TabIndex = 1;
            // 
            // MaNVLuong
            // 
            MaNVLuong.AutoSize = true;
            MaNVLuong.Location = new Point(46, 109);
            MaNVLuong.Name = "MaNVLuong";
            MaNVLuong.Size = new Size(166, 32);
            MaNVLuong.TabIndex = 2;
            MaNVLuong.Text = "Mã nhân viên:";
            // 
            // txtMaNVLuong
            // 
            txtMaNVLuong.Location = new Point(250, 102);
            txtMaNVLuong.Name = "txtMaNVLuong";
            txtMaNVLuong.Size = new Size(236, 39);
            txtMaNVLuong.TabIndex = 3;
            // 
            // ThangNam
            // 
            ThangNam.AutoSize = true;
            ThangNam.Location = new Point(599, 47);
            ThangNam.Name = "ThangNam";
            ThangNam.Size = new Size(140, 32);
            ThangNam.TabIndex = 4;
            ThangNam.Text = "Tháng năm:";
            // 
            // dateThangNam
            // 
            dateThangNam.CustomFormat = "MM/yyyy";
            dateThangNam.Format = DateTimePickerFormat.Custom;
            dateThangNam.Location = new Point(803, 45);
            dateThangNam.Name = "dateThangNam";
            dateThangNam.ShowUpDown = true;
            dateThangNam.Size = new Size(200, 39);
            dateThangNam.TabIndex = 5;
            // 
            // TongLuong
            // 
            TongLuong.AutoSize = true;
            TongLuong.Location = new Point(599, 102);
            TongLuong.Name = "TongLuong";
            TongLuong.Size = new Size(143, 32);
            TongLuong.TabIndex = 6;
            TongLuong.Text = "Tổng lương:";
            // 
            // txtTongLuong
            // 
            txtTongLuong.Location = new Point(803, 95);
            txtTongLuong.Name = "txtTongLuong";
            txtTongLuong.Size = new Size(236, 39);
            txtTongLuong.TabIndex = 7;
            // 
            // ThucLinh
            // 
            ThucLinh.AutoSize = true;
            ThucLinh.Location = new Point(599, 157);
            ThucLinh.Name = "ThucLinh";
            ThucLinh.Size = new Size(118, 32);
            ThucLinh.TabIndex = 8;
            ThucLinh.Text = "Thực lĩnh:";
            // 
            // txtThucLinh
            // 
            txtThucLinh.Location = new Point(803, 150);
            txtThucLinh.Name = "txtThucLinh";
            txtThucLinh.Size = new Size(236, 39);
            txtThucLinh.TabIndex = 9;
            // 
            // btnThemLuong
            // 
            btnThemLuong.Location = new Point(1388, 25);
            btnThemLuong.Name = "btnThemLuong";
            btnThemLuong.Size = new Size(150, 46);
            btnThemLuong.TabIndex = 10;
            btnThemLuong.Text = "Thêm";
            // 
            // btnSuaLuong
            // 
            btnSuaLuong.Location = new Point(1388, 77);
            btnSuaLuong.Name = "btnSuaLuong";
            btnSuaLuong.Size = new Size(150, 46);
            btnSuaLuong.TabIndex = 11;
            btnSuaLuong.Text = "Sửa";
            // 
            // btnXoaLuong
            // 
            btnXoaLuong.Location = new Point(1388, 129);
            btnXoaLuong.Name = "btnXoaLuong";
            btnXoaLuong.Size = new Size(150, 46);
            btnXoaLuong.TabIndex = 12;
            btnXoaLuong.Text = "Xoá";
            // 
            // btnHuyLuong
            // 
            btnHuyLuong.Location = new Point(1388, 182);
            btnHuyLuong.Name = "btnHuyLuong";
            btnHuyLuong.Size = new Size(150, 46);
            btnHuyLuong.TabIndex = 13;
            btnHuyLuong.Text = "Huỷ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1636, 875);
            Controls.Add(panelTienThuong);
            Controls.Add(panelTienPhat);
            Controls.Add(panelTamUng);
            Controls.Add(panelLuong);
            Controls.Add(panelchamCong);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chấm công";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelchamCong.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelTienThuong.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panelTienPhat.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panelTamUng.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            panelLuong.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelchamCong.Visible = true;
            panelTienThuong.Visible = false;
            panelTienPhat.Visible = false;
            panelTamUng.Visible = false;
            panelLuong.Visible = false;
        }

        private void tiềnThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelchamCong.Visible = false;
            panelTienThuong.Visible = true;
            panelTienPhat.Visible = false;
            panelTamUng.Visible = false;
            panelLuong.Visible = false;
        }

        private void tiềnPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelchamCong.Visible = false;
            panelTienThuong.Visible = false;
            panelTienPhat.Visible = true;
            panelTamUng.Visible = false;
            panelLuong.Visible = false;
        }

        private void tạmỨngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelchamCong.Visible = false;
            panelTienThuong.Visible = false;
            panelTienPhat.Visible = false;
            panelTamUng.Visible = true;
            panelLuong.Visible = false;
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelchamCong.Visible = false;
            panelTienThuong.Visible = false;
            panelTienPhat.Visible = false;
            panelTamUng.Visible = false;
            panelLuong.Visible = true;
        }
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chấmCôngToolStripMenuItem;
        private ToolStripMenuItem tiềnThưởngToolStripMenuItem;
        private ToolStripMenuItem tiềnPhạtToolStripMenuItem;
        private ToolStripMenuItem tạmỨngToolStripMenuItem;
        private ToolStripMenuItem lươngToolStripMenuItem;
        private Panel panelchamCong;
        private GroupBox groupBox2;
        private Label GioCheckout;
        private Label GioCheckin;
        private Label NgayLam;
        private TextBox txtSoGio;
        private Label SoGio;
        private TextBox txtMaNV;
        private Label MaNV;
        private TextBox txtMaCC;
        private Label MaCC;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtchamCong1;
        private Label MaChamCong1;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panelTienThuong;
        private GroupBox groupBox3;
        private Label MaThuong1;
        private TextBox txtmathuong1;
        private Label MaNhanVien1;
        private TextBox txtMaNhanVien1;
        private DataGridView dataGridView2;
        private GroupBox groupBox4;
        private Label MaThuong;
        private TextBox txtMaThuong2;
        private Label MaNV1;
        private TextBox txtMaNV3;
        private Label NDThuong;
        private TextBox txtNDThuong;
        private Label NgayNhan;
        private DateTimePicker datimeNgayNhan;
        private Label SoTienNhan;
        private TextBox txtSoTienNhan;
        private Button btnThem1;
        private Button btnSua1;
        private Button btnXoa1;
        private Button btnHuy1;
        private Panel panelTienPhat;
        private GroupBox groupBox5;
        private Label MaPhat1;
        private TextBox txtMaPhat1;
        private Label MaNhanVienPhat1;
        private TextBox txtMaNhanVienPhat1;
        private DataGridView dataGridView3;
        private GroupBox groupBox6;
        private Label MaPhat;
        private TextBox txtMaPhat2;
        private Label MaNVPhat;
        private TextBox txtMaNVPhat;
        private Label NDPhat;
        private TextBox txtNDPhat;
        private Label NgayPhat;
        private DateTimePicker dateNgayPhat;
        private Label SoTienPhat;
        private TextBox txtSoTienPhat;
        private Button btnThemPhat;
        private Button btnSuaPhat;
        private Button btnXoaPhat;
        private Button btnHuyPhat;
        private Panel panelTamUng;
        private GroupBox groupBox7;
        private Label MaUngLuong1;
        private TextBox txtMaUngLuong1;
        private Label MaNhanVienUng1;
        private TextBox txtMaNhanVienUng1;
        private DataGridView dataGridView4;
        private GroupBox groupBox8;
        private Label MaUngLuong;
        private TextBox txtMaUngLuong2;
        private Label MaNVUng;
        private TextBox txtMaNVUng;
        private Label LyDoUng;
        private TextBox txtLyDoUng;
        private Label NgayUng;
        private DateTimePicker dateNgayUng;
        private Label SoTienUng;
        private TextBox txtSoTienUng;
        private Button btnThemUng;
        private Button btnSuaUng;
        private Button btnXoaUng;
        private Button btnHuyUng;
        private Panel panelLuong;
        private GroupBox groupBox9;
        private Label MaLuong1;
        private TextBox txtMaLuong1;
        private Label MaNhanVienLuong1;
        private TextBox txtMaNhanVienLuong1;
        private DataGridView dataGridView5;
        private GroupBox groupBox10;
        private Label MaLuong;
        private TextBox txtMaLuong2;
        private Label MaNVLuong;
        private TextBox txtMaNVLuong;
        private Label ThangNam;
        private DateTimePicker dateThangNam;
        private Label TongLuong;
        private TextBox txtTongLuong;
        private Label ThucLinh;
        private TextBox txtThucLinh;
        private Button btnThemLuong;
        private Button btnSuaLuong;
        private Button btnXoaLuong;
        private Button btnHuyLuong;
    }
}
