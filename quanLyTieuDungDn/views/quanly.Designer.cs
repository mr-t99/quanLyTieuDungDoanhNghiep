namespace quanLyTieuDungDn.views
{
    partial class quanly
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.lựaChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duyệtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiêuDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiêuDùngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmDuyệtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlPhong1 = new quanLyTieuDungDn.views.userControll.QuanLy.QlPhong();
            this.qlNhanVien1 = new quanLyTieuDungDn.views.userControll.QuanLy.QlNhanVien();
            this.qlKiemDuyet1 = new quanLyTieuDungDn.views.userControll.QuanLy.QLKiemDuyet();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1282, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabel1.Text = "Quản lý: Trần Ngọc Thăng";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lựaChọnToolStripMenuItem,
            this.tiêuDùngToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1282, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // lựaChọnToolStripMenuItem
            // 
            this.lựaChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duyệtToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            this.lựaChọnToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.lựaChọnToolStripMenuItem.Text = "Quản lý";
            this.lựaChọnToolStripMenuItem.Click += new System.EventHandler(this.lựaChọnToolStripMenuItem_Click);
            // 
            // duyệtToolStripMenuItem
            // 
            this.duyệtToolStripMenuItem.Name = "duyệtToolStripMenuItem";
            this.duyệtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duyệtToolStripMenuItem.Text = "Duyệt";
            this.duyệtToolStripMenuItem.Click += new System.EventHandler(this.duyệtToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // tiêuDùngToolStripMenuItem
            // 
            this.tiêuDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiêuDùngToolStripMenuItem1,
            this.kiểmDuyệtToolStripMenuItem});
            this.tiêuDùngToolStripMenuItem.Name = "tiêuDùngToolStripMenuItem";
            this.tiêuDùngToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiêuDùngToolStripMenuItem.Text = "Theo dõi";
            // 
            // tiêuDùngToolStripMenuItem1
            // 
            this.tiêuDùngToolStripMenuItem1.Name = "tiêuDùngToolStripMenuItem1";
            this.tiêuDùngToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.tiêuDùngToolStripMenuItem1.Text = "Tiêu dùng";
            // 
            // kiểmDuyệtToolStripMenuItem
            // 
            this.kiểmDuyệtToolStripMenuItem.Name = "kiểmDuyệtToolStripMenuItem";
            this.kiểmDuyệtToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.kiểmDuyệtToolStripMenuItem.Text = "Kiểm duyệt";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // qlPhong1
            // 
            this.qlPhong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlPhong1.Location = new System.Drawing.Point(11, 27);
            this.qlPhong1.Margin = new System.Windows.Forms.Padding(4);
            this.qlPhong1.Name = "qlPhong1";
            this.qlPhong1.Size = new System.Drawing.Size(1258, 700);
            this.qlPhong1.TabIndex = 7;
            // 
            // qlNhanVien1
            // 
            this.qlNhanVien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlNhanVien1.Location = new System.Drawing.Point(11, 27);
            this.qlNhanVien1.Margin = new System.Windows.Forms.Padding(4);
            this.qlNhanVien1.Name = "qlNhanVien1";
            this.qlNhanVien1.Size = new System.Drawing.Size(1258, 700);
            this.qlNhanVien1.TabIndex = 8;
            // 
            // qlKiemDuyet1
            // 
            this.qlKiemDuyet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlKiemDuyet1.Location = new System.Drawing.Point(11, 27);
            this.qlKiemDuyet1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.qlKiemDuyet1.Name = "qlKiemDuyet1";
            this.qlKiemDuyet1.Size = new System.Drawing.Size(1258, 700);
            this.qlKiemDuyet1.TabIndex = 9;
            // 
            // quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.qlKiemDuyet1);
            this.Controls.Add(this.qlNhanVien1);
            this.Controls.Add(this.qlPhong1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "quanly";
            this.Text = "quanly";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem lựaChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiêuDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiêuDùngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kiểmDuyệtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem duyệtToolStripMenuItem;
        private userControll.QuanLy.QlPhong qlPhong1;
        private userControll.QuanLy.QlNhanVien qlNhanVien1;
        private userControll.QuanLy.QLKiemDuyet qlKiemDuyet1;
    }
}