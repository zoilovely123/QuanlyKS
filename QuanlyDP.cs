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
    public partial class QuanlyDP : Form
    {
        public QuanlyDP()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận nhận phòng!", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("Nhận phòng thành công!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
