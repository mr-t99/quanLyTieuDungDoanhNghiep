using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.Model.Object
{
    public class TrangThai
    {
        private int id_trang_thai;
        private string t_tthai;

        public int Id_trang_thai { get => id_trang_thai; set => id_trang_thai = value; }
        public string T_tthai { get => t_tthai; set => t_tthai = value; }
    }
}
