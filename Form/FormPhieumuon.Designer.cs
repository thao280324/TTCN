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
            this.cboTimkiemphieumuon = new System.Windows.Forms.ComboBox();
            this.btnTimkiemphieumuon = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoonl = new System.Windows.Forms.RadioButton();
            this.rdooff = new System.Windows.Forms.RadioButton();
            this.cboMadocgia = new System.Windows.Forms.ComboBox();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.mskNgaymuon = new System.Windows.Forms.MaskedTextBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTendocgia = new System.Windows.Forms.TextBox();
            this.txtPhieumuon = new System.Windows.Forms.TextBox();
            this.lblHinhthuc = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTendocgia = new System.Windows.Forms.Label();
            this.lblMadocgia = new System.Windows.Forms.Label();
            this.lblTennhanvien = new System.Windows.Forms.Label();
            this.lblManhanvien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaphieumuon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTentinhtrang = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.cboMatinhtrang = new System.Windows.Forms.ComboBox();
            this.cboMasach = new System.Windows.Forms.ComboBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblMatinhtrang = new System.Windows.Forms.Label();
            this.lblTentinhtrang = new System.Windows.Forms.Label();
            this.lblTensach = new System.Windows.Forms.Label();
            this.lblMasach = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemphieumuon = new System.Windows.Forms.Button();
            this.btnThoatphieu = new System.Windows.Forms.Button();
            this.btnInphieumuon = new System.Windows.Forms.Button();
            this.btnSuaphieumuon = new System.Windows.Forms.Button();
            this.btnXoaphieumuon = new System.Windows.Forms.Button();
            this.btnLuuphieu = new System.Windows.Forms.Button();
            this.lbldonvi = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.plheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
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
            this.panel3.Controls.Add(this.cboTimkiemphieumuon);
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
            // cboTimkiemphieumuon
            // 
            this.cboTimkiemphieumuon.FormattingEnabled = true;
            this.cboTimkiemphieumuon.Location = new System.Drawing.Point(128, 32);
            this.cboTimkiemphieumuon.Name = "cboTimkiemphieumuon";
            this.cboTimkiemphieumuon.Size = new System.Drawing.Size(249, 24);
            this.cboTimkiemphieumuon.TabIndex = 1;
            this.cboTimkiemphieumuon.SelectedIndexChanged += new System.EventHandler(this.cboTimkiemphieumuon_SelectedIndexChanged);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoonl);
            this.groupBox1.Controls.Add(this.rdooff);
            this.groupBox1.Controls.Add(this.cboMadocgia);
            this.groupBox1.Controls.Add(this.cboManhanvien);
            this.groupBox1.Controls.Add(this.mskNgaymuon);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTendocgia);
            this.groupBox1.Controls.Add(this.txtPhieumuon);
            this.groupBox1.Controls.Add(this.lblHinhthuc);
            this.groupBox1.Controls.Add(this.lblDiachi);
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
            // rdoonl
            // 
            this.rdoonl.AutoSize = true;
            this.rdoonl.Location = new System.Drawing.Point(805, 114);
            this.rdoonl.Name = "rdoonl";
            this.rdoonl.Size = new System.Drawing.Size(66, 20);
            this.rdoonl.TabIndex = 18;
            this.rdoonl.TabStop = true;
            this.rdoonl.Text = "Online";
            this.rdoonl.UseVisualStyleBackColor = true;
            // 
            // rdooff
            // 
            this.rdooff.AutoSize = true;
            this.rdooff.Location = new System.Drawing.Point(704, 114);
            this.rdooff.Name = "rdooff";
            this.rdooff.Size = new System.Drawing.Size(65, 20);
            this.rdooff.TabIndex = 17;
            this.rdooff.TabStop = true;
            this.rdooff.Text = "Offline";
            this.rdooff.UseVisualStyleBackColor = true;
            // 
            // cboMadocgia
            // 
            this.cboMadocgia.FormattingEnabled = true;
            this.cboMadocgia.Location = new System.Drawing.Point(704, 12);
            this.cboMadocgia.Name = "cboMadocgia";
            this.cboMadocgia.Size = new System.Drawing.Size(278, 24);
            this.cboMadocgia.TabIndex = 16;
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(186, 86);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(278, 24);
            this.cboManhanvien.TabIndex = 14;
            // 
            // mskNgaymuon
            // 
            this.mskNgaymuon.Location = new System.Drawing.Point(186, 55);
            this.mskNgaymuon.Mask = "00/00/0000 90:00";
            this.mskNgaymuon.Name = "mskNgaymuon";
            this.mskNgaymuon.Size = new System.Drawing.Size(218, 22);
            this.mskNgaymuon.TabIndex = 13;
            this.mskNgaymuon.ValidatingType = typeof(System.DateTime);
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(186, 116);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(278, 22);
            this.txtTennhanvien.TabIndex = 12;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(704, 82);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(278, 22);
            this.txtDiachi.TabIndex = 11;
            // 
            // txtTendocgia
            // 
            this.txtTendocgia.Location = new System.Drawing.Point(704, 49);
            this.txtTendocgia.Name = "txtTendocgia";
            this.txtTendocgia.Size = new System.Drawing.Size(278, 22);
            this.txtTendocgia.TabIndex = 9;
            // 
            // txtPhieumuon
            // 
            this.txtPhieumuon.Location = new System.Drawing.Point(186, 12);
            this.txtPhieumuon.Name = "txtPhieumuon";
            this.txtPhieumuon.Size = new System.Drawing.Size(278, 22);
            this.txtPhieumuon.TabIndex = 8;
            // 
            // lblHinhthuc
            // 
            this.lblHinhthuc.AutoSize = true;
            this.lblHinhthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhthuc.Location = new System.Drawing.Point(529, 119);
            this.lblHinhthuc.Name = "lblHinhthuc";
            this.lblHinhthuc.Size = new System.Drawing.Size(111, 16);
            this.lblHinhthuc.TabIndex = 7;
            this.lblHinhthuc.Text = "Hình thức mượn";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(529, 88);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(54, 16);
            this.lblDiachi.TabIndex = 6;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTendocgia
            // 
            this.lblTendocgia.AutoSize = true;
            this.lblTendocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendocgia.Location = new System.Drawing.Point(524, 55);
            this.lblTendocgia.Name = "lblTendocgia";
            this.lblTendocgia.Size = new System.Drawing.Size(90, 16);
            this.lblTendocgia.TabIndex = 5;
            this.lblTendocgia.Text = "Tên độc giả";
            // 
            // lblMadocgia
            // 
            this.lblMadocgia.AutoSize = true;
            this.lblMadocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadocgia.Location = new System.Drawing.Point(524, 18);
            this.lblMadocgia.Name = "lblMadocgia";
            this.lblMadocgia.Size = new System.Drawing.Size(84, 16);
            this.lblMadocgia.TabIndex = 4;
            this.lblMadocgia.Text = "Mã độc giả";
            // 
            // lblTennhanvien
            // 
            this.lblTennhanvien.AutoSize = true;
            this.lblTennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennhanvien.Location = new System.Drawing.Point(20, 125);
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
            this.groupBox2.Controls.Add(this.DataGridView1);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.txtTentinhtrang);
            this.groupBox2.Controls.Add(this.txtTensach);
            this.groupBox2.Controls.Add(this.cboMatinhtrang);
            this.groupBox2.Controls.Add(this.cboMasach);
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
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(28, 238);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1039, 157);
            this.DataGridView1.TabIndex = 23;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(184, 210);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(415, 22);
            this.txtSoluong.TabIndex = 11;
            // 
            // txtTentinhtrang
            // 
            this.txtTentinhtrang.Location = new System.Drawing.Point(184, 164);
            this.txtTentinhtrang.Name = "txtTentinhtrang";
            this.txtTentinhtrang.Size = new System.Drawing.Size(415, 22);
            this.txtTentinhtrang.TabIndex = 10;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(184, 75);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(415, 22);
            this.txtTensach.TabIndex = 9;
            // 
            // cboMatinhtrang
            // 
            this.cboMatinhtrang.FormattingEnabled = true;
            this.cboMatinhtrang.Location = new System.Drawing.Point(184, 117);
            this.cboMatinhtrang.Name = "cboMatinhtrang";
            this.cboMatinhtrang.Size = new System.Drawing.Size(415, 24);
            this.cboMatinhtrang.TabIndex = 8;
            // 
            // cboMasach
            // 
            this.cboMasach.FormattingEnabled = true;
            this.cboMasach.Location = new System.Drawing.Point(184, 29);
            this.cboMasach.Name = "cboMasach";
            this.cboMasach.Size = new System.Drawing.Size(415, 24);
            this.cboMasach.TabIndex = 7;
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
            this.panel4.Controls.Add(this.btnThemphieumuon);
            this.panel4.Controls.Add(this.btnThoatphieu);
            this.panel4.Controls.Add(this.btnInphieumuon);
            this.panel4.Controls.Add(this.btnSuaphieumuon);
            this.panel4.Controls.Add(this.btnXoaphieumuon);
            this.panel4.Controls.Add(this.btnLuuphieu);
            this.panel4.Location = new System.Drawing.Point(12, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 345);
            this.panel4.TabIndex = 25;
            // 
            // btnThemphieumuon
            // 
            this.btnThemphieumuon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemphieumuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemphieumuon.ForeColor = System.Drawing.Color.Teal;
            this.btnThemphieumuon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemphieumuon.Location = new System.Drawing.Point(37, 3);
            this.btnThemphieumuon.Name = "btnThemphieumuon";
            this.btnThemphieumuon.Size = new System.Drawing.Size(113, 36);
            this.btnThemphieumuon.TabIndex = 1;
            this.btnThemphieumuon.Text = "Thêm Mới";
            this.btnThemphieumuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemphieumuon.UseVisualStyleBackColor = false;
            // 
            // btnThoatphieu
            // 
            this.btnThoatphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoatphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnThoatphieu.Location = new System.Drawing.Point(37, 310);
            this.btnThoatphieu.Name = "btnThoatphieu";
            this.btnThoatphieu.Size = new System.Drawing.Size(77, 32);
            this.btnThoatphieu.TabIndex = 6;
            this.btnThoatphieu.Text = "Thoát";
            this.btnThoatphieu.UseVisualStyleBackColor = false;
            // 
            // btnInphieumuon
            // 
            this.btnInphieumuon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInphieumuon.ForeColor = System.Drawing.Color.Teal;
            this.btnInphieumuon.Location = new System.Drawing.Point(37, 248);
            this.btnInphieumuon.Name = "btnInphieumuon";
            this.btnInphieumuon.Size = new System.Drawing.Size(130, 32);
            this.btnInphieumuon.TabIndex = 7;
            this.btnInphieumuon.Text = "In Phiếu";
            this.btnInphieumuon.UseVisualStyleBackColor = false;
            // 
            // btnSuaphieumuon
            // 
            this.btnSuaphieumuon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuaphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaphieumuon.ForeColor = System.Drawing.Color.Teal;
            this.btnSuaphieumuon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaphieumuon.Location = new System.Drawing.Point(37, 60);
            this.btnSuaphieumuon.Name = "btnSuaphieumuon";
            this.btnSuaphieumuon.Size = new System.Drawing.Size(81, 32);
            this.btnSuaphieumuon.TabIndex = 2;
            this.btnSuaphieumuon.Text = "Sửa";
            this.btnSuaphieumuon.UseVisualStyleBackColor = false;
            // 
            // btnXoaphieumuon
            // 
            this.btnXoaphieumuon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaphieumuon.ForeColor = System.Drawing.Color.Teal;
            this.btnXoaphieumuon.Location = new System.Drawing.Point(37, 123);
            this.btnXoaphieumuon.Name = "btnXoaphieumuon";
            this.btnXoaphieumuon.Size = new System.Drawing.Size(84, 32);
            this.btnXoaphieumuon.TabIndex = 3;
            this.btnXoaphieumuon.Text = "Xoá";
            this.btnXoaphieumuon.UseVisualStyleBackColor = false;
            // 
            // btnLuuphieu
            // 
            this.btnLuuphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLuuphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnLuuphieu.Location = new System.Drawing.Point(38, 184);
            this.btnLuuphieu.Name = "btnLuuphieu";
            this.btnLuuphieu.Size = new System.Drawing.Size(76, 32);
            this.btnLuuphieu.TabIndex = 4;
            this.btnLuuphieu.Text = "Lưu";
            this.btnLuuphieu.UseVisualStyleBackColor = false;
            // 
            // lbldonvi
            // 
            this.lbldonvi.AutoSize = true;
            this.lbldonvi.Location = new System.Drawing.Point(839, 715);
            this.lbldonvi.Name = "lbldonvi";
            this.lbldonvi.Size = new System.Drawing.Size(44, 16);
            this.lbldonvi.TabIndex = 6;
            this.lbldonvi.Text = "quyển";
            this.lbldonvi.Click += new System.EventHandler(this.label8_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 709);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 26;
            // 
            // FormPhieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1321, 805);
            this.Controls.Add(this.textBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cboTimkiemphieumuon;
        private System.Windows.Forms.Button btnTimkiemphieumuon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaphieumuon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemphieumuon;
        private System.Windows.Forms.Button btnThoatphieu;
        private System.Windows.Forms.Button btnInphieumuon;
        private System.Windows.Forms.Button btnSuaphieumuon;
        private System.Windows.Forms.Button btnXoaphieumuon;
        private System.Windows.Forms.Button btnLuuphieu;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTendocgia;
        private System.Windows.Forms.Label lblMadocgia;
        private System.Windows.Forms.Label lblTennhanvien;
        private System.Windows.Forms.Label lblManhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHinhthuc;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.TextBox txtTendocgia;
        private System.Windows.Forms.TextBox txtPhieumuon;
        private System.Windows.Forms.ComboBox cboMadocgia;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.MaskedTextBox mskNgaymuon;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.RadioButton rdoonl;
        private System.Windows.Forms.RadioButton rdooff;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lbldonvi;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblMatinhtrang;
        private System.Windows.Forms.Label lblTentinhtrang;
        private System.Windows.Forms.Label lblTensach;
        private System.Windows.Forms.Label lblMasach;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTentinhtrang;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.ComboBox cboMatinhtrang;
        private System.Windows.Forms.ComboBox cboMasach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DataGridView1;
    }
}