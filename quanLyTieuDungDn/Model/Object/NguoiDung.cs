using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyTieuDungDn.Model.Object
{
    public class NguoiDung
    {
        private int id_nguoi_dung,id_phong;
        private string t_khoan, m_khau, tn_dung, que_quan, c_vu, t_phong;
        private DateTime ngay_lam;
        private bool g_tinh;

        public int Id_nguoi_dung { get => id_nguoi_dung; set => id_nguoi_dung = value; }
        public int Id_phong { get => id_phong; set => id_phong = value; }
        public string T_khoan { get => t_khoan; set => t_khoan = value; }
        public string Khau { get => m_khau; set => m_khau = value; }
        public string Tn_dung { get => tn_dung; set => tn_dung = value; }
        public string Que_quan { get => que_quan; set => que_quan = value; }
        public string C_vu { get => c_vu; set => c_vu = value; }
        public DateTime Ngay_lam { get => ngay_lam; set => ngay_lam = value; }
        public bool G_tinh { get => g_tinh; set => g_tinh = value; }
        public string T_phong { get => t_phong; set => t_phong = value; }
    }
}
