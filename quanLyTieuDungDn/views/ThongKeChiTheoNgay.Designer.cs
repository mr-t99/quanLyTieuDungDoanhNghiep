namespace quanLyTieuDungDn.views
{
    partial class ThongKeChiTheoNgay
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
            this.rpThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpThongKe
            // 
            this.rpThongKe.ActiveViewIndex = -1;
            this.rpThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpThongKe.Location = new System.Drawing.Point(0, 0);
            this.rpThongKe.Name = "rpThongKe";
            this.rpThongKe.Size = new System.Drawing.Size(800, 450);
            this.rpThongKe.TabIndex = 0;
            // 
            // ThongKeChiTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpThongKe);
            this.Name = "ThongKeChiTheoNgay";
            this.Text = "ThongKeChiTheoNgay";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpThongKe;
    }
}