using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.module
{
    class User
    {
        private int id, id_phong;
        private string t_ndung, c_vu;

        public int Id { get => id; set => id = value; }
        public int Id_phong { get => id_phong; set => id_phong = value; }
        public string T_ndung { get => t_ndung; set => t_ndung = value; }
        public string C_vu { get => c_vu; set => c_vu = value; }
    }
}
