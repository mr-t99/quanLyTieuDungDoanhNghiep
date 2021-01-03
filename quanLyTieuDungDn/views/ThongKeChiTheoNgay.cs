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
    public partial class ThongKeChiTheoNgay : Form
    {
        public ThongKeChiTheoNgay(DataTable data)
        {
            InitializeComponent();
            cpThongKeChiTheoNgay thongke = new cpThongKeChiTheoNgay();
            thongke.SetDataSource(data);
            rpThongKe.ReportSource = thongke;
        }
    }
}
