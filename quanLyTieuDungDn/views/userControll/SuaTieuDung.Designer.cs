namespace quanLyTieuDungDn.views.userControll
{
    partial class SuaTieuDung
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTieuDung
            // 
            this.dgvTieuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTieuDung.Location = new System.Drawing.Point(0, 3);
            this.dgvTieuDung.Name = "dgvTieuDung";
            this.dgvTieuDung.RowHeadersWidth = 51;
            this.dgvTieuDung.RowTemplate.Height = 24;
            this.dgvTieuDung.Size = new System.Drawing.Size(1252, 474);
            this.dgvTieuDung.TabIndex = 1;
            this.dgvTieuDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTieuDung_CellClick);
            this.dgvTieuDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTieuDung_CellContentClick);
            // 
            // SuaTieuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTieuDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SuaTieuDung";
            this.Size = new System.Drawing.Size(1258, 691);
            this.Load += new System.EventHandler(this.SuaTieuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTieuDung;
    }
}
