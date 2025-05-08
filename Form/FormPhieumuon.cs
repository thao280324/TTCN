using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thutap.Class;
using Excel = Microsoft.Office.Interop.Excel;

namespace thutap
{
    public partial class FormPhieumuon : Form
    {
        private string vaiTro;
        DataTable tblCTTT;
        public FormPhieumuon(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void FormPhieumuon_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoaHoaDon.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaThue.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            dtpNgaymuon.Enabled = false;
            txtTenSach.ReadOnly = true;
          //  txtSoLuong.ReadOnly = true;
            txtTenTinhTrang.ReadOnly = true;
            EnableAutoComplete();

            Class.function.FillCombo2("select Mathanhvien,Tenthanhvien from thanhvien", cboMaKH, "Mathanhvien", "Tenthanhvien");
            cboMaKH.SelectedIndex = -1;
            Class.function.FillCombo2("select Manhanvien,Tennhanvien from nhanvien", cboMaNV, "Manhanvien", "Tennhanvien");
            cboMaNV.SelectedIndex = -1;
            Class.function.FillCombo2("select Masach,Tensach from sach", cboMaSach, "Masach", "Tensach");
            cboMaSach.SelectedIndex = -1;
            Class.function.FillCombo2("select Matinhtrang,tentinhtrang from tinhtrang", cboMaTinhTrang, "Matinhtrang", "Tentinhtrang");
            cboMaTinhTrang.SelectedIndex = -1;
            Class.function.FillCombo2("select Maphieumuon from chitietmuon", cboPhieumuon, "Maphieumuon", "Maphieumuon");
            cboPhieumuon.SelectedIndex = -1;
            if (txtMaThue.Text != "")
            {
                Load_thongtin();
                btnXoaHoaDon.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            load_datagridviewchitiet();
        }
        private void EnableAutoComplete()
        {
            cboMaNV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Gợi ý và thêm vào
            cboMaNV.AutoCompleteSource = AutoCompleteSource.ListItems;  // Lấy dữ liệu từ Items của ComboBox
            cboMaKH.AutoCompleteMode= AutoCompleteMode.SuggestAppend;
            cboMaKH.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaSach.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMaTinhTrang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaTinhTrang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboPhieumuon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPhieumuon.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void PhanQuyenChucNang()
        {
            vaiTro = vaiTro.Trim();  // Loại bỏ khoảng trắng
            // Kiểm tra vai trò và phân quyền cho các nút
            if (vaiTro == "Nhân viên thủ thư")
            {
                // Nhân viên thủ thư có quyền thao tác tất cả các nút
                btnThem.Enabled = true;
                btnXoaHoaDon.Enabled = true;
                btnLuu.Enabled = true;
                btnInHoaDon.Enabled = true;
                btnThoatphieu.Enabled = true;
                btnTimkiemphieumuon.Enabled = true;
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                // Phó ban và Trưởng ban chỉ có quyền tìm kiếm và in danh sách
                btnThem.Enabled = false;
                btnXoaHoaDon.Enabled = false;
                btnLuu.Enabled = false;
                btnInHoaDon.Enabled = true;
                btnThoatphieu.Enabled = true;
                btnTimkiemphieumuon.Enabled = true;
                cboMaNV.Enabled = false;
                cboMaSach.Enabled = false;
                cboMaTinhTrang.Enabled = false;
                cboMaKH.Enabled = false;
                cboPhieumuon.Enabled=true;
                txtMaThue.Enabled = false;
                txtTenKH.Enabled = false;
                txtTenTinhTrang.Enabled=false;
                rdoOff.Enabled = false ;
                rdoOnl.Enabled = false;
                txtSoLuong.Enabled = false;
                txtTenNV.Enabled = false;
                txtTenSach.Enabled = false;
                dtpNgaymuon.Enabled = false;
                txtTong.Enabled = false;
            }
            else
            {
                // Nếu không có vai trò hợp lệ, đóng form
                MessageBox.Show("Bạn không có quyền truy cập vào form này!");
                this.Close();
            }
        }
        private void ResetValues()
        {
            txtMaThue.Text = "";
            dtpNgaymuon.Text = DateTime.Now.ToShortDateString();
            cboMaNV.Text = "";
            txtTenNV.Text = "";
            cboMaKH.Text = "";
            txtTenKH.Text = "";
           // rdoOff.Text = "";
           // rdoOnl.Text = "";
            txtTong.Text = "0";
        }
        private void ResetValuesHang()
        {
            cboMaSach.Text = "";
            txtTenSach.Text = "";
            txtSoLuong.Text = "";
            cboMaTinhTrang.Text = "";
            txtTenTinhTrang.Text = "";
            cboMaSach.Focus();
        }
        private void btnThoatphieu_Click(object sender, EventArgs e)
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
        private void load_datagridviewchitiet()
        {
            string sql;
            sql = "select a.Masach, b.Tensach, a.Soluong, a.Matinhtrang, c.Tentinhtrang " +
                         "from chitietmuon as a " +
                         "join sach as b on a.Masach = b.Masach " +
                         "join tinhtrang as c on a.Matinhtrang = c.Matinhtrang " +
                         "where a.Maphieumuon = N'" + txtMaThue.Text + "'";
            tblCTTT = Class.function.GetDataToTable(sql);
            datagridThue.DataSource = tblCTTT;
            datagridThue.Columns[0].HeaderText = "Mã sách";
            datagridThue.Columns[1].HeaderText = "Tên sách";
            datagridThue.Columns[2].HeaderText = "Số lượng";
            datagridThue.Columns[3].HeaderText = "Mã tình trạng";
            datagridThue.Columns[4].HeaderText = "Tên tình trạng";
            datagridThue.AllowUserToAddRows = false;
            datagridThue.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_thongtin()
        {
            string str;

            // Lấy ngày mượn từ bảng phieumuon
            // Lấy ngày mượn từ bảng phieumuon
            str = "SELECT Ngaymuon FROM phieumuon WHERE Maphieumuon = '" + txtMaThue.Text + "'";
            string ngay = Class.function.GetFieldValues(str);
            DateTime d;
            if (DateTime.TryParse(ngay, out d))
            {
                dtpNgaymuon.Value = d;
            }
            else
            {
                // nếu không parse được thì để Today hoặc bạn có thể show warning
                dtpNgaymuon.Value = DateTime.Today;
            }


            // Lấy mã nhân viên từ bảng phieumuon
            str = "SELECT Manhanvien FROM phieumuon WHERE Maphieumuon = '" + txtMaThue.Text + "'";
            cboMaNV.Text = Class.function.GetFieldValues(str);

            // Lấy tên nhân viên từ bảng nhanvien
            str = "SELECT Tennhanvien FROM nhanvien WHERE Manhanvien = '" + cboMaNV.Text + "'";
            txtTenNV.Text = Class.function.GetFieldValues(str);

            
            str = "SELECT Mathanhvien FROM phieumuon WHERE Maphieumuon = '" + txtMaThue.Text + "'";
            cboMaKH.Text = Class.function.GetFieldValues(str);

            
            str = "SELECT Tenthanhvien FROM thanhvien WHERE Mathanhvien = '" + cboMaKH.Text + "'";
            txtTenKH.Text = Class.function.GetFieldValues(str);

            // Lấy hình thức mượn từ bảng phieumuon (Offline hoặc Online)
            str = "SELECT Hinhthucmuon FROM phieumuon WHERE Maphieumuon = '" + txtMaThue.Text + "'";
            if (function.GetFieldValues(str) == "Offline")
            {
                rdoOff.Checked = true;
            }
            else
            {
                rdoOnl.Checked = true;
            }
        }

        private void btnThemphieumuon_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoaHoaDon.Enabled = false;
            btnLuu.Enabled = true;
            cboMaNV.Enabled = true;
            cboPhieumuon.Text = "";
            txtSoLuong.Enabled = true;
            cboMaNV.Enabled = true;
            cboMaSach.Enabled = true;
            cboMaKH.Enabled= true;
            ResetValues();
            txtMaThue.Text = function.CreateKey("PM");
            load_datagridviewchitiet();
            rdoOff.Enabled=true;
            rdoOnl.Enabled=true;
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select Tennhanvien from nhanvien where Manhanvien =N'" +
cboMaNV.Text + "'";
            txtTenNV.Text = function.GetFieldValues(str);

        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
            }
            str = "Select Tenthanhvien from thanhvien where Mathanhvien=N'" + cboMaKH.Text + "'";
            txtTenKH.Text = Class.function.GetFieldValues(str);
        }

        private void cboMaSach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaSach.Text == "")
            {
                txtTenSach.Text = "";
            }
            str = "Select Tensach from sach where Masach=N'" + cboMaSach.Text + "'";
            txtTenSach.Text = Class.function.GetFieldValues(str);
        }

