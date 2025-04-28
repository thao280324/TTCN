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
    public partial class Yeucaunhap : Form
    {
        private string vaiTro;
        public Yeucaunhap(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }


        private void Yeucaunhap_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
        }
        private void PhanQuyenChucNang()
        {
            if (vaiTro == "Nhân viên thủ thư")
            {
                //phân quyền
            }
            else if (vaiTro == "Phó ban thủ thư")
            {
               //phân quyền
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào form Phiếu Phục Chế.");
                this.Close();
            }
        }
    }
}
