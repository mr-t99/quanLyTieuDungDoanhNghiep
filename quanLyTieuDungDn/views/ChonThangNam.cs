using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.controller;

namespace quanLyTieuDungDn.views
{
    public partial class ChonThangNam : Form
    {
        public ChonThangNam()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "'Chọn ngày: 'MM / yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyController quanLy = new QuanLyController();
            XemAllThongKe allThongKe = new XemAllThongKe(quanLy.AllThongKe(dateTimePicker1.Value));
            allThongKe.ChiTietTieuDung();
            allThongKe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyController quanLy = new QuanLyController();
            XemAllThongKe allThongKe = new XemAllThongKe(quanLy.ThongTinTD(dateTimePicker1.Value));
            allThongKe.FThongTinTieuDung();
            allThongKe.Show();
        }
    }
}
