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
        public DataTable viewPhong, tieuDung, viewTieuDung, nhanvien, viewNhanVien, phong;
        public SqlDataAdapter adViewPhong, adTieuDung, adViewTieuDung, adNhanVien, adViewNhanVien, adPhong;
        //các đối tượng
        private NguoiDung nguoiDung;
        private int id_phong, id_tthai;

        public QuanLyModel()
        {
            conn = new SqlConnection(sqlConnect);
            quanLy = new DataSet();
            GetTableViewPhong();
        }
        //Kiểm duyệt
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
        public void GetTableViewPhong()
        {
            string sql = "select phong.id, phong.t_phong as 'Tên phòng','Số lượng nhân viên' = (select count(id) from nguoi_dung where nguoi_dung.id_phong = phong.id), phong.h_muc as 'Hạn mức' from phong ORDER BY id DESC;";
            try
            {
                MoKetNoi();
                adViewPhong = new SqlDataAdapter(sql, conn);
                adViewPhong.FillSchema(quanLy, SchemaType.Source, "VIEWPHONG");
                adViewPhong.Fill(quanLy, "VIEWPHONG");
                this.viewPhong = quanLy.Tables["VIEWPHONG"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Lỗi lấy hạn mức");
                this.viewPhong = null;
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
                string sql = "select  tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân loại', ngay_de_nghi as 'Đề nghị', ngay_hoan_thanh as 'Giao tiền', t_tthai as 'Trạng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = "+id_phong+" and (t_thai =1 or t_thai=2 or t_thai=3 )";
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
            UpdateDatabaseTieuDung();
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

        public void UpdateDatabaseTieuDung()
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
        //Phòng
        public QuanLyModel(int id_phong)
        {
            this.id_phong = id_phong;
            conn = new SqlConnection(sqlConnect);
            quanLy = new DataSet();
            getAllTable();
        }
        void getAllTable()
        {
            GetTableNhanVien();
            GetTableViewNhanVien();
            GetTableTieuDung();
            GetTableViewTieuDung();
            GetTableViewPhong();
            GetTablePhong();
        }
        private void GetTableNhanVien()
        {
            string sql = "select * from nguoi_dung";
            try
            {
                Console.WriteLine(sql);
                adNhanVien = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adNhanVien);
                adNhanVien.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adNhanVien.Fill(quanLy, "NHANVIEN");
                adNhanVien.FillSchema(quanLy, SchemaType.Source, "NHANVIEN");
                adNhanVien.Fill(quanLy, "NHANVIEN");
                nhanvien = quanLy.Tables["NHANVIEN"];
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
        
        private void GetTableViewNhanVien()
        {
            if (viewTieuDung != null)
            {
                viewTieuDung.Clear();
            }
            else
            {
                string sql;
                if (this.id_phong == 0)
                {
                    sql = "select t_khoan as 'Tài khoản', m_khau as 'Mật khẩu', tn_dung as 'Nhân viên', que_quan as 'Quê quán', ngay_lam as 'Ngày làm', c_vu as 'Chức vụ', phong.t_phong as 'Phòng'  from nguoi_dung, phong where phong.id = nguoi_dung.id_phong";
                }
                else
                {
                    sql = "select t_khoan as 'Tài khoản', m_khau as 'Mật khẩu', tn_dung as 'Nhân viên', que_quan as 'Quê quán', ngay_lam as 'Ngày làm', c_vu as 'Chức vụ', phong.t_phong as 'Phòng'  from nguoi_dung, phong where phong.id = nguoi_dung.id_phong and id_phong = " + this.id_phong + "";
                }
                
                Console.WriteLine(sql);
                try
                {
                    MoKetNoi();
                    adViewNhanVien = new SqlDataAdapter(sql, conn);
                    adViewNhanVien.FillSchema(quanLy, SchemaType.Source, "VIEWNHANVIEN");
                    adViewNhanVien.Fill(quanLy, "VIEWNHANVIEN");
                    this.viewNhanVien = quanLy.Tables["VIEWNHANVIEN"];
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi lấy data");
                    this.viewNhanVien = null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void GetTablePhong()
        {
            string sql = "select * from phong ORDER BY id DESC;";
            try
            {
                Console.WriteLine(sql);
                adPhong = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adPhong);
                adPhong.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adPhong.Fill(quanLy, "PHONG");
                adPhong.FillSchema(quanLy, SchemaType.Source, "PHONG");
                adPhong.Fill(quanLy, "PHONG");
                phong = quanLy.Tables["PHONG"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                phong = null;
            }
            finally
            {
                conn.Close();
            }
        }
        public void ThemPhong(Phong p)
        {

            DataRow dr = this.phong.NewRow();
            dr["t_phong"] = p.T_phong;
            dr["h_muc"] = p.H_muc;
            quanLy.Tables["PHONG"].Rows.Add(dr);

            DataRow ndr = this.viewPhong.NewRow();
            ndr["Tên phòng"] = p.T_phong;
            ndr["Hạn mức"] = p.H_muc;
            //ndr["id"] = Int32.Parse(viewPhong.Rows[0]["id"].ToString()) + 1;
            quanLy.Tables["VIEWPHONG"].Rows.Add(ndr);
        }
        public void SuaPhong(Phong p, int row)
        {
            try
            {
                Console.WriteLine(row);
                DataRow dr = quanLy.Tables["PHONG"].Rows[row];
                dr["t_phong"] = p.T_phong;
                dr["h_muc"] = p.H_muc;

                DataRow ndr = quanLy.Tables["VIEWPHONG"].Rows[row];
                ndr["Hạn mức"] = p.H_muc;
                ndr["Tên phòng"] = p.T_phong;
                Console.WriteLine(quanLy.Tables["PHONG"].Rows.Count);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Lỗi sửa");
            }

        }
        public void XoaPhong(int row)
        {
            try
            {
                Console.WriteLine(row);
                quanLy.Tables["PHONG"].Rows[row].Delete();
                quanLy.Tables["VIEWPHONG"].Rows[row].Delete();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }
        public void CapNhatDatabasePhong()
        {
            try
            {
                adPhong.Update(quanLy, "PHONG");
                phong = quanLy.Tables["PHONG"];
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Không cập nhật được database. Có thể đo xung đột khi xóa phòng");
            }
        }
        //Nhân viên
    }

}
