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
    public partial class HTQLKS : Form
    {
        public HTQLKS()
        {
            InitializeComponent();
        }
        private string tendangnhap;

        public string TenDangNhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
        private void home()
        {
            QuanlyTP quanly = new QuanlyTP();
            quanly.MdiParent = this;
            quanly.Show();
            truoc = quanly;
            
        }
     public   Form truoc = new Form();

        private void HTQLKS_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            home();
            lblXinchao.Text = "Xin chào, " + tendangnhap;
            if (tendangnhap == "admin")
            {

            }
            else
            {
                quanlyPh.Visible = false;
                quanlyNV.Visible = false;
                thongke.Visible = false;
            }
        }



        private void quanLyĐătPhongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanlyDP quanly = new QuanlyDP();
            quanly.MdiParent = this;
            quanly.Show();
            truoc.Close();
            truoc = quanly;
        }

        private void quanlyDV_Click(object sender, EventArgs e)
        {
            QuanlyDV quanly = new QuanlyDV();
            quanly.MdiParent = this;
            quanly.Show();
            truoc.Close();
            truoc = quanly;
        }

        private void quanlyPh_Click(object sender, EventArgs e)
        {
            QuanlyPh quanly = new QuanlyPh();
            quanly.MdiParent = this;
            quanly.Show();
            truoc.Close();
            truoc = quanly;
        }

        private void quanlyNV_Click(object sender, EventArgs e)
        {
            QuanlyNV quanly = new QuanlyNV();
            quanly.MdiParent = this;
            quanly.Show();
            truoc.Close();
            truoc = quanly;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            thongKe quanly = new thongKe();
            quanly.MdiParent = this;
            quanly.Show();
            truoc.Close();
            truoc = quanly;
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home();
        }
    }
}
