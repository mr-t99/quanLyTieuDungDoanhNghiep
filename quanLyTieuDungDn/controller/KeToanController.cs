using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.module;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using quanLyTieuDungDn.Model.Object;
using quanLyTieuDungDn.Model;
using quanLyTieuDungDn.views;

namespace quanLyTieuDungDn.controller
{
    class KeToanController
    {
        private NguoiDung nguoiDung;
        private KeToanModel keToan;
        public DataTable phong, hoaDonNhanTien;
        Phong phongModel;
        int id_phong;

        public int Id_phong { get => id_phong; set => id_phong = value; }

        public KeToanController()
        {
            keToan = new KeToanModel();
            phong = keToan.phong;
        }

        public KeToanController(NguoiDung nd,Phong p, int id_tthai)
        {
            this.nguoiDung = nd;
            this.phongModel = p;
            keToan = new KeToanModel(nguoiDung,phongModel, id_tthai);
            setAllTable();
        }
        private void setAllTable()
        {
            //lay bang phong
            if (keToan.phong != null)
            {
                this.phong = keToan.phong;
            }
            else
            {
                MessageBox.Show("Không thể lấy dữ liệu phòng");
            }
            //Lay danh sach tieu dung dk chap thuan
            if (keToan.thongKe != null)
            {
                this.hoaDonNhanTien = keToan.thongKe;
            }
            else
            {
                MessageBox.Show("Không thể lấy dữ liệu thống kê");
            }
        }
        public ArrayList ArrPhong()
        {
            ArrayList arrPhong = new ArrayList();
            foreach(DataRow dr in phong.Rows)
            {
                Phong p = new Phong();
                p.Id_phong = (int)dr["id"];
                p.T_phong = dr["t_phong"].ToString();
                arrPhong.Add(p);
            }
            Console.WriteLine(arrPhong.Count);
            return arrPhong;
        }
        public void NhanTien(int row, int id, TieuDung td)
        {
            if (row!=-1)
            {
                if (keToan.GiaoTien(row, td) == 1)
                {
                    HoaDonNhanTien hd = new HoaDonNhanTien(keToan.InHoaDon(id));
                    hd.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn tiêu dùng");
            }
        }
        public void NghiemTHu(int row, int id, TieuDung td)
        {
            if (row != -1)
            {
                if (keToan.NghiemThu(row, td) == 1)
                {
                    MessageBox.Show("Đã nghiệm thu");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn tiêu dùng");
            }
        }
    }
}
