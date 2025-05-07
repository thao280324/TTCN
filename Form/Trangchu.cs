using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Class.function.Connect();
        }
        private void PhanQuyenNguoiDung()
        {

            string vtro = vaiTro.Trim();  // Loại bỏ khoảng trắng

            // Quản lý menu phân quyền cho từng vai trò
            if (vtro == "Nhân viên thủ thư")
            {
                HienThiTatCaMenu(); // Hiển thị tất cả các menu
                menuPheDuyetPhieuYeuCau.Visible = false;  // Nhân viên không thể xem form Phê duyệt phiếu yêu cầu
            }
            else if (vtro == "Phó ban thủ thư")
            {
                HienThiTatCaMenu();
                // Phó ban chỉ được phép thao tác với tìm kiếm, in phiếu
                menuPhieuMuon.Visible = true;    // Không thêm sửa xóa phiếu
                menuPhieuTra.Visible = true;     // Không thêm sửa xóa phiếu
                menuPhieuNhap.Visible = true;    // Không thêm sửa xóa phiếu
                menuPhieuKiemKe.Visible = true; // Không thêm sửa xóa phiếu
                menuPhieuPhucChe.Visible =true;// Không thêm sửa xóa phiếu
                menuBaoCaoSoLuongNhap.Visible = true;
                menuBaoCaoUaThich.Visible = true;
                menuQuanLySach.Visible = true;
                menuTheThanhVien.Visible = true;

                // Các form còn lại như tìm kiếm, in thì vẫn cho phép
                menuPhieuYeuCauNhap.Visible = false;
                menuPheDuyetPhieuYeuCau.Visible = false;  // Không có quyền phê duyệt
            }
            else if (vtro == "Trưởng ban thủ thư")
            {
                menuPheDuyetPhieuYeuCau.Visible = true; // Trưởng ban có quyền duyệt phiếu
                menuBaoCaoSoLuongNhap.Visible = true;
                menuBaoCaoUaThich.Visible = true;
                menuQuanLySach.Visible = true;
                menuTheThanhVien.Visible = true;

                // Trưởng ban chỉ có quyền xem báo cáo và duyệt phiếu yêu cầu
                menuPhieuMuon.Enabled = false;    // Không thao tác phiếu
                menuPhieuTra.Enabled = false;     // Không thao tác phiếu
                menuPhieuNhap.Enabled = false;    // Không thao tác phiếu
                menuPhieuKiemKe.Enabled = false; // Không thao tác phiếu
                menuPhieuPhucChe.Enabled = false;// Không thao tác phiếu
                menuPhieuYeuCauNhap.Enabled = false;

            }
            else
            {
                MessageBox.Show("Vai trò không hợp lệ!", "Lỗi");
                this.Close();
            }
        }
        private void HienThiTatCaMenu()
        {
            // Hiển thị tất cả menu khi là Nhân viên hoặc Phó ban
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
            menuPheDuyetPhieuYeuCau.Visible = false;
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

        private void txtTendangnhap_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát và quay lại trang đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng Trang chủ (FormMain)
                this.Hide();

                // Mở FormDangNhap trong một Thread mới
                Thread thread = new Thread(new ThreadStart(OpenDangNhapForm));
                thread.Start();
            }
            else
            {
                // Không làm gì, ở lại trang chủ
                return;
            }

        }
        private void OpenDangNhapForm()
        {
            // Mở lại FormDangNhap sau khi đóng FormMain
            Application.Run(new Dangnhap());
        }
    }
}

