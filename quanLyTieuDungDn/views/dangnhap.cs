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
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginController lg = new LoginController(txtUsername.Text, txtPassword.Text);
            NguoiDung check = lg.CheckLogin();
            Console.WriteLine(check.Id_phong);
            if (check.C_vu == "Nhân viên")
            {
                nhanvien nv = new nhanvien(check);
                nv.Show();
                this.Visible = false;
            }
            else if (check.C_vu == "Quản lý")
            {
                quanly ql = new quanly(check);
                ql.Show();
                this.Visible = false;
            }
            else if (check.C_vu == "Kế toán")
            {
                ketoan kt = new ketoan(check);
                kt.Show();
                this.Visible = false;
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
