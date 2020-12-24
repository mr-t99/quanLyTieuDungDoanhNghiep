using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.Model;
using System.Data;
using System.Windows.Forms;
using quanLyTieuDungDn.Model.Object;

namespace quanLyTieuDungDn.controller
{
    class LoginController
    {
        private string userName, passWord;
        public LoginController(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
        public NguoiDung CheckLogin()
        {
            NguoiDung nguoiDung = new NguoiDung();
            string message = "";
            if (string.IsNullOrWhiteSpace(userName))
            {
                message += "Tài khoản không có dữ liệu\n";
            }
            if (string.IsNullOrWhiteSpace(passWord))
            {
                message += "Mật khẩu không có ký tự";
            }
            if (message.Length == 0)
            {
                DangNhapModel getData = new DangNhapModel("select * from nguoi_dung where t_khoan ='"
                    + this.userName + "' and m_khau='"
                    + this.passWord + "';");

                DataTable data = getData.DtNguoiDung;
                if (data != null)
                {
                    if (data.Rows.Count ==0)
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                    }
                    else
                    {
                        nguoiDung.Id_nguoi_dung = (int)data.Rows[0]["id"];
                        nguoiDung.C_vu = data.Rows[0]["c_vu"].ToString();
                        nguoiDung.Id_phong = (int)data.Rows[0]["id_phong"];
                        nguoiDung.Que_quan = data.Rows[0]["que_quan"].ToString();
                        nguoiDung.Tn_dung = data.Rows[0]["tn_dung"].ToString();
                        nguoiDung.T_khoan = data.Rows[0]["t_khoan"].ToString();
                        nguoiDung.G_tinh = (bool)data.Rows[0]["g_tinh"];
                    }
                }
                return nguoiDung;
            }
            else
            {
                MessageBox.Show(message);
                return nguoiDung;
            }
        }
        //internal User User { get => user; set => user = value; }

        //public void checkLogin()
        //{
        //    cnn = new ConnectDatabase();
        //    DataTable data;
        //    this.User = new User();
        //    try
        //    {
        //        data = cnn.getdata("select * from tai_khoan, nguoi_dung where tai_khoan.id = nguoi_dung.id_tkhoan and t_khoan ='"
        //            + this.userName + "' and m_khau='"
        //            + this.passWord + "'");
        //        if(data != null)
        //        {
                    
        //            foreach (DataRow dt in data.Rows)
        //            {
        //                this.User.T_ndung = dt["tn_dung"].ToString();
        //                this.User.C_vu = dt["c_vu"].ToString();
        //                this.User.Id = Int32.Parse(dt["id"].ToString());
        //                this.User.Id_phong = Int32.Parse(dt["id_phong"].ToString());
        //            }
        //        }
                
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Lỗi checkLogin ");
        //    }
        //}
    }
}
