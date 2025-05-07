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

namespace thutap
{
    public partial class Baocaonhapsach : Form
    {
        private string vaiTro;
        public Baocaonhapsach(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }
        private void HienThiBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                string connstring = "Data Source=DESKTOP-6RBUAUT\\SQLEXPRESS;Initial Catalog=thuvien;Integrated Security=True;TrustServerCertificate=True";
                
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    string queryTongSoSach = @"
                    SELECT SUM(CAST(ct.Soluong AS INT)) AS TongSoSachNhap
                    FROM phieunhap pn
                    INNER JOIN chitietnhap ct ON pn.Maphieunhap = ct.Maphieunhap
                    WHERE pn.Ngaynhap >= @TuNgay AND pn.Ngaynhap <= @DenNgay";

                    using (SqlCommand commandTongSoSach = new SqlCommand(queryTongSoSach, connection))
                    {
                        commandTongSoSach.Parameters.AddWithValue("@TuNgay", tuNgay);
                        commandTongSoSach.Parameters.AddWithValue("@DenNgay", denNgay);

                        // Thực thi truy vấn và lấy giá trị tổng số sách (nếu có)
                        object result = commandTongSoSach.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            // Gán giá trị tổng số sách cho txtsoluonghw
                            txtsoluong.Text = result.ToString();
                        }
                        else
                        {
                            txtsoluong.Text = "0"; // Hoặc một giá trị mặc định khác
                        }
                    }

                    // Câu truy vấn SQL để lấy thông tin phiếu nhập, ngày nhập và tổng số sách của mỗi phiếu trong khoảng thời gian
                    string query = @"
                        SELECT pn.Maphieunhap, pn.Ngaynhap, SUM(CAST(ct.Soluong AS INT)) AS TongSoSach
                        FROM phieunhap pn
                        INNER JOIN chitietnhap ct ON pn.Maphieunhap = ct.Maphieunhap
                        WHERE pn.Ngaynhap >= @TuNgay AND pn.Ngaynhap <= @DenNgay
                        GROUP BY pn.Maphieunhap, pn.Ngaynhap
                        ORDER BY pn.Ngaynhap";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TuNgay", tuNgay);
                        command.Parameters.AddWithValue("@DenNgay", denNgay);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Gán DataTable làm nguồn dữ liệu cho DataGridView (giả sử bạn có một DataGridView tên là dgvBaoCao)
                            dgvBaocao.DataSource = dataTable;

                            // Tùy chỉnh tiêu đề các cột (nếu cần)
                            dgvBaocao.Columns["MaPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
                            dgvBaocao.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
                            dgvBaocao.Columns["TongSoSach"].HeaderText = "Tổng Số Sách";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Baocaonhapsach_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime tuNgay;
            DateTime denNgay;

            // Kiểm tra xem người dùng đã nhập ngày chưa
            if (!DateTime.TryParse(txttungay.Text, out tuNgay) || !DateTime.TryParse(txtdenngay.Text, out denNgay))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày (dd/MM/yyyy).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi phương thức để lấy và hiển thị dữ liệu
            HienThiBaoCao(tuNgay, denNgay);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
