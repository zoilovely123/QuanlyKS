namespace QuanlyKS
{
    partial class QuanlyDV
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
            this.gbTTDV = new System.Windows.Forms.GroupBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.PanTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.PanXacnhan = new System.Windows.Forms.FlowLayoutPanel();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDV = new System.Windows.Forms.GroupBox();
            this.data_DSDV = new System.Windows.Forms.DataGridView();
            this.btBan = new System.Windows.Forms.Button();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nbSluong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.gbTTDV.SuspendLayout();
            this.PanTool.SuspendLayout();
            this.PanXacnhan.SuspendLayout();
            this.gbDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSluong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTTDV
            // 
            this.gbTTDV.Controls.Add(this.txtTenDV);
            this.gbTTDV.Controls.Add(this.PanTool);
            this.gbTTDV.Controls.Add(this.PanXacnhan);
            this.gbTTDV.Controls.Add(this.txtDonGia);
            this.gbTTDV.Controls.Add(this.txtSoluong);
            this.gbTTDV.Controls.Add(this.txtMaDV);
            this.gbTTDV.Controls.Add(this.label4);
            this.gbTTDV.Controls.Add(this.label3);
            this.gbTTDV.Controls.Add(this.label2);
            this.gbTTDV.Controls.Add(this.label1);
            this.gbTTDV.Location = new System.Drawing.Point(162, 113);
            this.gbTTDV.Name = "gbTTDV";
            this.gbTTDV.Size = new System.Drawing.Size(472, 146);
            this.gbTTDV.TabIndex = 3;
            this.gbTTDV.TabStop = false;
            this.gbTTDV.Text = "Thông tin dịch vụ:";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(70, 50);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.ReadOnly = true;
            this.txtTenDV.Size = new System.Drawing.Size(169, 20);
            this.txtTenDV.TabIndex = 16;
            // 
            // PanTool
            // 
            this.PanTool.Controls.Add(this.btAdd);
            this.PanTool.Controls.Add(this.btEdit);
            this.PanTool.Controls.Add(this.btXoa);
            this.PanTool.Location = new System.Drawing.Point(368, 11);
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
            this.PanXacnhan.Location = new System.Drawing.Point(283, 103);
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
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
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
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(70, 76);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(169, 20);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(70, 103);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.ReadOnly = true;
            this.txtSoluong.Size = new System.Drawing.Size(121, 20);
            this.txtSoluong.TabIndex = 8;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(70, 23);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(121, 20);
            this.txtMaDV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ:";
            // 
            // gbDV
            // 
            this.gbDV.Controls.Add(this.data_DSDV);
            this.gbDV.Location = new System.Drawing.Point(160, 332);
            this.gbDV.Name = "gbDV";
            this.gbDV.Size = new System.Drawing.Size(474, 196);
            this.gbDV.TabIndex = 4;
            this.gbDV.TabStop = false;
            this.gbDV.Text = "Danh sách dịch vụ:";
            // 
            // data_DSDV
            // 
            this.data_DSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DSDV.Location = new System.Drawing.Point(9, 19);
            this.data_DSDV.Name = "data_DSDV";
            this.data_DSDV.Size = new System.Drawing.Size(450, 167);
            this.data_DSDV.TabIndex = 0;
            this.data_DSDV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.data_DSDV_MouseClick);
            // 
            // btBan
            // 
            this.btBan.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBan.Location = new System.Drawing.Point(558, 534);
            this.btBan.Name = "btBan";
            this.btBan.Size = new System.Drawing.Size(76, 28);
            this.btBan.TabIndex = 10;
            this.btBan.Text = "Bán";
            this.btBan.UseVisualStyleBackColor = false;
            this.btBan.Click += new System.EventHandler(this.btBan_Click);
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(336, 18);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(121, 21);
            this.cbbPhong.TabIndex = 11;
            this.cbbPhong.Text = "Chọn phòng";
            this.cbbPhong.SelectedValueChanged += new System.EventHandler(this.cbbPhong_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nbSluong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbPhong);
            this.groupBox1.Location = new System.Drawing.Point(162, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 61);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phòng:";
            // 
            // nbSluong
            // 
            this.nbSluong.Location = new System.Drawing.Point(85, 19);
            this.nbSluong.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbSluong.Name = "nbSluong";
            this.nbSluong.Size = new System.Drawing.Size(42, 20);
            this.nbSluong.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng bán:";
            // 
            // QuanlyDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBan);
            this.Controls.Add(this.gbDV);
            this.Controls.Add(this.gbTTDV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanlyDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.QuanlyDV_Load);
            this.gbTTDV.ResumeLayout(false);
            this.gbTTDV.PerformLayout();
            this.PanTool.ResumeLayout(false);
            this.PanXacnhan.ResumeLayout(false);
            this.gbDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_DSDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTDV;
        private System.Windows.Forms.FlowLayoutPanel PanTool;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.FlowLayoutPanel PanXacnhan;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.GroupBox gbDV;
        private System.Windows.Forms.DataGridView data_DSDV;
        private System.Windows.Forms.Button btBan;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbSluong;
        private System.Windows.Forms.Label label5;
    }
}