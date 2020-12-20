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
using quanLyTieuDungDn.module;
using System.Collections;
using quanLyTieuDungDn.Model.Object;

namespace quanLyTieuDungDn.views
{
    public partial class ketoan : Form
    {

        private NguoiDung nguoiDung;
        private KeToanController keToan;
        public ketoan(NguoiDung ng)
        {
            this.nguoiDung = ng;
            InitializeComponent();
            keToan = new KeToanController(this.nguoiDung);
            setComBox();
            Phong p = (Phong)comBoxPhong.ComboBox.SelectedItem;
            nguoiDung.Id_phong = p.Id_phong;
            hoaDon1.setNguoiDung(nguoiDung);
        }

        private void setComBox()
        {
            comBoxPhong.ComboBox.DataSource = keToan.ArrPhong();
            comBoxPhong.ComboBox.DisplayMember = "t_phong";
            comBoxPhong.ComboBox.ValueMember = "id_phong";
            comBoxPhong.SelectedIndexChanged += ComBoxPhong_SelectedIndexChanged;
        }

        private void ComBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p = (Phong)comBoxPhong.ComboBox.SelectedItem;
            Console.WriteLine(p.T_phong);
            this.nguoiDung.Id_phong = p.Id_phong;
            keToan = new KeToanController(this.nguoiDung);
            hoaDon1.setNguoiDung(nguoiDung);
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
