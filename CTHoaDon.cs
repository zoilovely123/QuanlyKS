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
    public partial class CTHoaDon : Form
    {
        public CTHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection con = DBconnecter.sqlConnector();

        private void CTHoaDon_Load(object sender, EventArgs e)
        {
            btThToan.Enabled = false;
            con.Open();
            // string sql = "select maTPh,ThuePhong.maPh,tenThue,cmnd,sdt,timeNPh=convert(varchar,timeNPh),loai,soGiuong,donGia from ThuePhong inner join Phong on ThuePhong.maPh = Phong.maPh where ThuePhong.maPh = @maph and ThuePhong.tinhtrang=@tinhtrang";
            string sql = "seclect ct_hd(@maph,@tinhtrang)";
            SqlCommand ds = new SqlCommand(sql, con);
            ds.Parameters.Add(new SqlParameter("@maph", maphong.Trim()));
            ds.Parameters.Add(new SqlParameter("@tinhtrang","New"));
            SqlDataReader dr = ds.ExecuteReader();
            while (dr.Read())
            { 
                txtmaTP.Text = dr["maTPh"].ToString();
                txtMaph.Text = dr["maPh"].ToString();
                txtTen.Text = dr["tenThue"].ToString();
                txtCMND.Text = dr["cmnd"].ToString();
                txtSDT.Text = dr["sdt"].ToString();
                txttimeN.Text = dr["timeNPh"].ToString();
                txtLoai.Text = dr["loai"].ToString();
                txtSGiuong.Text = dr["soGiuong"].ToString();
                dongia = float.Parse(dr["donGia"].ToString());
            }
            dr.Close();
            con.Close();
            loaddata();
        }
        public void loaddata()
        {
            con.Open();
            string data = "select HDdichvu.maGD,dichvu.tenDV,HDdichvu.soluong,giaDV from HDdichvu inner join dichvu on dichvu.maDV=HDdichvu.maDV inner join ThuePhong on ThuePhong.maTPh=HDdichvu.maTPh  where HDdichvu.maTPh=@maTPh";
            SqlCommand hd = new SqlCommand(data, con);
            hd.CommandType = CommandType.Text;
            hd.Parameters.Add(new SqlParameter("@maTPh", txtmaTP.Text.Trim()));
            SqlDataAdapter da = new SqlDataAdapter(hd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dtDV.DataSource = dt;
        }
        public float dongia;
        public DateTime ngaynhan;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                btThToan.Enabled = true;
                txttimeT.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                int giotra = DateTime.Now.Hour;
                int phtra = DateTime.Now.Minute;
                string nhan = txttimeN.Text;
                float tiengio;
                ngaynhan = Convert.ToDateTime(txttimeN.Text);
                int gionhan = ngaynhan.Hour;
                if (ngaynhan.ToString("tt") == "CH") gionhan = gionhan + 12;
                if (ngaynhan.Minute - phtra > 10)
                {
                    tiengio = ((giotra - gionhan + 2) * dongia); }
                else
                {   tiengio = ((giotra - gionhan + 1) * dongia); }

                int sc = dtDV.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                    thanhtien += float.Parse(dtDV.Rows[i].Cells[2].Value.ToString())*float.Parse(dtDV.Rows[i].Cells[3].Value.ToString());
                txttongtien.Text = (thanhtien+tiengio).ToString();
                txttien.Text = tiengio.ToString();
            }
            else { txttimeT.Clear(); txttien.Clear(); txttongtien.Clear(); btThToan.Enabled = false; }
        }

        private string maphong;

        public string MaPhong
        {
            get { return maphong; }
            set { maphong = value; }
        }

        private void btThToan_Click(object sender, EventArgs e)
        {
            string timegd = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

            if (MessageBox.Show("Xác nhận Thanh toán!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string update_tP = "update ThuePhong set tinhtrang=@tinhtrang,timeTrPh=@timeTrPh,thanhtien=@tien where maTPh=@maTPh";
                    SqlCommand cmd = new SqlCommand(update_tP, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@maTPh", txtmaTP.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@timeTrPh", timegd.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@tien", txttien.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@tinhtrang", "Complete"));
                    cmd.ExecuteNonQuery();
                    string update_Ph = "update Phong set tinhTrang=@tinhtrang where maPh=@maPh";
                    SqlCommand cm = new SqlCommand(update_Ph, con);
                    cm.CommandType = CommandType.Text;
                    cm.Parameters.Add(new SqlParameter("@maPh", txtMaph.Text.Trim()));
                    cm.Parameters.Add(new SqlParameter("@tinhtrang", "Null"));
                    cm.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
                catch { MessageBox.Show("Thanh toán không thành công!\nVui lòng kiểm tra lại."); }
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
