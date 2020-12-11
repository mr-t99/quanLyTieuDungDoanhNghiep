namespace quanLyTieuDungDn.views.userControll
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
            this.dgvTieuDung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiTdung = new System.Windows.Forms.ComboBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThemLoaiTieuDung = new System.Windows.Forms.TextBox();
            this.btDuyet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThemLTdung = new System.Windows.Forms.Button();
            this.lbIntro = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTieuDung
            // 
            this.dgvTieuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTieuDung.Location = new System.Drawing.Point(0, 42);
            this.dgvTieuDung.Name = "dgvTieuDung";
            this.dgvTieuDung.RowHeadersWidth = 51;
            this.dgvTieuDung.RowTemplate.Height = 24;
            this.dgvTieuDung.Size = new System.Drawing.Size(1258, 450);
            this.dgvTieuDung.TabIndex = 0;
            this.dgvTieuDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTieuDung_CellClick);
            this.dgvTieuDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTieuDung_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại tiêu dùng:";
            // 
            // cbLoaiTdung
            // 
            this.cbLoaiTdung.FormattingEnabled = true;
            this.cbLoaiTdung.Location = new System.Drawing.Point(511, 542);
            this.cbLoaiTdung.Name = "cbLoaiTdung";
            this.cbLoaiTdung.Size = new System.Drawing.Size(268, 40);
            this.cbLoaiTdung.TabIndex = 3;
            this.cbLoaiTdung.SelectedIndexChanged += new System.EventHandler(this.cbLoaiTdung_SelectedIndexChanged);
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(65, 542);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(268, 39);
            this.txtMota.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(65, 628);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(268, 39);
            this.txtGia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thêm loại tiêu dùng:";
            // 
            // txtThemLoaiTieuDung
            // 
            this.txtThemLoaiTieuDung.Location = new System.Drawing.Point(83, 86);
            this.txtThemLoaiTieuDung.Name = "txtThemLoaiTieuDung";
            this.txtThemLoaiTieuDung.Size = new System.Drawing.Size(268, 39);
            this.txtThemLoaiTieuDung.TabIndex = 4;
            // 
            // btDuyet
            // 
            this.btDuyet.Location = new System.Drawing.Point(656, 626);
            this.btDuyet.Name = "btDuyet";
            this.btDuyet.Size = new System.Drawing.Size(123, 36);
            this.btDuyet.TabIndex = 6;
            this.btDuyet.Text = "Gửi duyệt";
            this.btDuyet.UseVisualStyleBackColor = true;
            this.btDuyet.Click += new System.EventHandler(this.btDuyet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btThemLTdung);
            this.panel1.Controls.Add(this.txtThemLoaiTieuDung);
            this.panel1.Location = new System.Drawing.Point(869, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 190);
            this.panel1.TabIndex = 7;
            // 
            // btThemLTdung
            // 
            this.btThemLTdung.Location = new System.Drawing.Point(228, 140);
            this.btThemLTdung.Name = "btThemLTdung";
            this.btThemLTdung.Size = new System.Drawing.Size(123, 36);
            this.btThemLTdung.TabIndex = 6;
            this.btThemLTdung.Text = "Thêm";
            this.btThemLTdung.UseVisualStyleBackColor = true;
            // 
            // lbIntro
            // 
            this.lbIntro.AutoSize = true;
            this.lbIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntro.Location = new System.Drawing.Point(525, 0);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(126, 46);
            this.lbIntro.TabIndex = 8;
            this.lbIntro.Text = "label5";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(579, 626);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(71, 36);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // ThemTieuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.lbIntro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btDuyet);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.cbLoaiTdung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTieuDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThemTieuDung";
            this.Size = new System.Drawing.Size(1258, 691);
            this.Load += new System.EventHandler(this.ThemTieuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTieuDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiTdung;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThemLoaiTieuDung;
        private System.Windows.Forms.Button btDuyet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThemLTdung;
        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.Button btXoa;
    }
}
