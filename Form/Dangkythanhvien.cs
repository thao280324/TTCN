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
    public partial class Dangkythanhvien : Form
    {
        private string vaiTro;
        public Dangkythanhvien(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }



        private void Dangkythanhvien_Load(object sender, EventArgs e)
        {
            //phân quyền
        }
    }
}
