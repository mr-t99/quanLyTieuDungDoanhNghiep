using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace quanLyTieuDungDn.module
{
    class ConnectDatabase
    {
        private static SqlConnection conn;
        public string sqlConnect = @"Data Source=DESKTOP-693KNU1\SQLEXPRESS;Initial Catalog=quanLyTieuDung;Integrated Security=True";
        public ConnectDatabase()
        {
            Conn = new SqlConnection(sqlConnect);
        }

        public static SqlConnection Conn { get => conn; set => conn = value; }

        public void MoKetNoi()
        {
            if (Conn.State == ConnectionState.Closed) Conn.Open();
            if (Conn.State == ConnectionState.Closed) MessageBox.Show("Không kết nối được");
        }
    }
}
