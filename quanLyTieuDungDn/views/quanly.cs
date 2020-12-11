using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyTieuDungDn.views
{
    public partial class quanly : Form
    {
        public quanly()
        {
            InitializeComponent();
            this.qlNhanVien1.Visible = true;
            this.qlKiemDuyet1.Visible = false;
            this.qlPhong1.Visible = false;
            this.thongke1.Visible = false;
        }

        private void tiêuDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qlPhong1_Load(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.qlNhanVien1.Visible = true;
            this.qlKiemDuyet1.Visible = false;
            this.qlPhong1.Visible = false;
            this.thongke1.Visible = false;
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.qlNhanVien1.Visible = false;
            this.qlKiemDuyet1.Visible = false;
            this.qlPhong1.Visible = true;
            this.thongke1.Visible = false;
        }

        private void tiêuDùngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.qlNhanVien1.Visible = false;
            this.qlKiemDuyet1.Visible = false;
            this.qlPhong1.Visible = false;
            this.thongke1.Visible = true;
        }

        private void kiểmDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.qlNhanVien1.Visible = false;
            this.qlKiemDuyet1.Visible = true;
            this.qlPhong1.Visible = false;
            this.thongke1.Visible = false;
        }
    }
}
