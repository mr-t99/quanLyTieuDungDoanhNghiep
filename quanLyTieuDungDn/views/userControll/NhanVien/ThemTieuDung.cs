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
using System.Collections;

namespace quanLyTieuDungDn.views.userControll.NhanVien
{
    public partial class ThemTieuDung : UserControl
    {

        private enum TrangThai { isViewing, IsEditing, IsAddnew, isEditingTD};
        private NguoiDung nguoiDung;
        private nhanvienController nhanVien;
        private TrangThai trangThai;
        private int selectIndexRow = -1;

        private TrangThai TT
        {
            get { return this.trangThai; }
            set
            {
                switch (value)
                {
                    case TrangThai.IsAddnew: SetAdding(); break;
                    case TrangThai.IsEditing: SetEditing(); break;
                    case TrangThai.isViewing: setView(); break;
                    case TrangThai.isEditingTD: SetAddPhanLoai(); break;
                }
            }
        }
        private void FillView(DataGridViewRow row)
        {
            txtMoTa.Text = row.Cells[1].Value.ToString();
            txtGia.Text = row.Cells[2].Value.ToString();
            cbLoaiTieuDung.SelectedIndex = cbLoaiTieuDung.FindStringExact(row.Cells[3].Value.ToString());
        }
        private void XoaTextBox()
        {
            txtGia.Clear();
            txtMoTa.Clear();
        }
        private void setView()
        {
            if(tbTieuDung.Rows.Count > 1)
            {
                Console.WriteLine(tbTieuDung.Rows[0].Cells[1].Value.ToString());
                DataGridViewRow cRow = tbTieuDung.Rows[0];
                tbTieuDung.ReadOnly = true;
                FillView(cRow);
            }
            tbTieuDung.ReadOnly = true;
            panel1.Enabled = false;
            txtThemTieuDung.Enabled = false;
            trangThai = TrangThai.isViewing;
        }
        private void SetAddPhanLoai()
        {
            panel1.Enabled = false;
            tbTieuDung.Enabled = false;
            txtThemTieuDung.Enabled = true;
        }
        private void SetAdding()
        {
            panel1.Enabled = true;
            XoaTextBox();
        }
        private void SetEditing()
        {
            panel1.Enabled = true;
        }
        public ThemTieuDung()
        {
            InitializeComponent();
        }

        public void setNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;
            nhanVien = new nhanvienController(ng);
            LoadView();
            TT = TrangThai.isViewing;
        }

        private void LoadView()
        {
            setCbTieuDung();
            setTbTieuDung();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TT != TrangThai.IsAddnew)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm");
                TT = TrangThai.IsAddnew;
                trangThai = TrangThai.IsAddnew;
            }
            else
            {
                LoaiTieuDung ltd = new LoaiTieuDung();
                ltd = (LoaiTieuDung)cbLoaiTieuDung.SelectedItem;
                nhanVien.ThemTieuDung(SetTieuDung(), ltd);
                XoaTextBox();
            }
        }
        private void setCbTieuDung()
        {
            ArrayList arrTieuDung = new ArrayList();
            DataTable tieuDung = nhanVien.tieuDung;
            foreach(DataRow dr in tieuDung.Rows)
            {
                LoaiTieuDung td = new LoaiTieuDung();
                td.Id_loai_tieu_dung = (int)dr["id"];
                td.L_tdung = dr["l_tdung"].ToString();
                arrTieuDung.Add(td);
            }
            cbLoaiTieuDung.DataSource = arrTieuDung;
            cbLoaiTieuDung.DisplayMember = "L_tdung";
            cbLoaiTieuDung.ValueMember = "Id_loai_tieu_dung";
            
        }
        private void setTbTieuDung()
        {
            nhanVien.GetThongKeCaNhan();
            tbTieuDung.DataSource = nhanVien.thongKeCaNhan;
            tbTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private TieuDung SetTieuDung()
        {
            TieuDung tieuDung = new TieuDung();
            try
            {
                tieuDung.Gia = Int32.Parse(txtGia.Text);
            }
            catch
            {
                MessageBox.Show("Giá chỉ bao gồm số");
                tieuDung.Gia = 0;
            }
            tieuDung.T_tdung = txtMoTa.Text;
            LoaiTieuDung td = new LoaiTieuDung();
            td = (LoaiTieuDung)cbLoaiTieuDung.SelectedItem;
            tieuDung.Id_tieu_dung = td.Id_loai_tieu_dung;
            return tieuDung;
        }

        private void ThemTieuDung_Load(object sender, EventArgs e)
        {

        }

        private void txtThemPhanLoai_Click(object sender, EventArgs e)
        {
            int row = 0;
            foreach (DataGridViewRow dr in tbTieuDung.Rows)
            {
                dr.Selected = false;
                if (dr.Cells[0].Value != null && dr.Cells[1].Value.ToString().Equals(txtThemTieuDung.Text))
                {
                    dr.Selected = true;
                    row++;
                }
            }
            if (row == 0)
            {
                MessageBox.Show("Không tìm thấy tiêu dùng này");
            }
            else
            {
                MessageBox.Show("Có " + row + " tiêu dùng được tìm thấy");
            }
        }

        private void tbTieuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                FillView(tbTieuDung.Rows[e.RowIndex]);
                selectIndexRow = e.RowIndex;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (TT != TrangThai.IsEditing)
            {
                MessageBox.Show("Bạn đang ở chế độ sửa");
                TT = TrangThai.IsEditing;
                trangThai = TrangThai.IsEditing;
            }
            else
            {
                if(selectIndexRow != -1)
                {
                    LoaiTieuDung ltd = new LoaiTieuDung();
                    ltd = (LoaiTieuDung)cbLoaiTieuDung.SelectedItem;
                    nhanVien.SuaTieuDung(SetTieuDung(), ltd, selectIndexRow);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (TT != TrangThai.IsEditing)
            {
                MessageBox.Show("Bạn đang ở chế độ xóa");
                TT = TrangThai.IsEditing;
                trangThai = TrangThai.IsEditing;
            }
            else
            {
                    nhanVien.XoaTieuDung(SetTieuDung(), selectIndexRow);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            nhanVien.CapNhatDatabase(); 
        }
    }
}
