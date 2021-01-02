using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.Model.Object;
using quanLyTieuDungDn.controller;

namespace quanLyTieuDungDn.views.userControll.NhanVien
{
    public partial class ThongKe : UserControl
    {
        private NguoiDung nguoiDung;
        nhanvienController nhanvien;
        public ThongKe()
        {
            InitializeComponent();
        }
        
        public void setNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;
            this.nhanvien = new nhanvienController(ng);
            SetLable();
            SetTable();
        }
        private void SetTable()
        {
            tbTieuDung.DataSource = this.nhanvien.thongKe;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbTieuDung.ReadOnly = true;
            tbTieuDung.Enabled = false;
        }
        private void SetLable()
        {
            lbCaNhan.Text = String.Format("{0:#,##0.00}", nhanvien.c_nhan);
            lbHanMuc.Text = String.Format("{0:#,##0.00}", nhanvien.h_muc);
            lbTongPhong.Text = String.Format("{0:#,##0.00}", nhanvien.t_phong);
            lbVuotMuc.Text = String.Format("{0:#,##0.00}", nhanvien.v_muc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = 0;
            foreach(DataGridViewRow dr in tbTieuDung.Rows)
            {
                dr.Selected = false;
                if(dr.Cells[0].Value != null && dr.Cells[1].Value.ToString().Equals(txtTimKiem.Text))
                {
                    dr.Selected = true;
                    row++;
                }
            }
            if (row == 0)
            {
                MessageBox.Show("Không tìm thấy tiêu dùng này");
            }
            else
            {
                MessageBox.Show("Có " + row + " tiêu dùng được tìm thấy");
            }
        }
    }
}