        private void cboMaTinhTrang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaTinhTrang.Text == "")
            {
                txtTenTinhTrang.Text = "";
            }
            str = "select Tentinhtrang from tinhtrang where Matinhtrang=N'" + cboMaTinhTrang.Text + "'";
            txtTenTinhTrang.Text = Class.function.GetFieldValues(str);
        }

        private void btnTimkiemphieumuon_Click(object sender, EventArgs e)
        {
            if (cboPhieumuon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã phiếu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtMaThue.Text = cboPhieumuon.SelectedValue.ToString();
            Load_thongtin();
            load_datagridviewchitiet();

            string sql = "SELECT SUM(CAST(Soluong AS INT)) FROM chitietmuon WHERE Maphieumuon = N'" + txtMaThue.Text + "'";
            string tongSoLuong = function.GetFieldValues(sql);
            txtTong.Text = tongSoLuong;

            btnXoaHoaDon.Enabled = true;
            btnInHoaDon.Enabled = true;
            txtSoLuong.Enabled = false;
            dtpNgaymuon.Enabled = false;
            cboMaNV.Enabled = false;
            cboMaSach.Enabled = false;
        }

        private void datagridThue_DoubleClick(object sender, EventArgs e)
        { // Lấy mã sách từ cột Masach (cột này cần khớp với tên trong DataGridView)
            string masach = datagridThue.CurrentRow.Cells["Masach"].Value.ToString();
            string soluong = datagridThue.CurrentRow.Cells["Soluong"].Value.ToString();

            // Kiểm tra nếu DataGridView không có dữ liệu
            if (datagridThue.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cảnh báo và xác nhận xóa sách khỏi phiếu
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xóa sách khỏi chi tiết phiếu mượn
                string sql = "DELETE FROM chitietmuon " +
                             "WHERE Maphieumuon=N'" + txtMaThue.Text.Trim() + "' " +
                             "AND Masach=N'" + masach + "'";
                function.RunSql(sql);
                sql = "UPDATE sach SET Soluong = Soluong + " + soluong + " WHERE Masach = N'" + masach + "'";
                function.RunSql(sql);

                // Cập nhật lại tổng số lượng sách trong phiếu
                txtTong.Text = function.GetFieldValues(
                    "SELECT SUM(CAST(Soluong AS INT)) FROM chitietmuon " +
                    "WHERE Maphieumuon=N'" + txtMaThue.Text.Trim() + "'");

                // Cập nhật lại DataGridView
                load_datagridviewchitiet();
            }
        }

        private void cboPhieumuon_DropDown(object sender, EventArgs e)
        {
            // Cập nhật lại danh sách các mã phiếu yêu cầu vào cboTimkiemphieunhap
            function.FillCombo2("SELECT Maphieumuon FROM phieumuon",
                                cboPhieumuon, "Maphieumuon", "Maphieumuon");

            // Đặt chỉ số của combo box về -1, tức là không có mục nào được chọn
            cboPhieumuon.SelectedIndex = -1;
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string masach = datagridThue.CurrentRow.Cells["Masach"].Value.ToString();
                string soluong = datagridThue.CurrentRow.Cells["Soluong"].Value.ToString();

                // Xóa chi tiết phiếu mượn trong bảng chitietmuon trước
                string sqlDeleteChiTiet = "DELETE FROM chitietmuon WHERE Maphieumuon = N'" + txtMaThue.Text.Trim() + "'";
                function.RunSql(sqlDeleteChiTiet);

                // Sau khi xóa chi tiết, xóa phiếu mượn trong bảng phieumuon
                string sqlDeletePhieu = "DELETE FROM phieumuon WHERE Maphieumuon = N'" + txtMaThue.Text.Trim() + "'";
                function.RunSql(sqlDeletePhieu);

                // Cập nhật lại số lượng sách trong bảng sach
                sqlDeletePhieu = "UPDATE sach SET Soluong = Soluong + " + soluong + " WHERE Masach = N'" + masach + "'";
                function.RunSql(sqlDeletePhieu);

                MessageBox.Show("Phiếu đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValues();
                load_datagridviewchitiet();

                btnXoaHoaDon.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                cboPhieumuon.Text = "";
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (datagridThue.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Không thể kích hoạt Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var workbook = excelApp.Workbooks.Add(Missing.Value);
            var worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            worksheet.Name = "DanhSachPhieuMuon";

            worksheet.Range["A1"].Value = "Phiếu mượn sách của thư viện";
            worksheet.Range["A1:E1"].Merge();
            worksheet.Range["A1"].Font.Size = 16;
            worksheet.Range["A1"].Font.Bold = true;
            worksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            worksheet.Cells[2, 1].Value = "Mã phiếu";
            worksheet.Cells[2, 2].Value = "Tổng số sách";

            worksheet.Cells[3, 1].Value = txtMaThue.Text.Trim();
            worksheet.Cells[3, 2].Value = txtTong.Text.Trim();

            worksheet.Cells[4, 1].Value = "DANH SÁCH SÁCH MƯỢN";
            worksheet.Range["A4:E4"].Merge();
            worksheet.Cells[4, 1].Font.Size = 12;
            worksheet.Cells[4, 1].Font.Bold = true;
            worksheet.Cells[4, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            worksheet.Cells[5, 1].Value = "Mã sách";
            worksheet.Cells[5, 2].Value = "Tên sách";
            worksheet.Cells[5, 3].Value = "Số lượng";

            for (int i = 0; i < datagridThue.Rows.Count; i++)
            {
                worksheet.Cells[i + 6, 1].Value = datagridThue.Rows[i].Cells[0].Value.ToString();
                worksheet.Cells[i + 6, 2].Value = datagridThue.Rows[i].Cells[1].Value.ToString();
                worksheet.Cells[i + 6, 3].Value = datagridThue.Rows[i].Cells[2].Value.ToString();
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin bắt buộc
            if (txtMaThue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThue.Focus();
                return;
            }

            if (dtpNgaymuon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaymuon.Focus();
                return;
            }

            if (cboMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }

            if (cboMaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSach.Focus();
                return;
            }

            if (txtSoLuong.Text.Trim().Length == 0 || Convert.ToInt32(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng sách phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (cboMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaKH.Focus();
                return;
            }
            if (cboMaTinhTrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã tình trạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTinhTrang.Focus();
                return;
            }

            // Kiểm tra ngày mượn
            DateTime ngaymuon = DateTime.ParseExact(dtpNgaymuon.Text.Trim(), "dd/MM/yyyy", null);

            // Kiểm tra mã phiếu mượn đã tồn tại chưa
            string sql = "SELECT Maphieumuon FROM phieumuon WHERE Maphieumuon=N'" + txtMaThue.Text.Trim() + "'";
            if (!function.CheckKey(sql))
            {
                // Nếu mã phiếu chưa tồn tại, thêm phiếu mượn mới vào bảng phieumuon
                sql = "INSERT INTO phieumuon(Maphieumuon, Ngaymuon, Manhanvien, Mathanhvien, Hinhthucmuon) VALUES(" +
           "N'" + txtMaThue.Text.Trim() + "', " +
           "'" + ngaymuon.ToString("yyyy-MM-dd") + "', " +
           "N'" + cboMaNV.SelectedValue + "', " + // Mathanhvien được thêm vào đây
           "N'" + cboMaKH.SelectedValue + "', " +  // Đảm bảo rằng bạn có cboMaThanhVien để lấy giá trị
           "N'" + (rdoOff.Checked ? "Offline" : "Online") + "')";
                function.RunSql(sql);
            }

            // Kiểm tra mã sách và số lượng trước khi thêm vào chi tiết
            if (cboMaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSach.Focus();
                return;
            }

            if (txtSoLuong.Text.Trim().Length == 0 || Convert.ToInt32(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // Cập nhật số lượng sách trong bảng sách
            sql = "UPDATE sach SET Soluong = Soluong - " + txtSoLuong.Text.Trim() + " WHERE Masach = N'" + cboMaSach.SelectedValue + "'";
            function.RunSql(sql);

            // Thêm chi tiết phiếu mượn vào bảng chitietmuon
            sql = "INSERT INTO chitietmuon (Maphieumuon, Masach, Soluong, Matinhtrang) " +
                  "VALUES (N'" + txtMaThue.Text.Trim() + "', " +
                  "N'" + cboMaSach.SelectedValue + "', " +
                  "CAST(" + txtSoLuong.Text.Trim() + " AS INT), N'" + cboMaTinhTrang.SelectedValue + "')";
            function.RunSql(sql);

            // Cập nhật tổng số lượng sách mượn trong phiếu mượn
            txtTong.Text = function.GetFieldValues("SELECT SUM(CAST(Soluong AS INT)) FROM chitietmuon WHERE Maphieumuon=N'" + txtMaThue.Text + "'");
            // Cập nhật lại dữ liệu DataGridView
            load_datagridviewchitiet();

            // Kích hoạt các nút chức năng
            btnXoaHoaDon.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
            dtpNgaymuon.Enabled = false;
            cboMaNV.Enabled = false;
            cboMaKH.Enabled = false;
            cboMaSach.Text = "";
            txtTenSach.Text = "";
            txtSoLuong.Text = "";
            cboMaTinhTrang.Text = "";
            txtTenTinhTrang.Text = "";
        }

        private void cboPhieumuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
