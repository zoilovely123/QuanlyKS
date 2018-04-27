namespace QuanlyKS
{
    partial class QuanlyTP
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
            this.dt_DSP = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDat = new System.Windows.Forms.Button();
            this.timeGD = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btTra = new System.Windows.Forms.Button();
            this.btThue = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSGiuong = new System.Windows.Forms.TextBox();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.txtMaph = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSear = new System.Windows.Forms.ComboBox();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyĐătPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyPh = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyNV = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyDV = new System.Windows.Forms.ToolStripMenuItem();
            this.thongke = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dt_DSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_DSP
            // 
            this.dt_DSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_DSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_DSP.Location = new System.Drawing.Point(3, 16);
            this.dt_DSP.Name = "dt_DSP";
            this.dt_DSP.Size = new System.Drawing.Size(479, 278);
            this.dt_DSP.TabIndex = 0;
            this.dt_DSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dt_DSP_MouseClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(727, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng xuất";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDat);
            this.groupBox2.Controls.Add(this.timeGD);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.btTra);
            this.groupBox2.Controls.Add(this.btThue);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.txtSGiuong);
            this.groupBox2.Controls.Add(this.txtLoai);
            this.groupBox2.Controls.Add(this.txtMaph);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(505, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 297);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuê phòng:";
            // 
            // btDat
            // 
            this.btDat.BackColor = System.Drawing.Color.LightBlue;
            this.btDat.Location = new System.Drawing.Point(99, 259);
            this.btDat.Name = "btDat";
            this.btDat.Size = new System.Drawing.Size(75, 27);
            this.btDat.TabIndex = 18;
            this.btDat.Text = "Đặt phòng";
            this.btDat.UseVisualStyleBackColor = false;
            this.btDat.Click += new System.EventHandler(this.button3_Click);
            // 
            // timeGD
            // 
            this.timeGD.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.timeGD.CustomFormat = "hh:mm:ss tt - dd/MM/yyyy";
            this.timeGD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeGD.Location = new System.Drawing.Point(116, 193);
            this.timeGD.Name = "timeGD";
            this.timeGD.Size = new System.Drawing.Size(151, 20);
            this.timeGD.TabIndex = 17;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(99, 162);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(168, 20);
            this.txtSDT.TabIndex = 16;
            // 
            // btTra
            // 
            this.btTra.BackColor = System.Drawing.Color.DarkSalmon;
            this.btTra.Location = new System.Drawing.Point(6, 259);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(75, 27);
            this.btTra.TabIndex = 10;
            this.btTra.Text = "Trả phòng";
            this.btTra.UseVisualStyleBackColor = false;
            this.btTra.Click += new System.EventHandler(this.btTra_Click);
            // 
            // btThue
            // 
            this.btThue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThue.Location = new System.Drawing.Point(192, 259);
            this.btThue.Name = "btThue";
            this.btThue.Size = new System.Drawing.Size(75, 27);
            this.btThue.TabIndex = 9;
            this.btThue.Text = "Thuê phòng";
            this.btThue.UseVisualStyleBackColor = false;
            this.btThue.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(99, 136);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(168, 20);
            this.txtCMND.TabIndex = 15;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(99, 110);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(168, 20);
            this.txtTen.TabIndex = 14;
            // 
            // txtSGiuong
            // 
            this.txtSGiuong.Location = new System.Drawing.Point(75, 74);
            this.txtSGiuong.Name = "txtSGiuong";
            this.txtSGiuong.ReadOnly = true;
            this.txtSGiuong.Size = new System.Drawing.Size(192, 20);
            this.txtSGiuong.TabIndex = 13;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(75, 48);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.ReadOnly = true;
            this.txtLoai.Size = new System.Drawing.Size(192, 20);
            this.txtLoai.TabIndex = 12;
            // 
            // txtMaph
            // 
            this.txtMaph.Location = new System.Drawing.Point(75, 22);
            this.txtMaph.Name = "txtMaph";
            this.txtMaph.ReadOnly = true;
            this.txtMaph.Size = new System.Drawing.Size(192, 20);
            this.txtMaph.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian giao dịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Người giao dịch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số giường:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_DSP);
            this.groupBox1.Location = new System.Drawing.Point(14, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 297);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(99, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(558, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "HỆ THỐNG QUẢN LÝ CHO THUÊ PHÒNG KHÁCH SẠN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tình trạng:";
            // 
            // cbSear
            // 
            this.cbSear.FormattingEnabled = true;
            this.cbSear.Items.AddRange(new object[] {
            "All",
            "Null",
            "Wait",
            "Used",
            "Close"});
            this.cbSear.Location = new System.Drawing.Point(368, 99);
            this.cbSear.Name = "cbSear";
            this.cbSear.Size = new System.Drawing.Size(121, 21);
            this.cbSear.TabIndex = 7;
            this.cbSear.Text = "All";
            this.cbSear.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblXinchao
            // 
            this.lblXinchao.AutoSize = true;
            this.lblXinchao.Location = new System.Drawing.Point(592, 9);
            this.lblXinchao.Name = "lblXinchao";
            this.lblXinchao.Size = new System.Drawing.Size(49, 13);
            this.lblXinchao.TabIndex = 9;
            this.lblXinchao.Text = "Xin chào";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyĐătPhongToolStripMenuItem,
            this.quanlyDV,
            this.quanlyPh,
            this.quanlyNV,
            this.thongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyĐătPhongToolStripMenuItem
            // 
            this.quanLyĐătPhongToolStripMenuItem.Name = "quanLyĐătPhongToolStripMenuItem";
            this.quanLyĐătPhongToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.quanLyĐătPhongToolStripMenuItem.Text = "Quản lý đặt phòng";
            this.quanLyĐătPhongToolStripMenuItem.Click += new System.EventHandler(this.quanLyĐătPhongToolStripMenuItem_Click_1);
            // 
            // quanlyPh
            // 
            this.quanlyPh.Name = "quanlyPh";
            this.quanlyPh.Size = new System.Drawing.Size(98, 20);
            this.quanlyPh.Text = "Quản lý phòng";
            this.quanlyPh.Click += new System.EventHandler(this.quanlyPh_Click);
            // 
            // quanlyNV
            // 
            this.quanlyNV.Name = "quanlyNV";
            this.quanlyNV.Size = new System.Drawing.Size(115, 20);
            this.quanlyNV.Text = "Quản lý nhân viên";
            this.quanlyNV.Click += new System.EventHandler(this.quanlyNV_Click);
            // 
            // quanlyDV
            // 
            this.quanlyDV.Name = "quanlyDV";
            this.quanlyDV.Size = new System.Drawing.Size(102, 20);
            this.quanlyDV.Text = "Quản lý dịch vụ";
            this.quanlyDV.Click += new System.EventHandler(this.quảnLýDịchVụToolStripMenuItem_Click);
            // 
            // thongke
            // 
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(69, 20);
            this.thongke.Text = "Thống kê";
            // 
            // QuanlyTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 431);
            this.Controls.Add(this.cbSear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblXinchao);
            this.Controls.Add(this.menuStrip1);
            this.Name = "QuanlyTP";
            this.Text = "Quản Lý Thuê Phòng";
            this.Load += new System.EventHandler(this.QuanlyTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_DSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dt_DSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSGiuong;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtMaph;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.Button btThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSear;
        private System.Windows.Forms.Label lblXinchao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyĐătPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlyPh;
        private System.Windows.Forms.ToolStripMenuItem quanlyNV;
        private System.Windows.Forms.ToolStripMenuItem thongke;
        private System.Windows.Forms.DateTimePicker timeGD;
        private System.Windows.Forms.Button btDat;
        private System.Windows.Forms.ToolStripMenuItem quanlyDV;
    }
}

