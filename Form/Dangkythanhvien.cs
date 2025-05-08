using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using thutap.Class;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using DrawingFont = System.Drawing.Font;
using iTextFont = iTextSharp.text.Font;
using System.Drawing.Printing;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Globalization;
namespace thutap
{
    public partial class Dangkythanhvien : Form
    {
        private string vaiTro;
        DataTable tblThanhVien;
        public Dangkythanhvien(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }



        private void Dangkythanhvien_Load(object sender, EventArgs e)
        {
            Class.function.Connect();
            txtMadocgia.Enabled = true;
            btnLuuthe.Enabled = false;
            btnBoquathe.Enabled = false;

            Load_DataGridView2();
            Resetvalues();
            string sql = "SELECT Mathanhvien FROM thanhvien";
            function.FillCombo2(sql, cboTimkiemthe, "Mathanhvien", "Mathanhvien");
            cboTimkiemthe.SelectedIndex = -1;
            vaiTro = vaiTro.Trim();  // Loại bỏ khoảng trắng

            // Kiểm tra vai trò và phân quyền cho các nút
            if (vaiTro == "Nhân viên thủ thư")
            {
                // Nhân viên thủ thư có quyền thao tác tất cả các nút
                btnThemthe.Enabled = true;
                btnSuathe.Enabled = true;
                btnXoathe.Enabled = true;
                btnLuuthe.Enabled = true;
                btnBoquathe.Enabled = true;
                btnInthe.Enabled = true;
                btnThoatthe.Enabled = true;
                btnTimkiemthe.Enabled = true;
            }
            else if (vaiTro == "Phó ban thủ thư" || vaiTro == "Trưởng ban thủ thư")
            {
                // Phó ban và Trưởng ban chỉ có quyền tìm kiếm và in danh sách
                btnThemthe.Enabled = false;
                btnSuathe.Enabled = false;
                btnXoathe.Enabled = false;
                btnLuuthe.Enabled = false;
                txtMadocgia.Enabled = false;
                txtTendocgia.Enabled = false;
                rdoNam.Enabled = false;
                rdoNu.Enabled= false;
                txtSodienthoai.Enabled = false;
                mskNgay.Enabled = false;
            }
            else
            {
                // Nếu không có vai trò hợp lệ, đóng form
                MessageBox.Show("Bạn không có quyền truy cập vào form này!");
                this.Close();
            }
        }
        private void Resetvalues()
        {
            txtMadocgia.Text = "";
            txtTendocgia.Text = "";
            txtSodienthoai.Text = "";
            mskNgay.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }
        private void Load_DataGridView2()
        {
            string sql = "SELECT Mathanhvien, Tenthanhvien, Gioitinh, Sodienthoai, Ngaydangky FROM thanhvien";
            tblThanhVien = function.GetDataToTable(sql);
            DataGridView2.DataSource = tblThanhVien;

            DataGridView2.Columns[0].HeaderText = "Mã thành viên";
            DataGridView2.Columns[1].HeaderText = "Tên thành viên";
            DataGridView2.Columns[2].HeaderText = "Giới tính";
            DataGridView2.Columns[3].HeaderText = "Số điện thoại";
            DataGridView2.Columns[4].HeaderText = "Ngày đăng ký";

            DataGridView2.Columns[0].Width = 100;
            DataGridView2.Columns[1].Width = 150;
            DataGridView2.Columns[2].Width = 80;
            DataGridView2.Columns[3].Width = 100;
            DataGridView2.Columns[4].Width = 100;

            DataGridView2.AllowUserToAddRows = false;
            DataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThemthe_Click(object sender, EventArgs e)
        {
            btnSuathe.Enabled = false;
            btnXoathe.Enabled = false;
            btnBoquathe.Enabled = true;
            btnLuuthe.Enabled = true;
            btnThemthe.Enabled = false;
            Resetvalues();
            txtMadocgia.Enabled = true;
            txtMadocgia.Focus();
        }

        private void btnBoquathe_Click(object sender, EventArgs e)
        {
            Resetvalues();
            btnBoquathe.Enabled = false;
            btnThemthe.Enabled = true;
            btnXoathe.Enabled = true;
            btnSuathe.Enabled = true;
            btnLuuthe.Enabled = false;
            txtMadocgia.Enabled = false;
        }

        private void DataGridView2_Click(object sender, EventArgs e)
        {
            if (btnThemthe.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadocgia.Focus();
                return;
            }

            if (tblThanhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMadocgia.Text = DataGridView2.CurrentRow.Cells["Mathanhvien"].Value.ToString();
            txtTendocgia.Text = DataGridView2.CurrentRow.Cells["Tenthanhvien"].Value.ToString();
            string gioitinh = DataGridView2.CurrentRow.Cells["Gioitinh"].Value.ToString();
            if (gioitinh == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            txtSodienthoai.Text = DataGridView2.CurrentRow.Cells["Sodienthoai"].Value.ToString();
            mskNgay.Text = Convert.ToDateTime(DataGridView2.CurrentRow.Cells["Ngaydangky"].Value).ToString("dd/MM/yyyy");

            btnSuathe.Enabled = true;
            btnXoathe.Enabled = true;
            btnBoquathe.Enabled = true;
        }

        private void btnThoatthe_Click(object sender, EventArgs e)
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

        private void btnLuuthe_Click(object sender, EventArgs e)
        {

          /// Kiểm tra mã độc giả
    if (txtMadocgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadocgia.Focus();
                return;
            }

            // Kiểm tra tên độc giả
            if (txtTendocgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendocgia.Focus();
                return;
            }

            // Kiểm tra giới tính
            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ngày đăng ký
            if (mskNgay.Text.Trim().Length != 10)  // dd/MM/yyyy dài 10 ký tự  
            {
                MessageBox.Show("Bạn phải nhập ngày đăng ký đúng định dạng dd/MM/yyyy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgay.Focus();
                return;
            }

            // Kiểm tra định dạng ngày tháng trước khi chuyển đổi
            DateTime ngayDangKy;
            if (!DateTime.TryParseExact(mskNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDangKy))
            {
                MessageBox.Show("Ngày không đúng định dạng dd/MM/yyyy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskNgay.Focus();
                return;
            }

            // Kiểm tra kết nối cơ sở dữ liệu
            if (function.Conn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy giới tính
            string gioitinh = rdoNam.Checked ? "Nam" : "Nữ";

            // Chuẩn bị câu lệnh SQL
            string sql = "INSERT INTO thanhvien (Mathanhvien, Tenthanhvien, Gioitinh, Sodienthoai, Ngaydangky) " +
                         "VALUES (@Mathanhvien, @Tenthanhvien, @Gioitinh, @Sodienthoai, @Ngaydangky)";

            // Tạo các tham số SQL
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Mathanhvien", txtMadocgia.Text.Trim()),
        new SqlParameter("@Tenthanhvien", txtTendocgia.Text.Trim()),
        new SqlParameter("@Gioitinh", gioitinh),
        new SqlParameter("@Sodienthoai", txtSodienthoai.Text.Trim()),
        new SqlParameter("@Ngaydangky", ngayDangKy)
            };

            // Kết nối và thực thi câu lệnh SQL
            function.Connect();  // Mở kết nối nếu chưa mở
            function.RunSql(sql, parameters);  // Chạy câu lệnh SQL
            function.Disconnect();  // Đóng kết nối sau khi thực thi xong

            // Tải lại dữ liệu vào DataGridView
            Load_DataGridView2();

            // Thông báo thành công
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

        private void btnSuathe_Click(object sender, EventArgs e)
        {
            string sql;
            txtMadocgia.Enabled = false;
            if (tblThanhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadocgia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTendocgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendocgia.Focus();
                return;
            }
            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mskNgay.Text.Trim().Length != 10)
            {
                MessageBox.Show("Bạn phải nhập ngày đăng ký đúng định dạng dd/MM/yyyy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgay.Focus();
                return;
            }

            string gioitinh = rdoNam.Checked ? "Nam" : "Nữ";

            sql = "UPDATE thanhvien SET Tenthanhvien=N'" + txtTendocgia.Text.Trim() +
                  "', Gioitinh=N'" + gioitinh +
                  "', Sodienthoai=N'" + txtSodienthoai.Text.Trim() +
                  "', Ngaydangky='" + function.ConvertDateTime(mskNgay.Text) +
                  "' WHERE Mathanhvien=N'" + txtMadocgia.Text.Trim() + "'";
            function.RunSql(sql);
            Load_DataGridView2();
            Resetvalues();
            btnBoquathe.Enabled = false;
            btnLuuthe.Enabled = true;
        }

        private void btnXoathe_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblThanhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadocgia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM thanhvien WHERE Mathanhvien=N'" + txtMadocgia.Text + "'";
                function.RunSqlDel(sql);
                Load_DataGridView2();
                Resetvalues();
            }
        }

        private void btnTimkiemthe_Click(object sender, EventArgs e)
        {
            if (cboTimkiemthe.SelectedIndex == -1) return;

            string sql = "SELECT * FROM thanhvien WHERE Mathanhvien = N'" + cboTimkiemthe.SelectedValue.ToString() + "'";
            DataTable dt = function.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                txtMadocgia.Text = dt.Rows[0]["Mathanhvien"].ToString();
                txtTendocgia.Text = dt.Rows[0]["Tenthanhvien"].ToString();
                string gioitinh = dt.Rows[0]["Gioitinh"].ToString();
                if (gioitinh == "Nam") rdoNam.Checked = true;
                else rdoNu.Checked = true;
                txtSodienthoai.Text = dt.Rows[0]["Sodienthoai"].ToString();
                mskNgay.Text = Convert.ToDateTime(dt.Rows[0]["Ngaydangky"]).ToString("dd/MM/yyyy");
            }
        }

        private void btnInthe_Click(object sender, EventArgs e)
        {
            if (DataGridView2.Rows.Count == 0)  // Kiểm tra nếu DataGridView không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng Excel
            Excel.Application excelApp = new Excel.Application();

            if (excelApp == null)
            {
                MessageBox.Show("Không thể kích hoạt Microsoft Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo workbook và worksheet
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "DanhSachSach";  // Đặt tên cho sheet

            // Tạo tiêu đề cột trong worksheet
            worksheet.Range["A1", "E1"].Merge();  // Merge các cột A đến E (có thể chỉnh lại nếu cần)
            worksheet.Range["A1"].Value = "DANH SÁCH ĐĂNG KÝ THẺ THÀNH VIÊN";  // Tiêu đề
            worksheet.Range["A1"].Font.Bold = true;
            worksheet.Range["A1"].Font.Size = 14;
            worksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Ghi tiêu đề cột DataGridView
            for (int i = 1; i <= DataGridView2.Columns.Count; i++)
            {
                worksheet.Cells[3, i] = DataGridView2.Columns[i - 1].HeaderText;
                worksheet.Cells[3, i].Font.Bold = true;
                worksheet.Cells[3, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);  // Màu nền header
            }

            // Ghi dữ liệu vào Excel từ DataGridView
            for (int i = 0; i < DataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridView2.Columns.Count; j++)
                {
                    if (DataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 4, j + 1] = DataGridView2.Rows[i].Cells[j].Value.ToString();  // Bắt đầu từ dòng 4
                    }
                }
            }

            // Tự động điều chỉnh độ rộng cột
            worksheet.Columns.AutoFit();

            // Hiển thị Excel
            excelApp.Visible = true;
        }

    }
}
