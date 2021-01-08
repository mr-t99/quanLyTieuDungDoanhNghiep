using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.Model.Object;

namespace quanLyTieuDungDn.views
{
    public partial class nhanvien : Form
    {
        private NguoiDung nguoiDung;

        public nhanvien(NguoiDung ng)
        {
            this.nguoiDung = ng;
            InitializeComponent();
            themTieuDung1.Visible = true;
            themTieuDung1.setNguoiDung(this.nguoiDung);
        }
        private void nhanvien_Load(object sender, EventArgs e)
        {
            lbNgay.Text = "Hôm nay: "+DateTime.Now.ToString("dd/MM/yyyy");
            lbTenNv.Text = "Nhân viên: " + nguoiDung.Tn_dung;
            lbphong.Text = "Phòng: " + nguoiDung.Id_phong;
        }

        private void dấdádsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themTieuDung1.Visible = true;
            themTieuDung1.setNguoiDung(this.nguoiDung);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rl = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (rl == DialogResult.Yes)
            {
                this.Dispose();
                dangnhap dn = new dangnhap();
                dn.Visible = true;
            }
        }

        private void option_Click(object sender, EventArgs e)
        {

        }

        private void themTieuDung1_Load(object sender, EventArgs e)
        {

        }
    }
}
