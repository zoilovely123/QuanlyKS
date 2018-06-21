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
        public QuanlyTP()
        {
            InitializeComponent();
        }
       
        
       
        SqlConnection con = DBconnecter.sqlConnector();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void quanlyDP_formclosed(object sender, FormClosedEventArgs e)
        {
            load();

        }




        private void QuanlyTP_Load(object sender, EventArgs e)
        {

            load();
            
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



        public void re_load()
        {
            txtCMND.ReadOnly = true;
            txtTen.Text = null;
            txtSDT.Text = null;
            txtCMND.Text = null;
            txtSDT.ReadOnly = true;
            txtTen.ReadOnly = true;
            btDat.Enabled = false;
            btThue.Enabled = false;
            btTra.Enabled = false;
        }
        public void load()
        {
            con.Open();
            pnDP.Show();
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



        private void CTHoaDon_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            load();
        }

        private void dt_DSP_MouseClick_1(object sender, MouseEventArgs e)
        {
            re_load();
            load_toTB(true);
            if (tinhtrang == "Null")
            {
                txtCMND.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtTen.ReadOnly = false;
                txtTen.Text = null;
                txtSDT.Text = null;
                txtCMND.Text = null;
                btThue.Enabled = btDat.Enabled = true;
            }
            else
            {
                if (tinhtrang == "Used") { btTra.Enabled = true; }
                else re_load();
            }
        }

        private void btTra_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CTHoaDon quanly = new CTHoaDon();
            quanly.FormClosed += new FormClosedEventHandler(CTHoaDon_formclosed);
            quanly.MaPhong = txtMaph.Text.ToString();
            quanly.Show();
        }

        private void btDat_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text != "" && txtSDT.Text != "" && txtTen.Text != "")
            {
                if (MessageBox.Show("Xác nhận đặt phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        string madp;
                        madp = timeGD.Value.ToString("yyyyMMddhhmmss");
                        string timegd;
                        timegd = timeGD.Value.ToString("yyyy/MM/dd hh:mm:ss");
                        con.Open();
                        string add_DP = "insert into DatPhong values(@maDPh,@maPh,@tenDat,@cmnd,@sdt,@timeDP,NULL,@tinhtrang)";
                        SqlCommand cmd = new SqlCommand(add_DP, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@maDPh", madp.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tenDat", txtTen.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sdt", txtSDT.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@timeDP", timegd.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tinhtrang", "Wait"));
                        cmd.ExecuteNonQuery();
                        string update_Ph = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                        SqlCommand cm = new SqlCommand(update_Ph, con);
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                        cm.Parameters.Add(new SqlParameter("@tinhtrang", "Wait"));
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

        private void btThue_Click(object sender, EventArgs e)
        {
            string timegd = timeGD.Value.ToString("yyyy/MM/dd hh:mm:ss");
            if (MessageBox.Show("Xác nhận thuê phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string matp;
                matp = timeGD.Value.ToString("yyyyMMddhhmmmss");
                con.Open();
                string add_TP = "insert into ThuePhong values(@maTPh,@maPh,@tenThue,@cmnd,@sdt,@timeNPh,NULL,NULL,@tinhtrang)";
                SqlCommand cmd = new SqlCommand(add_TP, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@maTPh", matp.Trim()));
                cmd.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@tenThue", txtTen.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@sdt", txtSDT.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@timeNPh", timegd.Trim()));
                cmd.Parameters.Add(new SqlParameter("@tinhtrang", "New"));
                cmd.ExecuteNonQuery();
                string update_Ph = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                SqlCommand cm = new SqlCommand(update_Ph, con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                cm.Parameters.Add(new SqlParameter("@tinhtrang", "Used"));
                cm.ExecuteNonQuery();
                con.Close();
                re_load();
                load();
                MessageBox.Show("Thuê phòng thành công!");
            }
        }

        private void cbSear_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSear.Text == "All") { load(); }
            else
            {
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
