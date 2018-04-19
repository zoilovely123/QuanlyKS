using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        SqlConnection con = DBconnecter.sqlConnector();


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void quanlyDP_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            load();
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
            load();
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
            this.Hide();
            QuanlyDP quanly = new QuanlyDP();
            quanly.FormClosed += new FormClosedEventHandler(quanlyDP_formclosed);
            quanly.Show();
        }

        private void quanlyPh_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            load();
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
            if (txtCMND.Text != "" && txtSDT.Text != "" && txtTen.Text != "")
            {
                if (MessageBox.Show("Xác nhận đặt phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        string madp;
                        madp = timeGD.Value.ToString("ddMMhhmmss");
                        con.Open();
                        string add_DP = "insert into DatPhong values(@maDPh,@maPh,@tenDat,@cmnd,@sdt,NULL,@tinhtrang)";
                        SqlCommand cmd = new SqlCommand(add_DP, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@maDPh", madp.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tenDat", txtTen.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sdt", txtSDT.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tinhtrang", "Wait"));
                        cmd.ExecuteNonQuery();
                        string update_Ph = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                        SqlCommand cm = new SqlCommand(update_Ph, con);
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                        cm.Parameters.Add(new SqlParameter("@tinhtrang","Wait"));
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Đặt phòng thành công!");
                        re_load();
                        load();
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
                }
            }
        }

        public void re_load()
        {
            txtCMND.ReadOnly = true;
            txtTen.Text = null;
            txtSDT.Text = null;
            txtCMND.Text = null;
            txtSDT.ReadOnly = true;
            txtTen.ReadOnly = true;
        }
        public void load()
        {
            con.Open();
            string sql = "select * from Phong";
            SqlCommand ds = new SqlCommand(sql, con);
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dt_DSP.DataSource = dt;
            re_load();
        }
        public string tinhtrang;
        private void dt_DSP_MouseClick(object sender, MouseEventArgs e)
        {
            load_toTB(true);
            if (tinhtrang=="Null")
            {
                txtCMND.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtTen.ReadOnly = false;
                txtTen.Text = null;
                txtSDT.Text = null;
                txtCMND.Text = null;
            }
            else
            {
                re_load();
            }
        }
        public void load_toTB(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    con.Open();
                    curRow = this.dt_DSP.CurrentRow.Index;
                    txtMaph.Text = this.dt_DSP.Rows[curRow].Cells[0].Value.ToString();
                    txtLoai.Text = this.dt_DSP.Rows[curRow].Cells[1].Value.ToString();
                    txtSGiuong.Text = this.dt_DSP.Rows[curRow].Cells[3].Value.ToString();
                    tinhtrang = this.dt_DSP.Rows[curRow].Cells[4].Value.ToString();
                    con.Close();

                }
                catch
                { }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSear.Text == "All") { load(); }
            else {
                con.Open();
                string sql = "select * from Phong where tinhTrang LIKE @tinhtrang";
                SqlCommand ds = new SqlCommand(sql, con);
                ds.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(ds);
                DataTable dt = new DataTable();
                ds.Parameters.Add(new SqlParameter("@tinhtrang", cbSear.Text.Trim()));
                ds.ExecuteNonQuery();
                da.Fill(dt);
                con.Close();
                dt_DSP.DataSource = dt;
                re_load();

            }
        }
    }
}
