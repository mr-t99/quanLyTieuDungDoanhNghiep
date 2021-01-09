using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.module;
using System.Data;
using System.Collections;
using quanLyTieuDungDn.Model.Object;
using quanLyTieuDungDn.Model;
using System.Windows.Forms;

namespace quanLyTieuDungDn.controller
{
    class nhanvienController
    {
        private NguoiDung nguoiDung;
        public DataTable thongKe, thongKeCaNhan, phong, tieuDung;
        NhanVienModel nhanVien;

        //Bien lable 
        public int h_muc = 0, v_muc = 0, t_phong = 0, c_nhan = 0;
        public nhanvienController(NguoiDung ng)
        {
            this.nguoiDung = ng;
            nhanVien = new NhanVienModel(ng);
            GetTb();
            setLable();
            getTieuDung();
        }

        //phương thức cho user controll Thong Ke
        private void GetTb()
        {
            if (nhanVien.thongKe != null)
            {
                
                this.thongKe = nhanVien.thongKe;
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu bảng thống kê");
            }
            if (nhanVien.phong != null)
            {
                this.phong = nhanVien.phong;
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu bảng phong");
            }
            if (nhanVien.thongKeCaNhan != null)
            {
                this.thongKeCaNhan = nhanVien.thongKeCaNhan;
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu bảng thong ke ca nhan");
            }
        }
        //Phương thức chu userControll Sua thong tin tieu dung
        public void GetThongKeCaNhan()
        {
            thongKe.Clear();
            if (nhanVien.thongKe != null)
            {
                nhanVien.GetTableThongKeCaNhan();
                this.thongKe = nhanVien.thongKe;
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu bảng thống kê");
            }
            if (nhanVien.phong != null)
            {
                this.phong = nhanVien.phong;
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu bảng phong");
            }
        }
        private void setLable()
        {
            if (phong.Rows.Count != 0)
            {
                this.h_muc = (int)phong.Rows[0]["h_muc"];
                Console.WriteLine(phong.Rows[0]["h_muc"]);
            }
            else
            {
                MessageBox.Show("Lỗi phòng");
            }
            //Lay tong phong
            //if (thongKe.Rows.Count != 0)
            //{
            //    foreach(DataRow dr in thongKe.Rows)
            //    {
            //        this.t_phong = t_phong + (int)dr["Giá"];
            //    }
            //    v_muc = t_phong - h_muc;
            //    if (h_muc >= t_phong)
            //    {
            //        v_muc = 0;
            //    }
            //    foreach (DataRow dr in thongKe.Rows)
            //    {
            //        if (dr["Nhân viên"].ToString() == nguoiDung.Tn_dung)
            //        {
            //            c_nhan += (int)dr["Giá"];
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi thong ke");
            //}
        }
        private void getTieuDung()
        {
            if(nhanVien.LoaiTeuDung != null)
            {
                this.tieuDung = nhanVien.LoaiTeuDung;
            }
        }
        public void ThemTieuDung(TieuDung td, LoaiTieuDung ltd)
        {
            if(td.Gia!=0)
            {
                string message = "";
                if (td.T_tdung.Length == 0)
                {
                    message += "Mô tả trống!\n";
                }
                if (message.Length == 0)
                {
                    nhanVien.ThemTieuDung(td, ltd);
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }
        public void SuaTieuDung(TieuDung td, LoaiTieuDung ltd, int row)
        {
            if (td.Gia != 0)
            {
                string message = "";
                if (td.T_tdung.Length == 0)
                {
                    message += "Mô tả trống!\n";
                }
                if (message.Length == 0)
                {
                    nhanVien.SuaTieuDung(td, ltd, row);
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }
        public void XoaTieuDung(TieuDung tieuDung ,int row)
        {
            if(row != -1 )
            {
                DialogResult rl = MessageBox.Show("Bạn có trắc muốn xóa công tiêu dùng " + tieuDung.T_tdung + " ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rl == DialogResult.Yes)
                {
                    nhanVien.XoaTieuDung(row);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn phòng để xóa!!!");
            }
        }
        public void CapNhatDatabase()
        {
            this.nhanVien.CapNhatDatabase();
        }
    }
}
