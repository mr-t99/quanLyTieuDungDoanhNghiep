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
            qlKiemDuyet1.Visible = true;
            qlKiemDuyet1.SetNguoiDung(nguoiDung);
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = false;
        }

        private void duyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlKiemDuyet1.Visible = true;
            qlKiemDuyet1.SetNguoiDung(nguoiDung);
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = false;
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlKiemDuyet1.Visible = false;
            qlNhanVien1.Visible = false;
            qlPhong1.Visible = true;
            qlPhong1.SetNguoiDung(nguoiDung);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlKiemDuyet1.Visible = false;
            qlNhanVien1.Visible = true;
            qlPhong1.Visible = false;
            qlNhanVien1.SetNguoiDung(nguoiDung);
        }

        private void lựaChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
