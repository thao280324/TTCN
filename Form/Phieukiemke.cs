using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thutap
{
    public partial class Phieukiemke : Form
    {
        private string vaiTro;

        public Phieukiemke(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void Phieukiemke_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
        }
        private void PhanQuyenChucNang()
        {
            if (vaiTro == "Nhân viên thủ thư")
            {
              //phân quyền nút
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
                //phân quyền nút
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào form Phiếu Kiểm Kê.");
                this.Close();
            }
        }

        private void plheader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
