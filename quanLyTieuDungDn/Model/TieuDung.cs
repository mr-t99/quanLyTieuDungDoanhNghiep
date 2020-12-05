using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.module
{
    class TieuDung
    {
        private int id_ndung, id_ltdung, id_tdung;
        private string t_tdung, ngay, gia;
        public TieuDung()
        {
            DateTime now = DateTime.Now;
            this.ngay = now.ToString();
        }
        public string T_tdung { get => t_tdung; set => t_tdung = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public int Id_ndung { get => id_ndung; set => id_ndung = value; }
        public string Gia { get => gia; set => gia = value; }
        public int Id_ltdung { get => id_ltdung; set => id_ltdung = value; }
        public int Id_tdung { get => id_tdung; set => id_tdung = value; }
    }
}
