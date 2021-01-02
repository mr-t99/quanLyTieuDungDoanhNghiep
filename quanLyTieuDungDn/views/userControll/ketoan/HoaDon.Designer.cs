namespace quanLyTieuDungDn.views.userControll.ketoan
{
    partial class HoaDon
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
            this.tbTieuDung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiemKiem = new System.Windows.Forms.TextBox();
            this.timKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTienTieuDung = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateGiao = new System.Windows.Forms.DateTimePicker();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbTieuDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTieuDung
            // 
            this.tbTieuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTieuDung.Location = new System.Drawing.Point(0, 49);
            this.tbTieuDung.Name = "tbTieuDung";
            this.tbTieuDung.RowHeadersWidth = 51;
            this.tbTieuDung.RowTemplate.Height = 24;
            this.tbTieuDung.Size = new System.Drawing.Size(1245, 399);
            this.tbTieuDung.TabIndex = 0;
            this.tbTieuDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbTieuDung_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tiêu dùng";
            // 
            // txtTiemKiem
            // 
            this.txtTiemKiem.Location = new System.Drawing.Point(960, 9);
            this.txtTiemKiem.Name = "txtTiemKiem";
            this.txtTiemKiem.Size = new System.Drawing.Size(188, 28);
            this.txtTiemKiem.TabIndex = 7;
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(1156, 9);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(89, 29);
            this.timKiem.TabIndex = 8;
            this.timKiem.Text = "Tìm";
            this.timKiem.UseVisualStyleBackColor = true;
            this.timKiem.Click += new System.EventHandler(this.timKiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTienTieuDung);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 225);
            this.panel1.TabIndex = 9;
            // 
            // txtTienTieuDung
            // 
            this.txtTienTieuDung.Location = new System.Drawing.Point(66, 161);
            this.txtTienTieuDung.Name = "txtTienTieuDung";
            this.txtTienTieuDung.Size = new System.Drawing.Size(345, 28);
            this.txtTienTieuDung.TabIndex = 13;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(66, 76);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(345, 28);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên nhân viên:";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(1102, 644);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(153, 44);
            this.btLuu.TabIndex = 19;
            this.btLuu.Text = "Lưu hóa đơn";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateGiao);
            this.panel2.Controls.Add(this.txtSoTien);
            this.panel2.Controls.Add(this.lbTen);
            this.panel2.Controls.Add(this.lbChucVu);
            this.panel2.Controls.Add(this.lbNgay);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(460, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 225);
            this.panel2.TabIndex = 20;
            // 
            // dateGiao
            // 
            this.dateGiao.Location = new System.Drawing.Point(300, 155);
            this.dateGiao.Name = "dateGiao";
            this.dateGiao.Size = new System.Drawing.Size(289, 28);
            this.dateGiao.TabIndex = 25;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(41, 161);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(151, 28);
            this.txtSoTien.TabIndex = 24;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(81, 73);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(145, 24);
            this.lbTen.TabIndex = 20;
            this.lbTen.Text = "Ngô Thị Thu Bơ";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(37, 29);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(79, 24);
            this.lbChucVu.TabIndex = 21;
            this.lbChucVu.Text = "Kế toán:";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(295, 123);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(100, 24);
            this.lbNgay.TabIndex = 22;
            this.lbNgay.Text = "Ngày giao:";
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
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.txtTiemKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTieuDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(1258, 691);
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTieuDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbTieuDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiemKiem;
        private System.Windows.Forms.Button timKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTienTieuDung;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateGiao;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label label5;
    }
}
