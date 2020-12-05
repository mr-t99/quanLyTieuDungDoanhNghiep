namespace quanLyTieuDungDn.views
{
    partial class ketoan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lựaChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comBoxPhong = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.thongke1 = new quanLyTieuDungDn.views.userControll.thongke();
            this.hoaDon1 = new quanLyTieuDungDn.views.userControll.ketoan.HoaDon();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lựaChọnToolStripMenuItem,
            this.userToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.comBoxPhong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lựaChọnToolStripMenuItem
            // 
            this.lựaChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            this.lựaChọnToolStripMenuItem.Size = new System.Drawing.Size(83, 28);
            this.lựaChọnToolStripMenuItem.Text = "Lựa chọn";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.tìmKiếmToolStripMenuItem.Text = "In hóa đơn";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(50, 28);
            this.userToolStripMenuItem.Text = "user";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Margin = new System.Windows.Forms.Padding(600, 0, 0, 0);
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.phòngToolStripMenuItem.Text = "Phòng:";
            // 
            // comBoxPhong
            // 
            this.comBoxPhong.Name = "comBoxPhong";
            this.comBoxPhong.Size = new System.Drawing.Size(121, 28);
            this.comBoxPhong.SelectedIndexChanged += new System.EventHandler(this.comBoxPhong_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1282, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(195, 20);
            this.toolStripStatusLabel1.Text = "Nhân viên: Trần Ngọc Thăng";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(700, 4, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(156, 20);
            this.toolStripStatusLabel2.Text = "Hôm  nay: 20-12-2020";
            // 
            // thongke1
            // 
            this.thongke1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke1.Location = new System.Drawing.Point(10, 30);
            this.thongke1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.thongke1.Name = "thongke1";
            this.thongke1.Size = new System.Drawing.Size(1258, 691);
            this.thongke1.TabIndex = 2;
            this.thongke1.Load += new System.EventHandler(this.thongke1_Load);
            // 
            // hoaDon1
            // 
            this.hoaDon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoaDon1.Location = new System.Drawing.Point(13, 36);
            this.hoaDon1.Margin = new System.Windows.Forms.Padding(5);
            this.hoaDon1.Name = "hoaDon1";
            this.hoaDon1.Size = new System.Drawing.Size(1258, 691);
            this.hoaDon1.TabIndex = 3;
            // 
            // ketoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.hoaDon1);
            this.Controls.Add(this.thongke1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ketoan";
            this.Text = "ketoan";
            this.Load += new System.EventHandler(this.ketoan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem lựaChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private userControll.thongke thongke1;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comBoxPhong;
        private userControll.ketoan.HoaDon hoaDon1;
    }
}