using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using thutap.Class;
using Excel = Microsoft.Office.Interop.Excel;

namespace thutap
{
    public partial class FormNhapsach : Form
    {
        private string vaiTro;
        DataTable tblCTPhieuNhapSach;
        public FormNhapsach(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void FormNhapsach_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
            btnThemphieunhap.Enabled = true;
            btnLuuphieunhap.Enabled = false;
            btnXoaphieunhap.Enabled = false;
            btnInphieunhap.Enabled = false;
            txtMaphieunhap.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTensach.ReadOnly = true;
           // txtGhichu.ReadOnly = true;
            txtTong.ReadOnly = true;

            Class.function.FillCombo2("select Manhanvien, Tennhanvien from nhanvien", cboManhanvien, "Manhanvien", "Tennhanvien");
            cboManhanvien.SelectedIndex = -1;
            Class.function.FillCombo2("select Masach, Tensach from sach", cboMasach, "Masach", "Tensach");
            cboMasach.SelectedIndex = -1;
            Class.function.FillCombo2("select Maphieunhap from phieunhap", cboTimkiemphieunhap, "Maphieunhap", "Maphieunhap");
            cboTimkiemphieunhap.SelectedIndex = -1;
            if (txtMaphieunhap.Text != "")
            {
                Load_Thongtin();
                btnXoaphieunhap.Enabled = true;
                btnInphieunhap.Enabled = true;
            }
            Load_DataGridViewChitiet();
            EnableAutoComplete();
        }
        private void EnableAutoComplete()
        {
            cboTimkiemphieunhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Gợi ý và thêm vào
            cboTimkiemphieunhap.AutoCompleteSource = AutoCompleteSource.ListItems;  // Lấy dữ liệu từ Items của ComboBox
            cboMasach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Gợi ý và thêm vào
            cboMasach.AutoCompleteSource = AutoCompleteSource.ListItems;  // Lấy dữ liệu từ Items của ComboBox
            cboManhanvien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Gợi ý và thêm vào
            cboManhanvien.AutoCompleteSource = AutoCompleteSource.ListItems;  // Lấy dữ liệu từ Items của ComboBox

        }
        private void PhanQuyenChucNang()
        {
            vaiTro = vaiTro.Trim();  // Loại bỏ khoảng trắng

            // Kiểm tra vai trò và phân quyền cho các nút
            if (vaiTro == "Nhân viên thủ thư")
            {
                // Nhân viên thủ thư có quyền thao tác tất cả các nút
                btnThemphieunhap.Enabled = true;
                btnXoaphieunhap.Enabled = true;
                btnLuuphieunhap.Enabled = true;
                btnThoatphieunhap.Enabled = true;
                btnInphieunhap.Enabled = true;
                btnTimkiemphieunhap.Enabled = true;
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                // Phó ban và Trưởng ban chỉ có quyền tìm kiếm và in danh sách
                btnThemphieunhap.Enabled = false;
                btnXoaphieunhap.Enabled = false;
                btnLuuphieunhap.Enabled = false;
                cboManhanvien.Enabled = false;
                cboMasach.Enabled = false;
                cboTimkiemphieunhap.Enabled=true;
                txtGhichu.Enabled = false;
                txtMaphieunhap.Enabled=true ;
                txtSoluong.Enabled = false ;
                txtTennhanvien.Enabled = false ;
                txtTensach.Enabled = false ;
                dtpNgaynhap.Enabled = false ;
                txtTong.Enabled = false ;
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
            txtMaphieunhap.Text = "";
            dtpNgaynhap.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            txtTennhanvien.Text = "";
            cboMasach.Text = "";
            txtTensach.Text = "";
            txtSoluong.Text = "";
            txtGhichu.Text = "";
            txtTong.Text = "0";
        }
        private void ResetValuesHang()
        {
            cboMasach.Text = "";
            txtTensach.Text = "";
            txtSoluong.Text = "";
            txtGhichu.Text = "";
            cboMasach.Focus();
        }
        private void Load_DataGridViewChitiet()
        {
            string sql = "select a.Masach, b.Tensach, a.Soluong, a.Ghichu from chitietnhap as a, sach as b, phieunhap as ph where a.Maphieunhap=N'" + txtMaphieunhap.Text + "' and a.Masach=b.Masach and a.Maphieunhap=ph.Maphieunhap";
            tblCTPhieuNhapSach = Class.function.GetDataToTable(sql);
            datagridPhieuNhapSach.DataSource = tblCTPhieuNhapSach;
            datagridPhieuNhapSach.Columns[0].HeaderText = "Mã sách";
            datagridPhieuNhapSach.Columns[1].HeaderText = "Tên sách";
            datagridPhieuNhapSach.Columns[2].HeaderText = "Số lượng";
            datagridPhieuNhapSach.Columns[3].HeaderText = "Ghi chú";  // Thêm cột Ghi chú

            datagridPhieuNhapSach.AllowUserToAddRows = false;
            datagridPhieuNhapSach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_Thongtin()
        {
            string str;
            str = "SELECT Ngaynhap FROM phieunhap WHERE Maphieunhap=N'" + txtMaphieunhap.Text + "'";
            dtpNgaynhap.Text = function.GetFieldValues(str);

            str = "SELECT Manhanvien FROM phieunhap WHERE Maphieunhap=N'" + txtMaphieunhap.Text + "'";
            cboManhanvien.SelectedValue = function.GetFieldValues(str);

            txtTennhanvien.Text = function.GetFieldValues("SELECT Tennhanvien FROM nhanvien WHERE Manhanvien=N'" + cboManhanvien.SelectedValue + "'");

            // Lấy Ghi chú từ cơ sở dữ liệu
            str = "SELECT Ghichu FROM chitietnhap WHERE Maphieunhap=N'" + txtMaphieunhap.Text + "'";
            txtGhichu.Text = function.GetFieldValues(str);
        }

        private void btnTimkiemphieunhap_Click(object sender, EventArgs e)
        {
            if (cboTimkiemphieunhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã phiếu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtMaphieunhap.Text = cboTimkiemphieunhap.SelectedValue.ToString();
            Load_Thongtin();
            Load_DataGridViewChitiet();

            string sql = "SELECT SUM(CAST(Soluong AS INT)) FROM chitietnhap WHERE Maphieunhap = N'" + txtMaphieunhap.Text + "'";
            string tongSoLuong = function.GetFieldValues(sql);
            txtTong.Text = tongSoLuong;

            btnXoaphieunhap.Enabled = true;
            btnInphieunhap.Enabled = true;
            txtGhichu.Text = "";
            txtGhichu.Enabled = false;
            txtSoluong.Enabled = false;
            txtGhichu.Enabled = false;
            dtpNgaynhap.Enabled = false;
            cboManhanvien.Enabled = false;
            cboMasach.Enabled = false;  
        }

        private void btnThemphieunhap_Click(object sender, EventArgs e)
        {
            btnThemphieunhap.Enabled = false;
            btnXoaphieunhap.Enabled = false;
            btnLuuphieunhap.Enabled = true;
            cboManhanvien.Enabled = true;
            cboTimkiemphieunhap.Text = "";
            txtSoluong.Enabled=true;
            txtGhichu.Enabled=true;
            cboManhanvien.Enabled=true;
            cboMasach.Enabled=true;

            ResetValues();
            txtMaphieunhap.Text = function.CreateKey("PN");
            Load_DataGridViewChitiet();
        }

        private void btnLuuphieunhap_Click(object sender, EventArgs e)
        {
            if (txtMaphieunhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphieunhap.Focus();
                return;
            }

            if (dtpNgaynhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày lập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaynhap.Focus();
                return;
            }

            if (cboManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }

            DateTime ngaynhap = DateTime.ParseExact(dtpNgaynhap.Text.Trim(), "dd/MM/yyyy", null);

            // Kiểm tra xem mã phiếu đã tồn tại chưa
            string sql = "SELECT Maphieunhap FROM phieunhap WHERE Maphieunhap=N'" + txtMaphieunhap.Text.Trim() + "'";
            if (!function.CheckKey(sql))
            {
                // Nếu mã phiếu chưa tồn tại, thêm mới phiếu vào bảng phieunhap
                sql = "INSERT INTO phieunhap(Maphieunhap, Ngaynhap, Manhanvien) VALUES(" +
                      "N'" + txtMaphieunhap.Text.Trim() + "', " +
                      "'" + ngaynhap.ToString("yyyy-MM-dd") + "', " +
                      "N'" + cboManhanvien.SelectedValue + "')";
                function.RunSql(sql);
            }

            // Kiểm tra mã sách và số lượng trước khi thêm vào chi tiết
            if (cboMasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMasach.Focus();
                return;
            }

            if (txtSoluong.Text.Trim().Length == 0 || Convert.ToInt32(txtSoluong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }

            // Cập nhật số lượng sách trong bảng sách
            sql = "UPDATE sach SET Soluong = Soluong + " + txtSoluong.Text.Trim() + " WHERE Masach = N'" + cboMasach.SelectedValue + "'";
            function.RunSql(sql);

            // Thêm chi tiết sách vào bảng chitietnhap
            sql = "INSERT INTO chitietnhap (Maphieunhap, Masach, Soluong, Ghichu) " +
             "VALUES (N'" + txtMaphieunhap.Text.Trim() + "', " +
             "N'" + cboMasach.SelectedValue + "', " +
             "CAST(" + txtSoluong.Text.Trim() + " AS INT), N'" + txtGhichu.Text.Trim() + "')";
            function.RunSql(sql);

            // Cập nhật tổng số lượng sách trong phiếu nhập
            txtTong.Text = function.GetFieldValues("SELECT SUM(CAST(Soluong AS INT)) FROM chitietnhap WHERE Maphieunhap=N'" + txtMaphieunhap.Text + "'");

            // Cập nhật lại dữ liệu DataGridView
            Load_DataGridViewChitiet();

            // Kích hoạt các nút chức năng
            btnXoaphieunhap.Enabled = true;
            btnLuuphieunhap.Enabled = true;
            btnThemphieunhap.Enabled = true;
            btnInphieunhap.Enabled = true;
            dtpNgaynhap.Enabled = false;
            cboManhanvien.Enabled = false;
            cboMasach.Text = "";
            txtTensach.Text = "";
            txtSoluong.Text = "";
            txtGhichu.Text = "";
        }

        private void btnXoaphieunhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy mã sách và số lượng từ DataGridView
                string masach = datagridPhieuNhapSach.CurrentRow.Cells["Masach"].Value.ToString();
                string soluong = datagridPhieuNhapSach.CurrentRow.Cells["Soluong"].Value.ToString();

                // Xóa chi tiết phiếu nhập trong bảng chitietnhap trước
                string sqlDeleteChiTiet = "DELETE FROM chitietnhap WHERE Maphieunhap = N'" + txtMaphieunhap.Text.Trim() + "'";
                function.RunSql(sqlDeleteChiTiet);

                // Xóa phiếu nhập trong bảng phieunhap
                string sqlDeletePhieu = "DELETE FROM phieunhap WHERE Maphieunhap = N'" + txtMaphieunhap.Text.Trim() + "'";
                function.RunSql(sqlDeletePhieu);

                // Cập nhật lại số lượng sách trong bảng sach
                string sqlUpdateSach = "UPDATE sach SET Soluong = Soluong - " + soluong + " WHERE Masach = N'" + masach + "'";
                function.RunSql(sqlUpdateSach);

                // Thông báo đã xóa thành công
                MessageBox.Show("Phiếu đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset giá trị và làm mới DataGridView
                ResetValues();
                Load_DataGridViewChitiet();

                // Cập nhật trạng thái các nút
                btnXoaphieunhap.Enabled = false;
                btnLuuphieunhap.Enabled = false;
                btnThemphieunhap.Enabled = true;
                cboTimkiemphieunhap.Text = "";
            }
        }

        private void btnInphieunhap_Click(object sender, EventArgs e)
        {
            if (datagridPhieuNhapSach.Rows.Count == 0)
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
            worksheet.Name = "DanhSachPhieu";

            worksheet.Range["A1"].Value = "Phiếu nhập sách của thư viện";
            worksheet.Range["A1:E1"].Merge();
            worksheet.Range["A1"].Font.Size = 16;
            worksheet.Range["A1"].Font.Bold = true;
            worksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            worksheet.Cells[2, 1].Value = "Mã phiếu";
            worksheet.Cells[2, 2].Value = "Tổng số sách";

            worksheet.Cells[3, 1].Value = txtMaphieunhap.Text.Trim();
         

            worksheet.Cells[4, 1].Value = "DANH SÁCH SÁCH NHẬP";
            worksheet.Range["A4:E4"].Merge();
            worksheet.Cells[4, 1].Font.Size = 12;
            worksheet.Cells[4, 1].Font.Bold = true;
            worksheet.Cells[4, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            worksheet.Cells[5, 1].Value = "Mã sách";
            worksheet.Cells[5, 2].Value = "Tên sách";
            worksheet.Cells[5, 3].Value = "Số lượng";

            for (int i = 0; i < datagridPhieuNhapSach.Rows.Count; i++)
            {
                worksheet.Cells[i + 6, 1].Value = datagridPhieuNhapSach.Rows[i].Cells[0].Value.ToString();
                worksheet.Cells[i + 6, 2].Value = datagridPhieuNhapSach.Rows[i].Cells[1].Value.ToString();
                worksheet.Cells[i + 6, 3].Value = datagridPhieuNhapSach.Rows[i].Cells[2].Value.ToString();
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }

        private void datagridPhieuNhapSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy mã sách từ cột Masach (cột này cần khớp với tên trong DataGridView)
            string masach = datagridPhieuNhapSach.CurrentRow.Cells["Masach"].Value.ToString();
            string soluong = datagridPhieuNhapSach.CurrentRow.Cells["Soluong"].Value.ToString();

            // Kiểm tra nếu DataGridView không có dữ liệu
            if (datagridPhieuNhapSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cảnh báo và xác nhận xóa sách khỏi phiếu
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xóa sách khỏi chi tiết phiếu nhập
                string sql = "DELETE FROM chitietnhap " +
                             "WHERE Maphieunhap=N'" + txtMaphieunhap.Text.Trim() + "' " +
                             "AND Masach=N'" + masach + "'";
                function.RunSql(sql);
                sql = "UPDATE sach SET Soluong = Soluong - " + soluong + " WHERE Masach = N'" + masach + "'";
                function.RunSql(sql);

                // Cập nhật lại tổng số lượng sách trong phiếu
                txtTong.Text = function.GetFieldValues(
                    "SELECT SUM(CAST(Soluong AS INT)) FROM chitietnhap " +
                    "WHERE Maphieunhap=N'" + txtMaphieunhap.Text.Trim() + "'");

                // Cập nhật lại DataGridView
                Load_DataGridViewChitiet();
            }
        }

        private void cboTimkiemphieunhap_DropDown(object sender, EventArgs e)
        {
            // Cập nhật lại danh sách các mã phiếu yêu cầu vào cboTimkiemphieunhap
            function.FillCombo2("SELECT Maphieunhap FROM phieunhap",
                                cboTimkiemphieunhap, "Maphieunhap", "Maphieunhap");

            // Đặt chỉ số của combo box về -1, tức là không có mục nào được chọn
            cboTimkiemphieunhap.SelectedIndex = -1;
        }

        private void btnThoatphieunhap_Click(object sender, EventArgs e)
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

        private void cboManhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTennhanvien.Text = function.GetFieldValues(
              "SELECT Tennhanvien FROM nhanvien " +
              "WHERE Manhanvien=N'" + cboManhanvien.SelectedValue + "'");
        }

        private void cboMasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTensach.Text = function.GetFieldValues(
               "SELECT Tensach FROM sach " +
               "WHERE Masach=N'" + cboMasach.SelectedValue + "'");
        }

        private void cboManhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select Tennhanvien from nhanvien where Manhanvien =N'" +
cboManhanvien.Text + "'";
            txtTennhanvien.Text = function.GetFieldValues(str);
        }

        private void cboMasach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select Tennhanvien from nhanvien where Manhanvien =N'" +
cboManhanvien.Text + "'";
            txtTennhanvien.Text = function.GetFieldValues(str);
        }

        private void cboTimkiemphieunhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngừng xử lý tiếp sự kiện nếu muốn giữ lại giá trị nhập vào
                e.Handled = true; // Ngăn không cho sự kiện Enter tiếp tục
            }
        }
    }
}
