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
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTiêuDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comBoxPhong = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.InHoaDon = new quanLyTieuDungDn.views.userControll.ketoan.HoaDon();
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
            this.menuStrip1.Size = new System.Drawing.Size(1282, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lựaChọnToolStripMenuItem
            // 
            this.lựaChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmToolStripMenuItem,
            this.thêmTiêuDùngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            this.lựaChọnToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.lựaChọnToolStripMenuItem.Text = "Lựa chọn";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tìmKiếmToolStripMenuItem.Text = "In phiếu nhân tiền";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // thêmTiêuDùngToolStripMenuItem
            // 
            this.thêmTiêuDùngToolStripMenuItem.Name = "thêmTiêuDùngToolStripMenuItem";
            this.thêmTiêuDùngToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thêmTiêuDùngToolStripMenuItem.Text = "Thêm tiêu dùng";
            this.thêmTiêuDùngToolStripMenuItem.Click += new System.EventHandler(this.thêmTiêuDùngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.userToolStripMenuItem.Text = "user";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Margin = new System.Windows.Forms.Padding(600, 0, 0, 0);
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.phòngToolStripMenuItem.Text = "Phòng:";
            // 
            // comBoxPhong
            // 
            this.comBoxPhong.Name = "comBoxPhong";
            this.comBoxPhong.Size = new System.Drawing.Size(121, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTen,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1282, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbTen
            // 
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(157, 17);
            this.lbTen.Text = "Nhân viên: Trần Ngọc Thăng";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(700, 4, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(123, 16);
            this.toolStripStatusLabel2.Text = "Hôm  nay: 20-12-2020";
            // 
            // InHoaDon
            // 
            this.InHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHoaDon.Location = new System.Drawing.Point(13, 36);
            this.InHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.InHoaDon.Name = "InHoaDon";
            this.InHoaDon.Size = new System.Drawing.Size(1258, 691);
            this.InHoaDon.TabIndex = 3;
            
            // 
            // ketoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.InHoaDon);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ketoan";
            this.Text = "ketoan";
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
        private System.Windows.Forms.ToolStripStatusLabel lbTen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem lựaChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comBoxPhong;
        private userControll.ketoan.HoaDon InHoaDon;
        private System.Windows.Forms.ToolStripMenuItem thêmTiêuDùngToolStripMenuItem;
    }
}