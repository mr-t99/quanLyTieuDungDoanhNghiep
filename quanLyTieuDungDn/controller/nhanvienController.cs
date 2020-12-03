using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.module;
using System.Data;
using System.Collections;

namespace quanLyTieuDungDn.controller
{
    class nhanvienController
    {
        private ConnectDatabase cnn;
        private DataTable dataTable;
        private NhanVien dataLable;
        private ArrayList dataDataCombox;
        

        public DataTable DataTable { get => dataTable; set => dataTable = value; }
        internal NhanVien DataLable { get => dataLable; set => dataLable = value; }
        public ArrayList DataDataCombox { get => dataDataCombox; set => dataDataCombox = value; }

        public void dataBangThongKe(int id)
        {
            cnn = new ConnectDatabase();
            this.dataTable = cnn.getdata("select tn_dung as'Tên người dùng', t_phong as 'Tên phòng', t_tdung as 'Sử dụng', gia as 'Giá', ngay as 'Ngày', t_thai as 'Trạng thái'  from nguoi_dung, tieu_dung, phong  where tieu_dung.id_nguoidung = nguoi_dung.id and phong.id=nguoi_dung.id_phong and phong.id="+id+"");
        }
        public void setDataLable(int id_ndung, int id_phong)
        {
            this.DataLable = new NhanVien();
            cnn = new ConnectDatabase();
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
            else {
                this.DataLable.V_muc = 0;
            }
            
        }
        public void dataCombox()
        {
            cnn = new ConnectDatabase();
            DataTable data = cnn.getdata("select * from loai_tieu_dung");
            dataDataCombox = new ArrayList();
            if (data != null)
            {
                foreach(DataRow dr in data.Rows)
                {
                    NhanVien nv = new NhanVien();
                    nv.Id_tdung = Int32.Parse(dr["id"].ToString());
                    nv.T_tdung = dr["l_tdung"].ToString();
                    dataDataCombox.Add(nv);
                }
            }
        }
        public int addTieuDung(TieuDung td)
        {
            int status = 0;
            status = this.cnn.RepairData("insert into tieu_dung(id_nguoidung, t_tdung, gia, ngay, id_tdung) values ("+
                td.Id_ndung+", N'"+
                td.T_tdung+"', "+
                td.Gia+", '"+
                td.Ngay+"', "+
                td.Id_ltdung+")");
            Console.WriteLine("insert into tieu_dung(id_nguoidung, t_tdung, gia, ngay, id_tdung) values (" +
                td.Id_ndung + ", N'" +
                td.T_tdung + "', " +
                td.Gia + ", '" +
                td.Ngay + "', " +
                td.Id_ltdung + ")");
            return status;
        }
        public int repairTieuDung(TieuDung td)
        {
            int status = 0;
            status = this.cnn.RepairData("update tieu_dung set t_tdung=N'"+
                td.T_tdung+"',gia="+
                td.Gia+", id_tdung="
                +td.Id_ltdung+", ngay='"+
                td.Ngay+"' where tieu_dung.id="+
                td.Id_tdung+"");
            return status;
        }
        public DataTable dataTableTieuDung(int id_ndung)
        {
            cnn = new ConnectDatabase();
            DataTable dt = cnn.getdata("select tieu_dung.id as id_td, t_tdung as 'Mô tả', loai_tieu_dung.l_tdung as 'Hạng mục', gia as 'Giá', ngay as 'Ngày lập', t_thai as 'Trạng thái' from tieu_dung, loai_tieu_dung where tieu_dung.id_tdung=loai_tieu_dung.id and tieu_dung.id_nguoidung=" + id_ndung+"");
            return dt;
        }

        public int DeleteTieuDung(int id)
        {
            int row = 0;
            cnn = new ConnectDatabase();
            row = cnn.RepairData("delete from tieu_dung where tieu_dung.id="+id+"");
            return row;
        }

    }
}
