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
    public partial class Sach : Form
    {
        private string vaiTro;
        public Sach(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            PhanQuyenChucNang();
        }
        private void PhanQuyenChucNang()
        {
            if (vaiTro == "Phó ban thủ thư")
            {
                //phân quyền các nút
            }
            else if (vaiTro == "Nhân viên thủ thư")
            {
                //phân quyền các nút
            }
            else if (vaiTro == "Trưởng ban thủ thư")
            {
                MessageBox.Show("Bạn không có quyền vào form này!");
                this.Close();
            }

        }
    }
}
