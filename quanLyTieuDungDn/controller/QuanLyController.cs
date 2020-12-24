using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.Model.Object;
using quanLyTieuDungDn.Model;
using System.Data;
using System.Collections;

namespace quanLyTieuDungDn.controller
{
    class QuanLyController
    {
        private QuanLyModel quanLy;
        private DataTable phong;
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
        public QuanLyController(NguoiDung ng)
        {

        }
    }
    //Kiểm duyệt
    //Nhân viên
    //Phòng
}
