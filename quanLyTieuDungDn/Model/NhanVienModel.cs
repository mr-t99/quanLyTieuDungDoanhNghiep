﻿using System;
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
        public DataTable thongKe, phong, tieuDung;
        public SqlDataAdapter adThongKe, adTieuDung, adPhong;
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
            GetTableTieuDung();
        }
        private void GetTableThongKe(int id_phong)
        {
            string sql = "select tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua',t_phong as 'Phòng', gia as 'Giá', ngay_de_nghi as 'Đề nghị', ngay_hoan_thanh as 'Hoàn thành', t_tthai as 'Trạng thái' from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = "+id_phong+"";
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
        private void GetTablePhong(int id_phong)
        {
            Console.WriteLine("ádasdsa");
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
        private void GetTableTieuDung()
        {
            string sql = "select * from loai_tieu_dung";
            try
            {
                MoKetNoi();
                adTieuDung = new SqlDataAdapter(sql, conn);
                adTieuDung.FillSchema(nhanVien, SchemaType.Source, "TIEUDUNG");
                adTieuDung.Fill(nhanVien, "TIEUDUNG");
                this.tieuDung = nhanVien.Tables["TIEUDUNG"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Lỗi lấy tieuDung");
                this.tieuDung = null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
