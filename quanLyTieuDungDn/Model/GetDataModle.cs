using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace quanLyTieuDungDn.Model
{
    class GetDataModle
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static DataSet qlTieuDung;
        private static DataTable dtNguoiDung;
        public static SqlDataAdapter adNguoiDung;
        public static string sqlConnect = @"Data Source=DESKTOP-U9CFM1J\SQLEXPRESS;Initial Catalog=quanLyTieuDung;Integrated Security=True";
        GetDataModle()
        {
            conn = new SqlConnection(sqlConnect);
            qlTieuDung = new DataSet();
            GetAllDataBase();
        }
        private void MoKn()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (conn.State == ConnectionState.Closed) MessageBox.Show("Không kết nối được");
        }
        
        private void GetAllDataBase()
        {
            NguoiDung();
        }
        private void NguoiDung()
        {
            string sql = "";
            try
            {
                MoKn();
                adNguoiDung = new SqlDataAdapter(sql, conn);
                adNguoiDung.FillSchema(qlTieuDung, SchemaType.Source, "NGUOIDUNG");
                adNguoiDung.Fill(qlTieuDung, "NGUOIDUNG");
                dtNguoiDung = qlTieuDung.Tables["NGUOIDUNG"];
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi lấy người dùng");
                dtNguoiDung = null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
