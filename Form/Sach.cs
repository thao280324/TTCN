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
using Excel = Microsoft.Office.Interop.Excel;
using thutap.Class;

namespace thutap
{
    public partial class Sach : Form
    {
        DataTable tblSach;
        private string vaiTro;
        public Sach(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            txtMasach.Enabled = true;
            btnLuusach.Enabled = false;
           // btnBoquasach.Enabled = false;
            PhanQuyenChucNang();
            function.FillCombo2("SELECT MaNXB,TenNXB FROM Nxb", cboManxb, "MaNXB", "TenNXB");
            cboManxb.SelectedIndex = -1;
            function.FillCombo2("SELECT Matheloai,Tentheloai from Theloai", cboMatheloai, "Matheloai", "Tentheloai");
            cboMatheloai.SelectedIndex = -1;
            function.FillCombo2("SELECT Matacgia,Tentacgia from Tacgia", cboMatacgia, "Matacgia", "Tentacgia");
            cboMatacgia.SelectedIndex = -1;
            Resetvalues();
            Load_DataGridView();
            string sql = "SELECT Masach FROM Sach";
            function.FillCombo2(sql, cboTimkiem, "Masach", "Masach");
            cboTimkiem.SelectedIndex = -1; // Không chọn mặc định
            EnableAutoComplete();

        }
        private void EnableAutoComplete()
        {
            cboTimkiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Gợi ý và thêm vào
            cboTimkiem.AutoCompleteSource = AutoCompleteSource.ListItems;  // Lấy dữ liệu từ Items của ComboBox

        }
        private void Resetvalues()
        {
            txtMasach.Text = "";
            txtTensach.Text = "";
            cboManxb.Text = "";
            cboMatacgia.Text = "";
            cboMatheloai.Text = "";
            txtSotrang.Text = "";
            txtGiabia.Text = "";
            txtMota.Text = "";
            txtSoluong.Text = "";
        }
        
