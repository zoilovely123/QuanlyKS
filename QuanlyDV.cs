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
    public partial class QuanlyDV : Form
    {
        public QuanlyDV()
        {
            InitializeComponent();
        }
        SqlConnection con = DBconnecter.sqlConnector();
        public void LoadGB()
        {
            con.Open();
            string sql = "select * from dichvu";
            SqlCommand ds = new SqlCommand(sql, con);
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            data_DSDV.DataSource = dt;
            PanXacnhan.Visible = false;
            PanTool.Visible = true;
            txtSoluong.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtMaDV.ReadOnly = true;
            txtTenDV.ReadOnly = true;
            cbbPhong.Enabled = false;
            btBan.Enabled = false;
            nbSluong.Value = 0;
            clearGb();
        }
        public void clearGb()
        {
            txtSoluong.Text = null;
            txtDonGia.Text = null;
            txtMaDV.Text = null;
            txtTenDV.Text = null;
        }
        private void QuanlyDV_Load(object sender, EventArgs e)
        {
            LoadGB();
        }
        public void loadToComboBox()
        {
            cbbPhong.Enabled = true;
            con.Open();
            string sql = "select maPh from Phong where tinhTrang=@tinhtrang";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            com.Parameters.Add(new SqlParameter("@tinhtrang", "Used"));
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbPhong.DataSource = dt;
            cbbPhong.DisplayMember = "maPh";
            cbbPhong.ValueMember = "maPh";
            cbbPhong.Text = "Chọn phòng";
            con.Close();
        }

        private void load_textbox(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    con.Open();
                    curRow = this.data_DSDV.CurrentRow.Index;
                    txtMaDV.Text = this.data_DSDV.Rows[curRow].Cells[0].Value.ToString();
                    txtTenDV.Text = this.data_DSDV.Rows[curRow].Cells[1].Value.ToString();
                    txtSoluong.Text = this.data_DSDV.Rows[curRow].Cells[2].Value.ToString();
                    txtDonGia.Text = this.data_DSDV.Rows[curRow].Cells[3].Value.ToString();
                    con.Close();
                }
                catch
                { }
            }
        }

        private void data_DSDV_MouseClick(object sender, MouseEventArgs e)
        {
            load_textbox(true);
            loadToComboBox();

        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            LoadGB();
        }
        private string maDV;

        private void btXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            int curRow = this.data_DSDV.CurrentRow.Index;
            string del_DV = "delete from dichvu where maDV=@maDV";
            SqlCommand cmd = new SqlCommand(del_DV, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@maDV", this.maDV = this.data_DSDV.Rows[curRow].Cells[0].Value.ToString()));
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                load_textbox(true);
                LoadGB();
            }
        }
        private bool id = false;

        private void btAdd_Click(object sender, EventArgs e)
        {
            id = false;
            PanXacnhan.Visible = true;
            PanTool.Visible = false;
            txtSoluong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtTenDV.ReadOnly = false;
            txtMaDV.ReadOnly = false;
            clearGb();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            id = true;
            PanXacnhan.Visible = true;
            PanTool.Visible = false;
            txtSoluong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtTenDV.ReadOnly = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            if (id)
            {
                if ((txtMaDV.Text != "") && (txtTenDV.Text != "") && (txtSoluong.Text != "") && (txtDonGia.Text != ""))
                    try
                    {
                        con.Open();
                        string edit_NV = "update dichvu set tenDV=@tendv,soluong=@soluong,giaDV=@giadv where maDV=@madv";
                        SqlCommand cmd = new SqlCommand(edit_NV, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@madv", txtMaDV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@soluong", txtSoluong.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tendv", txtTenDV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@giaDV", txtDonGia.Text.Trim()));
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Sửa thông tin dịch vụ thành công!");
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
            }
            else
            {
                if ((txtMaDV.Text != "") && (txtTenDV.Text != "") && (txtSoluong.Text != "") && (txtDonGia.Text != ""))
                    try
                    {

                        con.Open();
                        string edit_NV = "insert into dichvu values (@madv,@tendv,@soluong,@giaDV)";
                        SqlCommand cmd = new SqlCommand(edit_NV, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@madv", txtMaDV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@soluong", txtSoluong.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tendv", txtTenDV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@giaDV", txtDonGia.Text.Trim()));
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Thêm dịch vụ thành công!");
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
            }
            LoadGB();
        }

        private void cbbPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            btBan.Enabled = true;
        }
        string matph;

        private void btBan_Click(object sender, EventArgs e)
        {
            string madv = DateTime.Now.ToString("ddMMyyhhmmss");
            if (cbbPhong.Text!="Chọn phòng" && nbSluong.Value!=0)
            {
                try
                {
                    con.Open();
                    string sql = "select maTPh from ThuePhong inner join Phong on ThuePhong.maPh = Phong.maPh where ThuePhong.maPh = @maph and ThuePhong.tinhtrang=@tinhtrang";
                    SqlCommand ds = new SqlCommand(sql, con);
                    ds.Parameters.Add(new SqlParameter("@maph", cbbPhong.Text.Trim()));
                    ds.Parameters.Add(new SqlParameter("@tinhtrang", "New"));
                    SqlDataReader dr = ds.ExecuteReader();
                    while (dr.Read())
                    {
                        matph = dr["maTPh"].ToString();
                    }
                    dr.Close();
                    con.Close();
                    con.Open();
                    string edit_NV = "insert into HDdichvu values (@maGD,@maTPH,@maDV,@soluong)";
                    SqlCommand cmd = new SqlCommand(edit_NV, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@maGD", madv.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@maTPH", matph.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@maDV", txtMaDV.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@soluong", nbSluong.Value.ToString().Trim()));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    string edit_DV = "update dichvu set soluong=@soluong where maDV=@madv";
                    SqlCommand ed = new SqlCommand(edit_DV, con);
                    ed.CommandType = CommandType.Text;
                    ed.Parameters.Add(new SqlParameter("@madv", txtMaDV.Text.Trim()));
                    ed.Parameters.Add(new SqlParameter("@soluong", (int.Parse(txtSoluong.Text)-nbSluong.Value).ToString().Trim()));
                    ed.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Giao dịch thành công!");
                }
                catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
                LoadGB();
            }
        }
    }
}
