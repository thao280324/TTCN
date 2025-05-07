namespace thutap
{
    partial class Baocaouuthich
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox picLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocaouuthich));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtacgia = new System.Windows.Forms.RadioButton();
            this.rdbtheloai = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtdenngay = new System.Windows.Forms.DateTimePicker();
            this.dttungay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btntim = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            picLogo.Location = new System.Drawing.Point(709, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(90, 69);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(picLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 87);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO SÁCH ĐƯỢC ƯA THÍCH NHẤT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtacgia);
            this.groupBox1.Controls.Add(this.rdbtheloai);
            this.groupBox1.Location = new System.Drawing.Point(32, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách được mượn nhiều nhất theo";
            // 
            // rdbtacgia
            // 
            this.rdbtacgia.AutoSize = true;
            this.rdbtacgia.Location = new System.Drawing.Point(6, 73);
            this.rdbtacgia.Name = "rdbtacgia";
            this.rdbtacgia.Size = new System.Drawing.Size(74, 20);
            this.rdbtacgia.TabIndex = 3;
            this.rdbtacgia.Text = "Tác giả";
            this.rdbtacgia.UseVisualStyleBackColor = true;
            // 
            // rdbtheloai
            // 
            this.rdbtheloai.AutoSize = true;
            this.rdbtheloai.Location = new System.Drawing.Point(6, 47);
            this.rdbtheloai.Name = "rdbtheloai";
            this.rdbtheloai.Size = new System.Drawing.Size(77, 20);
            this.rdbtheloai.TabIndex = 2;
            this.rdbtheloai.Text = "Thể loại";
            this.rdbtheloai.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtdenngay);
            this.groupBox2.Controls.Add(this.dttungay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian";
            // 
            // dtdenngay
            // 
            this.dtdenngay.Location = new System.Drawing.Point(71, 65);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new System.Drawing.Size(200, 22);
            this.dtdenngay.TabIndex = 7;
            // 
            // dttungay
            // 
            this.dttungay.Location = new System.Drawing.Point(71, 31);
            this.dttungay.Name = "dttungay";
            this.dttungay.Size = new System.Drawing.Size(200, 22);
            this.dttungay.TabIndex = 3;
            this.dttungay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ ngày:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 266);
            this.dataGridView1.TabIndex = 5;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(22, 315);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 9;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(111, 315);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 10;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(111, 356);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 11;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(22, 356);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(75, 23);
            this.btntimlai.TabIndex = 12;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-157, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 50);
            this.panel2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(612, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phần mềm quản lý sách-Thư viện D FREE BOOK";
            // 
            // Baocaouuthich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Baocaouuthich";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Baocaouuthich_Load);
            ((System.ComponentModel.ISupportInitialize)(picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtheloai;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtacgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtdenngay;
        private System.Windows.Forms.DateTimePicker dttungay;
    }
}