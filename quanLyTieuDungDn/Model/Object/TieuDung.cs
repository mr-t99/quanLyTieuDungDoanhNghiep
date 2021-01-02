using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.Model.Object
{
    public class TieuDung
    {
        private int id_tieu_dung,id_nguoidung,id_tdung,t_thai,id_qly, gia, id_ktoan;
        private string t_tdung,ghi_chu, t_tthai;
        private DateTime ngay_de_nghi, ngay_hoan_thanh;

        public int Id_tieu_dung { get => id_tieu_dung; set => id_tieu_dung = value; }
        public int Id_nguoidung { get => id_nguoidung; set => id_nguoidung = value; }
        public int Id_tdung { get => id_tdung; set => id_tdung = value; }
        public int T_thai { get => t_thai; set => t_thai = value; }
        public int Id_qly { get => id_qly; set => id_qly = value; }
        public string T_tdung { get => t_tdung; set => t_tdung = value; }
        public string Ghi_chu { get => ghi_chu; set => ghi_chu = value; }
        public DateTime Ngay_de_nghi { get => ngay_de_nghi; set => ngay_de_nghi = value; }
        public DateTime Ngay_hoan_thanh { get => ngay_hoan_thanh; set => ngay_hoan_thanh = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Id_ktoan { get => id_ktoan; set => id_ktoan = value; }
        public string T_tthai { get => t_tthai; set => t_tthai = value; }
    }
}
