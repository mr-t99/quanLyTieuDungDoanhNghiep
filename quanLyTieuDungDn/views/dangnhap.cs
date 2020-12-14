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
using quanLyTieuDungDn.Model.Object;

namespace quanLyTieuDungDn.views
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginController lg = new LoginController(txtUsername.Text, txtPassword.Text);
            NguoiDung check = lg.CheckLogin();
            if (check.C_vu == "Nhân viên")
            {
                nhanvien nv = new nhanvien();
                nv.Id_ndung = check.Id_nguoi_dung;
                nv.Show();
                this.Visible = false;
            }
            else if (check.C_vu == "Quản lý")
            {

            }
            else if (check.C_vu == "Kế toán")
            {

            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            Console.WriteLine(dl);
            if(dl == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
