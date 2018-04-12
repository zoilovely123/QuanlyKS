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
        SqlConnection con = DBconnecter.sqlConnector();

        private void btLuu_Click(object sender, EventArgs e)
        {
        
            if (id)
            {
                if ((txtDonGia.Text!="")&&(txtMaPh.Text!="")&&(txtSoGiuong.Text!="")&&(cbbLoaiPh.Text!="")&&(cbbTinhtrang.Text!=""))
                    try
                    {

                        con.Open();
                        string edit_NV = "update Phong set loai=@loai,donGia=@dongia,soGiuong=@sogiuong,tinhTrang=@tinhtrang where maPh=@maph";
                        SqlCommand cmd = new SqlCommand(edit_NV, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@maph", txtMaPh.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@loai", cbbLoaiPh.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tinhtrang", cbbTinhtrang.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@dongia", txtDonGia.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sogiuong", txtSoGiuong.Text.Trim()));
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Sửa thông tin nhân viên thành công!");
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
            }
            else
            {
                if ((txtDonGia.Text != "") && (txtMaPh.Text != "") && (txtSoGiuong.Text != "") && (cbbLoaiPh.Text != "") && (cbbTinhtrang.Text != ""))
                    try
                    {

                        con.Open();
                        string edit_NV = "insert into Phong values (@maph,@loai,@dongia,@sogiuong,@tinhtrang)";
                        SqlCommand cmd = new SqlCommand(edit_NV, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@maph", txtMaPh.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@loai", cbbLoaiPh.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tinhtrang", cbbTinhtrang.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@dongia", txtDonGia.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sogiuong", txtSoGiuong.Text.Trim()));
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Thêm nhân viên thành công!");
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
            }
            loadGbTTCT();

        }


        public void loadGbTTCT()
        {
            con.Open();
            string sql = "select * from Phong";
            SqlCommand ds = new SqlCommand(sql, con);
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds);
            DataTable dt = new DataTable();
             da.Fill(dt);
            con.Close();
            data_DSPh.DataSource = dt;
            PanXacnhan.Visible = false;
            PanTool.Visible = true;
            txtSoGiuong.ReadOnly = true;
            txtSoGiuong.Text = null;
            txtDonGia.ReadOnly = true;
            txtDonGia.Text = null;
            cbbLoaiPh.Enabled = false;
            txtMaPh.ReadOnly = true;
            txtMaPh.Text = null;
            cbbTinhtrang.Enabled = false;
            cbbTinhtrang.Text = null;
            cbbLoaiPh.Text = null;
        }


        private bool id = false;


        private void btAdd_Click_1(object sender, EventArgs e)
        {
            id = false;
            PanXacnhan.Visible = true;
            PanTool.Visible = false;
            txtSoGiuong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtMaPh.ReadOnly = false;
            cbbLoaiPh.Enabled = true;
            cbbTinhtrang.Enabled = true;
        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            id = true;
            PanXacnhan.Visible = true;
            PanTool.Visible = false;
            txtSoGiuong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            cbbLoaiPh.Enabled = true;
            cbbTinhtrang.Enabled = true;
        }

        private void QuanlyPh_Load(object sender, EventArgs e)
        {
            loadGbTTCT();
        }

        private void load_textbox(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    con.Open();
                    curRow = this.data_DSPh.CurrentRow.Index;
                    txtMaPh.Text= this.data_DSPh.Rows[curRow].Cells[0].Value.ToString();
                    cbbLoaiPh.Text = this.data_DSPh.Rows[curRow].Cells[1].Value.ToString();
                    txtDonGia.Text = this.data_DSPh.Rows[curRow].Cells[2].Value.ToString();
                    txtSoGiuong.Text = this.data_DSPh.Rows[curRow].Cells[3].Value.ToString();
                    cbbTinhtrang.Text = this.data_DSPh.Rows[curRow].Cells[4].Value.ToString();
                    con.Close();
                }
                catch
                { }
            }
        }


        private void data_DSPh_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            load_textbox(true);

        }

        private void btHuy_Click_1(object sender, EventArgs e)
        {
            loadGbTTCT();
        }
        private string maph;
        private void btXoa_Click_1(object sender, EventArgs e)
        {
                con.Open();
                int curRow = this.data_DSPh.CurrentRow.Index;
                string del_SP = "delete from Phong where maPh=@MAPH";
                SqlCommand cmd = new SqlCommand(del_SP, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@MAPH", this.maph = this.data_DSPh.Rows[curRow].Cells[0].Value.ToString()));
                if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    load_textbox(true);
                    loadGbTTCT();
            }
        }
    }
}
