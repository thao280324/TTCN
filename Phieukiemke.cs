using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thutap.Class;

namespace thutap
{
    public partial class Phieukiemke : Form
    {
        public Phieukiemke()
        {
            InitializeComponent();
        }
        DataTable tblphieukiemke;

        /*string vaiTro = "";
        private void PhanQuyenChucNang()
        {
            vaiTro = vaiTro.Trim(); // Loại bỏ khoảng trắng

            // Kiểm tra vai trò và phân quyền cho các nút
            if (vaiTro == "Nhân viên thủ thư")
            {
                btnThemphieu.Enabled = true;
                btnSuaphieu.Enabled = true;
                btnXoaphieu.Enabled = true;
                btnLuuphieu.Enabled = true;
                btnThoatphieu.Enabled = true;
                btnInphieu.Enabled = true;
                

                txtMaphieu.Enabled = true;
                txtManhanvien.Enabled = true;
                txtTennhanvien.Enabled = true;
                txtMasach.Enabled = true;
                txtTensach.Enabled = true;
                txtSoluong.Enabled = true;
                mskNgaykiem.Enabled = true;
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                btnThemphieu.Enabled = false;
                btnSuaphieu.Enabled = false;
                btnXoaphieu.Enabled = false;
                btnLuuphieu.Enabled = false;
                btnThoatphieu.Enabled = true;
                btnInphieu.Enabled = true;
                
                txtMaphieu.Enabled = false;
                txtManhanvien.Enabled = false;
                txtTennhanvien.Enabled = false;
                txtMasach.Enabled = false;
                txtTensach.Enabled = false;
                txtSoluong.Enabled = false;
                mskNgaykiem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào form này!");
                this.Close();
            }*/

        
        private void Phieukiemke_Load(object sender, EventArgs e)
        {
            btnLuuphieu.Enabled = false;
            btnXoaphieu.Enabled = true;
            btnInphieu.Enabled = true;
            //PhanQuyenChucNang(); // Gọi phân quyền
            Load_datagrid();
        }


