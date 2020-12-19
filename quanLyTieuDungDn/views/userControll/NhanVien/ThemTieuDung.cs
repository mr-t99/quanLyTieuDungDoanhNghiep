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
using quanLyTieuDungDn.Model.Object;
using System.Collections;

namespace quanLyTieuDungDn.views.userControll.NhanVien
{
    public partial class ThemTieuDung : UserControl
    {


        private NguoiDung nguoiDung;
        private nhanvienController nhanVien;
        public ThemTieuDung()
        {
            InitializeComponent();
        }

        public void setNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;
            nhanVien = new nhanvienController(ng);
            LoadView();
        }

        private void LoadView()
        {
            setCbTieuDung();
            setTbTieuDung();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nhanVien.ThemTieuDung(SetTieuDung());
        }
        private void setCbTieuDung()
        {
            ArrayList arrTieuDung = new ArrayList();
            DataTable tieuDung = nhanVien.tieuDung;
            foreach(DataRow dr in tieuDung.Rows)
            {
                LoaiTieuDung td = new LoaiTieuDung();
                td.Id_loai_tieu_dung = (int)dr["id"];
                td.L_tdung = dr["l_tdung"].ToString();
                arrTieuDung.Add(td);
            }
            cbLoaiTieuDung.DataSource = arrTieuDung;
            cbLoaiTieuDung.DisplayMember = "L_tdung";
            cbLoaiTieuDung.ValueMember = "Id_loai_tieu_dung";
            
        }
        private void setTbTieuDung()
        {
            tbTieuDung.DataSource = nhanVien.thongKe;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private TieuDung SetTieuDung()
        {
            TieuDung tieuDung = new TieuDung();
            try
            {
                tieuDung.Gia = Int32.Parse(txtGia.Text);
            }
            catch
            {
                MessageBox.Show("Giá chỉ bao gồm số");
                tieuDung.Gia = 0;
            }
            tieuDung.T_tdung = txtMoTa.Text;
            LoaiTieuDung td = new LoaiTieuDung();
            td = (LoaiTieuDung)cbLoaiTieuDung.SelectedItem;
            tieuDung.Id_tieu_dung = td.Id_loai_tieu_dung;
            return tieuDung;
        }

        private void ThemTieuDung_Load(object sender, EventArgs e)
        {

        }
    }
}
