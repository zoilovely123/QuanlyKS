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
    public partial class Dangnhap : Form
    {
        QuanlyTP quanlytp = new QuanlyTP();
        public Dangnhap()
        {
            InitializeComponent();
        }
        
        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
        private void quanlyTP_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
                this.Hide();
                QuanlyTP quanly = new QuanlyTP();
                quanly.FormClosed += new FormClosedEventHandler(quanlyTP_formclosed);
                quanly.TenDangNhap = txtUser.Text;
                quanly.Show();
                txtUser.Clear();
                txtPass.Clear();
            }
        }
    }
