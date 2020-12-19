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

        }
        private void SetLable()
        {
            lbCaNhan.Text = String.Format("{0:#,##0.00}", nhanvien.c_nhan);
            lbHanMuc.Text = String.Format("{0:#,##0.00}", nhanvien.h_muc);
            lbTongPhong.Text = String.Format("{0:#,##0.00}", nhanvien.t_phong);
            lbVuotMuc.Text = String.Format("{0:#,##0.00}", nhanvien.v_muc);
        }

    }
}