    private void PhanQuyenChucNang()
        {
            vaiTro = vaiTro.Trim();  // Loại bỏ khoảng trắng

            // Kiểm tra vai trò và phân quyền cho các nút
            if (vaiTro == "Nhân viên thủ thư")
            {
                // Nhân viên thủ thư có quyền thao tác tất cả các nút
                btnThemsach.Enabled = true;
                btnSuasach.Enabled = true;
                btnXoasach.Enabled = true;
                btnLuusach.Enabled = true;
              //  btnBoquasach.Enabled = true;
                btnInsach.Enabled = true;
                btnThoatsach.Enabled = true;
                btnTimkiem.Enabled = true;
            }
            else if (vaiTro == "Phó ban thủ thư" || vaiTro == "Trưởng ban thủ thư")
            {
                // Phó ban và Trưởng ban chỉ có quyền tìm kiếm và in danh sách
                btnThemsach.Enabled = false;
                btnSuasach.Enabled = false;
                btnXoasach.Enabled = false;
                btnLuusach.Enabled = false;
                SetControlsEnabled(false);  
            }
            else
            {
                // Nếu không có vai trò hợp lệ, đóng form
                MessageBox.Show("Bạn không có quyền truy cập vào form này!");
                this.Close();
            }

        }
        private void SetControlsEnabled(bool isEnabled)
        {
            // Thiết lập trạng thái Enabled cho các TextBox và ComboBox

            // TextBox
            txtMasach.Enabled = isEnabled;
            txtTensach.Enabled = isEnabled;
            txtSoluong.Enabled = isEnabled;
            txtMota.Enabled = isEnabled;
            txtSotrang.Enabled = isEnabled;
            txtGiabia.Enabled = isEnabled;

            // ComboBox
            cboMatheloai.Enabled = isEnabled;
            cboMatacgia.Enabled = isEnabled;
            cboManxb.Enabled = isEnabled;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Masach, Tensach, Matheloai, Matacgia, MaNXB, Sotrang, Giabia, Soluong, Mota FROM sach";
            tblSach = function.GetDataToTable(sql);
            DataGridView.DataSource = tblSach;
            DataGridView.Columns[0].HeaderText = "Mã sách";
            DataGridView.Columns[1].HeaderText = "Tên sách";
            DataGridView.Columns[2].HeaderText = "Mã thể loại";
            DataGridView.Columns[3].HeaderText = "Mã tác giả";
            DataGridView.Columns[4].HeaderText = "Mã nhà xuất bản";
            DataGridView.Columns[5].HeaderText = "Số trang";
            DataGridView.Columns[6].HeaderText = "Giá bìa";
            DataGridView.Columns[7].HeaderText = "Số lượng";
            DataGridView.Columns[8].HeaderText = "Mô tả";
            DataGridView.Columns[0].Width = 80;
            DataGridView.Columns[1].Width = 140;
            DataGridView.Columns[2].Width = 80;
            DataGridView.Columns[3].Width = 80;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 190;
            DataGridView.Columns[7].Width = 100;
            DataGridView.Columns[8].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThemsach_Click(object sender, EventArgs e)
        {
            btnSuasach.Enabled = false;
            btnXoasach.Enabled = false;
          //  btnBoquasach.Enabled = true;
            btnLuusach.Enabled = true;
            btnThemsach.Enabled = false;
            Resetvalues();
            txtMasach.Enabled = true;
            txtMasach.Focus();

        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThemsach.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasach.Focus();
                return;
            }
            if (tblSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            txtMasach.Text = DataGridView.CurrentRow.Cells["Masach"].Value.ToString();
            txtTensach.Text = DataGridView.CurrentRow.Cells["Tensach"].Value.ToString();
            cboMatheloai.SelectedValue = DataGridView.CurrentRow.Cells["Matheloai"].Value.ToString();
            cboMatacgia.SelectedValue = DataGridView.CurrentRow.Cells["Matacgia"].Value.ToString();
            cboManxb.SelectedValue = DataGridView.CurrentRow.Cells["MaNXB"].Value.ToString();
            txtSotrang.Text = DataGridView.CurrentRow.Cells["Sotrang"].Value.ToString();
            txtGiabia.Text = DataGridView.CurrentRow.Cells["Giabia"].Value.ToString();
            txtSoluong.Text = DataGridView.CurrentRow.Cells["Soluong"].Value.ToString();
            txtMota.Text = DataGridView.CurrentRow.Cells["Mota"].Value.ToString();
            btnSuasach.Enabled = true;
            btnXoasach.Enabled = true;
          //  btnBoquasach.Enabled = true;
        }

        private void btnLuusach_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
            if (txtTensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtTensach.Focus();
                return;
            }
            if (cboMatheloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMatheloai.Focus();
                return;
            }
            if (cboManxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManxb.Focus();
                return;
            }
            sql = "SELECT Masach FROM sach WHERE Masach=N'" + txtMasach.Text.Trim() + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Mã sach này đã có, bạn phải nhập mã khác", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                txtMasach.Text = "";
                return;
            }
            sql = "INSERT INTO sach(Masach,Tensach,Matheloai,MaNXB,Matacgia,Sotrang,Giabia,Soluong,Mota) VALUES(N'" + txtMasach.Text.Trim() +
                    "',N'" + txtTensach.Text.Trim() + "',N'" + cboMatheloai.SelectedValue.ToString() + "',N'" + cboManxb.SelectedValue.ToString() + "',N'" + cboMatacgia.SelectedValue.ToString() + "'," + txtSotrang.Text.Trim() +
"," + txtGiabia.Text + "," + txtSoluong.Text + ",N'" + txtMota.Text.Trim() + "')";
            function.RunSql(sql);
            Load_DataGridView();
            Resetvalues();
            btnXoasach.Enabled = true;
            btnThemsach.Enabled = true;
            btnSuasach.Enabled = true;
          //  btnBoquasach.Enabled = false;
            btnLuusach.Enabled = false;
            txtMasach.Enabled = false;

        }

