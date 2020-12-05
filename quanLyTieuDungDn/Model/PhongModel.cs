using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.module
{
    class PhongModel
    {
        private int id, sl_nvien, han_muc;
        private string t_phong;

        public int Id { get => id; set => id = value; }
        public int Sl_nvien { get => sl_nvien; set => sl_nvien = value; }
        public int Han_muc { get => han_muc; set => han_muc = value; }
        public string T_phong { get => t_phong; set => t_phong = value; }
    }
}
