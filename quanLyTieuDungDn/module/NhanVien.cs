using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.module
{
    class NhanVien
    {
        
        private long h_muc, v_muc, s_phong, c_nhan;

        public long H_muc { get => h_muc; set => h_muc = value; }
        public long V_muc { get => v_muc; set => v_muc = value; }
        public long S_phong { get => s_phong; set => s_phong = value; }
        public long C_nhan { get => c_nhan; set => c_nhan = value; }
        public int Id_tdung { get => id_tdung; set => id_tdung = value; }
        public string T_tdung { get => t_tdung; set => t_tdung = value; }

        private int id_tdung;
        private string t_tdung;
    }
}
