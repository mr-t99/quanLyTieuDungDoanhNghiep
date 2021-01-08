using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using quanLyTieuDungDn.controller;
using quanLyTieuDungDn.Model.Object;
using System.Windows.Forms;

namespace quanLyTieuDungDn.Model
{
    class KeToanModel
    {
        public string sqlConnect = Environment.GetEnvironmentVariable("sqlString");
        private SqlConnection conn;
        public DataSet keToan;
        public DataTable phong, LoaiTeuDung, tieuDung, thongKe, HoaDon;
        public SqlDataAdapter adPhong, adTieuDung, adLoaiTieuDung, adThongKe, adHoaDon;
        public Phong phongModel;
        //các đối tượng
        private NguoiDung nguoiDung;
        private int id_phong, id_tthai;

        public int Id_phong { get => id_phong; set => id_phong = value; }
        public KeToanModel()
        {
            conn = new SqlConnection(sqlConnect);
            keToan = new DataSet();
            GetTablePhong();

        }
        public KeToanModel(NguoiDung ng, Phong p, int id_tthai)
        {
            conn = new SqlConnection(sqlConnect);
            keToan = new DataSet();
            this.nguoiDung = ng;
            this.phongModel = p;
            id_phong = phongModel.Id_phong;
            this.id_tthai = id_tthai;
            setTable();
        }
        
        private void setTable()
        {
            GetTablePhong();
            GetTableLoaiTieuDung();
            GetTableTieuDung();
            GetTableThongKe();
        }
        private void MoKetNoi()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (conn.State == ConnectionState.Closed) MessageBox.Show("Không kết nối được");
        }
        private void GetTablePhong()
        {
            string sql = "select * from phong";
            try
            {
                MoKetNoi();
                adPhong = new SqlDataAdapter(sql, conn);
                adPhong.FillSchema(keToan, SchemaType.Source, "PHONG");
                adPhong.Fill(keToan, "PHONG");
                this.phong = keToan.Tables["PHONG"];
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
        private void GetTableLoaiTieuDung()
        {
            string sql = "select * from loai_tieu_dung";
            try
            {
                MoKetNoi();
                adLoaiTieuDung = new SqlDataAdapter(sql, conn);
                adLoaiTieuDung.FillSchema(keToan, SchemaType.Source, "LOAITIEUDUNG");
                adLoaiTieuDung.Fill(keToan, "LOAITIEUDUNG");
                this.LoaiTeuDung = keToan.Tables["LOAITIEUDUNG"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Lỗi lấy tieuDung");
                this.LoaiTeuDung = null;
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetTableThongKe()
        {
            if (thongKe!=null)
            {
                thongKe.Clear();
            }
            else
            {
                string sql = "select  tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân loại', ngay_de_nghi as 'Đề nghị', ngay_hoan_thanh as 'Ngày giao', t_tthai as 'Trạng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = " + this.id_phong + " and t_thai = "+this.id_tthai+"";
                try
                {
                    MoKetNoi();
                    adThongKe = new SqlDataAdapter(sql, conn);
                    adThongKe.FillSchema(keToan, SchemaType.Source, "THONGKE");
                    adThongKe.Fill(keToan, "THONGKE");
                    this.thongKe = keToan.Tables["THONGKE"];
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi lấy data");
                    this.thongKe = null;
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }
        private void GetTableTieuDung()
        {
            string sql = "select * from tieu_dung where id_nguoidung in (select id from nguoi_dung where id_phong="+id_phong+") and t_thai = "+id_tthai+"";
            try
            {
                Console.WriteLine(sql);
                adTieuDung = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adTieuDung);
                adTieuDung.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adTieuDung.Fill(keToan, "TIEUDUNG");
                adTieuDung.FillSchema(keToan, SchemaType.Source, "TIEUDUNG");
                adTieuDung.Fill(keToan, "TIEUDUNG");
                tieuDung = keToan.Tables["TIEUDUNG"];
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
        public int GiaoTien(int row, TieuDung td)
        {
            try
            {
                DataRow dr = keToan.Tables["TIEUDUNG"].Rows[row];
                dr["ngay_giao_tien"] = td.Ngay_hoan_thanh;
                dr["id_ktoan"] = td.Id_ktoan;
                dr["t_thai"] = 4;
                CapNhatDatabase();
                DataRow tk = keToan.Tables["THONGKE"].Rows[row];
                tk["Trạng thái"] = "Đã nhận tiền";
                tk["Ngày giao"] = td.Ngay_hoan_thanh;
                return 1;
            }
            catch(Exception e)
            {
                Console.WriteLine("Lỗi phần giao tiền: "+e);
                return 0;
            }
        }
        public int NghiemThu(int row, TieuDung td)
        {
            try
            {

                DataRow dr = keToan.Tables["TIEUDUNG"].Rows[row];
                dr["ngay_hoan_thanh"] = td.Ngay_hoan_thanh;
                dr["t_thai"] = 5;
                CapNhatDatabase();
                DataRow tk = keToan.Tables["THONGKE"].Rows[row];
                tk["Trạng thái"] = "Đã nghiệm thu";
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi phần giao tiền: " + e);
                return 0;
            }
        }
        public void CapNhatDatabase()
        {
            try
            {
                adTieuDung.Update(keToan, "TIEUDUNG");
                tieuDung = keToan.Tables["TIEUDUNG"];
            }
            catch
            {
                MessageBox.Show("Không cập nhật được database");
            }
        }
        public DataTable InHoaDon(int id)
        {
            
            string sql = "select * from viewThongKe where id="+id+"";
            Console.WriteLine(sql);
            try
            {
                MoKetNoi();
                adHoaDon = new SqlDataAdapter(sql, conn);
                adHoaDon.FillSchema(keToan, SchemaType.Source, "HOADON");
                adHoaDon.Fill(keToan, "HOADON");
                return keToan.Tables["HOADON"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
