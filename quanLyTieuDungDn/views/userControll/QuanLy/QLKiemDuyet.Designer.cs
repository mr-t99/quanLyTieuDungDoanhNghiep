namespace quanLyTieuDungDn.views.userControll.QuanLy
{
    partial class QLKiemDuyet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTieuDung = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTienTieuDung = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.btNghiemThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTieuDung)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duyệt tiêu dùng";
            // 
            // cbPhong
            // 
            this.cbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(1093, 10);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(162, 24);
            this.cbPhong.TabIndex = 1;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1040, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng";
            // 
            // tbTieuDung
            // 
            this.tbTieuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTieuDung.Location = new System.Drawing.Point(6, 53);
            this.tbTieuDung.Name = "tbTieuDung";
            this.tbTieuDung.Size = new System.Drawing.Size(1252, 413);
            this.tbTieuDung.TabIndex = 3;
            this.tbTieuDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbTieuDung_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbTrangThai);
            this.panel2.Controls.Add(this.txtSoTien);
            this.panel2.Controls.Add(this.lbTen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(460, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 225);
            this.panel2.TabIndex = 22;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(212, 158);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(230, 32);
            this.cbTrangThai.TabIndex = 25;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(41, 161);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(151, 29);
            this.txtSoTien.TabIndex = 24;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(81, 73);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(44, 24);
            this.lbTen.TabIndex = 20;
            this.lbTen.Text = "Abc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quản lý:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số tiền:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTienTieuDung);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 225);
            this.panel1.TabIndex = 21;
            // 
            // txtTienTieuDung
            // 
            this.txtTienTieuDung.Location = new System.Drawing.Point(66, 161);
            this.txtTienTieuDung.Name = "txtTienTieuDung";
            this.txtTienTieuDung.Size = new System.Drawing.Size(345, 29);
            this.txtTienTieuDung.TabIndex = 13;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(66, 76);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(345, 29);
            this.txtTenNhanVien.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên tiêu dùng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên nhân viên:";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(927, 498);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(328, 153);
            this.rtxtGhiChu.TabIndex = 23;
            this.rtxtGhiChu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(927, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ghi chú:";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(1043, 660);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(125, 40);
            this.btLuu.TabIndex = 24;
            this.btLuu.Text = "Lưu duyệt";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btNghiemThu
            // 
            this.btNghiemThu.Location = new System.Drawing.Point(1043, 660);
            this.btNghiemThu.Name = "btNghiemThu";
            this.btNghiemThu.Size = new System.Drawing.Size(125, 40);
            this.btNghiemThu.TabIndex = 24;
            this.btNghiemThu.Text = "Nghiệm thu";
            this.btNghiemThu.UseVisualStyleBackColor = true;
            this.btNghiemThu.Click += new System.EventHandler(this.btNghiemThu_Click);
            // 
            // QLKiemDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btNghiemThu);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.rtxtGhiChu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTieuDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "QLKiemDuyet";
            this.Size = new System.Drawing.Size(1258, 700);
            this.Load += new System.EventHandler(this.QLKiemDuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTieuDung)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tbTieuDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTienTieuDung;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btNghiemThu;
    }
}
