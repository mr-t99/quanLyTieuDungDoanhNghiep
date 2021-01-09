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

namespace quanLyTieuDungDn.views.userControll.ketoan
{
    public partial class HoaDon : UserControl
    {
        KeToanController keToan;
        QuanLyController quanLy;
        NguoiDung nguoiDung;
        Phong phongModel;
        TrangThai trangThai;
        int row=-1, id;
        private enum TrangThai { isView, isEdit};
        TrangThai TT
        {
            get { return trangThai; }
            set
            {
                switch (value)
                {
                    case TrangThai.isView: setView(); break;
                    case TrangThai.isEdit: SetEditing(); break;
                }
            }
        }
        public void setView()
        {
            
            if (tbTieuDung.Rows.Count > 1)
            {
                DataGridViewRow cRow = tbTieuDung.Rows[0];
                FillView(cRow);
            }
            txtSoTien.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtTienTieuDung.ReadOnly = true;
        }
        public void SetEditing()
        {

        }
        void FillView(DataGridViewRow cRow)
        {
            
            txtTenNhanVien.Text = cRow.Cells[0].Value.ToString();
            txtSoTien.Text = cRow.Cells[2].Value.ToString();
            txtTienTieuDung.Text = cRow.Cells[1].Value.ToString();
        }
        
        public HoaDon()
        {
            InitializeComponent();
            
        }
        //xử lý
        public void setNguoiDung(NguoiDung nd, Phong p)
        {
            this.nguoiDung = nd;
            this.phongModel = p;
            keToan = new KeToanController(nguoiDung, phongModel, 2);
            loadView();
            TT = TrangThai.isView;
        }
      
        private void loadView()
        {
            //LoadTable
            tbTieuDung.DataSource = keToan.hoaDonNhanTien;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbTieuDung.ReadOnly = true;
            tbTieuDung.Columns[7].Visible = false;
            //Load ten
            lbTen.Text = nguoiDung.Tn_dung;
        }

        private void tbTieuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                FillView(tbTieuDung.Rows[e.RowIndex]);
                this.row = e.RowIndex;
                this.id = (int)tbTieuDung.Rows[e.RowIndex].Cells[7].Value;
            }
        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            int row = 0;
            foreach (DataGridViewRow dr in tbTieuDung.Rows)
            {
                dr.Selected = false;
                if (dr.Cells[0].Value != null && dr.Cells[1].Value.ToString().Equals(txtTiemKiem.Text))
                {
                    dr.Selected = true;
                    row++;
                }
            }
            if(row==0)
            {
                MessageBox.Show("Không tìm thấy tiêu dùng này");
            }
            else
            {
                MessageBox.Show("Có " + row + " tiêu dùng được tìm thấy");
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            TieuDung td = new TieuDung();
            //Xử lý phần in hóa đơn
            td.Ngay_hoan_thanh = dateGiao.Value;
            td.Id_ktoan = nguoiDung.Id_nguoi_dung;
            keToan.NhanTien(row, this.id, td);
        }
    }
}
