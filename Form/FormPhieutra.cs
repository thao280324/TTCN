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
    public partial class FormPhieutra : Form
    {
        private string vaiTro;
        public FormPhieutra(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void FormPhieutra_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
        }
        private void PhanQuyenChucNang()
        {
            vaiTro = vaiTro.Trim();  // Loại bỏ khoảng trắng

            // Kiểm tra vai trò và phân quyền cho các nút
            if (vaiTro == "Nhân viên thủ thư")
            {
                // Nhân viên thủ thư có quyền thao tác tất cả các nút
                btnThemmoi.Enabled = true;
                btnXoaphieu.Enabled = true;
                btnLuuphieu.Enabled = true;
                btnInphieu.Enabled = true;
                btnThoat.Enabled = true;
                btnTimkiemphieumuon.Enabled = true;
                btnTimphieutra.Enabled=true;
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                // Phó ban và Trưởng ban chỉ có quyền tìm kiếm và in danh sách
                btnThemmoi.Enabled = false;
                btnXoaphieu.Enabled = false;
                btnLuuphieu.Enabled = false;
                btnInphieu.Enabled = true;
                btnThoat.Enabled = true;
                btnTimkiemphieumuon.Enabled = false;
                btnTimphieutra.Enabled = true;
                cboManhanvien.Enabled = false;
                cboThanhvien.Enabled = false;
                mskNgaymuon.Enabled = false;
                mskNgaytra.Enabled = false; 
                txtTong.Enabled = false;
                chkVipham.Enabled = false;
                cboMavipham.Enabled = false;
                txtTenvipham.Enabled = false;
                txtSongaymuon.Enabled = false;
                cboTimkiemphieumuon.Enabled = false;
                txtMaphieutra.Enabled=false;
                cboPhieutra.Enabled=true;
            }
            else
            {
                // Nếu không có vai trò hợp lệ, đóng form
                MessageBox.Show("Bạn không có quyền truy cập vào form này!");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Bạn đang thao tác trên dữ liệu.\nNếu bạn đóng lại bây giờ, mọi thay đổi chưa lưu sẽ bị mất.\n\nBạn có chắc chắn muốn thoát không?",
      "Xác nhận thoát",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
  );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
