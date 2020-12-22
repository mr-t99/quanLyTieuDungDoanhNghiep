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
        NguoiDung nguoiDung;
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
        public void setNguoiDung(NguoiDung nd, string view)
        {
            this.nguoiDung = nd;
            if (view == "nghiemthu")
            {
                keToan = new KeToanController(nguoiDung,4);
                btLuu.Text = "Nghiệm thu";
                
            }
            else
            {
                keToan = new KeToanController(nguoiDung, 2);
            }
            loadView();
            TT = TrangThai.isView;
        }
      
        private void loadView()
        {
            tbTieuDung.DataSource = keToan.hoaDonNhanTien;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbTieuDung.ReadOnly = true;
            tbTieuDung.Columns[7].Visible = false;
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
        private void button1_Click(object sender, EventArgs e)
        {
            TieuDung td = new TieuDung();
            //xử lý phần nghiệm thu
            if (btLuu.Text == "Nghiệm thu")
            {
                td.Ngay_hoan_thanh = dateGiao.Value;
                td.Id_ktoan = nguoiDung.Id_nguoi_dung;
                keToan.NghiemTHu(row, this.id, td);
            }
            else
            {
                //Xử lý phần in hóa đơn
                td.Ngay_hoan_thanh = dateGiao.Value;
                td.Id_ktoan = nguoiDung.Id_nguoi_dung;
                keToan.NhanTien(row, this.id, td);
            }
        }
    }
}
