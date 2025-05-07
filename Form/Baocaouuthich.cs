using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
               
           
            if (txttungay.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập thời gian bắt đầu của báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttungay.Focus();
                return;
            }
            if (txtdenngay.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập thời gian bắt đầu của báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdenngay.Focus();
                return;
            }
                
                if (Convert.ToDateTime(txttungay.Text) > Convert.ToDateTime(txtdenngay.Text))
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttungay.Text = "  /  /";
                    txtdenngay.Text = "  /  /";
                    return;
                }
            string dk = "where Ngaymuon between " + txtdenngay.Text + " and " + txtdenngay.Text;
            if (rdbtacgia.Checked == true)
            {
                string sql = "select tensach,sum(C.soluong) as tsl from (phieumuon P join chitietmuon C on P.Maphieumuon=C.Maphieumuon)join sach S on C.Masach=S.Masach"
                    + dk + " group by tensach order by tsl desc";
                DataTable dt = new DataTable();
                dt = Class.function.GetDataToTable(sql);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Tên sách";
                dataGridView1.Columns[1].HeaderText = "Số lượng";
            }
            if (rdbtheloai.Checked == true)
            {
                string sql = "select tenhangsx,sum(C.soluong) as tsl from ((tbldondathang D join tblchitietddh C on D.soddh=C.soddh)join tbldmhang H on C.mahang=H.mahang) join tblhangsx S on H.mahangsx=S.mahangsx "
                    + dk + " group by tenhangsx order by tsl desc";
                DataTable dt = new DataTable();
                dt = Class.function.GetDataToTable(sql);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Tên sách";
                dataGridView1.Columns[1].HeaderText = "Số lượng";

            }
            
            btnin.Enabled = true;
            btntimlai.Enabled = true;
            btntim.Enabled = false;
            foreach (Control Ctl in this.Controls)
                if ((Ctl is System.Windows.Forms.TextBox) || (Ctl is MaskedTextBox))
                    Ctl.Enabled = false;
            rdbtheloai.Enabled = false;
            rdbtacgia.Enabled = false;
            
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
    }
    }
