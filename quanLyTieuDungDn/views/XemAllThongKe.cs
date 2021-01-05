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
        public XemAllThongKe(DataTable data)
        {
            InitializeComponent();
            rpXemAllThongKe rp = new rpXemAllThongKe();
            rp.SetDataSource(data);
            rpAll.ReportSource = rp;
        }

        private void XemAllThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
