using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyTieuDungDn.views
{
    public partial class nhanvien : Form
    {
        private int id_ndung, id_phong;
        public delegate void sendInfor(int id_ndung, int id_phong, string name);
        public sendInfor infor;
        public nhanvien()
        {
            InitializeComponent();
            infor = new sendInfor(setUserName);
        }
        private void setUserName(int id_nd, int id_phong, string name)
        {
            userOption.Text = name;
            this.id_ndung = id_nd;
            this.id_phong = id_phong;
        }
        private void nhanvien_Load(object sender, EventArgs e)
        {
            Console.WriteLine(this.id_phong);
            this.thongke1.setId(this.id_ndung, this.id_phong);
            this.themTieuDung1.Visible = false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes)
            {
                this.Dispose();
                dangnhap dn = new dangnhap();
                dn.Show();
            }
        }


        private void dấdádsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.thongke1.Visible = false;
            this.themTieuDung1.Visible = true;
            this.themTieuDung1.setUserName(id_ndung);
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
