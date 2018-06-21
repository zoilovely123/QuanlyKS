namespace QuanlyKS
{
    partial class HTQLKS
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyĐătPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyDV = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyPh = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyNV = new System.Windows.Forms.ToolStripMenuItem();
            this.thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Controls.Add(this.lblXinchao);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(873, 33);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QuanlyKS.Properties.Resources.Chi_tiet_SP;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 21);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyĐătPhongToolStripMenuItem,
            this.quanlyDV,
            this.quanlyPh,
            this.quanlyNV,
            this.thongke});
            this.menuStrip1.Location = new System.Drawing.Point(41, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyĐătPhongToolStripMenuItem
            // 
            this.quanLyĐătPhongToolStripMenuItem.Name = "quanLyĐătPhongToolStripMenuItem";
            this.quanLyĐătPhongToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.quanLyĐătPhongToolStripMenuItem.Text = "Quản lý đặt phòng";
            this.quanLyĐătPhongToolStripMenuItem.Click += new System.EventHandler(this.quanLyĐătPhongToolStripMenuItem_Click_1);
            // 
            // quanlyDV
            // 
            this.quanlyDV.Name = "quanlyDV";
            this.quanlyDV.Size = new System.Drawing.Size(102, 20);
            this.quanlyDV.Text = "Quản lý dịch vụ";
            this.quanlyDV.Click += new System.EventHandler(this.quanlyDV_Click);
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
            // thongke
            // 
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(69, 20);
            this.thongke.Text = "Thống kê";
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // lblXinchao
            // 
            this.lblXinchao.AutoSize = true;
            this.lblXinchao.Location = new System.Drawing.Point(646, 0);
            this.lblXinchao.Name = "lblXinchao";
            this.lblXinchao.Size = new System.Drawing.Size(49, 13);
            this.lblXinchao.TabIndex = 16;
            this.lblXinchao.Text = "Xin chào";
            this.lblXinchao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(701, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng xuất";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(168, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(558, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "HỆ THỐNG QUẢN LÝ CHO THUÊ PHÒNG KHÁCH SẠN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HTQLKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(877, 608);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.MaximumSize = new System.Drawing.Size(893, 647);
            this.MinimumSize = new System.Drawing.Size(893, 647);
            this.Name = "HTQLKS";
            this.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            this.Load += new System.EventHandler(this.HTQLKS_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyĐătPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlyDV;
        private System.Windows.Forms.ToolStripMenuItem quanlyPh;
        private System.Windows.Forms.ToolStripMenuItem quanlyNV;
        private System.Windows.Forms.ToolStripMenuItem thongke;
        private System.Windows.Forms.Label lblXinchao;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
    }
}