using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.Model.Object
{
    class NguoiDung
    {
        public int id_nguoidung { get; set; }
        public string t_khoan { get; set; }
        public string m_khau { get; set; }
        public string tn_dung { get; set; }
        public string que_quan { get; set; }
        public string nay_lam { get; set; }
        public string c_vu { get; set; }
        public string id_phong { get; set; }
        public NguoiDung() { }

    }
}
