namespace thutap
{
    partial class Baocaonhapsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocaonhapsach));
            this.plheader = new System.Windows.Forms.Panel();
            this.lblPhieunhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBaocao = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttungay = new System.Windows.Forms.MaskedTextBox();
            this.txtdenngay = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.plheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(699, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(105, 69);
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
            this.plheader.Size = new System.Drawing.Size(804, 85);
            this.plheader.TabIndex = 7;
            // 
            // lblPhieunhap
            // 
            this.lblPhieunhap.AutoSize = true;
            this.lblPhieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieunhap.ForeColor = System.Drawing.Color.Snow;
            this.lblPhieunhap.Location = new System.Drawing.Point(58, 29);
            this.lblPhieunhap.Name = "lblPhieunhap";
            this.lblPhieunhap.Size = new System.Drawing.Size(580, 38);
            this.lblPhieunhap.TabIndex = 0;
            this.lblPhieunhap.Text = "BÁO CÁO SỐ LƯỢNG NHẬP SÁCH\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày:";
            // 
            // dgvBaocao
            // 
            this.dgvBaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaocao.Location = new System.Drawing.Point(85, 167);
            this.dgvBaocao.Name = "dgvBaocao";
            this.dgvBaocao.RowHeadersWidth = 51;
            this.dgvBaocao.RowTemplate.Height = 24;
            this.dgvBaocao.Size = new System.Drawing.Size(600, 162);
            this.dgvBaocao.TabIndex = 8;
            this.dgvBaocao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(131, 354);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 22);
            this.txtsoluong.TabIndex = 13;
            // 
            // txttungay
            // 
            this.txttungay.Location = new System.Drawing.Point(131, 104);
            this.txttungay.Mask = "00/00/0000";
            this.txttungay.Name = "txttungay";
            this.txttungay.Size = new System.Drawing.Size(100, 22);
            this.txttungay.TabIndex = 14;
            this.txttungay.ValidatingType = typeof(System.DateTime);
            // 
            // txtdenngay
            // 
            this.txtdenngay.Location = new System.Drawing.Point(131, 130);
            this.txtdenngay.Mask = "00/00/0000";
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Size = new System.Drawing.Size(100, 22);
            this.txtdenngay.TabIndex = 15;
            this.txtdenngay.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-248, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 43);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(612, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phần mềm quản lý sách-Thư viện D FREE BOOK";
            // 
            // btnIn
            // 
            this.button1.Location = new System.Drawing.Point(290, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "In báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(467, 368);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 18;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThoat
            // 
            this.button3.Location = new System.Drawing.Point(591, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Baocaonhapsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtdenngay);
            this.Controls.Add(this.txttungay);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBaocao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plheader);
            this.Name = "Baocaonhapsach";
            this.Text = "Baocaonhapsach";
            this.Load += new System.EventHandler(this.Baocaonhapsach_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.plheader.ResumeLayout(false);
            this.plheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plheader;
        private System.Windows.Forms.Label lblPhieunhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBaocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.MaskedTextBox txttungay;
        private System.Windows.Forms.MaskedTextBox txtdenngay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnThoat;
    }
}