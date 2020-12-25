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
        ArrayList tthai;
        int row=-1;


        public QLKiemDuyet()
        {
            InitializeComponent();
        }
        public void SetNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;

            //lấy dữ liệu phòng
            this.quanLy = new QuanLyController();
            LoadComboxPhong();
            LoadDataTable(ng);
        }
        private void LoadComboxPhong()
        {
            //phong
            cbPhong.DataSource = quanLy.ArrPhong();
            cbPhong.DisplayMember = "t_phong";
            cbPhong.ValueMember = "id_phong";
            //trạng thái
             tthai = new ArrayList();
            TrangThai trangThai1 = new TrangThai();
            trangThai1.Id_trang_thai = 2;
            trangThai1.T_tthai = "Chấp nhận";
            tthai.Add(trangThai1);
            TrangThai trangThai2 = new TrangThai();
            trangThai2.Id_trang_thai = 3;
            trangThai2.T_tthai = "Từ chối";
            tthai.Add(trangThai2);
            cbTrangThai.DataSource = tthai;
            cbTrangThai.DisplayMember = "t_tthai";
            cbTrangThai.ValueMember = "id_trang_thai";
            //thong nguoi dung khong duc sua
            txtTenNhanVien.ReadOnly = true;
            txtTienTieuDung.ReadOnly = true;
        }
        private void LoadDataTable(NguoiDung ng)
        {
            Phong p = (Phong)cbPhong.SelectedItem;
            this.quanLy = new QuanLyController(ng,p.Id_phong, 1);
            tbTieuDung.DataSource = quanLy.viewTieuDung;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            if (tbTieuDung.Rows.Count > 1)
            {
                tbTieuDung.Columns["id"].Visible = false;
                tbTieuDung.ReadOnly = true;
                LoadDataTextBox(tbTieuDung.Rows[0]);
            }
        }
        private void QLKiemDuyet_Load(object sender, EventArgs e)
        {
            
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("thay doi");
            Phong p = (Phong)cbPhong.SelectedItem;
            this.quanLy = new QuanLyController(this.nguoiDung, p.Id_phong, 1);
            tbTieuDung.DataSource = quanLy.viewTieuDung;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDataTextBox(DataGridViewRow row)
        {
            txtTenNhanVien.Text = row.Cells["Nhân viên"].Value.ToString();
            txtSoTien.Text = row.Cells["Giá"].Value.ToString();
            txtTienTieuDung.Text = row.Cells["Mua"].Value.ToString();
            var a = cbTrangThai.SelectedItem = cbTrangThai.FindStringExact(row.Cells["Trạng Thái"].Value.ToString());
            
        }

        private void tbTieuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && tbTieuDung.Rows.Count - 1 != e.RowIndex)
            {
                LoadDataTextBox(tbTieuDung.Rows[e.RowIndex]);
                this.row = e.RowIndex;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Console.WriteLine(row);
            TieuDung tieuDung = new TieuDung();
            tieuDung.Gia = Int32.Parse(txtSoTien.Text);
            TrangThai tt = (TrangThai)cbTrangThai.SelectedItem;
            tieuDung.T_thai = tt.Id_trang_thai;
            tieuDung.Ghi_chu = rtxtGhiChu.Text;
            tieuDung.Id_qly = nguoiDung.Id_nguoi_dung;
            this.quanLy.CapNhatDataBase(row, tieuDung);
        }
    }
}
