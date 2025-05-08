using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using thutap.Class;
using Excel = Microsoft.Office.Interop.Excel;

namespace thutap
{
    public partial class Yeucaunhap : Form
    {
        DataTable tblCTYeuCauNhap;
        private string vaiTro;
        public Yeucaunhap(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }


        private void Yeucaunhap_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
            btnThemphieumuon.Enabled = true;
            btnLuuphieu.Enabled = false;
            btnXoaphieumuon.Enabled = false;
            btnInphieumuon.Enabled = false;
            txtMaphieunhap.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTensach.ReadOnly = true;
            txtTong.ReadOnly = true;
            Class.function.FillCombo2("select Manhanvien, Tennhanvien from NhanVien", cboManhanvien, "Manhanvien", "Tennhanvien");
            cboManhanvien.SelectedIndex = -1;
            Class.function.FillCombo2("select Masach, Tensach from sach", cboMasach, "Masach", "Tensach");
            cboMasach.SelectedIndex = -1;
            Class.function.FillCombo2("select Maphieuyeucaunhap from yeucaunhap", cboTimkiemphieunhap, "Maphieuyeucaunhap", "Maphieuyeucaunhap");
            cboTimkiemphieunhap.SelectedIndex = -1;
            if (txtMaphieunhap.Text != "")
            {
                Load_Thongtin();
                btnXoaphieumuon.Enabled = true;
                btnInphieumuon.Enabled = true;
            }
            Load_DataGridViewChitiet();
            txtGui.Enabled = false;
            txtDuyet.Enabled = false;
        }
        private void PhanQuyenChucNang()
        {
            if (vaiTro == "Trưởng ban thủ thư")
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
                this.Close();
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
                this.Close();
            }
            else
            {
                //
            }
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
        private void ResetValues()
        {
            txtMaphieunhap.Text = "";
            dtpNgaylap.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            txtTennhanvien.Text = "";
            cboMasach.Text = "";
            txtTensach.Text = "";
            txtSoluong.Text = "";
            txtTong.Text = "0";
        }
        private void ResetValuesHang()
        {
            cboMasach.Text = "";
            txtTensach.Text = "";
            txtSoluong.Text = "";
            cboMasach.Focus();
        }
        private void Load_DataGridViewChitiet()
        {
            string sql;
            sql = "select a.Masach, b.Tensach, a.Soluong from  chitietyeucaunhap as a, sach as b where a.Maphieuyeucaunhap=N'" + txtMaphieunhap.Text + "' and a.Masach=b.Masach";
            tblCTYeuCauNhap = Class.function.GetDataToTable(sql);
            datagridYeuCau.DataSource = tblCTYeuCauNhap;
            datagridYeuCau.Columns[0].HeaderText = "Mã sách";
            datagridYeuCau.Columns[1].HeaderText = "Tên sách";
            datagridYeuCau.Columns[2].HeaderText = "Số lượng";
            datagridYeuCau.AllowUserToAddRows = false;
            datagridYeuCau.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_Thongtin()
        {
            string str;
            // Ngày lập
            str = "SELECT Ngaylap FROM yeucaunhap WHERE Maphieuyeucaunhap=N'"
                  + txtMaphieunhap.Text + "'";
            dtpNgaylap.Text = function.GetFieldValues(str);

            // Mã & tên nhân viên
            str = "SELECT Manhanvien FROM yeucaunhap WHERE Maphieuyeucaunhap=N'"
                  + txtMaphieunhap.Text + "'";
            cboManhanvien.SelectedValue = function.GetFieldValues(str);

            // Tên nhân viên
            txtTennhanvien.Text = function.GetFieldValues(
                "SELECT Tennhanvien FROM nhanvien WHERE Manhanvien=N'"
                + cboManhanvien.SelectedValue + "'");
        }

        private void btnTimkiemphieunhap_Click(object sender, EventArgs e)
        {
            if (cboTimkiemphieunhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã phiếu để tìm",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            txtMaphieunhap.Text = cboTimkiemphieunhap.SelectedValue.ToString();
            Load_Thongtin();
            Load_DataGridViewChitiet();
            string sql1 = "SELECT Trangthaigui FROM yeucaunhap WHERE Maphieuyeucaunhap = N'" + txtMaphieunhap.Text.Trim() + "'";
            string trangThaiGui = function.GetFieldValues(sql1);


            // Cập nhật giá trị cho txtGui theo trạng thái gửi
            txtGui.Text = trangThaiGui;
            string sql2 = "SELECT Trangthaiduyet FROM yeucaunhap WHERE Maphieuyeucaunhap = N'" + txtMaphieunhap.Text.Trim() + "'";
            string trangThaiDuyet = function.GetFieldValues(sql2);
            txtDuyet.Text = trangThaiDuyet;
            // Cập nhật tổng số lượng sách
            string sql = "SELECT SUM(CAST(Soluong AS INT)) FROM chitietyeucaunhap " +
                         "WHERE Maphieuyeucaunhap = N'" + txtMaphieunhap.Text + "'";
            string tongSoLuong = function.GetFieldValues(sql);
            txtTong.Text = tongSoLuong;

            // Cho phép sửa/xóa dòng
            btnXoaphieumuon.Enabled = true;
            btnLuuphieu.Enabled = false;
            btnThemphieumuon.Enabled = true;
            btnInphieumuon.Enabled=true;
            txtGui.Enabled = false ;
        }

        private void btnThemphieumuon_Click(object sender, EventArgs e)
        {
            txtGui.Text = "Chưa gửi";
            // Chuẩn bị nhập mới header + detail
            btnThemphieumuon.Enabled = false;
            btnXoaphieumuon.Enabled = false;
            btnLuuphieu.Enabled = true;

            ResetValues();
            // Sinh khoá tự động, ví dụ "PCN20250507..."
            txtMaphieunhap.Text = function.CreateKey("PCN");
            Load_DataGridViewChitiet();
        }

        private void btnLuuphieu_Click(object sender, EventArgs e)
        {
            // 1) Kiểm tra điều kiện nhập
            if (txtMaphieunhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phiếu", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphieunhap.Focus();
                return;
            }
            if (dtpNgaylap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày lập", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaylap.Focus();
                return;
            }
            if (cboManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }

            DateTime ngaylap = DateTime.ParseExact(dtpNgaylap.Text.Trim(), "dd/MM/yyyy", null);

            // 2) Kiểm tra xem phiếu đã tồn tại chưa, nếu chưa thì thêm phiếu mới
            string sql = "SELECT Maphieuyeucaunhap FROM yeucaunhap WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() + "'";
            if (!function.CheckKey(sql))  // Nếu phiếu chưa tồn tại
            {
                // Thêm phiếu mới vào bảng yeucaunhap
                sql = "INSERT INTO yeucaunhap(Maphieuyeucaunhap, Ngaylap, Manhanvien, Trangthaigui, Trangthaiduyet) VALUES(" +
                      "N'" + txtMaphieunhap.Text.Trim() + "', " +
                      "'" + ngaylap.ToString("yyyy-MM-dd") + "', " +
                      "N'" + cboManhanvien.SelectedValue + "', " +
                      "N'Chưa gửi', N'Chưa duyệt')";
                function.RunSql(sql);  // Lưu phiếu mới vào bảng yeucaunhap
            }

            // 3) Lưu chi tiết sách (chitietyeucaunhap) cho mỗi sách
            if (cboMasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sách", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMasach.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0 || Convert.ToInt32(txtSoluong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }

            // Kiểm tra đã có sách đó trong phiếu chưa
            sql = "SELECT Masach FROM chitietyeucaunhap WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() + "' AND Masach=N'" + cboMasach.SelectedValue + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Sách này đã tồn tại trong phiếu", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMasach.Focus();
                return;
            }

            // Thực sự Insert dòng mới cho chi tiết sách
            sql = "INSERT INTO chitietyeucaunhap(Maphieuyeucaunhap, Masach, Soluong) " +
                  "VALUES(N'" + txtMaphieunhap.Text.Trim() + "', " +
                  "N'" + cboMasach.SelectedValue + "', " +
                  "CAST(" + txtSoluong.Text.Trim() + " AS INT))";  // Chuyển Soluong thành kiểu INT
            function.RunSql(sql);  // Thêm sách vào phiếu

            // 4) Cập nhật lại DataGrid và tổng số sách
            txtTong.Text = function.GetFieldValues(
                "SELECT SUM(CAST(Soluong AS INT)) FROM chitietyeucaunhap " +
                "WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text + "'");
            ResetValuesHang();
            Load_DataGridViewChitiet();

            // Cho phép sửa/xóa dòng, tắt lưu
            btnXoaphieumuon.Enabled = true;
            btnLuuphieu.Enabled = true;
            btnThemphieumuon.Enabled = true;
            btnInphieumuon.Enabled=true;
        }

        private void btnXoaphieumuon_Click(object sender, EventArgs e)
        {
            // Xác nhận người dùng có chắc chắn muốn xóa phiếu không
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này?", "Thông báo",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                string[] masach = new string[20]; // Mảng lưu các mã sách trong phiếu
                int n = 0;  // Biến đếm số lượng mã sách
                sql = "SELECT Masach FROM chitietyeucaunhap WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(sql, function.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    masach[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }

                reader.Close();

                // Xóa các mã sách trong chi tiết phiếu yêu cầu
                for (int i = 0; i < n; i++)
                {
                    string delSql = "DELETE FROM chitietyeucaunhap WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() +
                                    "' AND Masach='" + masach[i] + "'";
                    function.RunSql(delSql);
                }

                // Sau khi xóa chi tiết, xóa toàn bộ phiếu yêu cầu
                sql = "DELETE FROM yeucaunhap WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() + "'";
                function.RunSql(sql);

                // Cập nhật lại DataGridView và reset các giá trị
                Load_DataGridViewChitiet();
                ResetValuesHang();

                // Thông báo cho người dùng biết phiếu đã được xóa
                MessageBox.Show("Phiếu yêu cầu đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset lại các button
                txtGui.Text = "";
                txtDuyet.Text = "";
                cboTimkiemphieunhap.Text = "";
                txtMaphieunhap.Text = "";
                btnXoaphieumuon.Enabled = false;
                btnLuuphieu.Enabled = false;
                btnThemphieumuon.Enabled = true;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string sql =
                "UPDATE yeucaunhap SET Trangthaigui=N'Đã gửi' " +
                "WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() + "'";
            function.RunSql(sql);
            MessageBox.Show("Phiếu đã được gửi!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            txtGui.Text = "Đã gửi";
            cboTimkiemphieunhap.Text = "";
            btnInphieumuon.Enabled = true;
            btnThemphieumuon.Enabled=true;
            string sql2 = "SELECT Trangthaiduyet FROM yeucaunhap WHERE Maphieuyeucaunhap = N'" + txtMaphieunhap.Text.Trim() + "'";
            string trangThaiDuyet = function.GetFieldValues(sql2);
            txtDuyet.Text = trangThaiDuyet;
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

        private void cboMasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTensach.Text = function.GetFieldValues(
                "SELECT Tensach FROM sach " +
                "WHERE Masach=N'" + cboMasach.SelectedValue + "'");
        }

        private void cboManhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTennhanvien.Text = function.GetFieldValues(
               "SELECT Tennhanvien FROM nhanvien " +
               "WHERE Manhanvien=N'" + cboManhanvien.SelectedValue + "'");
        }

        private void btnInphieumuon_Click(object sender, EventArgs e)
        {
           
                // Kiểm tra nếu DataGridView không có dữ liệu
                if (datagridYeuCau.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Truy vấn thông tin trạng thái phiếu và trạng thái gửi
                string sql = "SELECT Trangthaigui, Trangthaiduyet, " +
                             "(SELECT SUM(CAST(Soluong AS INT)) FROM chitietyeucaunhap WHERE Maphieuyeucaunhap = N'" + txtMaphieunhap.Text.Trim() + "') AS TongSoluong " +
                             "FROM yeucaunhap WHERE Maphieuyeucaunhap = N'" + txtMaphieunhap.Text.Trim() + "'";

                // Lấy nhiều giá trị từ hàm GetFieldValuesMultiple
                List<string> results = function.GetFieldValuesMultiple(sql);
                string trangThaiGui = results.Count > 0 ? results[0] : "";
                string trangThaiDuyet = results.Count > 1 ? results[1] : "";
                string tongSoLuong = results.Count > 2 ? results[2] : "";

                // Tạo đối tượng Excel và Workbook
                var excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Không thể kích hoạt Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mở workbook mới
                var workbook = excelApp.Workbooks.Add(Missing.Value);
                var worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "DanhSachPhieu";  // Tên sheet

                // Tạo tiêu đề bảng
                worksheet.Range["A1"].Value = "Phiếu yêu cầu nhập sách của thư viện";
                worksheet.Range["A1:E1"].Merge();  // Gộp các ô cho tiêu đề
                worksheet.Range["A1"].Font.Size = 16;  // Cỡ chữ tiêu đề
                worksheet.Range["A1"].Font.Bold = true;  // In đậm
                worksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề các cột
                worksheet.Cells[2, 1].Value = "Mã phiếu";
                worksheet.Cells[2, 2].Value = "Trạng thái gửi";
                worksheet.Cells[2, 3].Value = "Trạng thái duyệt";
                worksheet.Cells[2, 4].Value = "Tổng số sách";
            worksheet.Cells[3, 1].Value = txtMaphieunhap.Text.Trim();
            worksheet.Cells[3, 2].Value = trangThaiGui;
            worksheet.Cells[3, 3].Value = trangThaiDuyet;
            worksheet.Cells[3, 4].Value = tongSoLuong;


            // Điền thông tin vào các cột
            worksheet.Cells[4, 1].Value = "DANH SÁCH SÁCH ĐỀ XUẤT NHẬP";
            worksheet.Range["A4:E4"].Merge();
            worksheet.Cells[4, 1].Font.Size = 12;
            worksheet.Cells[4, 1].Font.Bold = true;
            worksheet.Cells[4, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cho bảng sách
            worksheet.Cells[5, 1].Value = "Mã sách";
            worksheet.Cells[5, 2].Value = "Tên sách";
            worksheet.Cells[5, 3].Value = "Số lượng";

            // Điền thông tin sách từ DataGridView vào Excel
            for (int i = 0; i < datagridYeuCau.Rows.Count; i++)
            {
                worksheet.Cells[i + 6, 1].Value = datagridYeuCau.Rows[i].Cells[0].Value.ToString(); // Mã sách
                worksheet.Cells[i + 6, 2].Value = datagridYeuCau.Rows[i].Cells[1].Value.ToString(); // Tên sách
                worksheet.Cells[i + 6, 3].Value = datagridYeuCau.Rows[i].Cells[2].Value.ToString(); // Số lượng
            }

            // Tự động điều chỉnh cột cho vừa với dữ liệu
            worksheet.Columns.AutoFit();


            // Hiển thị Excel
            excelApp.Visible = true;

        }

        private void datagridYeuCau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy mã sách từ cột Masach (cột này cần khớp với tên trong DataGridView)
            string masach = datagridYeuCau.CurrentRow.Cells["Masach"].Value.ToString();
            double soluong = Convert.ToDouble(datagridYeuCau.CurrentRow.Cells["Soluong"].Value);

            // Kiểm tra nếu DataGridView không có dữ liệu
            if (datagridYeuCau.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cảnh báo và xác nhận xóa sách khỏi phiếu
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xóa sách khỏi chi tiết phiếu yêu cầu nhập
                string sql = "DELETE FROM chitietyeucaunhap " +
                             "WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() + "' " +
                             "AND Masach=N'" + masach + "'";
                function.RunSql(sql);

                // Cập nhật lại tổng số lượng sách trong phiếu
                txtTong.Text = function.GetFieldValues(
                    "SELECT SUM(CAST(Soluong AS INT)) FROM chitietyeucaunhap " +
                    "WHERE Maphieuyeucaunhap=N'" + txtMaphieunhap.Text.Trim() + "'");

                // Cập nhật lại DataGridView
                Load_DataGridViewChitiet();
            }
        }

        private void cboTimkiemphieunhap_DropDown(object sender, EventArgs e)
        {
            // Cập nhật lại danh sách các mã phiếu yêu cầu vào cboMaphieunhap
            function.FillCombo2("SELECT Maphieuyeucaunhap FROM yeucaunhap",
                                cboTimkiemphieunhap, "Maphieuyeucaunhap", "Maphieuyeucaunhap");

            // Đặt chỉ số của combo box về -1, tức là không có mục nào được chọn
            cboTimkiemphieunhap.SelectedIndex = -1;
        }

        private void cboTimkiemphieunhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngừng xử lý tiếp sự kiện nếu muốn giữ lại giá trị nhập vào
                e.Handled = true; // Ngăn không cho sự kiện Enter tiếp tục
            }
        }

        private void cboMasach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMasach.Text == "")
                txtTensach.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select Tensach from sach where Masach =N'" +
cboMasach.Text + "'";
            txtTensach.Text = function.GetFieldValues(str);
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
    }
}
