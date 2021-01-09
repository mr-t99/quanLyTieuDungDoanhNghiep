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

namespace quanLyTieuDungDn.views.userControll.QuanLy
{
    public partial class ThongKe : UserControl
    {
        private NguoiDung nguoiDung;
        private QuanLyController quanLy;
        private Phong phong;
        private DataTable data;
        public ThongKe()
        {
            InitializeComponent();
        }
        public void SetNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;
            this.quanLy = new QuanLyController();
            LoadComboxPhong();
            phong = (Phong)cbPhong.SelectedItem;
            this.quanLy = new QuanLyController(phong.Id_phong, dateTime.Value);
            data = quanLy.viewThongKeChi;
            tbViewThongKeChi.DataSource = data; 
            tbViewThongKeChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbViewThongKeChi.Columns["Kế toán"].Visible = false;
            tbViewThongKeChi.Columns["t_phong"].Visible = false;
            tbViewThongKeChi.Columns["ngay_giao_tien"].Visible = false;
        }
        private void LoadComboxPhong()
        {
            //phong
            cbPhong.DataSource = quanLy.ArrPhong();
            cbPhong.DisplayMember = "t_phong";
            cbPhong.ValueMember = "id_phong";
            
        }
        private void btXemChiTiet_Click(object sender, EventArgs e)
        {
            ThongKeChiTheoNgay thongke = new ThongKeChiTheoNgay(data);
            thongke.Show();
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            phong = (Phong)cbPhong.SelectedItem;
            this.quanLy = new QuanLyController(phong.Id_phong, dateTime.Value);
            data = quanLy.viewThongKeChi;
            tbViewThongKeChi.DataSource = data;
            tbViewThongKeChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbViewThongKeChi.Columns["Kế toán"].Visible = false;
            tbViewThongKeChi.Columns["t_phong"].Visible = false;
            tbViewThongKeChi.Columns["ngay_giao_tien"].Visible = false;
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
