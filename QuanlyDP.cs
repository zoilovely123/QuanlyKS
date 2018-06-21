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
            string timegd = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            if (MessageBox.Show("Xác nhận nhận phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string matp;
                    matp = DateTime.Now.ToString("yyyyMMddhhmmss");
                    string update_DP = "update DatPhong set tinhTrang=@tinhtrang , timeNPh=@timeNPh where maPh=@maPh";
                    SqlCommand cm = new SqlCommand(update_DP, con);
                    cm.CommandType = CommandType.Text;
                    cm.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                    cm.Parameters.Add(new SqlParameter("@tinhtrang", "Used"));
                    cm.Parameters.Add(new SqlParameter("@timeNPh", timegd.Trim()));

                    cm.ExecuteNonQuery();

                    string update_Ph = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                    SqlCommand cmd = new SqlCommand(update_Ph, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@tinhtrang", "Used"));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    load();
                    con.Open();
                    string add_TP = "insert into ThuePhong values(@maTPh,@maPh,@tenThue,@cmnd,@sdt,@timeNPh,NULL,NULL,@tinhtrang)";
                    SqlCommand tp = new SqlCommand(add_TP, con);
                    tp.CommandType = CommandType.Text;
                    tp.Parameters.Add(new SqlParameter("@maTPh", matp.Trim()));
                    tp.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                    tp.Parameters.Add(new SqlParameter("@tenThue", txtten.Text.Trim()));
                    tp.Parameters.Add(new SqlParameter("@cmnd", txtcmnd.Text.Trim()));
                    tp.Parameters.Add(new SqlParameter("@sdt", txtsdt.Text.Trim()));
                    tp.Parameters.Add(new SqlParameter("@timeNPh", timegd.Trim()));
                    tp.Parameters.Add(new SqlParameter("@tinhtrang", "New"));
                    tp.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Nhận phòng thành công!");
                    btnhan.Enabled = true;
                    bthuy.Enabled = true;
                    clearTB();
                    cbSear.Text = "All";

                }
                catch { MessageBox.Show("Nhận phòng không thành công!\nVui lòng kiểm tra lại."); }
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
                try
                {
                    con.Open();
                    string update_DP = "update DatPhong set tinhTrang=@tinhtrang where maDPh=@madp";
                    SqlCommand cm = new SqlCommand(update_DP, con);
                    cm.CommandType = CommandType.Text;
                    cm.Parameters.Add(new SqlParameter("@madp", madp.Trim()));
                    cm.Parameters.Add(new SqlParameter("@tinhtrang", "Close"));
                    cm.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    string update_Ph = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                    SqlCommand cmd = new SqlCommand(update_Ph, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@tinhtrang", "Null"));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Hủy đặt phòng thành công!");
                    load();
                    clearTB();
                    cbSear.Text = "All";
                }
                catch { MessageBox.Show("Hủy đặt phòng không thành công!\nVui lòng kiểm tra lại."); }
            }

        }

        public void clearTB()
        {
            txtcmnd.Text = null;
            txtloai.Text = null;
            txtMaph.Text = null;
            txtsdt.Text = null;
            txtSGiuong.Text = null;
            txtten.Text = null;
            txttime.Text = null;
            txttimenhan.Text = null;
            txttinhtrang.Text = null;
        }
        private void QuanlyDP_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            con.Open();
            string sql = "select maDPh, DatPhong.maPh, Phong.loai, soGiuong, tenDat,cmnd,sdt,timeDPh=CONVERT(varchar,timeDPh), timeNPh=CONVERT(varchar,timeNPh), DatPhong.tinhtrang from DatPhong inner join Phong on DatPhong.maPh=Phong.maPh ORDER BY maDPh DESC";
            SqlCommand ds = new SqlCommand(sql, con);
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            data_dp.DataSource = dt;
        }
        public string madp;
        public void load_toTB(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    curRow = this.data_dp.CurrentRow.Index;
                    madp = this.data_dp.Rows[curRow].Cells[0].Value.ToString();
                    txtMaph.Text = this.data_dp.Rows[curRow].Cells[1].Value.ToString();
                    txtloai.Text = this.data_dp.Rows[curRow].Cells[2].Value.ToString();
                    txtSGiuong.Text = this.data_dp.Rows[curRow].Cells[3].Value.ToString();
                    txtten.Text = this.data_dp.Rows[curRow].Cells[4].Value.ToString();
                    txtcmnd.Text = this.data_dp.Rows[curRow].Cells[5].Value.ToString();
                    txtsdt.Text = this.data_dp.Rows[curRow].Cells[6].Value.ToString();
                    txttime.Text = this.data_dp.Rows[curRow].Cells[7].Value.ToString();
                    txttimenhan.Text = this.data_dp.Rows[curRow].Cells[8].Value.ToString();
                    txttinhtrang.Text = this.data_dp.Rows[curRow].Cells[9].Value.ToString();
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
                btnhan.Enabled = true;
                bthuy.Enabled = true;

            }
            else
            {
                btnhan.Enabled = false;
                bthuy.Enabled = false;
            }
        }

        private void cbSear_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbSear.Text == "All") { load(); }
            else
            {
                con.Open();
                string sql = "select maDPh, DatPhong.maPh, Phong.loai, soGiuong, tenDat,cmnd,sdt,timeDPh=CONVERT(varchar,timeDPh), timeNPh=CONVERT(varchar,timeNPh), DatPhong.tinhtrang from DatPhong inner join Phong on DatPhong.maPh=Phong.maPh where DatPhong.tinhtrang=@tinhtrang ORDER BY maDPh DESC";
                SqlCommand ds = new SqlCommand(sql, con);
                ds.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(ds);
                DataTable dt = new DataTable();
                ds.Parameters.Add(new SqlParameter("@tinhtrang", cbSear.Text.Trim()));
                ds.ExecuteNonQuery();
                da.Fill(dt);
                con.Close();
                data_dp.DataSource = dt;
                clearTB();
            }
        }
    }
}
