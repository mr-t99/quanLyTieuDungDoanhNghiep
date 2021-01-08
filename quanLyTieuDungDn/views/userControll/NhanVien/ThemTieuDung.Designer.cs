namespace quanLyTieuDungDn.views.userControll.NhanVien
{
    partial class ThemTieuDung
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
            this.tbTieuDung = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLoaiTieuDung = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.MaskedTextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThemPhanLoai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThemTieuDung = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXetDuyet = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTieuDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu dùng";
            // 
            // tbTieuDung
            // 
            this.tbTieuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTieuDung.Location = new System.Drawing.Point(3, 45);
            this.tbTieuDung.Name = "tbTieuDung";
            this.tbTieuDung.RowHeadersWidth = 51;
            this.tbTieuDung.Size = new System.Drawing.Size(1248, 467);
            this.tbTieuDung.TabIndex = 1;
            this.tbTieuDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbTieuDung_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbLoaiTieuDung);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 177);
            this.panel1.TabIndex = 3;
            // 
            // cbLoaiTieuDung
            // 
            this.cbLoaiTieuDung.FormattingEnabled = true;
            this.cbLoaiTieuDung.Location = new System.Drawing.Point(478, 100);
            this.cbLoaiTieuDung.Name = "cbLoaiTieuDung";
            this.cbLoaiTieuDung.Size = new System.Drawing.Size(255, 37);
            this.cbLoaiTieuDung.TabIndex = 3;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(136, 105);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(171, 34);
            this.txtGia.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(136, 56);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(597, 34);
            this.txtMoTa.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Loại tiêu dùng:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtThemPhanLoai);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtThemTieuDung);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(842, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 115);
            this.panel3.TabIndex = 7;
            // 
            // txtThemPhanLoai
            // 
            this.txtThemPhanLoai.Location = new System.Drawing.Point(229, 79);
            this.txtThemPhanLoai.Name = "txtThemPhanLoai";
            this.txtThemPhanLoai.Size = new System.Drawing.Size(154, 33);
            this.txtThemPhanLoai.TabIndex = 0;
            this.txtThemPhanLoai.Text = "Tìm kiếm";
            this.txtThemPhanLoai.UseVisualStyleBackColor = true;
            this.txtThemPhanLoai.Click += new System.EventHandler(this.txtThemPhanLoai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 49);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtThemTieuDung
            // 
            this.txtThemTieuDung.Location = new System.Drawing.Point(65, 44);
            this.txtThemTieuDung.Name = "txtThemTieuDung";
            this.txtThemTieuDung.Size = new System.Drawing.Size(318, 34);
            this.txtThemTieuDung.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 39);
            this.label7.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btXetDuyet);
            this.panel2.Location = new System.Drawing.Point(842, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 53);
            this.panel2.TabIndex = 8;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(208, 8);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 35);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(104, 8);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(98, 35);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXetDuyet
            // 
            this.btXetDuyet.Location = new System.Drawing.Point(0, 8);
            this.btXetDuyet.Name = "btXetDuyet";
            this.btXetDuyet.Size = new System.Drawing.Size(98, 35);
            this.btXetDuyet.TabIndex = 0;
            this.btXetDuyet.Text = "Gửi duyệt";
            this.btXetDuyet.UseVisualStyleBackColor = true;
            this.btXetDuyet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(312, 8);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(94, 35);
            this.btLuu.TabIndex = 0;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // ThemTieuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTieuDung);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThemTieuDung";
            this.Size = new System.Drawing.Size(1258, 698);
            this.Load += new System.EventHandler(this.ThemTieuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTieuDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbTieuDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtGia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.ComboBox cbLoaiTieuDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtThemPhanLoai;
        private System.Windows.Forms.MaskedTextBox txtThemTieuDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btXetDuyet;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
    }
}
