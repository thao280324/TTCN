using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thutap.Class;

namespace thutap
{
    public partial class Phieuphucche : Form
    {
        private string vaiTro;
        public Phieuphucche(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void Phieuphucche_Load(object sender, EventArgs e)
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
                btnThemphieu.Enabled = true;
                btnXoaphieu.Enabled = true;
                btnLuuphieu.Enabled = true;
                btnThoatphieu.Enabled = true;
                btnInphieu.Enabled = true;
               // btnTi.Enabled = true;
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                // Phó ban và Trưởng ban chỉ có quyền tìm kiếm và in danh sách
                btnThemphieu.Enabled = false;
                btnXoaphieu.Enabled = false;
                btnLuuphieu.Enabled = false;
                cboManhanvien.Enabled = false;
                cboMasach.Enabled = false;
                //cboTimkiemphieunhap.Enabled = true;
                txtMaphieu.Enabled = false;
                txtTinhtrang.Enabled = false;
                txtTennhanvien.Enabled = false;
                txtTensach.Enabled = false;
                dtpNgaylap.Enabled = false;
                //txtTong.Enabled = false;
            }
            else
            {
                // Nếu không có vai trò hợp lệ, đóng form
                MessageBox.Show("Bạn không có quyền truy cập vào form này!");
                this.Close();
            }
        }

