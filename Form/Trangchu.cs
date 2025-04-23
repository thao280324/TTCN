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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qLSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach S = new Sach();
            S.Show();
        }
    }
}
