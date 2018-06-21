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
            this.pnDP = new System.Windows.Forms.Panel();
            this.cbSear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_DSP = new System.Windows.Forms.DataGridView();
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
            this.pnDP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_DSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDP
            // 
            this.pnDP.Controls.Add(this.cbSear);
            this.pnDP.Controls.Add(this.label10);
            this.pnDP.Controls.Add(this.groupBox1);
            this.pnDP.Controls.Add(this.groupBox2);
            this.pnDP.Location = new System.Drawing.Point(12, 61);
            this.pnDP.Name = "pnDP";
            this.pnDP.Size = new System.Drawing.Size(801, 512);
            this.pnDP.TabIndex = 11;
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
            this.cbSear.Location = new System.Drawing.Point(374, 14);
            this.cbSear.Name = "cbSear";
            this.cbSear.Size = new System.Drawing.Size(121, 21);
            this.cbSear.TabIndex = 11;
            this.cbSear.Text = "All";
            this.cbSear.SelectedValueChanged += new System.EventHandler(this.cbSear_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tình trạng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_DSP);
            this.groupBox1.Location = new System.Drawing.Point(20, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 451);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng:";
            // 
            // dt_DSP
            // 
            this.dt_DSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_DSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_DSP.Location = new System.Drawing.Point(3, 16);
            this.dt_DSP.Name = "dt_DSP";
            this.dt_DSP.Size = new System.Drawing.Size(479, 432);
            this.dt_DSP.TabIndex = 0;
            this.dt_DSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dt_DSP_MouseClick_1);
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
            this.groupBox2.Location = new System.Drawing.Point(511, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 297);
            this.groupBox2.TabIndex = 8;
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
            this.btDat.Click += new System.EventHandler(this.btDat_Click);
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
            this.btTra.Click += new System.EventHandler(this.btTra_Click_1);
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
            this.btThue.Click += new System.EventHandler(this.btThue_Click);
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
            // QuanlyTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 581);
            this.Controls.Add(this.pnDP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanlyTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thuê Phòng";
            this.Load += new System.EventHandler(this.QuanlyTP_Load);
            this.pnDP.ResumeLayout(false);
            this.pnDP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_DSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnDP;
        private System.Windows.Forms.ComboBox cbSear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dt_DSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDat;
        private System.Windows.Forms.DateTimePicker timeGD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.Button btThue;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSGiuong;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtMaph;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

