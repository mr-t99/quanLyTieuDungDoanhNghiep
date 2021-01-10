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
                Console.WriteLine(id_tthai);
                string sql = "select  tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân loại', ngay_de_nghi as 'Đề nghị', ngay_duyet as 'Ngày duyệt', t_tthai as 'Trạng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = "+id_phong+" and (t_thai =1 or t_thai=2 or t_thai=3 )";
                if(id_tthai == 4)
                {
                    sql = "select  tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân loại', ngay_de_nghi as 'Đề nghị', ngay_hoan_thanh as 'Ngày nghiệm thu', t_tthai as 'Trạng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = " + id_phong + " and t_thai =4";
                    Console.WriteLine(sql);
                }
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
            if (id_tthai == 4)
            {
                sql = "select * from tieu_dung where id_nguoidung in (select id from nguoi_dung where id_phong=" + id_phong + ") and t_thai =4 ";
            }
            try
            {
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
            dr["ngay_duyet"] = tieuDung.Ngay_hoan_thanh;
            UpdateDatabaseTieuDung();
            DataRow vdr = quanLy.Tables["VIEWTIEUDUNG"].Rows[row];
            vdr["Trạng thái"] = tieuDung.T_tthai;
            vdr["Giá"] = tieuDung.Gia;
            vdr[5] = tieuDung.Ngay_hoan_thanh;

        }
        public void NghiemThuTieuDung(int row, TieuDung tieuDung)
        {
            DataRow dr = quanLy.Tables["TIEUDUNG"].Rows[row];
            dr["gia"] = tieuDung.Gia;
            dr["t_thai"] = tieuDung.T_thai;
            dr["ghi_chu"] = tieuDung.Ghi_chu;
            dr["id_qly"] = tieuDung.Id_qly;
            dr["ngay_hoan_thanh"] = tieuDung.Ngay_hoan_thanh;
            UpdateDatabaseTieuDung();
            DataRow vdr = quanLy.Tables["VIEWTIEUDUNG"].Rows[row];
            vdr["Trạng thái"] = tieuDung.T_tthai;
            vdr["Giá"] = tieuDung.Gia;
            vdr[5] = tieuDung.Ngay_hoan_thanh;

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
                    sql = "select t_khoan as 'Tài khoản', m_khau as 'Mật khẩu', tn_dung as 'Nhân viên', g_tinh as 'Giới tính', que_quan as 'Quê quán', ngay_lam as 'Ngày làm', c_vu as 'Chức vụ', phong.t_phong as 'Phòng' from nguoi_dung, phong where phong.id = nguoi_dung.id_phong";
                }
                else
                {
                    sql = "select t_khoan as 'Tài khoản', m_khau as 'Mật khẩu', tn_dung as 'Nhân viên', que_quan as 'Quê quán', ngay_lam as 'Ngày làm', c_vu as 'Chức vụ', phong.t_phong as 'Phòng'  from nguoi_dung, phong where phong.id = nguoi_dung.id_phong and id_phong = " + this.id_phong + "";
                }
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
                DataRow dr = quanLy.Tables["PHONG"].Rows[row];
                dr["t_phong"] = p.T_phong;
                dr["h_muc"] = p.H_muc;

                DataRow ndr = quanLy.Tables["VIEWPHONG"].Rows[row];
                ndr["Hạn mức"] = p.H_muc;
                ndr["Tên phòng"] = p.T_phong;
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
        public void ThemNhanVien(NguoiDung nguoi)
        {
            DataRow dr = quanLy.Tables["NHANVIEN"].NewRow();
            DataRow ndr = quanLy.Tables["VIEWNHANVIEN"].NewRow();
            ndr["Tài khoản"] = dr["t_khoan"] = nguoi.T_khoan;
            ndr["Mật khẩu"] = dr["m_khau"] = nguoi.Khau;
            ndr["Nhân viên"] = dr["tn_dung"] = nguoi.Tn_dung;
            ndr["Quê quán"] = dr["que_quan"] = nguoi.Que_quan;
            ndr["Ngày làm"] = dr["ngay_lam"] = nguoi.Ngay_lam;
            ndr["Chức vụ"] = dr["c_vu"] = nguoi.C_vu;
            dr["id_phong"] = nguoi.Id_phong;
            ndr["Phòng"] = nguoi.T_phong;
            ndr["Giới tính"] = dr["g_tinh"] = nguoi.G_tinh;
            quanLy.Tables["NHANVIEN"].Rows.Add(dr);
            quanLy.Tables["VIEWNHANVIEN"].Rows.Add(ndr);
        }
        public void SuaNhanVien(NguoiDung nguoi, int row)
        {
            DataRow dr = quanLy.Tables["NHANVIEN"].Rows[row];
            DataRow ndr = quanLy.Tables["VIEWNHANVIEN"].Rows[row];
            ndr["Tài khoản"] = dr["t_khoan"] = nguoi.T_khoan;
            ndr["Mật khẩu"] = dr["m_khau"] = nguoi.Khau;
            ndr["Nhân viên"] = dr["tn_dung"] = nguoi.Tn_dung;
            ndr["Quê quán"] = dr["que_quan"] = nguoi.Que_quan;
            ndr["Ngày làm"] = dr["ngay_lam"] = nguoi.Ngay_lam;
            ndr["Chức vụ"] = dr["c_vu"] = nguoi.C_vu;
            dr["id_phong"] = nguoi.Id_phong;
            ndr["Phòng"] = nguoi.T_phong;
            ndr["Giới tính"] = dr["g_tinh"] = nguoi.G_tinh;
        }
        public void XoaNhanVien(int row)
        {
            quanLy.Tables["NHANVIEN"].Rows[row].Delete();
            quanLy.Tables["VIEWNHANVIEN"].Rows[row].Delete();
        }
        public void CapNhatDatabaseNhanVien()
        {
            try
            {
                adNhanVien.Update(quanLy, "NHANVIEN");
                this.nhanvien = quanLy.Tables["NHANVIEN"];
                MessageBox.Show("Lưu cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi không thể lưu dữ liệu, xảy ra xung đột khi xóa phòng");
            }
        }

        //Thống kê
        public DataTable viewThongKeChi,allThongKe;
        public SqlDataAdapter adViewThongKeChi, adAllThongKe;
        private DateTime date;
        public QuanLyModel(int id_phong, DateTime ngay)
        {
            this.id_phong = id_phong;
            this.date = ngay;
            conn = new SqlConnection(sqlConnect);
            quanLy = new DataSet();
            GetTableViewThongKeChi();
        }

        public DataTable GetTableViewAllThongKeChi(DateTime MM)
        {
            string sql = "select nguoi_dung.tn_dung as 'Nhân viên', t_tdung as 'Tiêu dùng', gia as 'Giá', trang_thai.t_tthai as 'Trạng thái', 'Kế toán'=(select tn_dung from nguoi_dung where id = tieu_dung.id_ktoan), phong.t_phong, tieu_dung.ngay_giao_tien, phong.h_muc from tieu_dung, nguoi_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and trang_thai.id = tieu_dung.t_thai and phong.id = nguoi_dung.id_phong and FORMAT (tieu_dung.ngay_de_nghi, 'MM')=" + MM.ToString("MM")+"";
            Console.WriteLine(sql);
            try
            {
                MoKetNoi();
                adViewThongKeChi = new SqlDataAdapter(sql, conn);
                adViewThongKeChi.FillSchema(quanLy, SchemaType.Source, "VIEWTHONGKECHI");
                adViewThongKeChi.Fill(quanLy, "VIEWTHONGKECHI");
                this.viewThongKeChi = quanLy.Tables["VIEWTHONGKECHI"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy data");
                this.viewThongKeChi = null;
            }
            finally
            {
                conn.Close();
            }
            return viewThongKeChi;
        }
        public DataTable GetTableThongTinTD(DateTime MM)
        {
            string sql = "select tieu_dung.t_tdung, 'Kế toán' = (select tn_dung from nguoi_dung where id = tieu_dung.id_ktoan), 'Quản lý' = (select tn_dung from nguoi_dung where id = tieu_dung.id_qly), CONVERT(varchar, tieu_dung.ngay_de_nghi, 103) as 'ngay_de_nghi',CONVERT(varchar, tieu_dung.ngay_duyet, 103) as 'ngay_duyet' ,CONVERT(varchar, tieu_dung.ngay_giao_tien, 103) as 'ngay_giao_tien',CONVERT(varchar, tieu_dung.ngay_hoan_thanh, 103) as 'ngay_hoan_thanh', thang = FORMAT (tieu_dung.ngay_de_nghi, 'MM') from tieu_dung, nguoi_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and trang_thai.id = tieu_dung.t_thai and phong.id = nguoi_dung.id_phong and ngay_giao_tien is not null and FORMAT (tieu_dung.ngay_de_nghi, 'MM')=" + MM.ToString("MM")+"";
            try
            {
                MoKetNoi();
                adViewThongKeChi = new SqlDataAdapter(sql, conn);
                adViewThongKeChi.FillSchema(quanLy, SchemaType.Source, "VIEWTHONGKECHI");
                adViewThongKeChi.Fill(quanLy, "VIEWTHONGKECHI");
                this.viewThongKeChi = quanLy.Tables["VIEWTHONGKECHI"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy data");
                this.viewThongKeChi = null;
            }
            finally
            {
                conn.Close();
            }
            return viewThongKeChi;
        }
        void GetTableViewThongKeChi()
        {
            if (viewThongKeChi != null)
            {
                viewThongKeChi.Clear();
            }
            else
            {
                string sql = "select nguoi_dung.tn_dung as 'Nhân viên', t_tdung as 'Tiêu dùng', gia as 'Giá', trang_thai.t_tthai as 'Trạng thái', 'Kế toán'=(select tn_dung from nguoi_dung where id = tieu_dung.id_ktoan), phong.t_phong ,CONVERT(varchar, tieu_dung.ngay_giao_tien, 103) as 'ngay_giao_tien', h_muc = (select h_muc from phong where id = " + id_phong+") from tieu_dung, nguoi_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and trang_thai.id = tieu_dung.t_thai and phong.id = nguoi_dung.id_phong and tieu_dung.t_thai = 4 and phong.id = " + id_phong+" and ngay_giao_tien ='"+date+"' ";
                Console.WriteLine(sql);
                try
                {
                    MoKetNoi();
                    adViewThongKeChi = new SqlDataAdapter(sql, conn);
                    adViewThongKeChi.FillSchema(quanLy, SchemaType.Source, "VIEWTHONGKECHI");
                    adViewThongKeChi.Fill(quanLy, "VIEWTHONGKECHI");
                    this.viewThongKeChi = quanLy.Tables["VIEWTHONGKECHI"];
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi lấy data");
                    this.viewThongKeChi = null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }

}
