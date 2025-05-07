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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
            txtMatkhau.PasswordChar = '●';
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTendangnhap.Text.Trim();
            string matKhau = txtMatkhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo");
                return;
            }

            if (KiemTraDangNhap(tenDangNhap, matKhau, out string vaiTro))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                FrmMain formMain = new FrmMain(tenDangNhap, vaiTro);
                this.Hide();                 // Ẩn form đăng nhập
                formMain.ShowDialog();       // Mở form chính
                this.Close();                // Đóng form đăng nhập sau khi tắt form chính
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập");
            }
        }
        private bool KiemTraDangNhap(string tenDangNhap, string matKhau, out string vaiTro)
        {
            vaiTro = "";

            try
            {
                // Đảm bảo đã kết nối
                if (function.Conn == null || function.Conn.State != ConnectionState.Open)
                {
                    function.Connect();
                }

                string query = "SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(query, function.Conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    vaiTro = result.ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn: " + ex.Message);
            }

            return false;
        }
    }
}
