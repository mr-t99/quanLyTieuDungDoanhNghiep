using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.module;
using System.Data;

namespace quanLyTieuDungDn.controller
{
    class login
    {
        private string userName, passWord;
        private connectDatabase cnn;
        private user user;
        
        public login(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
        public void checkLogin()
        {
            cnn = new connectDatabase();
            this.user = new user();
            DataTable data;
            try
            {
                data = cnn.getdata("select * from tai_khoan, nguoi_dung where tai_khoan.id = nguoi_dung.id_tkhoan and t_khoan ='"
                    + this.userName + "' and m_khau='"
                    + this.passWord + "'");
                foreach (DataRow dt in data.Rows)
                {
                    this.user.T_ndung = dt["tn_dung"].ToString();
                    this.user.C_vu = dt["c_vu"].ToString();
                    this.user.Id = Int32.Parse(dt["id"].ToString());
                    this.user.Id_phong = Int32.Parse(dt["id_phong"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Lỗi checkLogin ");
            }
        }
    }
}
