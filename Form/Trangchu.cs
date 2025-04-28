using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thutap
{
    public partial class FrmMain : Form
    {
        private string vaiTro;
        private string tenDangNhap;

        public FrmMain(string tenDangNhap, string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
            this.tenDangNhap = tenDangNhap;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtTendangnhap.Text = tenDangNhap;
            txtTendangnhap.ReadOnly = true;
            PhanQuyenNguoiDung();
        }
        private void PhanQuyenNguoiDung()
        {
            // Ẩn tất cả menu trước
            AnTatCaMenu();

            string vtro = vaiTro.Trim();  // Loại bỏ khoảng trắng

            if (vtro == "Nhân viên thủ thư")
            {
                HienThiTatCaMenu();
                menuPheDuyetPhieuYeuCau.Visible = false;
            }
            else if (vtro == "Phó ban thủ thư")
            {
                HienThiTatCaMenu();
                menuPhieuYeuCauNhap.Visible = false;
                menuPheDuyetPhieuYeuCau.Visible = false;
            }
            else if (vtro == "Trưởng ban thủ thư")
            {
                AnTatCaMenu();
                menuPheDuyetPhieuYeuCau.Visible = true;
                menuBaoCaoSoLuongNhap.Visible = true;
                menuBaoCaoUaThich.Visible = true;
            }
            else
            {
                MessageBox.Show("Vai trò không hợp lệ!", "Lỗi");
                this.Close();
            }
        }
        private void AnTatCaMenu()
        {
            menuQuanLySach.Visible = false;
            menuTheThanhVien.Visible = false;
            menuPhieuMuon.Visible = false;
            menuPhieuTra.Visible = false;
            menuPhieuNhap.Visible = false;
            menuPhieuKiemKe.Visible = false;
            menuPhieuPhucChe.Visible = false;
            menuPhieuYeuCauNhap.Visible = false;
            menuPheDuyetPhieuYeuCau.Visible = false;
            menuBaoCaoSoLuongNhap.Visible = false;
            menuBaoCaoUaThich.Visible = false;
        }
        private void HienThiTatCaMenu()
        {
            menuQuanLySach.Visible = true;
            menuTheThanhVien.Visible = true;
            menuPhieuMuon.Visible = true;
            menuPhieuTra.Visible = true;
            menuPhieuNhap.Visible = true;
            menuPhieuKiemKe.Visible = true;
            menuPhieuPhucChe.Visible = true;
            menuPhieuYeuCauNhap.Visible = true;
            menuBaoCaoSoLuongNhap.Visible = true;
            menuBaoCaoUaThich.Visible = true;
        }

        private void menuQuanLySach_Click(object sender, EventArgs e)
        {
            Sach frm = new Sach(vaiTro);
            frm.ShowDialog();
        }

        private void menuTheThanhVien_Click(object sender, EventArgs e)
        {
            Dangkythanhvien frm = new Dangkythanhvien(vaiTro);
            frm.ShowDialog();
        }

        private void menuBaoCaoSoLuongNhap_Click(object sender, EventArgs e)
        {
            Baocaonhapsach frm = new Baocaonhapsach(vaiTro);
            frm.ShowDialog();
        }

        private void menuBaoCaoUaThich_Click(object sender, EventArgs e)
        {
            Baocaouuthich frm = new Baocaouuthich(vaiTro);
            frm.ShowDialog();
        }

        private void menuPhieuNhap_Click(object sender, EventArgs e)
        {
            FormNhapsach frm = new FormNhapsach(vaiTro);
            frm.ShowDialog();
        }

        private void menuPhieuMuon_Click(object sender, EventArgs e)
        {
            FormPhieumuon frm = new FormPhieumuon(vaiTro);
            frm.ShowDialog();
        }

        private void menuPhieuTra_Click(object sender, EventArgs e)
        {
            FormPhieutra frm = new FormPhieutra(vaiTro);
            frm.ShowDialog();
        }

        private void menuPhieuKiemKe_Click(object sender, EventArgs e)
        {
            Phieukiemke frm = new Phieukiemke(vaiTro);
            frm.ShowDialog();
        }

        private void menuPhieuPhucChe_Click(object sender, EventArgs e)
        {
            Phieuphucche frm = new Phieuphucche(vaiTro);
            frm.ShowDialog();
        }

        private void menuPhieuYeuCauNhap_Click(object sender, EventArgs e)
        {
            Yeucaunhap frm = new Yeucaunhap(vaiTro);
            frm.ShowDialog();
        }

        private void menuPheDuyetPhieuYeuCau_Click(object sender, EventArgs e)
        {
            Duyetyeucau frm = new Duyetyeucau(vaiTro);
            frm.ShowDialog();
        }
    }
}

