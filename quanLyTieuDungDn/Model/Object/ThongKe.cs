using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.Model.Object
{
    class ThongKe
    {
        private int id_thong_ke,id_phong;
        private DateTime ngay_bdau, ngay_ketthuc;
        private long v_muc, t_kiem;

        public int Id_thong_ke { get => id_thong_ke; set => id_thong_ke = value; }
        public int Id_phong { get => id_phong; set => id_phong = value; }
        public DateTime Ngay_bdau { get => ngay_bdau; set => ngay_bdau = value; }
        public DateTime Ngay_ketthuc { get => ngay_ketthuc; set => ngay_ketthuc = value; }
        public long V_muc { get => v_muc; set => v_muc = value; }
        public long T_kiem { get => t_kiem; set => t_kiem = value; }
    }
}
