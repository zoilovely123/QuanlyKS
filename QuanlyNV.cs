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
    public partial class QuanlyNV : Form
    {
        public QuanlyNV()
        {
            InitializeComponent();
        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection con = DBconnecter.sqlConnector();
        private object da;
        private object ds;
        private string manv, tennv, gioitinh, ngaysinh, Sdt, Cmnd, chucvu, diachi, timelam, timenghi;

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtTenNV.ReadOnly = false;
            cbbGTinh.Enabled = true;
            txtCMND.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            cbbChucVu.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtLuong.ReadOnly = false;
            dtLamviec.Enabled = true;
            dtThoiviec.Enabled = true;
            xoa_textBox();
            id = false;
            PanXacnhan.Visible = true;
        }

        private void btHuy_Click_1(object sender, EventArgs e)
        {
            xoa_textBox();
            load();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (id)
            {
                if((txtMaNV.Text!="")&&(txtTenNV.Text!="")&&(txtCMND.Text!="")&&(txtSDT.Text!="")&&(txtDiaChi.Text!="")
                    &&(txtLuong.Text!="")&&(cbbGTinh.Text!="")&&(cbbChucVu.Text!=""))
                    try
                    {
                        
                        con.Open();
                        string edit_NV = "update NhanVien set tenNV=@tennv,gioiTinh=@gioitinh,ngaySinh=@ngaysinh,cmnd=@cmnd,sdt=@sdt,chucVu=@chucvu, diaChi=@diachi, luong=@luong, timeLam=@timelam, timeNghi=@timenghi where maNV=@manv";
                        SqlCommand cmd = new SqlCommand(edit_NV, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@manv", txtMaNV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tennv", txtTenNV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@gioitinh", cbbGTinh.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@ngaysinh", dtNgaySinh.Value.ToString("dd/mm/yyyy").Trim()));
                        cmd.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sdt", txtSDT.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@chucvu", cbbChucVu.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@luong", txtLuong.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@timelam", dtLamviec.Value.ToString("dd/mm/yyyy").Trim()));
                        cmd.Parameters.Add(new SqlParameter("@timenghi", dtThoiviec.Value.ToString("dd/mm/yyyy").Trim()));
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Sửa thông tin nhân viên thành công!");
                        this.Close();
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
            }
            else
            {
                if ((txtMaNV.Text != "") && (txtTenNV.Text != "") && (txtCMND.Text != "") && (txtSDT.Text != "") && (txtDiaChi.Text != "")
                    && (txtLuong.Text != "") && (cbbGTinh.Text != "") && (cbbChucVu.Text != ""))
                    try
                    {
                        con.Open();
                        string add_NV = "insert into NhanVien values(@manv,@tennv,@gioitinh,@ngaysinh,@cmnd,@sdt,@chucvu,@diachi,luong,@timelam,@timenghi)";
                        SqlCommand cmd = new SqlCommand(add_NV, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@manv", txtMaNV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tennv", txtTenNV.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@gioitinh", cbbGTinh.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sdt", txtSDT.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@chucvu", cbbChucVu.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@luong", txtLuong.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@timelam", timelam.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@timenghi", timenghi.Trim()));
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Thêm nhân viên thành công!");
                        this.Close();
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
            }
        }

        private void xoa_textBox()
        {
            txtTenNV.Text = null;
            cbbGTinh.Text = null;
            txtCMND.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            cbbChucVu.Text = null;
            dtNgaySinh.Value = DateTime.Now;
            txtLuong.Text = null;
            dtLamviec.Value = DateTime.Now;
            dtThoiviec.Value = DateTime.Now;
        }
        private void data_DSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadToTextBox(true);
        }

        private void QuanlyNV_Load(object sender, EventArgs e)
        {
            load();
        }

        private bool id = false ;

        private void btEdit_Click(object sender, EventArgs e)
        {
            PanXacnhan.Visible = true;
            txtTenNV.ReadOnly = false;
            cbbGTinh.Enabled = true;
            txtCMND.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            cbbChucVu.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtLuong.ReadOnly = false;
            dtLamviec.Enabled = true;
            dtThoiviec.Enabled = true;
            id = true;
        }

        private float soluong;



        private void loadToTextBox(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    con.Open();
                    curRow = this.data_DSNV.CurrentRow.Index;
                    this.manv = this.data_DSNV.Rows[curRow].Cells[0].Value.ToString();
                    string select = "select * from Nhanvien when maNV =" + this.manv ;
                    SqlCommand com = new SqlCommand(select, con);
                    com.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    txtMaNV.Text = "maNV";
                    txtTenNV.Text = "tenNV";
                    cbbGTinh.SelectedValue = "gioiTinh";
                    txtCMND.Text = "cmnd";
                    txtSDT.Text = "sdt";
                    txtDiaChi.Text = "diaChi";
                    cbbChucVu.SelectedValue = "chucVu";
                    dtNgaySinh.Text = "ngaySinh";
                    txtLuong.Text = "luong";
                    dtLamviec.Text = "timeLam";
                    dtThoiviec.Text = "timeNghi";
                    con.Close();
                }
                catch
                { }
            }
        }
        private void load()
        {
            con.Open();
            string sql = "select maNV,tenNV,gioiTinh,ngaySinh,cmnd,sdt,chucVu from NhanVien";
            SqlCommand ds = new SqlCommand(sql, con);
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            data_DSNV.DataSource = dt;
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            cbbGTinh.Enabled = false;
            txtCMND.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            cbbChucVu.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtLuong.ReadOnly = true;
            dtLamviec.Enabled = false;
            dtThoiviec.Enabled = false;
            PanXacnhan.Visible = false;
        }

    }
}
