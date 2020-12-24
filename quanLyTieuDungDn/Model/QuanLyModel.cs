using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.Model.Object;
using quanLyTieuDungDn.controller;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanLyTieuDungDn.Model
{
    class QuanLyModel
    {
        public string sqlConnect = Environment.GetEnvironmentVariable("sqlString");
        private SqlConnection conn;
        public DataSet quanLy;
        public DataTable phong, tieuDung, viewTieuDung;
        public SqlDataAdapter adPhong, adTieuDung, adViewTieuDung;
        //các đối tượng
        private NguoiDung nguoiDung;
        private int id_phong, id_tthai;

        public QuanLyModel()
        {
            conn = new SqlConnection(sqlConnect);
            quanLy = new DataSet();
            GetTablePhong();
        }
        public QuanLyModel(NguoiDung ng)
        {
            this.nguoiDung = ng;
            conn = new SqlConnection(sqlConnect);
            quanLy = new DataSet();
        }

        private void MoKetNoi()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (conn.State == ConnectionState.Closed) MessageBox.Show("Không kết nối được");
        }
        public void GetTablePhong()
        {
            string sql = "select * from phong";
            try
            {
                MoKetNoi();
                adPhong = new SqlDataAdapter(sql, conn);
                adPhong.FillSchema(quanLy, SchemaType.Source, "PHONG");
                adPhong.Fill(quanLy, "PHONG");
                this.phong = quanLy.Tables["PHONG"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Lỗi lấy hạn mức");
                this.phong = null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
    //Kiểm duyệt

    //Nhân viên
    //Phòng

}
