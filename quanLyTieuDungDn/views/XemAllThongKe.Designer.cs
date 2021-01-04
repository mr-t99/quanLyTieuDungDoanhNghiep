namespace quanLyTieuDungDn.views
{
    partial class XemAllThongKe
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
            this.rpAll = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpAll
            // 
            this.rpAll.ActiveViewIndex = -1;
            this.rpAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpAll.Location = new System.Drawing.Point(0, 0);
            this.rpAll.Name = "rpAll";
            this.rpAll.Size = new System.Drawing.Size(1217, 647);
            this.rpAll.TabIndex = 0;
            // 
            // XemAllThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 647);
            this.Controls.Add(this.rpAll);
            this.Name = "XemAllThongKe";
            this.Text = "XemAllThongKe";
            this.Load += new System.EventHandler(this.XemAllThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpAll;
    }
}