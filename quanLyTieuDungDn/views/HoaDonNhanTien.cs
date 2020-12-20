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
    public partial class HoaDonNhanTien : Form
    {
        public HoaDonNhanTien(DataTable data)
        {
            InitializeComponent();
            cpHoaDonNhanTien rp = new cpHoaDonNhanTien();
            rp.SetDataSource(data);
            rpHoaDon.ReportSource = rp;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void HoaDonNhanTien_Load(object sender, EventArgs e)
        {

        }
    }
}
