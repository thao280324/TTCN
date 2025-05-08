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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thutap
{
    public partial class Duyetyeucau : Form
    {
        private string vaiTro;
        public Duyetyeucau(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void Duyetyeucau_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
            //Cập nhật dữ liệu vào cboChonphieu chỉ hiển thị phiếu có trạng thái "Đã gửi"
            string sql = "SELECT Maphieuyeucaunhap FROM yeucaunhap WHERE Trangthaigui = N'Đã gửi' AND Trangthaiduyet = N'Chưa duyệt'";
            function.FillCombo2(sql, cboChonphieu, "Maphieuyeucaunhap", "Maphieuyeucaunhap");
            cboChonphieu.SelectedIndex = -1;
            txtManhanvien.Enabled = false;
            txtMaphieu.Enabled = false;
            dtpNgaylap.Enabled = false;
            EnableAutoComplete();
        }
        private void PhanQuyenChucNang()
        {
            if (vaiTro == "Nhân viên thủ thư")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào form Phiếu Phục Chế.");
                this.Close();
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào form Phiếu Phục Chế.");
                this.Close();
            }
            else
            {
                //phân quyền
            }
        }
        private void EnableAutoComplete()
        {
            cboChonphieu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Gợi ý và thêm vào
            cboChonphieu.AutoCompleteSource = AutoCompleteSource.ListItems;  // Lấy dữ liệu từ Items của ComboBox
        }
            private void cboChonphieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonphieu.SelectedIndex != -1)
            {
                // Lấy Mã phiếu đã chọn
                string maphieu = cboChonphieu.Text.ToString();

                // Hiển thị các thông tin của phiếu vào các textbox
                string sql = "SELECT * FROM yeucaunhap WHERE Maphieuyeucaunhap = N'" + maphieu + "'";
                DataTable dt = function.GetDataToTable(sql);
                if (dt.Rows.Count > 0)
                {
                    txtMaphieu.Text = dt.Rows[0]["Maphieuyeucaunhap"].ToString();
                    dtpNgaylap.Text = dt.Rows[0]["Ngaylap"].ToString();
                    string manv = dt.Rows[0]["Manhanvien"].ToString();
                    txtManhanvien.Text = manv;
                    // Cập nhật thông tin sách vào DataGridView
                    Load_DataGridViewChitiet(maphieu);
                }
            }
            // Kiểm tra xem có mục nào được chọn không
            if (cboChonphieu.SelectedItem != null)
            {
                string selectedValue = cboChonphieu.SelectedItem.ToString();
                Console.WriteLine(selectedValue); // In giá trị ra console
            }
        }
        private void Load_DataGridViewChitiet(string maphieu)
        {
            string sql = "SELECT a.Masach, b.Tensach, a.Soluong " +
                         "FROM chitietyeucaunhap a " +
                         "JOIN sach b ON a.Masach = b.Masach " +
                         "WHERE a.Maphieuyeucaunhap = N'" + maphieu + "'";
            DataTable dt = function.GetDataToTable(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string maphieu = txtMaphieu.Text;
            string sql = "UPDATE yeucaunhap SET Trangthaiduyet = N'Đã duyệt' WHERE Maphieuyeucaunhap = N'" + maphieu + "'";
            function.RunSql(sql);
            MessageBox.Show("Phiếu đã được duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Sau khi duyệt, cập nhật lại trạng thái
            txtTrangthaiduyet.Text = "Đã duyệt";
            btnKhongduyet.Enabled = false;
        }

        private void btnKhongduyet_Click(object sender, EventArgs e)
        {
            string maphieu = txtMaphieu.Text;
            string sql = "UPDATE yeucaunhap SET Trangthaiduyet = N'Chưa duyệt' WHERE Maphieuyeucaunhap = N'" + maphieu + "'";
            function.RunSql(sql);
            MessageBox.Show("Phiếu không được duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Sau khi không duyệt, cập nhật lại trạng thái
            txtTrangthaiduyet.Text = "Chưa duyệt";
            
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

        private void cboChonphieu_DropDown(object sender, EventArgs e)
        {

        }

        private void cboChonphieu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                // Ngừng xử lý tiếp sự kiện nếu muốn giữ lại giá trị nhập vào
                e.Handled = true; // Ngăn không cho sự kiện Enter tiếp tục
            }
        }
    }
}
