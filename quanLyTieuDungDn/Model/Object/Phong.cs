using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.Model.Object
{
    public class Phong
    {
        private int id_phong,sl_nvien;
        private string t_phong;
        private long h_muc;
        public int Id_phong { get => id_phong; set => id_phong = value; }
        public int Sl_nvien { get => sl_nvien; set => sl_nvien = value; }
        public string T_phong { get => t_phong; set => t_phong = value; }
        public long H_muc { get => h_muc; set => h_muc = value; }
    }
}