        private void btnThoatsach_Click(object sender, EventArgs e)
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
        private void btnSuasach_Click(object sender, EventArgs e)
        {
            string sql;
            txtMasach.Enabled=false;
            if (tblSach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtTensach.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtGiabia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bìa", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtGiabia.Focus();
                return;
            }
            if (txtSotrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số trang", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtSotrang.Focus();
                return;
            }
            if (txtMota.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mô tả", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMota.Focus();
                return;
            }
            if (cboMatheloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thể loại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMatheloai.Focus();
                return;
            }
            if (cboManxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà xuất bản", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManxb.Focus();
                return;
            }
            if (cboMatacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tác giả", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMatacgia.Focus();
                return;
            }
            sql = "UPDATE sach SET  Tensach=N'" + txtTensach.Text.Trim().ToString() +
                "',Matheloai=N'" + cboMatheloai.SelectedValue.ToString() +
                "',MaNXB=N'" + cboManxb.SelectedValue.ToString() + "',Matacgia=N'" + cboMatacgia.SelectedValue.ToString() + "',Sotrang=" + txtSotrang.Text.Trim() +",Giabia=" + txtGiabia.Text + ",Soluong=" + txtSoluong.Text + ",Mota=N'" + txtMota.Text.Trim() + "' WHERE Masach=N'" + txtMasach.Text + "'";
            function.RunSql(sql);
            Load_DataGridView();
            Resetvalues();
            btnLuusach.Enabled = true;

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            if (cboTimkiem.SelectedIndex == -1) return; // Nếu chưa chọn gì thì bỏ qua

            string sql = "SELECT * FROM sach WHERE Masach = N'" + cboTimkiem.SelectedValue.ToString() + "'";
            DataTable dt = function.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                txtMasach.Text = dt.Rows[0]["Masach"].ToString();
                txtTensach.Text = dt.Rows[0]["Tensach"].ToString();
                cboMatheloai.SelectedValue = dt.Rows[0]["Matheloai"].ToString();
                cboMatacgia.SelectedValue = dt.Rows[0]["Matacgia"].ToString();
                cboManxb.SelectedValue = dt.Rows[0]["MaNXB"].ToString();
                txtSotrang.Text = dt.Rows[0]["Sotrang"].ToString();
                txtGiabia.Text = dt.Rows[0]["Giabia"].ToString();
                txtSoluong.Text = dt.Rows[0]["Soluong"].ToString();
                txtMota.Text = dt.Rows[0]["Mota"].ToString();
            }

        }

        private void btnXoasach_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE sach WHERE Masach=N'" + txtMasach.Text + "'";
                function.RunSqlDel(sql);
                Load_DataGridView();
                Resetvalues();
            }

        }

        private void btnInsach_Click(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count == 0)  // Kiểm tra nếu DataGridView không có dữ liệu
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
            worksheet.Range["A1"].Value = "DANH SÁCH SÁCH CỦA THƯ VIỆN";  // Tiêu đề
            worksheet.Range["A1"].Font.Bold = true;
            worksheet.Range["A1"].Font.Size = 14;
            worksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Ghi tiêu đề cột DataGridView
            for (int i = 1; i <= DataGridView.Columns.Count; i++)
            {
                worksheet.Cells[3, i] = DataGridView.Columns[i - 1].HeaderText;
                worksheet.Cells[3, i].Font.Bold = true;
                worksheet.Cells[3, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);  // Màu nền header
            }

            // Ghi dữ liệu vào Excel từ DataGridView
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridView.Columns.Count; j++)
                {
                    if (DataGridView.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 4, j + 1] = DataGridView.Rows[i].Cells[j].Value.ToString();  // Bắt đầu từ dòng 4
                    }
                }
            }

            // Tự động điều chỉnh độ rộng cột
            worksheet.Columns.AutoFit();

            // Hiển thị Excel
            excelApp.Visible = true;
        }

        private void cboTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngừng xử lý tiếp sự kiện nếu muốn giữ lại giá trị nhập vào
                e.Handled = true; // Ngăn không cho sự kiện Enter tiếp tục
            }
        }
    }
}

