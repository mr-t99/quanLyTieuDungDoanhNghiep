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
    public partial class XemAllThongKe : Form
    {
        private DataTable data;
        public XemAllThongKe(DataTable data)
        {
            InitializeComponent();
            this.data = data;
        }

        public void FThongTinTieuDung()
        {
            ThongTinTieuDung thongTin = new ThongTinTieuDung();
            thongTin.SetDataSource(this.data);
            rpAll.ReportSource = thongTin;
        }
        public void ChiTietTieuDung()
        {
            rpXemAllThongKe rp = new rpXemAllThongKe();
            rp.SetDataSource(data);
            rpAll.ReportSource = rp;
        }

        private void XemAllThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
