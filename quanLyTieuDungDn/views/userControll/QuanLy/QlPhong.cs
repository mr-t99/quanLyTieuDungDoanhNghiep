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

namespace quanLyTieuDungDn.views.userControll.QuanLy
{
    public partial class QlPhong : UserControl
    {
        private NguoiDung nguoiDung;
        private QuanLyController quanLy;
        private QuanLyController quanLyPhong;
        private enum Status { isView, isAdd, isEdit};
        private Status status;
        private int row=-1;
        Status statuss
        {
            get { return status; }
            set
            {
                switch (value)
                {
                    case Status.isView: SetView(); break;
                    case Status.isEdit: SetEdit(); break;
                    case Status.isAdd: SetAdd(); break;
                }
            }
        }
        private void SetView()
        {
            tbNhanVien.ReadOnly = true;
            tbPhong.ReadOnly = true;
            tbTieuDungPhong.ReadOnly = true;
            txtHanMuc.ReadOnly = true;
            txtPhong.ReadOnly = true;
            txtHanMuc.Text = "0";
        }
        private void SetEdit()
        {
            txtHanMuc.ReadOnly = false;
            txtPhong.ReadOnly = false;
        }
        void SetAdd()
        {
            txtHanMuc.Clear();
            txtPhong.Clear();
            txtHanMuc.ReadOnly = false;
            txtPhong.ReadOnly = false;
        }
        public QlPhong()
        {
            InitializeComponent();
        }
        public void SetNguoiDung(NguoiDung ng)
        {
            this.nguoiDung = ng;
            LoadTablePhong();
            statuss = Status.isView;
        }
        private void LoadTablePhong()
        {
            this.quanLyPhong = new QuanLyController(0);
            tbPhong.DataSource = quanLyPhong.phong;
            tbPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbPhong.Columns["id"].Visible = false;
            tbPhong.Columns["Số lượng nhân viên"].Visible = false;
            if (tbPhong.Rows.Count > 1)
            {
                LoadData(tbPhong.Rows[0]);
                LoadTable((int)tbPhong.Rows[0].Cells["id"].Value);
            }
        }
        private void LoadTable(int id_phong)
        {
            this.quanLy = new QuanLyController(id_phong);
            //custom bang nhanvien
            tbNhanVien.DataSource = quanLy.viewNhanVien;
            tbNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbNhanVien.Columns["Tài Khoản"].Visible = false;
            tbNhanVien.Columns["Mật khẩu"].Visible = false;
            tbNhanVien.Columns["Phòng"].Visible = false;

            tbTieuDungPhong.DataSource = quanLy.viewTieuDung;
            tbTieuDungPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbTieuDungPhong.Columns["Giá"].Visible = false;
            tbTieuDungPhong.Columns["Đề nghị"].Visible = false;
            tbTieuDungPhong.Columns["Ngày duyệt"].Visible = false;
            tbTieuDungPhong.Columns["Trạng thái"].Visible = false;
            tbTieuDungPhong.Columns["id"].Visible = false;
        }

        private void LoadData(DataGridViewRow row)
        {
            txtPhong.Text = row.Cells["Tên phòng"].Value.ToString();
            txtHanMuc.Text = row.Cells["Hạn mức"].Value.ToString();
            lbSoLuong.Text = row.Cells["Số lượng nhân viên"].Value.ToString();
        }
        private void tbPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1 && tbPhong.Rows.Count - 1 != e.RowIndex)
            {
                
                LoadData(tbPhong.Rows[e.RowIndex]);
                int id_phong = (int)tbPhong.Rows[e.RowIndex].Cells["id"].Value;
                LoadTable(id_phong);
                row = e.RowIndex;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            quanLyPhong.CapNhatDatabasePhong();
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {            
            if (statuss != Status.isAdd)
            {
                statuss = Status.isAdd;
                status = Status.isAdd;
                MessageBox.Show("Bạn vừa vào chế độ thêm");
            }
            else
            {
                Phong p = new Phong();
                p.H_muc = Int32.Parse(txtHanMuc.Text);
                p.T_phong = txtPhong.Text;
                quanLyPhong.ThemPhong(p);

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (statuss != Status.isEdit)
            {
                statuss = Status.isEdit;
                status = Status.isEdit;
                MessageBox.Show("Bạn vừa thoát chế độ sửa");
            }
            else
            {
                Phong p = new Phong();
                try
                {
                    p.H_muc = Int32.Parse(txtHanMuc.Text);
                }
                catch
                {
                    MessageBox.Show("Hạn mức không hợp lệ");
                }
                p.T_phong = txtPhong.Text;
                quanLyPhong.SuaPhong(p, row);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (statuss != Status.isEdit)
            {
                statuss = Status.isEdit;
                status = Status.isEdit;
                MessageBox.Show("Chế độ sửa");
            }
            else
            {
                quanLyPhong.XoaPhong(row);

            }
        }
    }
}
