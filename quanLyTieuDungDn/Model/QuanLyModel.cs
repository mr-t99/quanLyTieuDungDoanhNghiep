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
        public QuanLyModel(NguoiDung ng, int id_phong, int id_tthai)
        {
            this.nguoiDung = ng;
            conn = new SqlConnection(sqlConnect);
            quanLy = new DataSet();
            this.id_phong = id_phong;
            this.id_tthai = id_tthai;
            GetAllTable();
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
        private void GetAllTable()
        {
            GetTableViewTieuDung();
            GetTableTieuDung();
        }
        private void GetTableViewTieuDung()
        {
            if (viewTieuDung != null)
            {
                viewTieuDung.Clear();
            }
            else
            {
                string sql = "select  tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân loại', ngay_de_nghi as 'Đề nghị', ngay_hoan_thanh as 'Giao tiền', t_tthai as 'Trạng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = 1 and (t_thai =1 or t_thai=2 or t_thai=3 )";
                Console.WriteLine(sql);
                try
                {
                    MoKetNoi();
                    adViewTieuDung = new SqlDataAdapter(sql, conn);
                    adViewTieuDung.FillSchema(quanLy, SchemaType.Source, "VIEWTIEUDUNG");
                    adViewTieuDung.Fill(quanLy, "VIEWTIEUDUNG");
                    this.viewTieuDung = quanLy.Tables["VIEWTIEUDUNG"];
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi lấy data");
                    this.viewTieuDung = null;
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        private void GetTableTieuDung()
        {
            string sql = "select * from tieu_dung where id_nguoidung in (select id from nguoi_dung where id_phong=" + id_phong + ") and (t_thai =1 or t_thai=2 or t_thai=3 )";
            try
            {
                Console.WriteLine(sql);
                adTieuDung = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adTieuDung);
                adTieuDung.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adTieuDung.Fill(quanLy, "TIEUDUNG");
                adTieuDung.FillSchema(quanLy, SchemaType.Source, "TIEUDUNG");
                adTieuDung.Fill(quanLy, "TIEUDUNG");
                tieuDung = quanLy.Tables["TIEUDUNG"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public void KiemDuyetTieuDung(int row, TieuDung tieuDung)
        {
            DataRow dr = quanLy.Tables["TIEUDUNG"].Rows[row];
            dr["gia"] = tieuDung.Gia;
            dr["t_thai"] = tieuDung.T_thai;
            dr["ghi_chu"] = tieuDung.Ghi_chu;
            dr["id_qly"] = tieuDung.Id_qly;
            UpdateDatabase();
            DataRow vdr = quanLy.Tables["VIEWTIEUDUNG"].Rows[row];
            vdr["Giá"] = tieuDung.Gia;
            if(tieuDung.T_thai == 2)
            {
                vdr["Trạng thái"] = "Chấp nhận";
            }
            else
            {
                vdr["Trạng thái"] = "Từ chối";
            }
            
        }
        




        public void UpdateDatabase()
        {
            try
            {
                adTieuDung.Update(quanLy, "TIEUDUNG");
                tieuDung = quanLy.Tables["TIEUDUNG"];
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Không cập nhật được database");
            }
        }
    }
    //Kiểm duyệt

    //Nhân viên
    //Phòng

}
