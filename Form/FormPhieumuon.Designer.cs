namespace thutap
{
    partial class FormPhieumuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieumuon));
            this.plheader = new System.Windows.Forms.Panel();
            this.lblPhieumuon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMa = new System.Windows.Forms.Label();
            this.cboPhieumuon = new System.Windows.Forms.ComboBox();
            this.btnTimkiemphieumuon = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOnl = new System.Windows.Forms.RadioButton();
            this.rdoOff = new System.Windows.Forms.RadioButton();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.mskNgayThue = new System.Windows.Forms.MaskedTextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.lblHinhthuc = new System.Windows.Forms.Label();
            this.lblTendocgia = new System.Windows.Forms.Label();
            this.lblMadocgia = new System.Windows.Forms.Label();
            this.lblTennhanvien = new System.Windows.Forms.Label();
            this.lblManhanvien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaphieumuon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridThue = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cboMaTinhTrang = new System.Windows.Forms.ComboBox();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblMatinhtrang = new System.Windows.Forms.Label();
            this.lblTentinhtrang = new System.Windows.Forms.Label();
            this.lblTensach = new System.Windows.Forms.Label();
            this.lblMasach = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoatphieu = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbldonvi = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.plheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridThue)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(1128, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(144, 111);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // plheader
            // 
            this.plheader.BackColor = System.Drawing.Color.Turquoise;
            this.plheader.Controls.Add(this.lblPhieumuon);
            this.plheader.Controls.Add(pictureBox1);
            this.plheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plheader.Location = new System.Drawing.Point(0, 0);
            this.plheader.Name = "plheader";
            this.plheader.Size = new System.Drawing.Size(1321, 114);
            this.plheader.TabIndex = 4;
            // 
            // lblPhieumuon
            // 
            this.lblPhieumuon.AutoSize = true;
            this.lblPhieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieumuon.ForeColor = System.Drawing.Color.Snow;
            this.lblPhieumuon.Location = new System.Drawing.Point(286, 19);
            this.lblPhieumuon.Name = "lblPhieumuon";
            this.lblPhieumuon.Size = new System.Drawing.Size(609, 69);
            this.lblPhieumuon.TabIndex = 0;
            this.lblPhieumuon.Text = "PHIẾU MƯỢN SÁCH\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 759);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 51);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm quản lý sách-Thư viện D FREE BOOK";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.lblMa);
            this.panel3.Controls.Add(this.cboPhieumuon);
            this.panel3.Controls.Add(this.btnTimkiemphieumuon);
            this.panel3.Location = new System.Drawing.Point(12, 689);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 64);
            this.panel3.TabIndex = 7;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(3, 35);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(119, 16);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã phiếu mượn :";
            // 
            // cboPhieumuon
            // 
            this.cboPhieumuon.FormattingEnabled = true;
            this.cboPhieumuon.Location = new System.Drawing.Point(128, 32);
            this.cboPhieumuon.Name = "cboPhieumuon";
            this.cboPhieumuon.Size = new System.Drawing.Size(249, 24);
            this.cboPhieumuon.TabIndex = 1;
            this.cboPhieumuon.DropDown += new System.EventHandler(this.cboPhieumuon_DropDown);
            // 
            // btnTimkiemphieumuon
            // 
            this.btnTimkiemphieumuon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTimkiemphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemphieumuon.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTimkiemphieumuon.Location = new System.Drawing.Point(383, 26);
            this.btnTimkiemphieumuon.Name = "btnTimkiemphieumuon";
            this.btnTimkiemphieumuon.Size = new System.Drawing.Size(99, 32);
            this.btnTimkiemphieumuon.TabIndex = 0;
            this.btnTimkiemphieumuon.Text = "Tìm kiếm";
            this.btnTimkiemphieumuon.UseVisualStyleBackColor = false;
            this.btnTimkiemphieumuon.Click += new System.EventHandler(this.btnTimkiemphieumuon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOnl);
            this.groupBox1.Controls.Add(this.rdoOff);
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.mskNgayThue);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaThue);
            this.groupBox1.Controls.Add(this.lblHinhthuc);
            this.groupBox1.Controls.Add(this.lblTendocgia);
            this.groupBox1.Controls.Add(this.lblMadocgia);
            this.groupBox1.Controls.Add(this.lblTennhanvien);
            this.groupBox1.Controls.Add(this.lblManhanvien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMaphieumuon);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1297, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // rdoOnl
            // 
            this.rdoOnl.AutoSize = true;
            this.rdoOnl.Location = new System.Drawing.Point(817, 110);
            this.rdoOnl.Name = "rdoOnl";
            this.rdoOnl.Size = new System.Drawing.Size(66, 20);
            this.rdoOnl.TabIndex = 18;
            this.rdoOnl.TabStop = true;
            this.rdoOnl.Text = "Online";
            this.rdoOnl.UseVisualStyleBackColor = true;
            // 
            // rdoOff
            // 
            this.rdoOff.AutoSize = true;
            this.rdoOff.Location = new System.Drawing.Point(704, 110);
            this.rdoOff.Name = "rdoOff";
            this.rdoOff.Size = new System.Drawing.Size(65, 20);
            this.rdoOff.TabIndex = 17;
            this.rdoOff.TabStop = true;
            this.rdoOff.Text = "Offline";
            this.rdoOff.UseVisualStyleBackColor = true;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(704, 12);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(278, 24);
            this.cboMaKH.TabIndex = 16;
            this.cboMaKH.TextChanged += new System.EventHandler(this.cboMaKH_TextChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(186, 86);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(278, 24);
            this.cboMaNV.TabIndex = 14;
            this.cboMaNV.TextChanged += new System.EventHandler(this.cboMaNV_TextChanged);
            // 
            // mskNgayThue
            // 
            this.mskNgayThue.Location = new System.Drawing.Point(186, 55);
            this.mskNgayThue.Mask = "00/00/0000";
            this.mskNgayThue.Name = "mskNgayThue";
            this.mskNgayThue.Size = new System.Drawing.Size(218, 22);
            this.mskNgayThue.TabIndex = 13;
            this.mskNgayThue.ValidatingType = typeof(System.DateTime);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(186, 116);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(278, 22);
            this.txtTenNV.TabIndex = 12;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(704, 58);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(278, 22);
            this.txtTenKH.TabIndex = 9;
            // 
            // txtMaThue
            // 
            this.txtMaThue.Location = new System.Drawing.Point(186, 12);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(278, 22);
            this.txtMaThue.TabIndex = 8;
            // 
            // lblHinhthuc
            // 
            this.lblHinhthuc.AutoSize = true;
            this.lblHinhthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhthuc.Location = new System.Drawing.Point(524, 114);
            this.lblHinhthuc.Name = "lblHinhthuc";
            this.lblHinhthuc.Size = new System.Drawing.Size(111, 16);
            this.lblHinhthuc.TabIndex = 7;
            this.lblHinhthuc.Text = "Hình thức mượn";
            // 
            // lblTendocgia
            // 
            this.lblTendocgia.AutoSize = true;
            this.lblTendocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendocgia.Location = new System.Drawing.Point(524, 61);
            this.lblTendocgia.Name = "lblTendocgia";
            this.lblTendocgia.Size = new System.Drawing.Size(108, 16);
            this.lblTendocgia.TabIndex = 5;
            this.lblTendocgia.Text = "Tên thành viên";
            // 
            // lblMadocgia
            // 
            this.lblMadocgia.AutoSize = true;
            this.lblMadocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadocgia.Location = new System.Drawing.Point(524, 18);
            this.lblMadocgia.Name = "lblMadocgia";
            this.lblMadocgia.Size = new System.Drawing.Size(102, 16);
            this.lblMadocgia.TabIndex = 4;
            this.lblMadocgia.Text = "Mã thành viên";
            // 
            // lblTennhanvien
            // 
            this.lblTennhanvien.AutoSize = true;
            this.lblTennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennhanvien.Location = new System.Drawing.Point(15, 119);
            this.lblTennhanvien.Name = "lblTennhanvien";
            this.lblTennhanvien.Size = new System.Drawing.Size(152, 16);
            this.lblTennhanvien.TabIndex = 3;
            this.lblTennhanvien.Text = "Tên nhân viên thủ thư";
            // 
            // lblManhanvien
            // 
            this.lblManhanvien.AutoSize = true;
            this.lblManhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhanvien.Location = new System.Drawing.Point(20, 88);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(146, 16);
            this.lblManhanvien.TabIndex = 2;
            this.lblManhanvien.Text = "Mã nhân viên thủ thư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày mượn";
            // 
            // lblMaphieumuon
            // 
            this.lblMaphieumuon.AutoSize = true;
            this.lblMaphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphieumuon.Location = new System.Drawing.Point(20, 18);
            this.lblMaphieumuon.Name = "lblMaphieumuon";
            this.lblMaphieumuon.Size = new System.Drawing.Size(111, 16);
            this.lblMaphieumuon.TabIndex = 0;
            this.lblMaphieumuon.Text = "Mã phiếu mượn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridThue);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtTenTinhTrang);
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.cboMaTinhTrang);
            this.groupBox2.Controls.Add(this.cboMaSach);
            this.groupBox2.Controls.Add(this.lblSoluong);
            this.groupBox2.Controls.Add(this.lblMatinhtrang);
            this.groupBox2.Controls.Add(this.lblTentinhtrang);
            this.groupBox2.Controls.Add(this.lblTensach);
            this.groupBox2.Controls.Add(this.lblMasach);
            this.groupBox2.Location = new System.Drawing.Point(211, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1098, 401);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách mượn";
            // 
            // datagridThue
            // 
            this.datagridThue.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datagridThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridThue.Location = new System.Drawing.Point(28, 238);
            this.datagridThue.Name = "datagridThue";
            this.datagridThue.RowHeadersWidth = 51;
            this.datagridThue.RowTemplate.Height = 24;
            this.datagridThue.Size = new System.Drawing.Size(1039, 157);
            this.datagridThue.TabIndex = 23;
            this.datagridThue.DoubleClick += new System.EventHandler(this.datagridThue_DoubleClick);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(184, 210);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(415, 22);
            this.txtSoLuong.TabIndex = 11;
            // 
            // txtTenTinhTrang
            // 
            this.txtTenTinhTrang.Location = new System.Drawing.Point(184, 164);
            this.txtTenTinhTrang.Name = "txtTenTinhTrang";
            this.txtTenTinhTrang.Size = new System.Drawing.Size(415, 22);
            this.txtTenTinhTrang.TabIndex = 10;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(184, 75);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(415, 22);
            this.txtTenSach.TabIndex = 9;
            // 
            // cboMaTinhTrang
            // 
            this.cboMaTinhTrang.FormattingEnabled = true;
            this.cboMaTinhTrang.Location = new System.Drawing.Point(184, 117);
            this.cboMaTinhTrang.Name = "cboMaTinhTrang";
            this.cboMaTinhTrang.Size = new System.Drawing.Size(415, 24);
            this.cboMaTinhTrang.TabIndex = 8;
            this.cboMaTinhTrang.TextChanged += new System.EventHandler(this.cboMaTinhTrang_TextChanged);
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(184, 29);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(415, 24);
            this.cboMaSach.TabIndex = 7;
            this.cboMaSach.TextChanged += new System.EventHandler(this.cboMaSach_TextChanged);
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(25, 213);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(68, 16);
            this.lblSoluong.TabIndex = 4;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblMatinhtrang
            // 
            this.lblMatinhtrang.AutoSize = true;
            this.lblMatinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatinhtrang.Location = new System.Drawing.Point(22, 125);
            this.lblMatinhtrang.Name = "lblMatinhtrang";
            this.lblMatinhtrang.Size = new System.Drawing.Size(95, 16);
            this.lblMatinhtrang.TabIndex = 3;
            this.lblMatinhtrang.Text = "Mã tình trạng";
            // 
            // lblTentinhtrang
            // 
            this.lblTentinhtrang.AutoSize = true;
            this.lblTentinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentinhtrang.Location = new System.Drawing.Point(22, 167);
            this.lblTentinhtrang.Name = "lblTentinhtrang";
            this.lblTentinhtrang.Size = new System.Drawing.Size(101, 16);
            this.lblTentinhtrang.TabIndex = 2;
            this.lblTentinhtrang.Text = "Tên tình trạng";
            // 
            // lblTensach
            // 
            this.lblTensach.AutoSize = true;
            this.lblTensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensach.Location = new System.Drawing.Point(22, 82);
            this.lblTensach.Name = "lblTensach";
            this.lblTensach.Size = new System.Drawing.Size(71, 16);
            this.lblTensach.TabIndex = 1;
            this.lblTensach.Text = "Tên sách";
            // 
            // lblMasach
            // 
            this.lblMasach.AutoSize = true;
            this.lblMasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasach.Location = new System.Drawing.Point(22, 38);
            this.lblMasach.Name = "lblMasach";
            this.lblMasach.Size = new System.Drawing.Size(65, 16);
            this.lblMasach.TabIndex = 0;
            this.lblMasach.Text = "Mã sách";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnThoatphieu);
            this.panel4.Controls.Add(this.btnInHoaDon);
            this.panel4.Controls.Add(this.btnXoaHoaDon);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Location = new System.Drawing.Point(12, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 345);
            this.panel4.TabIndex = 25;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Teal;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(37, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThemphieumuon_Click);
            // 
            // btnThoatphieu
            // 
            this.btnThoatphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoatphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnThoatphieu.Location = new System.Drawing.Point(37, 289);
            this.btnThoatphieu.Name = "btnThoatphieu";
            this.btnThoatphieu.Size = new System.Drawing.Size(77, 32);
            this.btnThoatphieu.TabIndex = 6;
            this.btnThoatphieu.Text = "Thoát";
            this.btnThoatphieu.UseVisualStyleBackColor = false;
            this.btnThoatphieu.Click += new System.EventHandler(this.btnThoatphieu_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Teal;
            this.btnInHoaDon.Location = new System.Drawing.Point(37, 221);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(130, 32);
            this.btnInHoaDon.TabIndex = 7;
            this.btnInHoaDon.Text = "In Phiếu";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHoaDon.ForeColor = System.Drawing.Color.Teal;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(38, 76);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(84, 32);
            this.btnXoaHoaDon.TabIndex = 3;
            this.btnXoaHoaDon.Text = "Xoá";
            this.btnXoaHoaDon.UseVisualStyleBackColor = false;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Teal;
            this.btnLuu.Location = new System.Drawing.Point(38, 146);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 32);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbldonvi
            // 
            this.lbldonvi.AutoSize = true;
            this.lbldonvi.Location = new System.Drawing.Point(839, 715);
            this.lbldonvi.Name = "lbldonvi";
            this.lbldonvi.Size = new System.Drawing.Size(44, 16);
            this.lbldonvi.TabIndex = 6;
            this.lbldonvi.Text = "quyển";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(575, 715);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(51, 16);
            this.lblTong.TabIndex = 7;
            this.lblTong.Text = "Tổng :";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(667, 709);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(143, 22);
            this.txtTong.TabIndex = 26;
            // 
            // FormPhieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1321, 805);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldonvi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plheader);
            this.Name = "FormPhieumuon";
            this.Text = "FormPhieumuon";
            this.Load += new System.EventHandler(this.FormPhieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.plheader.ResumeLayout(false);
            this.plheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridThue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plheader;
        private System.Windows.Forms.Label lblPhieumuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboPhieumuon;
        private System.Windows.Forms.Button btnTimkiemphieumuon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaphieumuon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoatphieu;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTendocgia;
        private System.Windows.Forms.Label lblMadocgia;
        private System.Windows.Forms.Label lblTennhanvien;
        private System.Windows.Forms.Label lblManhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHinhthuc;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.MaskedTextBox mskNgayThue;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.RadioButton rdoOnl;
        private System.Windows.Forms.RadioButton rdoOff;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lbldonvi;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblMatinhtrang;
        private System.Windows.Forms.Label lblTentinhtrang;
        private System.Windows.Forms.Label lblTensach;
        private System.Windows.Forms.Label lblMasach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenTinhTrang;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cboMaTinhTrang;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.DataGridView datagridThue;
    }
}