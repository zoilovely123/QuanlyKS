namespace QuanlyKS
{
    partial class QuanlyPh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_DSPh = new System.Windows.Forms.DataGridView();
            this.btQuaylai = new System.Windows.Forms.Button();
            this.gbTTCT = new System.Windows.Forms.GroupBox();
            this.PanTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.PanXacnhan = new System.Windows.Forms.FlowLayoutPanel();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbbLoaiPh = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.txtMaPh = new System.Windows.Forms.TextBox();
            this.cbbTinhtrang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSPh)).BeginInit();
            this.gbTTCT.SuspendLayout();
            this.PanTool.SuspendLayout();
            this.PanXacnhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_DSPh);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng:";
            // 
            // data_DSPh
            // 
            this.data_DSPh.AllowUserToAddRows = false;
            this.data_DSPh.AllowUserToDeleteRows = false;
            this.data_DSPh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DSPh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaP,
            this.loai,
            this.donGia,
            this.sogiuong,
            this.tinhtrang});
            this.data_DSPh.Location = new System.Drawing.Point(6, 19);
            this.data_DSPh.Name = "data_DSPh";
            this.data_DSPh.ReadOnly = true;
            this.data_DSPh.Size = new System.Drawing.Size(542, 272);
            this.data_DSPh.TabIndex = 0;
            this.data_DSPh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_DSPh_CellContentClick);
            // 
            // btQuaylai
            // 
            this.btQuaylai.Location = new System.Drawing.Point(12, 467);
            this.btQuaylai.Name = "btQuaylai";
            this.btQuaylai.Size = new System.Drawing.Size(75, 23);
            this.btQuaylai.TabIndex = 1;
            this.btQuaylai.Text = "Quay lại";
            this.btQuaylai.UseVisualStyleBackColor = true;
            this.btQuaylai.Click += new System.EventHandler(this.btQuaylai_Click);
            // 
            // gbTTCT
            // 
            this.gbTTCT.Controls.Add(this.PanTool);
            this.gbTTCT.Controls.Add(this.PanXacnhan);
            this.gbTTCT.Controls.Add(this.cbbLoaiPh);
            this.gbTTCT.Controls.Add(this.txtDonGia);
            this.gbTTCT.Controls.Add(this.txtSoGiuong);
            this.gbTTCT.Controls.Add(this.txtMaPh);
            this.gbTTCT.Controls.Add(this.cbbTinhtrang);
            this.gbTTCT.Controls.Add(this.label5);
            this.gbTTCT.Controls.Add(this.label4);
            this.gbTTCT.Controls.Add(this.label3);
            this.gbTTCT.Controls.Add(this.label2);
            this.gbTTCT.Controls.Add(this.label1);
            this.gbTTCT.Location = new System.Drawing.Point(12, 12);
            this.gbTTCT.Name = "gbTTCT";
            this.gbTTCT.Size = new System.Drawing.Size(557, 146);
            this.gbTTCT.TabIndex = 2;
            this.gbTTCT.TabStop = false;
            this.gbTTCT.Text = "Thông tin chi tiết phòng:";
            // 
            // PanTool
            // 
            this.PanTool.Controls.Add(this.btAdd);
            this.PanTool.Controls.Add(this.btEdit);
            this.PanTool.Controls.Add(this.btXoa);
            this.PanTool.Location = new System.Drawing.Point(466, 9);
            this.PanTool.Name = "PanTool";
            this.PanTool.Size = new System.Drawing.Size(85, 25);
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
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
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
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click_1);
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
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // PanXacnhan
            // 
            this.PanXacnhan.Controls.Add(this.btHuy);
            this.PanXacnhan.Controls.Add(this.btLuu);
            this.PanXacnhan.Controls.Add(this.button2);
            this.PanXacnhan.Location = new System.Drawing.Point(371, 108);
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
            // cbbLoaiPh
            // 
            this.cbbLoaiPh.Enabled = false;
            this.cbbLoaiPh.FormattingEnabled = true;
            this.cbbLoaiPh.Items.AddRange(new object[] {
            "VIP",
            "Thuong"});
            this.cbbLoaiPh.Location = new System.Drawing.Point(70, 49);
            this.cbbLoaiPh.Name = "cbbLoaiPh";
            this.cbbLoaiPh.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiPh.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(332, 23);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(70, 80);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.ReadOnly = true;
            this.txtSoGiuong.Size = new System.Drawing.Size(121, 20);
            this.txtSoGiuong.TabIndex = 8;
            // 
            // txtMaPh
            // 
            this.txtMaPh.Location = new System.Drawing.Point(70, 23);
            this.txtMaPh.Name = "txtMaPh";
            this.txtMaPh.ReadOnly = true;
            this.txtMaPh.Size = new System.Drawing.Size(121, 20);
            this.txtMaPh.TabIndex = 6;
            // 
            // cbbTinhtrang
            // 
            this.cbbTinhtrang.Enabled = false;
            this.cbbTinhtrang.FormattingEnabled = true;
            this.cbbTinhtrang.Items.AddRange(new object[] {
            "Null",
            "Wait",
            "Used",
            "Close"});
            this.cbbTinhtrang.Location = new System.Drawing.Point(332, 53);
            this.cbbTinhtrang.Name = "cbbTinhtrang";
            this.cbbTinhtrang.Size = new System.Drawing.Size(121, 21);
            this.cbbTinhtrang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số giường:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng:";
            // 
            // MaP
            // 
            this.MaP.DataPropertyName = "maPh";
            this.MaP.HeaderText = "Ma Phong";
            this.MaP.Name = "MaP";
            // 
            // loai
            // 
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Loai";
            this.loai.Name = "loai";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Don gia";
            this.donGia.Name = "donGia";
            // 
            // sogiuong
            // 
            this.sogiuong.DataPropertyName = "soGiuong";
            this.sogiuong.HeaderText = "So giuong";
            this.sogiuong.Name = "sogiuong";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhTrang";
            this.tinhtrang.HeaderText = "Tinh trang";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // QuanlyPh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 502);
            this.Controls.Add(this.gbTTCT);
            this.Controls.Add(this.btQuaylai);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanlyPh";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.QuanlyPh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_DSPh)).EndInit();
            this.gbTTCT.ResumeLayout(false);
            this.gbTTCT.PerformLayout();
            this.PanTool.ResumeLayout(false);
            this.PanXacnhan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_DSPh;
        private System.Windows.Forms.Button btQuaylai;
        private System.Windows.Forms.GroupBox gbTTCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTinhtrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPh;
        private System.Windows.Forms.ComboBox cbbLoaiPh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.FlowLayoutPanel PanXacnhan;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.FlowLayoutPanel PanTool;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
    }
}