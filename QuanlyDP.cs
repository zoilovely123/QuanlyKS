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
    public partial class QuanlyDP : Form
    {
        public QuanlyDP()
        {
            InitializeComponent();
        }

        SqlConnection con = DBconnecter.sqlConnector();


        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận nhận phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                string update_DP = "update DatPhong set tinhTrang=@tinhtrang where maPh=@maPh";
                SqlCommand cm = new SqlCommand(update_DP, con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                cm.Parameters.Add(new SqlParameter("@tinhtrang", "Used"));
                cm.ExecuteNonQuery();

                string update_Ph = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                SqlCommand cmd = new SqlCommand(update_Ph, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@tinhtrang", "Used"));
                cmd.ExecuteNonQuery();
                con.Close();
                load();
                MessageBox.Show("Nhận phòng thành công!");
                btnhan.Enabled = true;
                bthuy.Enabled = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy đặt phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                string update_DP = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                SqlCommand cm = new SqlCommand(update_DP, con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                cm.Parameters.Add(new SqlParameter("@tinhtrang", "Close"));
                cm.ExecuteNonQuery();
                con.Close();
                load();
                MessageBox.Show("Hủy đặt phòng thành công!");
            }
        }

        private void QuanlyDP_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            con.Open();
            string sql = "select * from DatPhong";
            SqlCommand ds = new SqlCommand(sql, con);
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            data_dp.DataSource = dt;
        }
        public void load_toTB(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    curRow = this.data_dp.CurrentRow.Index;
                    txtMaph.Text = this.data_dp.Rows[curRow].Cells[1].Value.ToString();
                    txtten.Text = this.data_dp.Rows[curRow].Cells[2].Value.ToString();
                    txtcmnd.Text = this.data_dp.Rows[curRow].Cells[3].Value.ToString();
                    txtsdt.Text = this.data_dp.Rows[curRow].Cells[4].Value.ToString();
                    txttinhtrang.Text = this.data_dp.Rows[curRow].Cells[6].Value.ToString();
                }
                catch
                { }
            }
        }



        private void data_dp_MouseClick_1(object sender, MouseEventArgs e)
        {
            load_toTB(true);
            if (txttinhtrang.Text == "Wait")
            {
                btnhan.Enabled = false;
                bthuy.Enabled = false;

            }
            else
            {
                btnhan.Enabled = true;
                bthuy.Enabled = true;
            }
        }
    }
}
