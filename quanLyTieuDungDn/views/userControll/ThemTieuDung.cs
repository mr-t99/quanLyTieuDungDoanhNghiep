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
using System.Collections;
using quanLyTieuDungDn.module;

namespace quanLyTieuDungDn.views.userControll
{
    public partial class ThemTieuDung : UserControl
    {
        private int id_ndung;
        public ThemTieuDung()
        {
            InitializeComponent();
            SetDataCombox();
        }
        public void setUserName(int id_nd)
        {
            this.id_ndung = id_nd;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThemTieuDung_Load(object sender, EventArgs e)
        {

        }

        private void btDuyet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.id_ndung.ToString());
        }
        private void SetDataCombox()
        {
            
            nhanvienController nhanvienController = new nhanvienController();
            nhanvienController.dataCombox();
            ArrayList data = nhanvienController.DataDataCombox;
            cbLoaiTdung.DataSource = data;
            cbLoaiTdung.DisplayMember = "t_tdung";
            cbLoaiTdung.ValueMember = "id_tdung";
        }

        private void cbLoaiTdung_SelectedIndexChanged(object sender, EventArgs e)
        {
            quanLyTieuDungDn.module.NhanVien a = new NhanVien();
            
            a = (quanLyTieuDungDn.module.NhanVien)cbLoaiTdung.SelectedItem;
            MessageBox.Show(a.T_tdung + " " + a.Id_tdung);
        }
    }
}
