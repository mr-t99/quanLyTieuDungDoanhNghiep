using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.module;
using System.Data;

namespace quanLyTieuDungDn.controller
{
    class thongkeController
    {
        private connectDatabase cnn;
        private DataTable data;
        public DataTable Data { get => data; set => data = value; }

        public void dataBangThongKe()
        {
            cnn = new connectDatabase();
            this.data = cnn.getdata("select tn_dung as'Tên người dùng', t_phong as 'Tên phòng', t_tdung as 'Sử dụng', gia as 'Giá', ngay as 'Ngày', t_thai as 'Trạng thái'  from nguoi_dung, tieu_dung, phong  where tieu_dung.id_nguoidung = nguoi_dung.id and phong.id=nguoi_dung.id_phong");
        }
    }
}
