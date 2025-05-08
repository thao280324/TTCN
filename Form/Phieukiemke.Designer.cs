namespace thutap
{
    partial class Phieukiemke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phieukiemke));
            this.plheader = new System.Windows.Forms.Panel();
            this.lblPhieumuon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemphieu = new System.Windows.Forms.Button();
            this.btnThoatphieu = new System.Windows.Forms.Button();
            this.btnInphieu = new System.Windows.Forms.Button();
            this.btnSuaphieu = new System.Windows.Forms.Button();
            this.btnXoaphieu = new System.Windows.Forms.Button();
            this.btnLuuphieu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.rdoThieu = new System.Windows.Forms.RadioButton();
            this.rdoDu = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.dtpNgaykiemke = new System.Windows.Forms.DateTimePicker();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.plheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(1226, 3);
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
            this.plheader.Size = new System.Drawing.Size(1382, 114);
            this.plheader.TabIndex = 5;
            // 
            // lblPhieumuon
            // 
            this.lblPhieumuon.AutoSize = true;
            this.lblPhieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieumuon.ForeColor = System.Drawing.Color.Snow;
            this.lblPhieumuon.Location = new System.Drawing.Point(286, 19);
            this.lblPhieumuon.Name = "lblPhieumuon";
            this.lblPhieumuon.Size = new System.Drawing.Size(672, 69);
            this.lblPhieumuon.TabIndex = 0;
            this.lblPhieumuon.Text = "PHIẾU KIỂM KÊ SÁCH\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 721);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 51);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.btnThemphieu);
            this.panel4.Controls.Add(this.btnThoatphieu);
            this.panel4.Controls.Add(this.btnInphieu);
            this.panel4.Controls.Add(this.btnSuaphieu);
            this.panel4.Controls.Add(this.btnXoaphieu);
            this.panel4.Controls.Add(this.btnLuuphieu);
            this.panel4.Location = new System.Drawing.Point(25, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 435);
            this.panel4.TabIndex = 26;
            // 
            // btnThemphieu
            // 
            this.btnThemphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemphieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnThemphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemphieu.Location = new System.Drawing.Point(37, 3);
            this.btnThemphieu.Name = "btnThemphieu";
            this.btnThemphieu.Size = new System.Drawing.Size(113, 36);
            this.btnThemphieu.TabIndex = 1;
            this.btnThemphieu.Text = "Thêm Mới";
            this.btnThemphieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemphieu.UseVisualStyleBackColor = false;
            // 
            // btnThoatphieu
            // 
            this.btnThoatphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoatphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnThoatphieu.Location = new System.Drawing.Point(37, 384);
            this.btnThoatphieu.Name = "btnThoatphieu";
            this.btnThoatphieu.Size = new System.Drawing.Size(77, 32);
            this.btnThoatphieu.TabIndex = 6;
            this.btnThoatphieu.Text = "Thoát";
            this.btnThoatphieu.UseVisualStyleBackColor = false;
            // 
            // btnInphieu
            // 
            this.btnInphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnInphieu.Location = new System.Drawing.Point(37, 304);
            this.btnInphieu.Name = "btnInphieu";
            this.btnInphieu.Size = new System.Drawing.Size(130, 32);
            this.btnInphieu.TabIndex = 7;
            this.btnInphieu.Text = "In Phiếu";
            this.btnInphieu.UseVisualStyleBackColor = false;
            // 
            // btnSuaphieu
            // 
            this.btnSuaphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnSuaphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaphieu.Location = new System.Drawing.Point(37, 80);
            this.btnSuaphieu.Name = "btnSuaphieu";
            this.btnSuaphieu.Size = new System.Drawing.Size(81, 32);
            this.btnSuaphieu.TabIndex = 2;
            this.btnSuaphieu.Text = "Sửa";
            this.btnSuaphieu.UseVisualStyleBackColor = false;
            // 
            // btnXoaphieu
            // 
            this.btnXoaphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnXoaphieu.Location = new System.Drawing.Point(37, 155);
            this.btnXoaphieu.Name = "btnXoaphieu";
            this.btnXoaphieu.Size = new System.Drawing.Size(84, 32);
            this.btnXoaphieu.TabIndex = 3;
            this.btnXoaphieu.Text = "Xoá";
            this.btnXoaphieu.UseVisualStyleBackColor = false;
            // 
            // btnLuuphieu
            // 
            this.btnLuuphieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLuuphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuphieu.ForeColor = System.Drawing.Color.Teal;
            this.btnLuuphieu.Location = new System.Drawing.Point(37, 230);
            this.btnLuuphieu.Name = "btnLuuphieu";
            this.btnLuuphieu.Size = new System.Drawing.Size(76, 32);
            this.btnLuuphieu.TabIndex = 4;
            this.btnLuuphieu.Text = "Lưu";
            this.btnLuuphieu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaykiemke);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.txtMaphieu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(248, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 218);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(185, 133);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(224, 22);
            this.txtTennhanvien.TabIndex = 7;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(185, 47);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(224, 22);
            this.txtMaphieu.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày kiểm kê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã phiếu kiểm kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.txtTensach);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.rdoThieu);
            this.groupBox2.Controls.Add(this.rdoDu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(766, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 218);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách kiểm kê";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(203, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(203, 111);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(224, 22);
            this.txtTensach.TabIndex = 12;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(203, 161);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(224, 22);
            this.txtSoluong.TabIndex = 8;
            // 
            // rdoThieu
            // 
            this.rdoThieu.AutoSize = true;
            this.rdoThieu.Location = new System.Drawing.Point(333, 27);
            this.rdoThieu.Name = "rdoThieu";
            this.rdoThieu.Size = new System.Drawing.Size(94, 20);
            this.rdoThieu.TabIndex = 11;
            this.rdoThieu.TabStop = true;
            this.rdoThieu.Text = "Thiếu sách";
            this.rdoThieu.UseVisualStyleBackColor = true;
            // 
            // rdoDu
            // 
            this.rdoDu.AutoSize = true;
            this.rdoDu.Location = new System.Drawing.Point(170, 27);
            this.rdoDu.Name = "rdoDu";
            this.rdoDu.Size = new System.Drawing.Size(76, 20);
            this.rdoDu.TabIndex = 10;
            this.rdoDu.TabStop = true;
            this.rdoDu.Text = "Đủ sách";
            this.rdoDu.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tình trạng kho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số lượng thiếu";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(31, 120);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(108, 16);
            this.label.TabIndex = 7;
            this.label.Text = "Tên sách thiếu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã sách thiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(969, 679);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1122, 679);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "quyển";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 249);
            this.dataGridView1.TabIndex = 29;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(1022, 673);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(96, 22);
            this.txtTong.TabIndex = 13;
            // 
            // dtpNgaykiemke
            // 
            this.dtpNgaykiemke.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykiemke.Location = new System.Drawing.Point(185, 177);
            this.dtpNgaykiemke.Name = "dtpNgaykiemke";
            this.dtpNgaykiemke.Size = new System.Drawing.Size(224, 22);
            this.dtpNgaykiemke.TabIndex = 10;
            // 
            // Phieukiemke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1382, 771);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plheader);
            this.Name = "Phieukiemke";
            this.Text = "Phieukiemke";
            this.Load += new System.EventHandler(this.Phieukiemke_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.plheader.ResumeLayout(false);
            this.plheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plheader;
        private System.Windows.Forms.Label lblPhieumuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemphieu;
        private System.Windows.Forms.Button btnThoatphieu;
        private System.Windows.Forms.Button btnInphieu;
        private System.Windows.Forms.Button btnSuaphieu;
        private System.Windows.Forms.Button btnXoaphieu;
        private System.Windows.Forms.Button btnLuuphieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.RadioButton rdoThieu;
        private System.Windows.Forms.RadioButton rdoDu;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.DateTimePicker dtpNgaykiemke;
    }
}