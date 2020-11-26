using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.controller;
using System.Data;

namespace quanLyTieuDungDn.views.userControll
{
    public partial class thongke : UserControl
    {
        public thongke()
        {
            InitializeComponent();
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            thongkeController controllerThongke = new thongkeController();
            controllerThongke.dataBangThongKe();
            dgThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgThongKe.DataSource = controllerThongke.Data;
            
        }
    }
}
