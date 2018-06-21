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
    public partial class thongKe : Form
    {
        public thongKe()
        {
            InitializeComponent();
        }
        SqlConnection con = DBconnecter.sqlConnector();



        private void bt_search_Click(object sender, EventArgs e)
        {
            string dayto = date_to.Value.ToString("yyyy-MM-dd");
            string dayfrom = date_from.Value.ToString("yyyy-MM-dd");
            string sql = "select * from ThuePhong where timeTrPh >= @dayto and timeTrPh <= @dayfrom";
            if (dayfrom==dayto)
            {
                sql = "select * from ThuePhong where timeTrPh >= @dayto and DAY(timeTrPh) <= DAY(@dayfrom)+1";
            }
            con.Open();
            SqlCommand ds = new SqlCommand(sql, con);
            ds.CommandType = CommandType.Text;
            ds.Parameters.Add(new SqlParameter("@dayto", dayto.Trim()));
            ds.Parameters.Add(new SqlParameter("@dayfrom", dayfrom.Trim()));
            SqlDataAdapter da = new SqlDataAdapter(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dt_tien.DataSource = dt;
            float sum=0;
            for (int i =0; i<dt_tien.RowCount-1;i++)
            {
                sum = sum + float.Parse(dt_tien.Rows[i].Cells["thanhtien"].Value.ToString());
            }
            tb_tien.Text = sum.ToString();
        }
    }
}
