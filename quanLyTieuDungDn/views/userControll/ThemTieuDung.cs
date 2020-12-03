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
using System.Collections;
using quanLyTieuDungDn.module;

namespace quanLyTieuDungDn.views.userControll
{
    public partial class ThemTieuDung : UserControl
    {
        private int id_ndung, type, id_tdung;
        private nhanvienController nhanvienController = new nhanvienController();
        public ThemTieuDung()
        {
            InitializeComponent();
            SetDataCombox();
        }
        public void setUserName(int id_nd, int type)
        {
            this.id_ndung = id_nd;
            this.type = type;
            dgvTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTieuDung.DataSource = nhanvienController.dataTableTieuDung(id_ndung);
            dgvTieuDung.Columns["id_td"].Visible = false;
            if (type == 1)
            {
                lbIntro.Text = "Thêm tiêu dùng";
                btXoa.Visible = false;
                txtGia.Clear();
                txtMota.Clear();
            }else if(type==2){
                lbIntro.Text = "Sửa tiêu dùng";
                btDuyet.Text = "lưu thay đối";
                btXoa.Visible = true;
                btXoa.Enabled = false;
                txtGia.Clear();
                txtMota.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThemTieuDung_Load(object sender, EventArgs e)
        {
        }

        private void btDuyet_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                TieuDung td = new TieuDung();
                td.Id_ndung = this.id_ndung;
                quanLyTieuDungDn.module.NhanVien a = new NhanVien();
                a = (quanLyTieuDungDn.module.NhanVien)cbLoaiTdung.SelectedItem;
                Console.WriteLine(a.Id_tdung);
                td.Id_ltdung = a.Id_tdung;
                td.T_tdung = txtMota.Text;
                td.Gia = txtGia.Text;
                if (nhanvienController.addTieuDung(td) != 0)
                {
                    MessageBox.Show("thêm thành công");
                    dgvTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTieuDung.DataSource = nhanvienController.dataTableTieuDung(id_ndung);
                }
                else
                {
                    MessageBox.Show("Lỗi không thể thêm bạn đã nhập đủ thông tin chưa");
                }
            }
            else if (type == 2)
            {
                TieuDung td = new TieuDung();
                td.Id_ndung = this.id_ndung;
                quanLyTieuDungDn.module.NhanVien a = new NhanVien();
                a = (quanLyTieuDungDn.module.NhanVien)cbLoaiTdung.SelectedItem;
                td.Id_ltdung = a.Id_tdung;
                td.T_tdung = txtMota.Text;
                td.Gia = txtGia.Text;
                td.Id_tdung = this.id_tdung;
                if (nhanvienController.repairTieuDung(td) != 0)
                {
                    MessageBox.Show("Sửa thành công");
                    dgvTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTieuDung.DataSource = nhanvienController.dataTableTieuDung(id_ndung);
                }
                else
                {
                    MessageBox.Show("Lỗi không thể thêm bạn đã nhập đủ thông tin chưa");
                }
            }
        }
        private void SetDataCombox()
        {
            
            this.nhanvienController = new nhanvienController();
            nhanvienController.dataCombox();
            ArrayList data = nhanvienController.DataDataCombox;
            cbLoaiTdung.DataSource = data;
            cbLoaiTdung.DisplayMember = "t_tdung";
            cbLoaiTdung.ValueMember = "id_tdung";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có trắc muốn xóa!", "Thông báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes)
            {
                if (nhanvienController.DeleteTieuDung(this.id_tdung) != 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTieuDung.DataSource = nhanvienController.dataTableTieuDung(id_ndung);
                }
                else
                {
                    MessageBox.Show("Lỗi không thể xóa");
                }
            }
        }

        private void cbLoaiTdung_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //MessageBox.Show(a.T_tdung + " " + a.Id_tdung);    
        }

        private void dgvTieuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (type == 1)
                {
                }
                else if (type == 2)
                {
                    DataGridViewRow row = this.dgvTieuDung.Rows[e.RowIndex];
                    //Console.WriteLine();
                    //Console.WriteLine(e.RowIndex);
                    txtMota.Text = row.Cells[1].Value.ToString();
                    txtGia.Text = row.Cells[3].Value.ToString();
                    this.id_tdung = Int32.Parse(row.Cells[0].Value.ToString());
                    cbLoaiTdung.SelectedIndex = cbLoaiTdung.FindStringExact(row.Cells[2].Value.ToString());
                    btXoa.Enabled = true;
                }
            }
        }
    }
}
