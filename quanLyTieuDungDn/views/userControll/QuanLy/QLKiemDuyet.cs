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
using System.Collections;

namespace quanLyTieuDungDn.views.userControll.QuanLy
{
    public partial class QLKiemDuyet : UserControl
    {
        private QuanLyController quanLy;
        private NguoiDung nguoiDung;
        public QLKiemDuyet()
        {
            InitializeComponent();
        }
        public void SetNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;

            //lấy dữ liệu phòng
            this.quanLy = new QuanLyController();
            cbPhong.DataSource = quanLy.ArrPhong();
            cbPhong.DisplayMember = "t_phong";
            cbPhong.ValueMember = "id_phong";
        }
        private void QLKiemDuyet_Load(object sender, EventArgs e)
        {
            
        }
    }
}