        private void btnThemphieu_Click(object sender, EventArgs e)
        {
           // btnSuaphieu.Enabled = false;
            btnXoaphieu.Enabled = false;
            btnThoatphieu.Enabled = true;
            btnLuuphieu.Enabled = true;
            btnThemphieu.Enabled = false;
            resetvalue();
            txtMaphieu.Enabled = true;
            txtMaphieu.Focus();
        }
        private void resetvalue()
        {
            cboManhanvien.Text = "";
            txtMaphieu.Text = "";
            txtTennhanvien.Text = "";
            dtpNgaylap.Text = "";
            cboMasach.Text = "";
            txtTensach.Text = "";
            txtTinhtrang.Text = "";
            /*chkHuhong.Checked = false;
            chkRachtrang.Checked = false;
            chkNammoc.Checked = false;
            chkRachbia.Checked = false; // Sửa lỗi dư thừa chkHuhong*/
            rdoCo.Checked = false;
            rdoKhong.Checked = false;
            txtMaphieu.Focus();
        }
        private void Load_datagrid()
        {
            string sql = @"
    SELECT 
        pk.Maphieuphucche AS [Mã phiếu],
        nv.Manhanvien AS [Mã nhân viên],
        nv.Tennhanvien AS [Tên nhân viên],
        FORMAT(pk.Ngaylap, 'dd/MM/yyyy') AS [Ngày lập],        
        ctp.Masach AS [Mã sách thiếu],
        s.Tensach AS [Tên sách thiếu],
        ctp.Tinhtranghuhong AS [Tình trạng hư hỏng],
        ctp.Phucche AS [phục chế]
    FROM phieuphucche pk
    LEFT JOIN nhanvien nv ON pk.Manhanvien = nv.Manhanvien
LEFT JOIN chitietphucche ctp ON pk.Maphieuphucche = ctp.Maphieuphucche
    LEFT JOIN sach s ON ctp.Masach = s.Masach";

            DataTable phieuphucche = Class.function.GetDataToTable(sql);
            dgridphucche.DataSource = phieuphucche;

            // Auto-size cột vừa dữ liệu
            dgridphucche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgridphucche.AutoResizeColumns();

            // Tự động căn giữa header
            dgridphucche.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cho phép select toàn dòng khi click
            dgridphucche.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridphucche.MultiSelect = false;

            // Không cho người dùng thêm dòng trực tiếp
            dgridphucche.AllowUserToAddRows = false;

            // Chỉ đọc (không cho chỉnh sửa trực tiếp trên grid)
            dgridphucche.ReadOnly = true;

            // Đặt EditMode về Programmatically để khóa edit
            dgridphucche.EditMode = DataGridViewEditMode.EditProgrammatically;
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

        private void dgridphucche_Click(object sender, EventArgs e)
        {
            if (btnThemphieu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaphieu.Focus();
                return;
            }

            if (dgridphucche.Rows.Count == 0 || dgridphucche.CurrentRow == null || dgridphucche.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var currentRow = dgridphucche.CurrentRow;

            // Bảo vệ chống null → tránh lỗi
            txtMaphieu.Text = currentRow.Cells["Mã phiếu"].Value?.ToString() ?? "";
            cboManhanvien.Text = currentRow.Cells["Mã nhân viên"].Value?.ToString() ?? "";
            txtTennhanvien.Text = currentRow.Cells["Tên nhân viên"].Value?.ToString() ?? "";
            dtpNgaylap.Text = currentRow.Cells["Ngày lập"].Value?.ToString() ?? "";

            /* // Kiểm tra tình trạng hư hỏng
             string tinhtranghuhong = currentRow.Cells["Tình trạng kho"].Value?.ToString() ?? "";
             chkRachbia.Checked = tinhtranghuhong.Contains("Rách bìa");
             chkRachtrang.Checked = tinhtranghuhong.Contains("Rách trang");
             chkNammoc.Checked = tinhtranghuhong.Contains("Nấm mốc");
             chkHuhong.Checked = tinhtranghuhong.Contains("Hư hỏng khác");*/

            // Xác định phục chế
            string phucche = currentRow.Cells["Phục chế"].Value?.ToString() ?? "";
            rdoCo.Checked = phucche == "Có";
            rdoKhong.Checked = phucche == "Không";

            cboMasach.Text = currentRow.Cells["Mã sách"].Value?.ToString() ?? "";
            txtTensach.Text = currentRow.Cells["Tên sách"].Value?.ToString() ?? "";

            // Bật các nút sửa/xóa phiếu

            btnXoaphieu.Enabled = true;
        }

        private void txtMaphieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void dgridphucche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql;

            // Kiểm tra nếu không phải ở chế độ thêm mới
            if (btnThemphieu.Enabled == false)
            {
                MessageBox.Show("Bạn phải nhấn nút thêm mới trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaphieu.Focus();
                return;
            }

            // Kiểm tra nếu không có dữ liệu
            if (dgridphucche.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu nhấn vào dòng hợp lệ
            if (e.RowIndex < 0)
                return;

            // Lấy dữ liệu từ dòng đã chọn trong DataGridView và gán vào các ô nhập liệu
            var currentRow = dgridphucche.Rows[e.RowIndex];

            // Gán dữ liệu vào các TextBox
            txtMaphieu.Text = currentRow.Cells["Mã phiếu"].Value?.ToString() ?? "";
            cboManhanvien.Text = currentRow.Cells["Mã nhân viên"].Value?.ToString() ?? "";
            txtTennhanvien.Text = currentRow.Cells["Tên nhân viên"].Value?.ToString() ?? "";
            dtpNgaylap.Text = currentRow.Cells["Ngày lập"].Value?.ToString() ?? "";

            /*// Kiểm tra tình trạng hư hỏng và gán checkbox tương ứng
            string tinhtranghuhong = currentRow.Cells["Tình trạng kho"].Value?.ToString() ?? "";
            chkRachbia.Checked = tinhtranghuhong.Contains("Rách bìa");
            chkRachtrang.Checked = tinhtranghuhong.Contains("Rách trang");
            chkNammoc.Checked = tinhtranghuhong.Contains("Nấm mốc");
            chkHuhong.Checked = tinhtranghuhong.Contains("Hư hỏng khác");*/

            // Xác định tình trạng phục chế (RadioButton)
            string phucche = currentRow.Cells["Phục chế"].Value?.ToString() ?? "";
            rdoCo.Checked = phucche == "Có";
            rdoKhong.Checked = phucche == "Không";

            // Gán dữ liệu vào các TextBox mã sách và tên sách
            cboMasach.Text = currentRow.Cells["Mã sách"].Value?.ToString() ?? "";
            txtTensach.Text = currentRow.Cells["Tên sách"].Value?.ToString() ?? "";

            // Bật các nút sửa/xóa phiếu

            btnXoaphieu.Enabled = true;
        }

        private void btnXoaphieu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bản ghi nào được chọn không
            if (dgridphucche.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu cần xóa từ dòng được chọn
            string maphieu = dgridphucche.SelectedRows[0].Cells["Mã phiếu"].Value.ToString();

            // Xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu phục chế này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Xóa dữ liệu từ bảng Chitietphucche
            string sql = "DELETE FROM chitietphucche WHERE Maphieuphucche = N'" + maphieu + "'";
            function.RunSql(sql);

            // Xóa dữ liệu từ bảng Phieukiemke
            sql = "DELETE FROM phieuphucche WHERE Maphieuphucche = N'" + maphieu + "'";
            function.RunSql(sql);

            // Cập nhật lại DataGrid sau khi xóa
            Load_datagrid();

            // Thông báo hoàn tất
            MessageBox.Show("Đã xóa phiếu phục chế thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuuphieu_Click(object sender, EventArgs e)
        {
            string sql;

            // Kiểm tra dữ liệu bắt buộc
            if (txtMaphieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phiếu phục chế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphieu.Focus();
                return;
            }
            if (cboManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }

            if (dtpNgaylap.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaylap.Focus();
                return;
            }
            if (!function.IsDate(dtpNgaylap.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaylap.Text = "";
                dtpNgaylap.Focus();
                return;
            }

            // Kiểm tra mã phiếu phục chế đã tồn tại chưa
            sql = "SELECT Maphieuphucche FROM phieuphucche WHERE Maphieuphucche = N'" + txtMaphieu.Text.Trim() + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Mã phiếu phục chế này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphieu.Text = "";
                txtMaphieu.Focus();
                return;
            }

            // Kiểm tra tình trạng hư hỏng
            /*string tinhtranghuhong = "";
            if (chkRachbia.Checked) tinhtranghuhong += "Rách bìa, ";
            if (chkRachtrang.Checked) tinhtranghuhong += "Rách trang, ";
            if (chkNammoc.Checked) tinhtranghuhong += "Nấm mốc, ";
            if (chkHuhong.Checked) tinhtranghuhong += "Hư hỏng khác";

            if (tinhtranghuhong.EndsWith(", "))
                tinhtranghuhong = tinhtranghuhong.Substring(0, tinhtranghuhong.Length - 2);*/

            string phucche = rdoCo.Checked ? "Có" : "Không";

            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=thuvien;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check + Insert nhân viên
                string checkNhanvienSql = "SELECT COUNT(*) FROM nhanvien WHERE Manhanvien = @Manhanvien";
                using (SqlCommand cmd = new SqlCommand(checkNhanvienSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Manhanvien", cboManhanvien.Text.Trim());
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        string insertNhanvienSql = "INSERT INTO nhanvien (Manhanvien, Tennhanvien, Mataikhoan, Chucvu) VALUES (@Manhanvien, @Tennhanvien, @Mataikhoan, @Chucvu)";
                        using (SqlCommand insertCmd = new SqlCommand(insertNhanvienSql, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Manhanvien", cboManhanvien.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@Tennhanvien", txtTennhanvien.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@Mataikhoan", "defaultTK");
                            insertCmd.Parameters.AddWithValue("@Chucvu", "Nhân viên");
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                // Insert vào phieuphucche
                string insertPhieuSql = "INSERT INTO phieuphucche (Maphieuphucche, Manhanvien, Ngaylap) VALUES (@Maphieuphucche, @Manhanvien, @Ngaylap)";
                using (SqlCommand cmd = new SqlCommand(insertPhieuSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Maphieuphucche", txtMaphieu.Text.Trim());
                    cmd.Parameters.AddWithValue("@Manhanvien", cboManhanvien.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngaylap", function.ConvertDateTime(dtpNgaylap.Text));
                    cmd.ExecuteNonQuery();
                }

                // Insert vào chitietphucche
                string insertChiTietSql = "INSERT INTO chitietphucche (Maphieuphucche, Masach, Tinhtranghuhong, Phucche) VALUES (@Maphieuphucche, @Masach, @Tinhtranghuhong, @Phucche)";
                using (SqlCommand cmd = new SqlCommand(insertChiTietSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Maphieuphucche", txtMaphieu.Text.Trim());
                    cmd.Parameters.AddWithValue("@Masach", cboMasach.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tinhtranghuhong", txtTinhtrang.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phucche", phucche);
                    cmd.ExecuteNonQuery();
                }
            }

            Load_datagrid();
            resetvalue();

            btnXoaphieu.Enabled = true;
            btnThemphieu.Enabled = true;
            btnLuuphieu.Enabled = false;
            txtMaphieu.Enabled = false;
        }

        private void btnInphieu_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo ứng dụng Excel
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                // Kiểm tra xem Excel đã được cài chưa
                if (xlApp == null)
                {
                    MessageBox.Show("Excel không được cài đặt trên hệ thống của bạn.");
                    return;
                }

                // Tạo một workbook mới
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();

                // Tạo một sheet mới
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Sheets[1];

                // Tạo tiêu đề cột trong Excel từ DataGridView
                for (int i = 0; i < dgridphucche.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dgridphucche.Columns[i].HeaderText;
                }

                // Xuất dữ liệu từng dòng trong DataGridView vào Excel
                for (int i = 0; i < dgridphucche.Rows.Count; i++)
                {
                    for (int j = 0; j < dgridphucche.Columns.Count; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dgridphucche.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Đặt chế độ hiển thị Excel
                xlApp.Visible = true;
                xlApp.UserControl = true;

                // Giải phóng tài nguyên
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
