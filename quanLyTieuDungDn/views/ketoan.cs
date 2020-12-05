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

namespace quanLyTieuDungDn.views
{
    public partial class ketoan : Form
    {
        private KeToanController kt;
        private ArrayList arrPhong;
        public ketoan()
        {
            InitializeComponent();
            kt = new KeToanController();
            arrPhong = kt.getDataPhong();
            comBoxPhong.ComboBox.DataSource = arrPhong;
            comBoxPhong.ComboBox.DisplayMember = "t_phong";
            comBoxPhong.ComboBox.ValueMember = "id";
            PhongModel phong = new PhongModel();
            phong = (PhongModel)comBoxPhong.ComboBox.SelectedItem;
            thongke1.setId('1', phong.Id);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ketoan_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void thongke1_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhongModel phong = new PhongModel();
            phong = (PhongModel)comBoxPhong.ComboBox.SelectedItem;
            thongke1.setId(1, phong.Id);
        }
    }
}
