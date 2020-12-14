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
        //public static SqlCommand cmd;
        public  DataSet qlTieuDung;
        private DataTable dtNguoiDung;
        public  SqlDataAdapter adNguoiDung;
        public string sqlConnect = @"Data Source=DESKTOP-693KNU1\SQLEXPRESS;Initial Catalog=quanLyTieuDung;Integrated Security=True";

        public DataTable DtNguoiDung { get => dtNguoiDung; set => dtNguoiDung = value; }

        public GetDataModle()
        {
            conn = new SqlConnection(sqlConnect);
            qlTieuDung = new DataSet();
            GetAllDataBase();
        }
        public GetDataModle(string sql)
        {
            conn = new SqlConnection(sqlConnect);
            qlTieuDung = new DataSet();
            DangNhap(sql);
        }
        private void DangNhap(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                conn.Open();
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
        //private void MoKn()
        //{
        //    if (conn.State != ConnectionState.Closed) conn.Open();
        //    if (conn.State == ConnectionState.Closed) MessageBox.Show("Không kết nối được");
        //}
        
        private void GetAllDataBase()
        {
            NguoiDung();
        }
        private void NguoiDung()
        {
            string sql = "";
            try
            {
                conn.Open();
                adNguoiDung = new SqlDataAdapter(sql, conn);
                adNguoiDung.FillSchema(qlTieuDung, SchemaType.Source, "NGUOIDUNG");
                adNguoiDung.Fill(qlTieuDung, "NGUOIDUNG");
                DtNguoiDung = qlTieuDung.Tables["NGUOIDUNG"];
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi lấy người dùng");
                DtNguoiDung = null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
