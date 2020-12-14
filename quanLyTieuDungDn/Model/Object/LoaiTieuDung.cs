using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.Model.Object
{
    class LoaiTieuDung
    {
        private int id_loai_tieu_dung;
        private string l_tdung;

        public int Id_loai_tieu_dung { get => id_loai_tieu_dung; set => id_loai_tieu_dung = value; }
        public string L_tdung { get => l_tdung; set => l_tdung = value; }
    }
}
