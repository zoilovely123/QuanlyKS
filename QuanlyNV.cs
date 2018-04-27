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
            
            PanTool.Visible = false;
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

        private void data_DSNV_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            loadToTextBox(true);
        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void dtLamviec_ValueChanged(object sender, EventArgs e)
        {
            dtLamviec.CustomFormat = "dd/MM/yyyy";
        }

        private void dtThoiviec_ValueChanged(object sender, EventArgs e)
        {
            dtThoiviec.CustomFormat = "dd/MM/yyyy";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            int curRow = this.data_DSNV.CurrentRow.Index;
            string del_NV = "delete from NhanVien where MaNV=@MANV";
            SqlCommand cmd = new SqlCommand(del_NV, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@MANV", this.manv = this.data_DSNV.Rows[curRow].Cells[0].Value.ToString()));
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                loadToTextBox(true);
                load();
                xoa_textBox();
            }
        }



        private void btLuu_Click(object sender, EventArgs e)
        {
            ngaysinh = dtNgaySinh.Value.ToString("yyyy-MM-dd");
            timelam = dtLamviec.Value.ToString("yyyy-MM-dd");
            timenghi = dtThoiviec.Value.ToString("yyyy-MM-dd");
            if (id)
            {
                if((txtMaNV.Text!="")&&(txtTenNV.Text!="")&&(txtCMND.Text!="")&&(txtSDT.Text!="")&&(txtDiaChi.Text!="")
                    &&(txtLuong.Text!="")&&(cbbGTinh.Text!="")&&(cbbChucVu.Text!=""))
                    try
                    {
                        
                        con.Open();
                        string edit_NV = "update NhanVien set TenNV=@tennv,GioiTinh=@gioitinh,NgaySinh=@ngaysinh,CMND=@cmnd,SDT=@sdt,ChucVu=@chucvu, DiaChi=@diachi, Luong=@luong, ThoiGianVaoLam=@timelam, ThoiGianNghi=@timenghi where MaNV=@manv";
                        SqlCommand cmd = new SqlCommand(edit_NV, con);
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
                        MessageBox.Show("Sửa thông tin nhân viên thành công!");
                        xoa_textBox();
                        load();
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
                        string add_NV = "insert into NhanVien values(@manv,@tennv,@gioitinh,@ngaysinh,@cmnd,@sdt,@chucvu,@diachi,@luong,@timelam,@timenghi)";
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
                        xoa_textBox();
                        load();
                    }
                    catch { MessageBox.Show("Không thành công! Vui lòng kiểm tra lại!"); }
            }
        }

        private void xoa_textBox()
        {
            txtMaNV.Text = null;
            txtTenNV.Text = null;
            cbbGTinh.Text = null;
            txtCMND.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            cbbChucVu.Text = null;
            txtLuong.Text = null;
            dtThoiviec.CustomFormat = "None";
            dtNgaySinh.CustomFormat = "None";
            dtLamviec.CustomFormat = "None";
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
            PanTool.Visible = false;
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


        private void loadToTextBox(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    con.Open();
                    curRow = this.data_DSNV.CurrentRow.Index;
                    txtMaNV.Text = this.data_DSNV.Rows[curRow].Cells[0].Value.ToString();
                    txtTenNV.Text = this.data_DSNV.Rows[curRow].Cells[1].Value.ToString();
                    cbbGTinh.Text = this.data_DSNV.Rows[curRow].Cells[2].Value.ToString();
                    dtNgaySinh.CustomFormat = this.data_DSNV.Rows[curRow].Cells[3].Value.ToString(); 
                    txtCMND.Text = this.data_DSNV.Rows[curRow].Cells[4].Value.ToString();
                    txtSDT.Text = this.data_DSNV.Rows[curRow].Cells[5].Value.ToString();
                    cbbChucVu.Text = this.data_DSNV.Rows[curRow].Cells[6].Value.ToString();
                    txtDiaChi.Text = this.data_DSNV.Rows[curRow].Cells[7].Value.ToString();
                    txtLuong.Text = this.data_DSNV.Rows[curRow].Cells[8].Value.ToString();
                    dtLamviec.CustomFormat = this.data_DSNV.Rows[curRow].Cells[9].Value.ToString();
                    dtThoiviec.CustomFormat = this.data_DSNV.Rows[curRow].Cells[10].Value.ToString();
                    con.Close();

                }
                catch
                { }
            }
        }
        private void load()
        {
            con.Open();
            string sql = "select MaNV,TenNV,GioiTinh,NgaySinh=CONVERT (nvarchar,NgaySinh, 103),CMND,SDT,ChucVu,DiaChi,Luong,ThoiGianVaoLam=convert(varchar,ThoiGianVaoLam, 103),ThoiGianNghi=convert(varchar, ThoiGianNghi, 103) from NhanVien";
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
            dtThoiviec.CustomFormat = "None";
            dtNgaySinh.CustomFormat = "None";
            dtLamviec.CustomFormat = "None";
            PanXacnhan.Visible = false;
            PanTool.Visible = true;
        }

    }
}
