using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace quanLyTieuDungDn.module
{
    class connectDatabase
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter adap;
        public static string sqlConnect = @"Data Source=DESKTOP-693KNU1\SQLEXPRESS;Initial Catalog=quanLyTieuDung;Integrated Security=True";

        public DataTable getdata(string sql)
        {
            try
            {
                conn = new SqlConnection(sqlConnect);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                adap = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adap.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi getData");
            }
            return dt;
        }
    }
}
