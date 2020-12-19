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
    class DangNhapModel
    {
        public static SqlConnection conn;
        public  DataSet qlTieuDung;
        private DataTable dtNguoiDung;
        public  SqlDataAdapter adNguoiDung;
        public string sqlConnect = Environment.GetEnvironmentVariable("sqlString");

        public DataTable DtNguoiDung { get => dtNguoiDung; set => dtNguoiDung = value; }

        public DangNhapModel()
        {
        }
        public DangNhapModel(string sql)
        {
            conn = new SqlConnection(sqlConnect);
            qlTieuDung = new DataSet();
            DangNhap(sql);
        }
        private void MoKn()
        {
            if (conn.State != ConnectionState.Closed) conn.Open();
            if (conn.State != ConnectionState.Closed) MessageBox.Show("Không kết nối được");
        }
        private void DangNhap(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                MoKn();
                adNguoiDung = new SqlDataAdapter(sql, conn);
                adNguoiDung.FillSchema(qlTieuDung, SchemaType.Source, "NGUOIDUNG");
                adNguoiDung.Fill(qlTieuDung, "NGUOIDUNG");
                DtNguoiDung = qlTieuDung.Tables["NGUOIDUNG"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy người dùng");
                DtNguoiDung = null;
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }
        
    }
}
