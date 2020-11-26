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
        public delegate void sendInfor(int id, string name);
        public sendInfor infor;
        public nhanvien()
        {
            InitializeComponent();
            infor = new sendInfor(setUserName);
        }
        private void setUserName(int id, string name)
        {
            userOption.Text = name;
        }
        private void nhanvien_Load(object sender, EventArgs e)
        {
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

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
