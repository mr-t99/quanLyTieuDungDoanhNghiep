namespace quanLyTieuDungDn.views.userControll.QuanLy
{
    partial class ThongKe
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
            this.tbViewThongKeChi = new System.Windows.Forms.DataGridView();
            this.btXemChiTiet = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tbViewThongKeChi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách thống kê phòng:";
            // 
            // cbPhong
            // 
            this.cbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(252, 1);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(243, 26);
            this.cbPhong.TabIndex = 1;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // tbViewThongKeChi
            // 
            this.tbViewThongKeChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbViewThongKeChi.Location = new System.Drawing.Point(3, 38);
            this.tbViewThongKeChi.Name = "tbViewThongKeChi";
            this.tbViewThongKeChi.Size = new System.Drawing.Size(1252, 659);
            this.tbViewThongKeChi.TabIndex = 2;
            // 
            // btXemChiTiet
            // 
            this.btXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemChiTiet.Location = new System.Drawing.Point(849, 1);
            this.btXemChiTiet.Name = "btXemChiTiet";
            this.btXemChiTiet.Size = new System.Drawing.Size(93, 29);
            this.btXemChiTiet.TabIndex = 3;
            this.btXemChiTiet.Text = "Xem chi tiết";
            this.btXemChiTiet.UseVisualStyleBackColor = true;
            this.btXemChiTiet.Click += new System.EventHandler(this.btXemChiTiet_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(533, 1);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(310, 29);
            this.dateTime.TabIndex = 4;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.btXemChiTiet);
            this.Controls.Add(this.tbViewThongKeChi);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1258, 700);
            ((System.ComponentModel.ISupportInitialize)(this.tbViewThongKeChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.DataGridView tbViewThongKeChi;
        private System.Windows.Forms.Button btXemChiTiet;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}
