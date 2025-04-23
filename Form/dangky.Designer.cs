namespace thutap
{
    partial class dangky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangky));
            this.plheader = new System.Windows.Forms.Panel();
            this.lblPhieumuon = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plheader
            // 
            this.plheader.BackColor = System.Drawing.Color.Turquoise;
            this.plheader.Controls.Add(this.lblPhieumuon);
            this.plheader.Controls.Add(pictureBox1);
            this.plheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plheader.Location = new System.Drawing.Point(0, 0);
            this.plheader.Name = "plheader";
            this.plheader.Size = new System.Drawing.Size(1274, 114);
            this.plheader.TabIndex = 7;
            // 
            // lblPhieumuon
            // 
            this.lblPhieumuon.AutoSize = true;
            this.lblPhieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieumuon.ForeColor = System.Drawing.Color.Snow;
            this.lblPhieumuon.Location = new System.Drawing.Point(75, 9);
            this.lblPhieumuon.Name = "lblPhieumuon";
            this.lblPhieumuon.Size = new System.Drawing.Size(968, 69);
            this.lblPhieumuon.TabIndex = 0;
            this.lblPhieumuon.Text = "PHIẾU TÀI LIỆU CẦN PHỤC CHẾ\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(1087, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(144, 111);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 631);
            this.Controls.Add(this.plheader);
            this.Name = "dangky";
            this.Text = "dangky";
            this.plheader.ResumeLayout(false);
            this.plheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plheader;
        private System.Windows.Forms.Label lblPhieumuon;
    }
}