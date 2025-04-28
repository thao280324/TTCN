namespace thutap
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTheThanhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCaoSoLuongNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCaoUaThich = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuTra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuKiemKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuPhucChe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuYeuCauNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.phêDuyệtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPheDuyetPhieuYeuCau = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "        CHƯƠNG TRÌNH QUẢN LÝ\r\nSÁCH CỦA THƯ VIỆN D FREE BOOK";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDanhmuc,
            this.thốngKêToolStripMenuItem,
            this.đăngKýToolStripMenuItem,
            this.phêDuyệtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDanhmuc
            // 
            this.menuDanhmuc.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLySach,
            this.menuTheThanhVien});
            this.menuDanhmuc.Name = "menuDanhmuc";
            this.menuDanhmuc.Size = new System.Drawing.Size(90, 24);
            this.menuDanhmuc.Text = "Danh mục";
            // 
            // menuQuanLySach
            // 
            this.menuQuanLySach.Name = "menuQuanLySach";
            this.menuQuanLySach.Size = new System.Drawing.Size(308, 26);
            this.menuQuanLySach.Text = "Quản Lý Sách";
            this.menuQuanLySach.Click += new System.EventHandler(this.menuQuanLySach_Click);
            // 
            // menuTheThanhVien
            // 
            this.menuTheThanhVien.Name = "menuTheThanhVien";
            this.menuTheThanhVien.Size = new System.Drawing.Size(308, 26);
            this.menuTheThanhVien.Text = "Quản Lý Thẻ Đăng Ký Thành Viên";
            this.menuTheThanhVien.Click += new System.EventHandler(this.menuTheThanhVien_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBaoCaoSoLuongNhap,
            this.menuBaoCaoUaThich});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // menuBaoCaoSoLuongNhap
            // 
            this.menuBaoCaoSoLuongNhap.Name = "menuBaoCaoSoLuongNhap";
            this.menuBaoCaoSoLuongNhap.Size = new System.Drawing.Size(236, 26);
            this.menuBaoCaoSoLuongNhap.Text = "Báo cáo nhập sách";
            this.menuBaoCaoSoLuongNhap.Click += new System.EventHandler(this.menuBaoCaoSoLuongNhap_Click);
            // 
            // menuBaoCaoUaThich
            // 
            this.menuBaoCaoUaThich.Name = "menuBaoCaoUaThich";
            this.menuBaoCaoUaThich.Size = new System.Drawing.Size(236, 26);
            this.menuBaoCaoUaThich.Text = "Báo cáo sách ưu thích";
            this.menuBaoCaoUaThich.Click += new System.EventHandler(this.menuBaoCaoUaThich_Click);
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.đăngKýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPhieuNhap,
            this.menuPhieuMuon,
            this.menuPhieuTra,
            this.menuPhieuKiemKe,
            this.menuPhieuPhucChe,
            this.menuPhieuYeuCauNhap});
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.đăngKýToolStripMenuItem.Text = "Phiếu";
            // 
            // menuPhieuNhap
            // 
            this.menuPhieuNhap.Name = "menuPhieuNhap";
            this.menuPhieuNhap.Size = new System.Drawing.Size(245, 26);
            this.menuPhieuNhap.Text = "Phiếu Nhập Sách";
            this.menuPhieuNhap.Click += new System.EventHandler(this.menuPhieuNhap_Click);
            // 
            // menuPhieuMuon
            // 
            this.menuPhieuMuon.Name = "menuPhieuMuon";
            this.menuPhieuMuon.Size = new System.Drawing.Size(245, 26);
            this.menuPhieuMuon.Text = "Phiếu Mượn Sách";
            this.menuPhieuMuon.Click += new System.EventHandler(this.menuPhieuMuon_Click);
            // 
            // menuPhieuTra
            // 
            this.menuPhieuTra.Name = "menuPhieuTra";
            this.menuPhieuTra.Size = new System.Drawing.Size(245, 26);
            this.menuPhieuTra.Text = "Phiếu Trả Sách";
            this.menuPhieuTra.Click += new System.EventHandler(this.menuPhieuTra_Click);
            // 
            // menuPhieuKiemKe
            // 
            this.menuPhieuKiemKe.Name = "menuPhieuKiemKe";
            this.menuPhieuKiemKe.Size = new System.Drawing.Size(245, 26);
            this.menuPhieuKiemKe.Text = "Phiếu Kiểm Kê Sách";
            this.menuPhieuKiemKe.Click += new System.EventHandler(this.menuPhieuKiemKe_Click);
            // 
            // menuPhieuPhucChe
            // 
            this.menuPhieuPhucChe.Name = "menuPhieuPhucChe";
            this.menuPhieuPhucChe.Size = new System.Drawing.Size(245, 26);
            this.menuPhieuPhucChe.Text = "Phiếu Tài Liệu Phục Chế";
            this.menuPhieuPhucChe.Click += new System.EventHandler(this.menuPhieuPhucChe_Click);
            // 
            // menuPhieuYeuCauNhap
            // 
            this.menuPhieuYeuCauNhap.Name = "menuPhieuYeuCauNhap";
            this.menuPhieuYeuCauNhap.Size = new System.Drawing.Size(245, 26);
            this.menuPhieuYeuCauNhap.Text = "Phiếu Yêu cầu nhập";
            this.menuPhieuYeuCauNhap.Click += new System.EventHandler(this.menuPhieuYeuCauNhap_Click);
            // 
            // phêDuyệtToolStripMenuItem
            // 
            this.phêDuyệtToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.phêDuyệtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPheDuyetPhieuYeuCau});
            this.phêDuyệtToolStripMenuItem.Name = "phêDuyệtToolStripMenuItem";
            this.phêDuyệtToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.phêDuyệtToolStripMenuItem.Text = "Phê duyệt";
            // 
            // menuPheDuyetPhieuYeuCau
            // 
            this.menuPheDuyetPhieuYeuCau.Name = "menuPheDuyetPhieuYeuCau";
            this.menuPheDuyetPhieuYeuCau.Size = new System.Drawing.Size(226, 26);
            this.menuPheDuyetPhieuYeuCau.Text = "Duyệt phiếu yêu cầu";
            this.menuPheDuyetPhieuYeuCau.Click += new System.EventHandler(this.menuPheDuyetPhieuYeuCau_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 36);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(612, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phần mềm quản lý sách-Thư viện D FREE BOOK";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.BackColor = System.Drawing.Color.MistyRose;
            this.txtTendangnhap.Location = new System.Drawing.Point(589, 5);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(135, 22);
            this.txtTendangnhap.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLySach;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTheThanhVien;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuMuon;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuTra;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCaoSoLuongNhap;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCaoUaThich;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuKiemKe;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuPhucChe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem phêDuyệtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPheDuyetPhieuYeuCau;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuYeuCauNhap;
        private System.Windows.Forms.TextBox txtTendangnhap;
    }
}

