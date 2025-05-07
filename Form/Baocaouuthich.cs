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
    public partial class Baocaouuthich : Form
    {
        string connectionString = "Data Source=DESKTOP-6RBUAUT\\SQLEXPRESS;Initial Catalog=thuvien;Integrated Security=True;TrustServerCertificate=True";


        private string vaiTro;
        public Baocaouuthich(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void Baocaouuthich_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((rdbtacgia.Checked == false) && (rdbtheloai.Checked == false))
            {
                MessageBox.Show("Bạn chưa chọn tiêu chí báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
           
            if (dttungay.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập thời gian bắt đầu của báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dttungay.Focus();
                return;
            }
            if (dtdenngay.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập thời gian bắt đầu của báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtdenngay.Focus();
                return;
            }

            DateTime tuNgay = dttungay.Value.Date;
            DateTime denNgay = dtdenngay.Value.Date;

            string query = "";

            if (rdbtheloai.Checked)
            {
                query = @"
                    SSELECT 
                        s.Masach,
                        s.Tensach,
                        tl.Tentheloai,
                        SUM(cast(ct.Soluong as int)) AS TongSoLuongMuon
                    FROM phieumuon pm
                    JOIN chitietmuon ct ON pm.Maphieumuon = ct.Maphieumuon
                    JOIN sach s ON ct.Masach = s.Masach
                    JOIN TheLoai tl ON s.Matheloai = tl.Matheloai
                    WHERE pm.NgayLap BETWEEN @TuNgay AND @DenNgay
                    GROUP BY s.Masach, s.Tensach, tl.Tentheloai
                    ORDER BY TongSoLuongMuon DESC";
            }
            else if (rdbtacgia.Checked)
            {
                query = @"
                    SELECT 
                        s.Masach,
                        s.Tensach,
                        tg.Tentacgia,
                        SUM(cast(ct.Soluong as int)) AS TongSoLuongMuon
                    FROM phieumuon pm
                    JOIN chitietmuon ct ON pm.Maphieumuon = ct.Maphieumuon
                    JOIN sach s ON ct.Masach = s.Masach
                    JOIN Tacgia tg ON s.Matacgia = tg.Matacgia
                    WHERE pm.NgayLap BETWEEN @TuNgay AND @DenNgay
                    GROUP BY s.MaSach, s.TenSach, tg.TenTacGia
                    ORDER BY TongSoLuongMuon DESC";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lọc theo Thể loại hoặc Tác giả.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = function.GetDataToTable(query);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Mã sách";
                dataGridView1.Columns[1].HeaderText = "Tên sách";
                dataGridView1.Columns[1].HeaderText = "Tên tác giả";
                dataGridView1.Columns[1].HeaderText = "Tổng số lượng";




                // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
                dataGridView1.AllowUserToAddRows = false;
                // Không cho phép sửa dữ liệu trực tiếp trên lưới
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {

        }
    }
    }