        private void Load_datagrid()
        {
            string sql = @"
SELECT 
    pk.Maphieukiemke AS [Mã phiếu],
    nv.Manhanvien AS [Mã nhân viên],
    nv.Tennhanvien AS [Tên nhân viên],
    FORMAT(pk.Ngaykiemke, 'dd/MM/yyyy') AS [Ngày kiểm kê],
    ctk.Tinhtrangkho AS [Tình trạng kho],
    ctk.Masach AS [Mã sách thiếu],
    s.Tensach AS [Tên sách thiếu],
    ctk.Soluongsachthieu AS [Số lượng thiếu]
FROM tblphieukiemke pk
LEFT JOIN nhanvien nv ON pk.Manhanvien = nv.Manhanvien
LEFT JOIN Chitietkiemke ctk ON pk.Maphieukiemke = ctk.Maphieukiemke
LEFT JOIN sach s ON ctk.Masach = s.Masach";

            DataTable tblphieukiemke = Class.Functions.GetdatatoTable(sql);
            dgridkiemke.DataSource = tblphieukiemke;

            // Auto-size cột vừa dữ liệu
            dgridkiemke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgridkiemke.AutoResizeColumns();

            // Tự động căn giữa header
            dgridkiemke.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cho phép select toàn dòng khi click
            dgridkiemke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridkiemke.MultiSelect = false;

            // Không cho người dùng thêm dòng trực tiếp
            dgridkiemke.AllowUserToAddRows = false;

            // Chỉ đọc (không cho chỉnh sửa trực tiếp trên grid)
            dgridkiemke.ReadOnly = true;

            // Đặt EditMode về Programmatically để khóa edit
            dgridkiemke.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void btnThemphieu_Click(object sender, EventArgs e)
        {
            btnSuaphieu.Enabled = false;
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
            txtMaphieu.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            mskNgaykiem.Text = "";
            rdoDu.Checked = false;
            rdoThieu.Checked = false;
            txtMasach.Text = "";
            txtTensach.Text = "";
            txtSoluong.Text = "";
            txtMaphieu.Focus();
        }
        private void dgridPhieuKiemKe_Click(object sender, EventArgs e)
        {
            if (btnThemphieu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaphieu.Focus();
                return;
            }

            if (dgridkiemke.Rows.Count == 0 || dgridkiemke.CurrentRow == null || dgridkiemke.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var currentRow = dgridkiemke.CurrentRow;

            // Bảo vệ chống null → tránh lỗi
            txtMaphieu.Text = currentRow.Cells["Mã phiếu"].Value?.ToString() ?? "";
            txtManhanvien.Text = currentRow.Cells["Mã nhân viên"].Value?.ToString() ?? "";
            txtTennhanvien.Text = currentRow.Cells["Tên nhân viên"].Value?.ToString() ?? "";
            mskNgaykiem.Text = currentRow.Cells["Ngày kiểm kê"].Value?.ToString() ?? "";

            string tinhtrang = currentRow.Cells["Tình trạng kho"].Value?.ToString();
            rdoDu.Checked = tinhtrang == "Đủ sách";
            rdoThieu.Checked = tinhtrang == "Thiếu sách";

            txtMasach.Text = currentRow.Cells["Mã sách thiếu"].Value?.ToString() ?? "";
            txtTensach.Text = currentRow.Cells["Tên sách thiếu"].Value?.ToString() ?? "";
            txtSoluong.Text = currentRow.Cells["Số lượng thiếu"].Value?.ToString() ?? "";

            btnSuaphieu.Enabled = true;
            btnXoaphieu.Enabled = true;
        }
        private void btnSuaphieu_Click(object sender, EventArgs e)
        {
            string sql;

            // Kiểm tra nếu DataGridView không có dữ liệu hoặc chưa chọn bản ghi
            if (dgridkiemke.Rows.Count == 0 || dgridkiemke.CurrentRow == null || dgridkiemke.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra các thông tin đầu vào
            if (txtMaphieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách kiểm kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (mskNgaykiem.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày kiểm kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaykiem.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaykiem.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày kiểm kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaykiem.Text = "";
                mskNgaykiem.Focus();
                return;
            }

            // Cập nhật bảng tblPhieukiemke (chỉ cập nhật ngày kiểm kê)
            sql = "UPDATE tblPhieukiemke SET Ngaykiemke = '" + Functions.ConvertDateTime(mskNgaykiem.Text) + "' " +
                  "WHERE Maphieukiemke = N'" + txtMaphieu.Text + "'";
            Functions.RunSql(sql);

            // Lấy giá trị tình trạng kho
            string tinhtrang = rdoDu.Checked ? "Đủ sách" : "Thiếu sách";

            // Cập nhật bảng Chitietkiemke, bao gồm mã sách thiếu, tên sách thiếu và số lượng thiếu
            sql = "UPDATE Chitietkiemke SET " +
                  "Soluongsachthieu = N'" + txtSoluong.Text.Trim() + "', " +
                  "Tinhtrangkho = N'" + tinhtrang + "', " +
                  "Masach = N'" + txtMasach.Text.Trim() + "', " +
                  "Tensach = N'" + txtTensach.Text.Trim() + "' " +
                  "WHERE Maphieukiemke = N'" + txtMaphieu.Text + "' AND Masach = N'" + txtMasach.Text.Trim() + "'";
            Functions.RunSql(sql);

            // Tải lại dữ liệu trong DataGridView
            Load_datagrid();
            resetvalue();

            // Vô hiệu hóa nút sau khi cập nhật
            btnSuaphieu.Enabled = false;
            btnXoaphieu.Enabled = false;
        }


        private void btnLuuphieu_Click(object sender, EventArgs e)
        {
            string sql;

            // Kiểm tra dữ liệu bắt buộc
            if (txtMaphieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phiếu kiểm kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphieu.Focus();
                return;
            }
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }

            // Kiểm tra khi tình trạng kho là "Thiếu sách" mới yêu cầu nhập mã sách và số lượng
            if (rdoThieu.Checked)
            {
                if (txtMasach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMasach.Focus();
                    return;
                }
                if (txtSoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoluong.Focus();
                    return;
                }
            }

            // Kiểm tra ngày kiểm kê
            if (mskNgaykiem.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày kiểm kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaykiem.Focus();
                return;
            }

            if (!Functions.IsDate(mskNgaykiem.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày kiểm kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaykiem.Text = "";
                mskNgaykiem.Focus();
                return;
            }

            // Kiểm tra mã nhân viên đã tồn tại chưa
            sql = "SELECT Manhanvien FROM nhanvien WHERE Manhanvien = N'" + txtManhanvien.Text.Trim() + "'";
            if (!Functions.checkkey(sql))
            {
                // Nếu chưa có → thêm nhân viên mới
                sql = "INSERT INTO nhanvien (Manhanvien, Tennhanvien, Mataikhoan, Chucvu) " +
                      "VALUES (N'" + txtManhanvien.Text.Trim() + "', N'" + txtTennhanvien.Text.Trim() + "', 'TK01', N'Nhân viên')";
                Functions.RunSql(sql);
            }

            // Kiểm tra mã phiếu trùng
            sql = "SELECT Maphieukiemke FROM tblphieukiemke WHERE Maphieukiemke = N'" + txtMaphieu.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã phiếu kiểm kê này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphieu.Text = "";
                txtMaphieu.Focus();
                return;
            }

            // Insert vào tblphieukiemke
            sql = "INSERT INTO tblphieukiemke (Maphieukiemke, Manhanvien, Ngaykiemke) " +
                  "VALUES (N'" + txtMaphieu.Text.Trim() + "', N'" + txtManhanvien.Text.Trim() + "', '" +
                  Functions.ConvertDateTime(mskNgaykiem.Text) + "')";
            Functions.RunSql(sql);

            // Xác định tình trạng kho
            string tinhtrang = rdoDu.Checked ? "đủ sách" : "thiếu sách";

            // Insert vào chitietkiemke chỉ khi tình trạng kho là "Thiếu sách"
            if (rdoThieu.Checked)
            {
                sql = "INSERT INTO Chitietkiemke (Maphieukiemke, Masach, Soluongsachthieu, Tinhtrangkho) " +
                      "VALUES (N'" + txtMaphieu.Text.Trim() + "', N'" + txtMasach.Text.Trim() + "', N'" +
                      txtSoluong.Text.Trim() + "', N'" + tinhtrang + "')";
                Functions.RunSql(sql);
            }

            // Load lại lưới và reset form
            Load_datagrid();
            resetvalue();

            // Bật/tắt nút
            btnXoaphieu.Enabled = true;
            btnThemphieu.Enabled = true;
            btnSuaphieu.Enabled = true;
            btnLuuphieu.Enabled = false;
            txtMaphieu.Enabled = false;
        }



        private void btnXoaphieu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bản ghi nào được chọn không
            if (dgridkiemke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu cần xóa từ dòng được chọn
            string maphieu = dgridkiemke.SelectedRows[0].Cells["Mã phiếu"].Value.ToString();

            // Xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu kiểm kê này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Xóa dữ liệu từ bảng Chitietkiemke
            string sql = "DELETE FROM Chitietkiemke WHERE Maphieukiemke = N'" + maphieu + "'";
            Functions.RunSql(sql);

            // Xóa dữ liệu từ bảng tblPhieukiemke
            sql = "DELETE FROM tblPhieukiemke WHERE Maphieukiemke = N'" + maphieu + "'";
            Functions.RunSql(sql);

            // Cập nhật lại DataGrid sau khi xóa
            Load_datagrid();

            // Thông báo hoàn tất
            MessageBox.Show("Đã xóa phiếu kiểm kê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoatphieu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgridkiemke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgridkiemke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql;
            if (btnThemphieu.Enabled == false)
            {
                MessageBox.Show("Bạn phải nhấn nút thêm mới trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaphieu.Focus();
                return;
            }
            if (tblphieukiemke.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e.RowIndex < 0)
                return;
            txtMaphieu.Text = dgridkiemke.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMasach.Text = dgridkiemke.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTensach.Text = dgridkiemke.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoluong.Text = dgridkiemke.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskNgaykiem.Text = dgridkiemke.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void txtMaPhieuKiemKe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void rdoDu_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu chọn Đủ sách, ẩn các trường mã sách thiếu, tên sách thiếu, số lượng thiếu
            if (rdoDu.Checked)
            {
                txtMasach.Enabled = false;
                txtTensach.Enabled = false;
                txtSoluong.Enabled = false;
            }
            else
            {
                // Nếu chọn Thiếu sách, cho phép nhập mã sách thiếu, tên sách thiếu, số lượng thiếu
                txtMasach.Enabled = true;
                txtTensach.Enabled = true;
                txtSoluong.Enabled = true;
            }
        }
        private void rdoThieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThieu.Checked)
            {
                txtMasach.Enabled = true;
                txtTensach.Enabled = true;
                txtSoluong.Enabled = true;
            }
            else
            {
                txtMasach.Enabled = false;
                txtTensach.Enabled = false;
                txtSoluong.Enabled = false;
            }
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
                for (int i = 0; i < dgridkiemke.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dgridkiemke.Columns[i].HeaderText;
                }

                // Xuất dữ liệu từng dòng trong DataGridView vào Excel
                for (int i = 0; i < dgridkiemke.Rows.Count; i++)
                {
                    for (int j = 0; j < dgridkiemke.Columns.Count; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dgridkiemke.Rows[i].Cells[j].Value.ToString();
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
