namespace thutap
{
    partial class Duyetyeucau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duyetyeucau));
            this.plheader = new System.Windows.Forms.Panel();
            this.lblPhieu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.cboChonphieu = new System.Windows.Forms.ComboBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskNgay = new System.Windows.Forms.MaskedTextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnKhongduyet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.plheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(1168, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(144, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // plheader
            // 
            this.plheader.BackColor = System.Drawing.Color.Turquoise;
            this.plheader.Controls.Add(this.lblPhieu);
            this.plheader.Controls.Add(pictureBox1);
            this.plheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plheader.Location = new System.Drawing.Point(0, 0);
            this.plheader.Name = "plheader";
            this.plheader.Size = new System.Drawing.Size(1324, 151);
            this.plheader.TabIndex = 8;
            // 
            // lblPhieu
            // 
            this.lblPhieu.AutoSize = true;
            this.lblPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieu.ForeColor = System.Drawing.Color.Snow;
            this.lblPhieu.Location = new System.Drawing.Point(160, 38);
            this.lblPhieu.Name = "lblPhieu";
            this.lblPhieu.Size = new System.Drawing.Size(919, 69);
            this.lblPhieu.TabIndex = 0;
            this.lblPhieu.Text = "DUYỆT PHIẾU YÊU CẦU NHẬP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 47);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(612, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phần mềm quản lý sách-Thư viện D FREE BOOK";
          //  this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn phiếu duyệt";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.cboChonphieu);
            this.grp.Controls.Add(this.label1);
            this.grp.Location = new System.Drawing.Point(64, 186);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(555, 104);
            this.grp.TabIndex = 11;
            this.grp.TabStop = false;
            this.grp.Text = "CHỌN PHIẾU";
            // 
            // cboChonphieu
            // 
            this.cboChonphieu.FormattingEnabled = true;
            this.cboChonphieu.Location = new System.Drawing.Point(171, 34);
            this.cboChonphieu.Name = "cboChonphieu";
            this.cboChonphieu.Size = new System.Drawing.Size(229, 24);
            this.cboChonphieu.TabIndex = 11;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(33, 33);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(128, 16);
            this.lblMa.TabIndex = 12;
            this.lblMa.Text = "Mã phiếu yêu cầu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskNgay);
            this.groupBox2.Controls.Add(this.txtManhanvien);
            this.groupBox2.Controls.Add(this.txtMaphieu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblMa);
            this.groupBox2.Location = new System.Drawing.Point(64, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 172);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu";
            // 
            // mskNgay
            // 
            this.mskNgay.Location = new System.Drawing.Point(222, 80);
            this.mskNgay.Mask = "00/00/0000";
            this.mskNgay.Name = "mskNgay";
            this.mskNgay.Size = new System.Drawing.Size(192, 22);
            this.mskNgay.TabIndex = 18;
            this.mskNgay.ValidatingType = typeof(System.DateTime);
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(222, 134);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(192, 22);
            this.txtManhanvien.TabIndex = 17;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(222, 26);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(192, 22);
            this.txtMaphieu.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(703, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 232);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.Teal;
            this.btnDuyet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuyet.Location = new System.Drawing.Point(360, 496);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(166, 56);
            this.btnDuyet.TabIndex = 15;
            this.btnDuyet.Text = "DUYỆT";
            this.btnDuyet.UseVisualStyleBackColor = false;
            // 
            // btnKhongduyet
            // 
            this.btnKhongduyet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKhongduyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongduyet.ForeColor = System.Drawing.Color.Teal;
            this.btnKhongduyet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhongduyet.Location = new System.Drawing.Point(639, 496);
            this.btnKhongduyet.Name = "btnKhongduyet";
            this.btnKhongduyet.Size = new System.Drawing.Size(166, 56);
            this.btnKhongduyet.TabIndex = 16;
            this.btnKhongduyet.Text = "KHÔNG DUYỆT";
            this.btnKhongduyet.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Teal;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(913, 496);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 56);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // Duyetyeucau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 618);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhongduyet);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plheader);
            this.Name = "Duyetyeucau";
            this.Text = "Duyetyeucau";
            this.Load += new System.EventHandler(this.Duyetyeucau_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.plheader.ResumeLayout(false);
            this.plheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plheader;
        private System.Windows.Forms.Label lblPhieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboChonphieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskNgay;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Button btnKhongduyet;
        private System.Windows.Forms.Button btnThoat;
    }
}