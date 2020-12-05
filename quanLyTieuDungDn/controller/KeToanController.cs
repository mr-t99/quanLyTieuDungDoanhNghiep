using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.module;
using System.Data;
using System.Collections;

namespace quanLyTieuDungDn.controller
{
    class KeToanController
    {
        ConnectDatabase conn = new ConnectDatabase();
        public ArrayList getDataPhong()
        {
            DataTable data = conn.getdata("select * from phong");
            ArrayList arrPhong = new ArrayList();
            if(data != null)
            {
                foreach (DataRow dr in data.Rows)
                {
                    PhongModel p = new PhongModel();
                    p.Id = Int32.Parse(dr["id"].ToString());
                    p.T_phong = dr["t_phong"].ToString();
                    p.Han_muc = Int32.Parse(dr["h_muc"].ToString());
                    p.Sl_nvien = Int32.Parse(dr["sl_nvien"].ToString());
                    arrPhong.Add(p);
                }
            }
            return arrPhong;
        }
    }
}
