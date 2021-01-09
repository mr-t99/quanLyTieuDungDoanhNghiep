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
using quanLyTieuDungDn.Model;

namespace quanLyTieuDungDn.views
{
    public partial class quanly : Form
    {
        private NguoiDung nguoiDung;
        public quanly(NguoiDung ng)
        {
            //setNguoi dung
            //nguoiDung = new NguoiDung();
            //nguoiDung.Id_nguoi_dung = 1;
            //nguoiDung.Id_phong = 1;
            //nguoiDung.Ngay_lam = DateTime.Now;
            //nguoiDung.Que_quan = "Thai Binh";
            //nguoiDung.Tn_dung = "Trần Ngọc Thăng";
            //nguoiDung.C_vu = "Quản lý";
            //nguoiDung.G_tinh = true;
            this.nguoiDung = ng;

            InitializeComponent();
            urChapThuan.Visible = true;
            urChapThuan.SetNguoiDung(nguoiDung);
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = false;
            urNghiemThu.Visible = false;
            thongKe1.Visible = false;
        }

        private void duyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urChapThuan.Visible = true;
            urChapThuan.SetNguoiDung(nguoiDung);
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = false;
            urNghiemThu.Visible = false;
            thongKe1.Visible = false;
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urChapThuan.Visible = false;
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = true;
            urNghiemThu.Visible = false;
            qlPhong1.SetNguoiDung(nguoiDung);
            thongKe1.Visible = false;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urChapThuan.Visible = false;
            qlNhanVien1.Visible = true;
            qlPhong1.Visible = false;
            urNghiemThu.Visible = false;
            qlNhanVien1.SetNguoiDung(nguoiDung);
            thongKe1.Visible = false;
        }

        private void lựaChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void kiểmDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urNghiemThu.Visible = false;
            urChapThuan.Visible = false;
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = false;
            urNghiemThu.SetViewNghiemThu(this.nguoiDung);
            thongKe1.Visible = true;
            thongKe1.SetNguoiDung(nguoiDung);
        }

        private void nghiệmThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urNghiemThu.Visible = true;
            urChapThuan.Visible = false;
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = false;
            urNghiemThu.SetViewNghiemThu(this.nguoiDung);
            thongKe1.Visible = false;
        }

        private void thooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QuanLyModel ql = new QuanLyModel();
            //XemAllThongKe xem = new XemAllThongKe(ql.GetTableViewAllThongKeChi());
            //xem.Show();
            ChonThangNam date = new ChonThangNam();
            date.Show();
        }

        private void tiêuDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
