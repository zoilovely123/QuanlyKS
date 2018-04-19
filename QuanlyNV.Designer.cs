namespace QuanlyKS
{
    partial class QuanlyNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.PanXacnhan = new System.Windows.Forms.FlowLayoutPanel();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbbGTinh = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGTinh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.gbTTCTNV = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtThoiviec = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtLamviec = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.btQuaylai = new System.Windows.Forms.Button();
            this.data_DSNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanTool.SuspendLayout();
            this.PanXacnhan.SuspendLayout();
            this.gbTTCTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTool
            // 
            this.PanTool.Controls.Add(this.btAdd);
            this.PanTool.Controls.Add(this.btEdit);
            this.PanTool.Controls.Add(this.btXoa);
            this.PanTool.Location = new System.Drawing.Point(559, 10);
            this.PanTool.Name = "PanTool";
            this.PanTool.Size = new System.Drawing.Size(85, 24);
            this.PanTool.TabIndex = 15;
            // 
            // btAdd
            // 
            this.btAdd.BackgroundImage = global::QuanlyKS.Properties.Resources.if_add_circle_outline_326501;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdd.Location = new System.Drawing.Point(3, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(20, 20);
            this.btAdd.TabIndex = 14;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackgroundImage = global::QuanlyKS.Properties.Resources.if_edit_216184;
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEdit.Location = new System.Drawing.Point(29, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(20, 20);
            this.btEdit.TabIndex = 13;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = global::QuanlyKS.Properties.Resources.if_delete_outline_216169;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoa.Location = new System.Drawing.Point(55, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(20, 20);
            this.btXoa.TabIndex = 11;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // PanXacnhan
            // 
            this.PanXacnhan.Controls.Add(this.btHuy);
            this.PanXacnhan.Controls.Add(this.btLuu);
            this.PanXacnhan.Controls.Add(this.button2);
            this.PanXacnhan.Location = new System.Drawing.Point(485, 164);
            this.PanXacnhan.Name = "PanXacnhan";
            this.PanXacnhan.Size = new System.Drawing.Size(170, 32);
            this.PanXacnhan.TabIndex = 12;
            this.PanXacnhan.Visible = false;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(3, 3);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 23);
            this.btHuy.TabIndex = 0;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click_1);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(84, 3);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 1;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbbGTinh
            // 
            this.cbbGTinh.Enabled = false;
            this.cbbGTinh.FormattingEnabled = true;
            this.cbbGTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbGTinh.Location = new System.Drawing.Point(62, 78);
            this.cbbGTinh.Name = "cbbGTinh";
            this.cbbGTinh.Size = new System.Drawing.Size(175, 21);
            this.cbbGTinh.TabIndex = 10;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(62, 133);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(175, 20);
            this.txtCMND.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(87, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(150, 20);
            this.txtMaNV.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // lbGTinh
            // 
            this.lbGTinh.AutoSize = true;
            this.lbGTinh.Location = new System.Drawing.Point(6, 86);
            this.lbGTinh.Name = "lbGTinh";
            this.lbGTinh.Size = new System.Drawing.Size(50, 13);
            this.lbGTinh.TabIndex = 1;
            this.lbGTinh.Text = "Giới tính:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(6, 30);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(75, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // gbTTCTNV
            // 
            this.gbTTCTNV.Controls.Add(this.label9);
            this.gbTTCTNV.Controls.Add(this.txtTenNV);
            this.gbTTCTNV.Controls.Add(this.txtLuong);
            this.gbTTCTNV.Controls.Add(this.label8);
            this.gbTTCTNV.Controls.Add(this.dtThoiviec);
            this.gbTTCTNV.Controls.Add(this.label7);
            this.gbTTCTNV.Controls.Add(this.txtDiaChi);
            this.gbTTCTNV.Controls.Add(this.label6);
            this.gbTTCTNV.Controls.Add(this.txtSDT);
            this.gbTTCTNV.Controls.Add(this.label2);
            this.gbTTCTNV.Controls.Add(this.dtLamviec);
            this.gbTTCTNV.Controls.Add(this.label1);
            this.gbTTCTNV.Controls.Add(this.dtNgaySinh);
            this.gbTTCTNV.Controls.Add(this.PanTool);
            this.gbTTCTNV.Controls.Add(this.PanXacnhan);
            this.gbTTCTNV.Controls.Add(this.cbbGTinh);
            this.gbTTCTNV.Controls.Add(this.txtCMND);
            this.gbTTCTNV.Controls.Add(this.txtMaNV);
            this.gbTTCTNV.Controls.Add(this.cbbChucVu);
            this.gbTTCTNV.Controls.Add(this.label5);
            this.gbTTCTNV.Controls.Add(this.label4);
            this.gbTTCTNV.Controls.Add(this.label3);
            this.gbTTCTNV.Controls.Add(this.lbGTinh);
            this.gbTTCTNV.Controls.Add(this.lbMaNV);
            this.gbTTCTNV.Location = new System.Drawing.Point(12, 12);
            this.gbTTCTNV.Name = "gbTTCTNV";
            this.gbTTCTNV.Size = new System.Drawing.Size(660, 202);
            this.gbTTCTNV.TabIndex = 5;
            this.gbTTCTNV.TabStop = false;
            this.gbTTCTNV.Text = "Thông tin chi tiết nhân viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tên nhân viên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(87, 50);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(150, 20);
            this.txtTenNV.TabIndex = 27;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(402, 136);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.ReadOnly = true;
            this.txtLuong.Size = new System.Drawing.Size(161, 20);
            this.txtLuong.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Lương:";
            // 
            // dtThoiviec
            // 
            this.dtThoiviec.CustomFormat = "yyyy-MM-dd";
            this.dtThoiviec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiviec.Location = new System.Drawing.Point(402, 109);
            this.dtThoiviec.Name = "dtThoiviec";
            this.dtThoiviec.Size = new System.Drawing.Size(161, 20);
            this.dtThoiviec.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày thôi việc:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(55, 161);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(424, 35);
            this.txtDiaChi.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(402, 23);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(131, 20);
            this.txtSDT.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số điện thoại:";
            // 
            // dtLamviec
            // 
            this.dtLamviec.CustomFormat = "yyyy-MM-dd";
            this.dtLamviec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLamviec.Location = new System.Drawing.Point(402, 83);
            this.dtLamviec.Name = "dtLamviec";
            this.dtLamviec.Size = new System.Drawing.Size(161, 20);
            this.dtLamviec.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ngày vào làm:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "yyyy-MM-dd";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(62, 105);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(175, 20);
            this.dtNgaySinh.TabIndex = 16;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.Enabled = false;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Thu ngan",
            "Tap vu"});
            this.cbbChucVu.Location = new System.Drawing.Point(402, 49);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(131, 21);
            this.cbbChucVu.TabIndex = 5;
            // 
            // btQuaylai
            // 
            this.btQuaylai.Location = new System.Drawing.Point(12, 467);
            this.btQuaylai.Name = "btQuaylai";
            this.btQuaylai.Size = new System.Drawing.Size(75, 23);
            this.btQuaylai.TabIndex = 4;
            this.btQuaylai.Text = "Quay lại";
            this.btQuaylai.UseVisualStyleBackColor = true;
            this.btQuaylai.Click += new System.EventHandler(this.btQuaylai_Click);
            // 
            // data_DSNV
            // 
            this.data_DSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DSNV.Location = new System.Drawing.Point(9, 19);
            this.data_DSNV.Name = "data_DSNV";
            this.data_DSNV.Size = new System.Drawing.Size(635, 216);
            this.data_DSNV.TabIndex = 0;
            this.data_DSNV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_DSNV_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_DSNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 241);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên:";
            // 
            // QuanlyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 495);
            this.Controls.Add(this.gbTTCTNV);
            this.Controls.Add(this.btQuaylai);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanlyNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QuanlyNV_Load);
            this.PanTool.ResumeLayout(false);
            this.PanXacnhan.ResumeLayout(false);
            this.gbTTCTNV.ResumeLayout(false);
            this.gbTTCTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanTool;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.FlowLayoutPanel PanXacnhan;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbbGTinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGTinh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.GroupBox gbTTCTNV;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Button btQuaylai;
        private System.Windows.Forms.DataGridView data_DSNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.DateTimePicker dtLamviec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtThoiviec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenNV;
    }
}