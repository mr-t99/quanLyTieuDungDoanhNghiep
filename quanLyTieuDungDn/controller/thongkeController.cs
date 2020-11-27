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
        private DataTable dataTable;
        private lableData dataLable;

        public DataTable DataTable { get => dataTable; set => dataTable = value; }
        internal lableData DataLable { get => dataLable; set => dataLable = value; }

        public void dataBangThongKe(int id)
        {
            cnn = new connectDatabase();
            this.dataTable = cnn.getdata("select tn_dung as'Tên người dùng', t_phong as 'Tên phòng', t_tdung as 'Sử dụng', gia as 'Giá', ngay as 'Ngày', t_thai as 'Trạng thái'  from nguoi_dung, tieu_dung, phong  where tieu_dung.id_nguoidung = nguoi_dung.id and phong.id=nguoi_dung.id_phong and phong.id="+id+"");
        }
        public void setDataLable(int id_ndung, int id_phong)
        {
            this.DataLable = new lableData();
            cnn = new connectDatabase();
            DataTable dataLable = cnn.getdata("select nguoi_dung.tn_dung, sum(tieu_dung.gia) as tong from nguoi_dung, tieu_dung, phong where nguoi_dung.id_phong = phong.id and tieu_dung.id_nguoidung = nguoi_dung.id and id_nguoidung="+id_ndung+" GROUP BY nguoi_dung.tn_dung");
            
            if (dataLable != null)
            {
                foreach(DataRow row in dataLable.Rows)
                {
                    this.DataLable.C_nhan = Int64.Parse(row["tong"].ToString());
                }
            }
            dataLable = cnn.getdata("select phong.t_phong, phong.h_muc, sum(tieu_dung.gia) as tong from nguoi_dung, tieu_dung, phong where nguoi_dung.id_phong = phong.id and tieu_dung.id_nguoidung = nguoi_dung.id and phong.id="+id_phong+" GROUP BY phong.t_phong, phong.h_muc");
            if (dataLable != null)
            {
                foreach (DataRow row in dataLable.Rows)
                {
                    this.DataLable.S_phong = Int64.Parse(row["tong"].ToString());
                    this.DataLable.H_muc = Int64.Parse(row["h_muc"].ToString());
                }
            }
            if (this.DataLable.S_phong - this.DataLable.H_muc > 0)
            {
                this.DataLable.V_muc = this.DataLable.S_phong - this.DataLable.H_muc;
            }
            this.DataLable.V_muc = 0;
        }
    }
}
