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
    public partial class FormPhieutra : Form
    {
        private string vaiTro;
        public FormPhieutra(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void FormPhieutra_Load(object sender, EventArgs e)
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
                MessageBox.Show("Bạn không có quyền truy cập vào form Phiếu Trả.");
                this.Close();
            }
        }
    }
}
