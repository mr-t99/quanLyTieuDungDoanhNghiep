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
        int row=-1, id_tthai;


        public QLKiemDuyet()
        {
            InitializeComponent();
        }
        public void SetNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;
            lbTen.Text = nguoiDung.Tn_dung;
            //lấy dữ liệu phòng
            this.quanLy = new QuanLyController();
            LoadComboxPhong();
            loadComboxTrangThai();
            id_tthai = 1;
            LoadDataTable(ng);
            btNghiemThu.Visible = false;
        }
        private void LoadComboxPhong()
        {
            //phong
            cbPhong.DataSource = quanLy.ArrPhong();
            cbPhong.DisplayMember = "t_phong";
            cbPhong.ValueMember = "id_phong";
            
        }
        private void loadComboxTrangThai()
        {
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
            this.quanLy = new QuanLyController(ng,p.Id_phong, id_tthai);
            tbTieuDung.DataSource = quanLy.viewTieuDung;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbTieuDung.Columns["id"].Visible = false;
            if (tbTieuDung.Rows.Count > 1)
            {
                tbTieuDung.ReadOnly = true;
                LoadDataTextBox(tbTieuDung.Rows[0]);
            }
        }
        private void QLKiemDuyet_Load(object sender, EventArgs e)
        {
            
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phong p = (Phong)cbPhong.SelectedItem;
            this.quanLy = new QuanLyController(this.nguoiDung, p.Id_phong, id_tthai);
            tbTieuDung.DataSource = quanLy.viewTieuDung;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (tbTieuDung.Rows.Count > 1)
            {
                tbTieuDung.ReadOnly = true;
                LoadDataTextBox(tbTieuDung.Rows[0]);
            }
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

            TieuDung tieuDung = new TieuDung();
            tieuDung.Gia = Int32.Parse(txtSoTien.Text);
            TrangThai tt = (TrangThai)cbTrangThai.SelectedItem;
            tieuDung.T_thai = tt.Id_trang_thai;
            tieuDung.T_tthai = tt.T_tthai;
            tieuDung.Ghi_chu = rtxtGhiChu.Text;
            tieuDung.Id_qly = nguoiDung.Id_nguoi_dung;
            tieuDung.Ngay_hoan_thanh = DateTime.Now;
            this.quanLy.CapNhatDataTieuDung(row, tieuDung);
        }

        private void btNghiemThu_Click(object sender, EventArgs e)
        {
            TieuDung tieuDung = new TieuDung();
            tieuDung.Gia = Int32.Parse(txtSoTien.Text);
            TrangThai tt = (TrangThai)cbTrangThai.SelectedItem;
            tieuDung.T_thai = tt.Id_trang_thai;
            tieuDung.T_tthai = tt.T_tthai;
            tieuDung.Ghi_chu = rtxtGhiChu.Text;
            tieuDung.Id_qly = nguoiDung.Id_nguoi_dung;
            tieuDung.Ngay_hoan_thanh = DateTime.Now;
            this.quanLy.CapNhatDataNghiemThuTieuDung(row, tieuDung);
        }

        //Nghiem Thu
        public void SetViewNghiemThu(NguoiDung ng)
        {
            this.nguoiDung = ng;
            this.quanLy = new QuanLyController();
            lbTen.Text = nguoiDung.Tn_dung;
            LoadComboxPhong();
            id_tthai = 4;
            LoadDataTable(nguoiDung);
            btNghiemThu.Visible = true;
            LoadComboxTrangThaiNghiemThu();
        }
        private void LoadComboxTrangThaiNghiemThu()
        {
            tthai = new ArrayList();
            TrangThai trangThai1 = new TrangThai();
            trangThai1.Id_trang_thai = 5;
            trangThai1.T_tthai = "Nghiệm thu";
            tthai.Add(trangThai1);
            TrangThai trangThai2 = new TrangThai();
            trangThai2.Id_trang_thai = 6;
            trangThai2.T_tthai = "Hoàn tiền";
            tthai.Add(trangThai2);
            cbTrangThai.DataSource = tthai;
            cbTrangThai.DisplayMember = "t_tthai";
            cbTrangThai.ValueMember = "id_trang_thai";
            //thong nguoi dung khong duc sua
            txtTenNhanVien.ReadOnly = true;
            txtTienTieuDung.ReadOnly = true;
        }
    }
}
