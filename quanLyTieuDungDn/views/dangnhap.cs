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
            login lg = new login(txtUsername.Text, txtPassword.Text);
            lg.checkLogin();
            if(lg.User.T_ndung == null)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if(lg.User.C_vu== "Nhân viên")
                {
                    nhanvien nv = new nhanvien();

                    nv.infor(lg.User.Id, lg.User.Id_phong, lg.User.T_ndung);
                    nv.Show();
                    this.Hide();
                }
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
