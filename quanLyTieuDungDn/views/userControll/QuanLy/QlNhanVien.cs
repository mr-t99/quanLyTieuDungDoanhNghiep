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
    public partial class QlNhanVien : UserControl
    {
        private NguoiDung nguoiDung;
        private QuanLyController quanLy;
        private DataTable phong;
        private TrangThai trangThai;
        private int row = -1;
        enum TrangThai { isViewing, isAdding, isEditing}
        private TrangThai getSetTrangThai
        {
            get { return trangThai; }
            set
            {
                switch (value)
                {
                    case TrangThai.isAdding: IsAdding(); break;
                    case TrangThai.isEditing: IsEditing(); break;
                    case TrangThai.isViewing: IsViewing(); break;
                }
            }
        }
        private void IsAdding()
        {
            MessageBox.Show("Trạng thái thêm người dùng");
            ClearConten();
            txtHoTen.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            txtQueQuan.ReadOnly = false;
            txtTenTaiKhoan.ReadOnly = false;
            cbPhong.Enabled = true;
            cbQuyen.Enabled = true;
            dateNgayLam.Value = DateTime.Now;
        }
        private void IsEditing()
        {
            MessageBox.Show("Trạng thái sửa xóa");
            txtHoTen.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            txtQueQuan.ReadOnly = false;
            txtTenTaiKhoan.ReadOnly = false;
            cbPhong.Enabled = true;
            cbQuyen.Enabled = true;
            if (tbDsNhanvien.Rows.Count > 1)
            {
                LoadConten(tbDsNhanvien.CurrentRow);
            }
        }
        private void IsViewing()
        {
            MessageBox.Show("Trạng thái xem");
            txtHoTen.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
            txtQueQuan.ReadOnly = true;
            txtTenTaiKhoan.ReadOnly = true;
            cbPhong.Enabled = false;
            cbQuyen.Enabled = false;
            if (tbDsNhanvien.Rows.Count > 1)
            {
                LoadConten(tbDsNhanvien.CurrentRow);
            }
        }
        private void LoadConten(DataGridViewRow row)
        {
            
            txtHoTen.Text = row.Cells["Nhân viên"].Value.ToString();
            txtMatKhau.Text = row.Cells["Mật khẩu"].Value.ToString();
            txtTenTaiKhoan.Text = row.Cells["Tài Khoản"].Value.ToString();
            txtQueQuan.Text = row.Cells["Quê quán"].Value.ToString();

            cbPhong.SelectedIndex = cbPhong.FindStringExact(row.Cells["Phòng"].Value.ToString());
            cbQuyen.SelectedIndex = cbQuyen.FindStringExact(row.Cells["Chức vụ"].Value.ToString());

            string[] arrNgayLam = row.Cells["Ngày làm"].Value.ToString().Split(' ');
            arrNgayLam = arrNgayLam[0].Split('/');
            dateNgayLam.Value = new DateTime(Int32.Parse(arrNgayLam[2]), Int32.Parse(arrNgayLam[0]), Int32.Parse(arrNgayLam[1]));

            rbNu.Checked = true;
            if((bool)row.Cells["Giới tính"].Value == true)
            {
                rbNam.Checked = true;
            }
        }
        private void ClearConten()
        {
            txtHoTen.Clear();
            txtMatKhau.Clear();
            txtQueQuan.Clear();
            txtTenTaiKhoan.Clear();
        }
        private NguoiDung SetNguoiDung()
        {
            NguoiDung newNguoiDung = new NguoiDung();
            newNguoiDung.Khau = txtMatKhau.Text;
            newNguoiDung.T_khoan = txtTenTaiKhoan.Text;
            newNguoiDung.Tn_dung = txtHoTen.Text;
            newNguoiDung.Que_quan = txtQueQuan.Text;
            newNguoiDung.C_vu = cbQuyen.Text;
            Phong p = (Phong)cbPhong.SelectedItem;
            newNguoiDung.Id_phong = p.Id_phong;
            newNguoiDung.G_tinh = true;
            if(rbNam.Checked == false)
            {
                newNguoiDung.G_tinh = false;
            }
            newNguoiDung.Ngay_lam = dateNgayLam.Value;
            newNguoiDung.T_phong = p.T_phong;
            return newNguoiDung;
        }
        public QlNhanVien()
        {
            InitializeComponent();

        }
        public void SetNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;
            LoadCombox();
            LoadView();
            getSetTrangThai=TrangThai.isViewing;
        }
        private void LoadCombox()
        {
            //load danh sách phòng
            quanLy = new QuanLyController();
            cbPhong.DataSource = quanLy.ArrPhong();
            cbPhong.DisplayMember = "t_phong";
            cbPhong.ValueMember = "id_phong";

            //load danh sach chức vụ
            cbQuyen.Items.Add("Nhân viên");
            cbQuyen.Items.Add("Kế toán");
            cbQuyen.Items.Add("Quản lý");
        }
        private void LoadView()
        {
            quanLy = new QuanLyController(0);
            tbDsNhanvien.DataSource = quanLy.viewNhanVien;
            tbDsNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbDsNhanvien.ReadOnly = true;
            tbDsNhanvien.Columns["Giới tính"].Visible = false;
        }

        private void tbDsNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1 && tbDsNhanvien.Rows.Count-1 != e.RowIndex)
            {
                LoadConten(tbDsNhanvien.Rows[e.RowIndex]);
                this.row = e.RowIndex;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(trangThai != TrangThai.isAdding)
            {
                getSetTrangThai = TrangThai.isAdding;
                trangThai = TrangThai.isAdding;
            }
            else
            {
                this.quanLy.ThemNhanVien(SetNguoiDung());
                ClearConten();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (trangThai != TrangThai.isEditing)
            {
                getSetTrangThai = TrangThai.isEditing;
                trangThai = TrangThai.isEditing;
            }
            else
            {
                this.quanLy.SuaNhanVien(SetNguoiDung(),row);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (trangThai != TrangThai.isEditing)
            {
                getSetTrangThai = TrangThai.isEditing;
                trangThai = TrangThai.isEditing;
            }
            else
            {
                this.quanLy.XoaNhanVien(row);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            this.quanLy.LuuDatabaseTableNhanVien();
        }
    }
}
