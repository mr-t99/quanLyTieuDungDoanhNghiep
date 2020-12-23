﻿using System;
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
        Phong p;
        public ketoan(NguoiDung ng)
        {
            this.nguoiDung = ng;
            InitializeComponent();
            keToan = new KeToanController();
            setComBox();
            p = new Phong();
            p = (Phong)comBoxPhong.ComboBox.SelectedItem;
            keToan = new KeToanController(this.nguoiDung, p, 4);
            
            NghiemThu.Visible = true;
            NghiemThu.setNguoiDung(nguoiDung, p, "nghiemthu");
            InHoaDon.Visible = false;
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
            
            p = (Phong)comBoxPhong.ComboBox.SelectedItem;
            
            if (NghiemThu.Visible == true)
            {
                keToan = new KeToanController(this.nguoiDung,p, 4);
                InHoaDon.setNguoiDung(nguoiDung, p, "nghiemthu");
            }
            else
            {
                keToan = new KeToanController(this.nguoiDung,p, 2);
                InHoaDon.setNguoiDung(nguoiDung, p, "hoadon");
            }
            
        }

        private void hoaDon1_Load(object sender, EventArgs e)
        {

        }

        private void thêmTiêuDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Id phong:" + nguoiDung.Id_phong);
            nhanvien nv = new nhanvien(nguoiDung);
            nv.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InHoaDon.Visible = true;
            NghiemThu.Visible = false;
            p = (Phong)comBoxPhong.ComboBox.SelectedItem;
            InHoaDon.setNguoiDung(nguoiDung, p, "hoadon");
            
        }

        private void nghiệmThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = (Phong)comBoxPhong.ComboBox.SelectedItem;
            NghiemThu.Visible = true;
            NghiemThu.setNguoiDung(nguoiDung, p, "nghiemthu");
            InHoaDon.Visible = false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rl = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if(rl == DialogResult.Yes)
            {
                this.Dispose();
                dangnhap dn = new dangnhap();
                dn.Visible = true;
            }
        }
    }
}
