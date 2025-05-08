namespace thutap
{
    partial class FormNhapsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapsach));
            this.plheader = new System.Windows.Forms.Panel();
            this.lblPhieunhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMa = new System.Windows.Forms.Label();
            this.cboTimkiemphieunhap = new System.Windows.Forms.ComboBox();
            this.btnTimkiemphieunhap = new System.Windows.Forms.Button();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.txtMaphieunhap = new System.Windows.Forms.TextBox();
            this.lblTennhanvien = new System.Windows.Forms.Label();
            this.lblManhanvien = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblMaphieunhap = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemphieunhap = new System.Windows.Forms.Button();
            this.btnThoatphieunhap = new System.Windows.Forms.Button();
            this.btnInphieunhap = new System.Windows.Forms.Button();
            this.btnXoaphieunhap = new System.Windows.Forms.Button();
            this.btnLuuphieunhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.cboMasach = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lbldonvi = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.datagridPhieuNhapSach = new System.Windows.Forms.DataGridView();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTensach = new System.Windows.Forms.Label();
            this.lblMasach = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.plheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grp1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPhieuNhapSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(1204, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(144, 111);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // plheader
            // 
            this.plheader.BackColor = System.Drawing.Color.Turquoise;
            this.plheader.Controls.Add(this.lblPhieunhap);
            this.plheader.Controls.Add(pictureBox1);
            this.plheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plheader.Location = new System.Drawing.Point(0, 0);
            this.plheader.Name = "plheader";
            this.plheader.Size = new System.Drawing.Size(1360, 114);
            this.plheader.TabIndex = 6;
            // 
            // lblPhieunhap
            // 
            this.lblPhieunhap.AutoSize = true;
            this.lblPhieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieunhap.ForeColor = System.Drawing.Color.Snow;
            this.lblPhieunhap.Location = new System.Drawing.Point(314, 20);
            this.lblPhieunhap.Name = "lblPhieunhap";
            this.lblPhieunhap.Size = new System.Drawing.Size(592, 69);
            this.lblPhieunhap.TabIndex = 0;
            this.lblPhieunhap.Text = "PHIẾU NHẬP SÁCH\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 759);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 51);
            this.panel1.TabIndex = 7;
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
            this.panel3.Controls.Add(this.cboTimkiemphieunhap);
            this.panel3.Controls.Add(this.btnTimkiemphieunhap);
            this.panel3.Location = new System.Drawing.Point(25, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 43);
            this.panel3.TabIndex = 8;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(3, 10);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(116, 16);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã phiếu nhập :";
            // 
            // cboTimkiemphieunhap
            // 
            this.cboTimkiemphieunhap.FormattingEnabled = true;
            this.cboTimkiemphieunhap.Location = new System.Drawing.Point(128, 7);
            this.cboTimkiemphieunhap.Name = "cboTimkiemphieunhap";
            this.cboTimkiemphieunhap.Size = new System.Drawing.Size(249, 24);
            this.cboTimkiemphieunhap.TabIndex = 1;
            this.cboTimkiemphieunhap.DropDown += new System.EventHandler(this.cboTimkiemphieunhap_DropDown);
            this.cboTimkiemphieunhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTimkiemphieunhap_KeyDown);
            // 
            // btnTimkiemphieunhap
            // 
            this.btnTimkiemphieunhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTimkiemphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemphieunhap.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTimkiemphieunhap.Location = new System.Drawing.Point(423, 3);
            this.btnTimkiemphieunhap.Name = "btnTimkiemphieunhap";
            this.btnTimkiemphieunhap.Size = new System.Drawing.Size(99, 32);
            this.btnTimkiemphieunhap.TabIndex = 0;
            this.btnTimkiemphieunhap.Text = "Tìm kiếm";
            this.btnTimkiemphieunhap.UseVisualStyleBackColor = false;
            this.btnTimkiemphieunhap.Click += new System.EventHandler(this.btnTimkiemphieunhap_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.dtpNgaynhap);
            this.grp1.Controls.Add(this.txtTennhanvien);
            this.grp1.Controls.Add(this.cboManhanvien);
            this.grp1.Controls.Add(this.txtMaphieunhap);
            this.grp1.Controls.Add(this.lblTennhanvien);
            this.grp1.Controls.Add(this.lblManhanvien);
            this.grp1.Controls.Add(this.lblNgaynhap);
            this.grp1.Controls.Add(this.lblMaphieunhap);
            this.grp1.Location = new System.Drawing.Point(25, 222);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(667, 333);
            this.grp1.TabIndex = 9;
            this.grp1.TabStop = false;
            this.grp1.Text = "Thông tin chung";
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaynhap.Location = new System.Drawing.Point(206, 140);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(328, 22);
            this.dtpNgaynhap.TabIndex = 9;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(206, 287);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(328, 22);
            this.txtTennhanvien.TabIndex = 8;
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(206, 210);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(328, 24);
            this.cboManhanvien.TabIndex = 7;
            this.cboManhanvien.SelectedIndexChanged += new System.EventHandler(this.cboManhanvien_SelectedIndexChanged);
            this.cboManhanvien.TextChanged += new System.EventHandler(this.cboManhanvien_TextChanged);
            // 
            // txtMaphieunhap
            // 
            this.txtMaphieunhap.Location = new System.Drawing.Point(206, 56);
            this.txtMaphieunhap.Name = "txtMaphieunhap";
            this.txtMaphieunhap.Size = new System.Drawing.Size(328, 22);
            this.txtMaphieunhap.TabIndex = 5;
            // 
            // lblTennhanvien
            // 
            this.lblTennhanvien.AutoSize = true;
            this.lblTennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennhanvien.Location = new System.Drawing.Point(19, 293);
            this.lblTennhanvien.Name = "lblTennhanvien";
            this.lblTennhanvien.Size = new System.Drawing.Size(152, 16);
            this.lblTennhanvien.TabIndex = 4;
            this.lblTennhanvien.Text = "Tên nhân viên thủ thư";
            // 
            // lblManhanvien
            // 
            this.lblManhanvien.AutoSize = true;
            this.lblManhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhanvien.Location = new System.Drawing.Point(19, 219);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(146, 16);
            this.lblManhanvien.TabIndex = 2;
            this.lblManhanvien.Text = "Mã nhân viên thủ thư";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaynhap.Location = new System.Drawing.Point(19, 147);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(82, 16);
            this.lblNgaynhap.TabIndex = 1;
            this.lblNgaynhap.Text = "Ngày nhập";
            // 
            // lblMaphieunhap
            // 
            this.lblMaphieunhap.AutoSize = true;
            this.lblMaphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphieunhap.Location = new System.Drawing.Point(19, 63);
            this.lblMaphieunhap.Name = "lblMaphieunhap";
            this.lblMaphieunhap.Size = new System.Drawing.Size(108, 16);
            this.lblMaphieunhap.TabIndex = 0;
            this.lblMaphieunhap.Text = "Mã phiếu nhập";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.btnThemphieunhap);
            this.panel4.Controls.Add(this.btnThoatphieunhap);
            this.panel4.Controls.Add(this.btnInphieunhap);
            this.panel4.Controls.Add(this.btnXoaphieunhap);
            this.panel4.Controls.Add(this.btnLuuphieunhap);
            this.panel4.Location = new System.Drawing.Point(72, 614);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(611, 116);
            this.panel4.TabIndex = 41;
            // 
            // btnThemphieunhap
            // 
            this.btnThemphieunhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemphieunhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemphieunhap.ForeColor = System.Drawing.Color.Teal;
            this.btnThemphieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemphieunhap.Location = new System.Drawing.Point(6, 11);
            this.btnThemphieunhap.Name = "btnThemphieunhap";
            this.btnThemphieunhap.Size = new System.Drawing.Size(113, 36);
            this.btnThemphieunhap.TabIndex = 1;
            this.btnThemphieunhap.Text = "Thêm Mới";
            this.btnThemphieunhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemphieunhap.UseVisualStyleBackColor = false;
            this.btnThemphieunhap.Click += new System.EventHandler(this.btnThemphieunhap_Click);
            // 
            // btnThoatphieunhap
            // 
            this.btnThoatphieunhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoatphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatphieunhap.ForeColor = System.Drawing.Color.Teal;
            this.btnThoatphieunhap.Location = new System.Drawing.Point(143, 81);
            this.btnThoatphieunhap.Name = "btnThoatphieunhap";
            this.btnThoatphieunhap.Size = new System.Drawing.Size(77, 32);
            this.btnThoatphieunhap.TabIndex = 6;
            this.btnThoatphieunhap.Text = "Thoát";
            this.btnThoatphieunhap.UseVisualStyleBackColor = false;
            this.btnThoatphieunhap.Click += new System.EventHandler(this.btnThoatphieunhap_Click);
            // 
            // btnInphieunhap
            // 
            this.btnInphieunhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInphieunhap.ForeColor = System.Drawing.Color.Teal;
            this.btnInphieunhap.Location = new System.Drawing.Point(367, 81);
            this.btnInphieunhap.Name = "btnInphieunhap";
            this.btnInphieunhap.Size = new System.Drawing.Size(111, 32);
            this.btnInphieunhap.TabIndex = 7;
            this.btnInphieunhap.Text = "In Phiếu";
            this.btnInphieunhap.UseVisualStyleBackColor = false;
            this.btnInphieunhap.Click += new System.EventHandler(this.btnInphieunhap_Click);
            // 
            // btnXoaphieunhap
            // 
            this.btnXoaphieunhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaphieunhap.ForeColor = System.Drawing.Color.Teal;
            this.btnXoaphieunhap.Location = new System.Drawing.Point(242, 11);
            this.btnXoaphieunhap.Name = "btnXoaphieunhap";
            this.btnXoaphieunhap.Size = new System.Drawing.Size(102, 36);
            this.btnXoaphieunhap.TabIndex = 3;
            this.btnXoaphieunhap.Text = "Xoá";
            this.btnXoaphieunhap.UseVisualStyleBackColor = false;
            this.btnXoaphieunhap.Click += new System.EventHandler(this.btnXoaphieunhap_Click);
            // 
            // btnLuuphieunhap
            // 
            this.btnLuuphieunhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLuuphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuphieunhap.ForeColor = System.Drawing.Color.Teal;
            this.btnLuuphieunhap.Location = new System.Drawing.Point(497, 11);
            this.btnLuuphieunhap.Name = "btnLuuphieunhap";
            this.btnLuuphieunhap.Size = new System.Drawing.Size(76, 36);
            this.btnLuuphieunhap.TabIndex = 4;
            this.btnLuuphieunhap.Text = "Lưu";
            this.btnLuuphieunhap.UseVisualStyleBackColor = false;
            this.btnLuuphieunhap.Click += new System.EventHandler(this.btnLuuphieunhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.lblGhichu);
            this.groupBox1.Controls.Add(this.cboMasach);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.lbldonvi);
            this.groupBox1.Controls.Add(this.txtTong);
            this.groupBox1.Controls.Add(this.txtTensach);
            this.groupBox1.Controls.Add(this.datagridPhieuNhapSach);
            this.groupBox1.Controls.Add(this.lblTong);
            this.groupBox1.Controls.Add(this.lblSoluong);
            this.groupBox1.Controls.Add(this.lblTensach);
            this.groupBox1.Controls.Add(this.lblMasach);
            this.groupBox1.Location = new System.Drawing.Point(734, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 566);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(157, 199);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(328, 22);
            this.txtGhichu.TabIndex = 45;
            // 
            // lblGhichu
            // 
            this.lblGhichu.AutoSize = true;
            this.lblGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhichu.Location = new System.Drawing.Point(33, 202);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(58, 16);
            this.lblGhichu.TabIndex = 44;
            this.lblGhichu.Text = "Ghi chú";
            // 
            // cboMasach
            // 
            this.cboMasach.FormattingEnabled = true;
            this.cboMasach.Location = new System.Drawing.Point(157, 18);
            this.cboMasach.Name = "cboMasach";
            this.cboMasach.Size = new System.Drawing.Size(328, 24);
            this.cboMasach.TabIndex = 9;
            this.cboMasach.SelectedIndexChanged += new System.EventHandler(this.cboMasach_SelectedIndexChanged);
            this.cboMasach.TextChanged += new System.EventHandler(this.cboMasach_TextChanged);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(157, 138);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(328, 22);
            this.txtSoluong.TabIndex = 43;
            // 
            // lbldonvi
            // 
            this.lbldonvi.AutoSize = true;
            this.lbldonvi.Location = new System.Drawing.Point(536, 516);
            this.lbldonvi.Name = "lbldonvi";
            this.lbldonvi.Size = new System.Drawing.Size(46, 16);
            this.lbldonvi.TabIndex = 42;
            this.lbldonvi.Text = "Quyển";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(457, 516);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(55, 22);
            this.txtTong.TabIndex = 41;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(157, 72);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(328, 22);
            this.txtTensach.TabIndex = 9;
            // 
            // datagridPhieuNhapSach
            // 
            this.datagridPhieuNhapSach.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datagridPhieuNhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPhieuNhapSach.Location = new System.Drawing.Point(33, 236);
            this.datagridPhieuNhapSach.Name = "datagridPhieuNhapSach";
            this.datagridPhieuNhapSach.RowHeadersWidth = 51;
            this.datagridPhieuNhapSach.RowTemplate.Height = 24;
            this.datagridPhieuNhapSach.Size = new System.Drawing.Size(549, 254);
            this.datagridPhieuNhapSach.TabIndex = 40;
            this.datagridPhieuNhapSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPhieuNhapSach_CellDoubleClick);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(389, 522);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(45, 16);
            this.lblTong.TabIndex = 3;
            this.lblTong.Text = "Tổng: ";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(33, 140);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(68, 16);
            this.lblSoluong.TabIndex = 2;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblTensach
            // 
            this.lblTensach.AutoSize = true;
            this.lblTensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensach.Location = new System.Drawing.Point(30, 78);
            this.lblTensach.Name = "lblTensach";
            this.lblTensach.Size = new System.Drawing.Size(71, 16);
            this.lblTensach.TabIndex = 1;
            this.lblTensach.Text = "Tên sách";
            // 
            // lblMasach
            // 
            this.lblMasach.AutoSize = true;
            this.lblMasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasach.Location = new System.Drawing.Point(30, 26);
            this.lblMasach.Name = "lblMasach";
            this.lblMasach.Size = new System.Drawing.Size(65, 16);
            this.lblMasach.TabIndex = 0;
            this.lblMasach.Text = "Mã sách";
            // 
            // FormNhapsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 809);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plheader);
            this.Name = "FormNhapsach";
            this.Text = "FormNhapsach";
            this.Load += new System.EventHandler(this.FormNhapsach_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.plheader.ResumeLayout(false);
            this.plheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPhieuNhapSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plheader;
        private System.Windows.Forms.Label lblPhieunhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ComboBox cboTimkiemphieunhap;
        private System.Windows.Forms.Button btnTimkiemphieunhap;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemphieunhap;
        private System.Windows.Forms.Button btnThoatphieunhap;
        private System.Windows.Forms.Button btnInphieunhap;
        private System.Windows.Forms.Button btnXoaphieunhap;
        private System.Windows.Forms.Button btnLuuphieunhap;
        private System.Windows.Forms.Label lblTennhanvien;
        private System.Windows.Forms.Label lblManhanvien;
        private System.Windows.Forms.Label lblNgaynhap;
        private System.Windows.Forms.Label lblMaphieunhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.TextBox txtMaphieunhap;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTensach;
        private System.Windows.Forms.Label lblMasach;
        private System.Windows.Forms.DataGridView datagridPhieuNhapSach;
        private System.Windows.Forms.Label lbldonvi;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label lblGhichu;
        private System.Windows.Forms.ComboBox cboMasach;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
    }
}