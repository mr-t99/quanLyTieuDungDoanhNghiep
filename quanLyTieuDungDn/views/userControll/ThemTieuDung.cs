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
        private nhanvienController nhanvienController = new nhanvienController();
        public ThemTieuDung()
        {
            InitializeComponent();
            SetDataCombox();
        }
        public void setUserName(int id_nd)
        {
            this.id_ndung = id_nd;
            dgvTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTieuDung.DataSource = nhanvienController.dataTableTieuDung(id_ndung);
            dgvTieuDung.Columns["id"].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThemTieuDung_Load(object sender, EventArgs e)
        {
        }

        private void btDuyet_Click(object sender, EventArgs e)
        {
            TieuDung td = new TieuDung();
            td.Id_ndung = this.id_ndung;
            quanLyTieuDungDn.module.NhanVien a = new NhanVien();
            a = (quanLyTieuDungDn.module.NhanVien)cbLoaiTdung.SelectedItem;
            td.Id_tdung = a.Id_tdung;
            td.T_tdung = txtMota.Text;
            td.Gia = txtGia.Text;
            if (nhanvienController.addTieuDung(td) != 0)
            {
                MessageBox.Show("thêm thành công");
                dgvTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTieuDung.DataSource = nhanvienController.dataTableTieuDung(id_ndung);
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm bạn đã nhập đủ thông tin chưa");
            }
        }
        private void SetDataCombox()
        {
            
            this.nhanvienController = new nhanvienController();
            nhanvienController.dataCombox();
            ArrayList data = nhanvienController.DataDataCombox;
            cbLoaiTdung.DataSource = data;
            cbLoaiTdung.DisplayMember = "t_tdung";
            cbLoaiTdung.ValueMember = "id_tdung";
        }

        private void cbLoaiTdung_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //MessageBox.Show(a.T_tdung + " " + a.Id_tdung);    
        }
    }
}
