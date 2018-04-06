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
    public partial class QuanlyPh : Form
    {
        public QuanlyPh()
        {
            InitializeComponent();
        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công!");
            loadGbTTCT();
        }

        public void loadGbTTCT()
        {
            PanXacnhan.Visible = false;
            PanTool.Visible = true;
            txtSoGiuong.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            cbbLoaiPh.Enabled = false;
            txtMaPh.ReadOnly = true;
            cbbTinhtrang.Enabled = false;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            loadGbTTCT();
        }



        private void btAdd_Click(object sender, EventArgs e)
        {

            PanXacnhan.Visible = true;
            PanTool.Visible = false;
            txtSoGiuong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtMaPh.ReadOnly = false;
            cbbLoaiPh.Enabled = true;
            cbbTinhtrang.Enabled = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            PanXacnhan.Visible = true;
            PanTool.Visible = false;
            txtSoGiuong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            cbbLoaiPh.Enabled = true;
            cbbTinhtrang.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("Xóa phòng thành công!");
            }
        }


    }
}
