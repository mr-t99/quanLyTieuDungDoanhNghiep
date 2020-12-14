using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.Model.Object;

namespace quanLyTieuDungDn.views
{
    public partial class nhanvien : Form
    {
        private int id_ndung;
        public nhanvien()
        {
            InitializeComponent();
        }

        public int Id_ndung { get => id_ndung; set => id_ndung = value; }
        private void đáToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
