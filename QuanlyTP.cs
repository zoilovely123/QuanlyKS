using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKS
{
    public partial class QuanlyTP : Form
    {
        private string tendangnhap;
        public QuanlyTP()
        {
            InitializeComponent();
        }
        public string TenDangNhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void quanlyDP_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thuê phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("Thuê phòng thành công!");
            }
        }

        private void QuanlyTP_Load(object sender, EventArgs e)
        {
            lblXinchao.Text = "Xin chào, " + tendangnhap;
            if (tendangnhap=="admin")
            {

            }
            else
            {
                quanlyPh.Visible=false;
                quanlyNV.Visible = false;
                thongke.Visible = false;
            }
        }

        private void quanLyĐătPhongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            QuanlyDP quanly = new QuanlyDP();
            quanly.FormClosed += new FormClosedEventHandler(quanlyDP_formclosed);
            quanly.Show();
        }

        private void quanlyPh_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void quanlyPh_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanlyPh quanly = new QuanlyPh();
            quanly.FormClosed += new FormClosedEventHandler(quanlyPh_formclosed);
            quanly.Show();
        }

        private void quanlyNV_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void quanlyNV_Click(object sender, EventArgs e)
        {
            QuanlyNV quanly = new QuanlyNV();
            this.Hide();
            quanly.FormClosed += new FormClosedEventHandler(quanlyNV_formclosed);
            quanly.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đặt phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("Đặt phòng thành công!");
            }
        }
    }
}
