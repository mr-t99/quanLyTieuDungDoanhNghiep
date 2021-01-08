using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using quanLyTieuDungDn.Model.Object;
namespace quanLyTieuDungDn.Model
{
    class NhanVienModel
    {
        public string sqlConnect = Environment.GetEnvironmentVariable("sqlString");
        private SqlConnection conn;
        public DataSet nhanVien;
        public DataTable thongKe, thongKeCaNhan, phong, LoaiTeuDung, tieuDung;
        public SqlDataAdapter adThongKe, adThongKeCaNhan, adLoaiTieuDung, adPhong, adTieuDung;
        //các đối tượng
        private NguoiDung nguoiDung;
        //các biến
        public int h_muc = 0;
        //contructor
        public NhanVienModel(NguoiDung ng)
        {
            this.nguoiDung = ng;
            conn = new SqlConnection(sqlConnect);
            nhanVien = new DataSet("NHANVIEN");
            setTable();
        }
        //check o ket noi
        private void MoKetNoi()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (conn.State == ConnectionState.Closed) MessageBox.Show("Không kết nối được");
        }


        //cac ham lay table
        private void setTable()
        {
            GetTableThongKe(nguoiDung.Id_phong);
            GetTablePhong(nguoiDung.Id_phong);
            GetTableLoaiTieuDung();
            GetTableTieuDung();
            GetTableThongKeCaNhan();
        }
        //phương thức cho user controll Thong Ke
        private void GetTableThongKe(int id_phong)
        {
            string sql = "select tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân loại', ngay_de_nghi as 'Đề nghị', t_tthai as 'Trạng thái', ghi_chu as 'Ghi chú' from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = " + id_phong+"";
            try
            {
                MoKetNoi();
                adThongKe = new SqlDataAdapter(sql, conn);
                adThongKe.FillSchema(nhanVien, SchemaType.Source, "THONGKE");
                adThongKe.Fill(nhanVien, "THONGKE");
                this.thongKe = nhanVien.Tables["THONGKE"];
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
        //Phương thức chu userControll Sua thong tin tieu dung
        public void GetTableThongKeCaNhan()
        {
            if (thongKeCaNhan != null)
            {
                this.thongKeCaNhan.Clear();
            }
            string sql = "select tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân loại', ngay_de_nghi as 'Đề nghị', t_tthai as 'Trạng thái',tieu_dung.ghi_chu as 'Ghi chú' from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = " + nguoiDung.Id_phong + " and id_nguoidung=" + nguoiDung.Id_nguoi_dung + "";
            try
            {
                Console.WriteLine(sql);
                MoKetNoi();
                adThongKeCaNhan = new SqlDataAdapter(sql, conn);
                adThongKeCaNhan.FillSchema(nhanVien, SchemaType.Source, "THONGKECANHAN");
                adThongKeCaNhan.Fill(nhanVien, "THONGKECANHAN");
                this.thongKeCaNhan = nhanVien.Tables["THONGKECANHAN"];
            }
            catch
            {
                MessageBox.Show("Lỗi lấy data");
                this.thongKeCaNhan = null;
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetTablePhong(int id_phong)
        {   
            string sql = "select * from phong where id=" + id_phong + "";
            try
            {
                MoKetNoi();
                adPhong = new SqlDataAdapter(sql, conn);
                adPhong.FillSchema(nhanVien, SchemaType.Source, "PHONG");
                adPhong.Fill(nhanVien, "PHONG");
                this.phong = nhanVien.Tables["PHONG"];
            }catch(Exception e)
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
                adLoaiTieuDung.FillSchema(nhanVien, SchemaType.Source, "LOAITIEUDUNG");
                adLoaiTieuDung.Fill(nhanVien, "LOAITIEUDUNG");
                this.LoaiTeuDung = nhanVien.Tables["LOAITIEUDUNG"];
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
        public void GetTableTieuDung()
        {
            string sql = "select * from tieu_dung where id_nguoidung = "+nguoiDung.Id_nguoi_dung+"";
            try
            {
                adTieuDung = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adTieuDung);
                adTieuDung.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adTieuDung.Fill(nhanVien, "TIEUDUNG");
                adTieuDung.FillSchema(nhanVien, SchemaType.Source, "TIEUDUNG");
                adTieuDung.Fill(nhanVien, "TIEUDUNG");
                tieuDung = nhanVien.Tables["TIEUDUNG"];
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
        public void ThemTieuDung(TieuDung td, LoaiTieuDung ltd)
        {
            DataRow newTd = this.tieuDung.NewRow();
            newTd["id_nguoidung"] = nguoiDung.Id_nguoi_dung;
            newTd["t_tdung"] = td.T_tdung;
            newTd["gia"] = td.Gia;
            newTd["ngay_de_nghi"] = DateTime.Now.ToString("yyyy/MM/dd");
            newTd["id_tdung"] = td.Id_tieu_dung;
            newTd["t_thai"] = 1;
            nhanVien.Tables["TIEUDUNG"].Rows.Add(newTd);
            DataRow dr = this.thongKeCaNhan.NewRow();
            dr["Nhân viên"] = nguoiDung.Tn_dung;
            dr["Mua"] = td.T_tdung;
            dr["Phân loại"] = ltd.L_tdung;
            dr["Giá"] = td.Gia;
            dr["Đề nghị"] = DateTime.Now.ToString("yyyy/MM/dd");
            dr["Trạng thái"] = "Khởi tạo";
            nhanVien.Tables["THONGKECANHAN"].Rows.Add(dr);
        }
        public void SuaTieuDung(TieuDung td, LoaiTieuDung ltd, int row)
        {
            //Phương thức để cập nhật bảng
            DataRow rdr = nhanVien.Tables["TIEUDUNG"].Rows[row];
            rdr["t_tdung"] = td.T_tdung;
            rdr["gia"] = td.Gia;
            rdr["id_tdung"] = td.Id_tieu_dung;
            rdr["ngay_de_nghi"] = DateTime.Now.ToString("yyyy/MM/dd");
            /*
             Muốn đưa xuống database thì đưa ở đây thì thêm hàm CapNhatDatabase()
             */
            //Phương thức để cập nhật trên view
            DataRow dr = nhanVien.Tables["THONGKECANHAN"].Rows[row];
            dr["Mua"] = td.T_tdung;
            dr["Giá"] = td.Gia;
            dr["Phân loại"] = ltd.L_tdung;
            dr["Đề nghị"] = DateTime.Now.ToString("yyyy/MM/dd");
            
        }
        public void XoaTieuDung(int row)
        {
            nhanVien.Tables["TIEUDUNG"].Rows[row].Delete();
            nhanVien.Tables["THONGKECANHAN"].Rows[row].Delete();
        }
        public void CapNhatDatabase()
        {
            try
            {
                adTieuDung.Update(nhanVien, "TIEUDUNG");
                tieuDung = nhanVien.Tables["TIEUDUNG"];
            }
            catch
            {
                MessageBox.Show("Không cập nhật được database");
            }
        }
    }
}
