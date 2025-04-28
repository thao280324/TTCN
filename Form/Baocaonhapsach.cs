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
    public partial class Baocaonhapsach : Form
    {
        private string vaiTro;
        public Baocaonhapsach(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void Baocaonhapsach_Load(object sender, EventArgs e)
        {
            if (vaiTro == "Phó ban thủ thư")
            {
                //phân quyền
            }
            else if (vaiTro == "Trưởng ban thủ thư")
            {
                //phân quyền
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem báo cáo!");
                this.Close();
            }
        }
    }
}
