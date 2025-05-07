using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tuNgay = txttungay.Text; // Giả sử txtTuNgay là TextBox chứa "Từ ngày"
            string denNgay = txtdenngay.Text; // Giả sử txtDenNgay là TextBox chứa "Đến ngày"

            Excel.Application exApp = null;
            Excel.Workbook exBook = null;
            Excel.Worksheet exSheet = null;
            Excel.Range exRange = null;

            try
            {
                // Khởi tạo ứng dụng Excel
                exApp = new Excel.Application();
                exBook = exApp.Workbooks.Add(Type.Missing);
                exSheet = (Excel.Worksheet)exBook.Sheets[1]; // Lấy sheet đầu tiên

                // Đặt tiêu đề báo cáo
                exRange = exSheet.Cells[1, 1];
                exRange.Value2 = "BÁO CÁO SỐ LƯỢNG NHẬP SÁCH";
                exRange.Font.Bold = true;
                exRange.Font.Size = 14;

                // Thông tin về thời gian
                exSheet.Cells[2, 1].Value2 = $"Từ ngày: {tuNgay}";
                exSheet.Cells[3, 1].Value2 = $"Đến ngày: {denNgay}";

                // Tiêu đề các cột
                exSheet.Cells[5, 1].Value2 = "Mã Phiếu Nhập";
                exSheet.Cells[5, 2].Value2 = "Ngày Nhập";
                exSheet.Cells[5, 3].Value2 = "Tổng Số Sách";

                // Đổ dữ liệu từ DataGridView (nếu có)
                if (dgvBaocao.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvBaocao.Rows.Count; i++)
                    {
                        if (!dgvBaocao.Rows[i].IsNewRow)
                        {
                            exSheet.Cells[i + 6, 1].Value2 = dgvBaocao.Rows[i].Cells["MaPhieuNhap"].Value?.ToString();
                            exSheet.Cells[i + 6, 2].Value2 = dgvBaocao.Rows[i].Cells["NgayNhap"].Value?.ToString();
                            exSheet.Cells[i + 6, 3].Value2 = dgvBaocao.Rows[i].Cells["TongSoSach"].Value?.ToString();
                        }
                    }

                    // Định dạng bảng dữ liệu (tùy chọn)
                    exRange = exSheet.Range[exSheet.Cells[5, 1], exSheet.Cells[dgvBaocao.Rows.Count + 5, 3]];
                    exRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    exRange.Columns.AutoFit();
                }
                else
                {
                    exSheet.Cells[6, 1].Value2 = "Không có dữ liệu để xuất.";
                }

                // Tổng số lượng (nếu có TextBox txtSoLuong)
                if (!string.IsNullOrEmpty(txtsoluong.Text))
                {
                    exSheet.Cells[dgvBaocao.Rows.Count + 7, 1].Value2 = "Tổng số lượng:";
                    exSheet.Cells[dgvBaocao.Rows.Count + 7, 2].Value2 = txtsoluong.Text;
                    exSheet.Cells[dgvBaocao.Rows.Count + 7, 2].Font.Bold = true;
                }

                // Hiển thị hoặc lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.Title = "Lưu báo cáo Excel";
                saveFileDialog.FileName = $"BaoCaoNhapSach_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook,
                        Type.Missing, Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    MessageBox.Show("Xuất báo cáo ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Nếu người dùng không chọn lưu, bạn có thể hiển thị Excel
                    exApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất ra Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Giải phóng các đối tượng COM
                if (exRange != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(exRange);
                if (exSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(exSheet);
                if (exBook != null) exBook.Close(false, Type.Missing, Type.Missing);
                if (exApp != null) exApp.Quit();

                // Giải phóng bộ nhớ
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
