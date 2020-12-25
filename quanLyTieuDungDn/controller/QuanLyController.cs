using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.Model.Object;
using quanLyTieuDungDn.Model;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace quanLyTieuDungDn.controller
{
    class QuanLyController
    {
        private QuanLyModel quanLy;
        public DataTable phong, viewTieuDung;
        private int id_phong, id_tthai;
        public QuanLyController()
        {
            quanLy = new QuanLyModel();
            this.phong = quanLy.phong;
        }
        public ArrayList ArrPhong()
        {
            ArrayList arrPhong = new ArrayList();
            foreach (DataRow dr in phong.Rows)
            {
                Phong p = new Phong();
                p.Id_phong = (int)dr["id"];
                p.T_phong = dr["t_phong"].ToString();
                arrPhong.Add(p);
            }
            return arrPhong;
        }
        public QuanLyController(NguoiDung ng, int id_phong, int id_tthai)
        {
            this.id_phong = id_phong;
            this.id_tthai = id_tthai;
            quanLy = new QuanLyModel(ng, id_phong, id_tthai);
            loadTable();
        }
        private void loadTable()
        {
            if (quanLy.viewTieuDung != null)
            {
                this.viewTieuDung = quanLy.viewTieuDung;
                
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu tiêu dùng");
            }
        }
        public void CapNhatDataBase(int row, TieuDung td)
        {
            if (row != -1)
            {
                if (td.Gia == 0)
                {
                    MessageBox.Show("Giá không hợp lệ");
                }
                else
                {
                    quanLy.KiemDuyetTieuDung(row, td);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng");
            }
        }
    }
    //Kiểm duyệt
    //Nhân viên
    //Phòng
}
