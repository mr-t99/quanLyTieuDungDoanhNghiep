using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.views;

namespace quanLyTieuDungDn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Environment.SetEnvironmentVariable("sqlString", @"Data Source=192.168.0.127;Initial Catalog=quanLyTieuDung;Persist Security Info=True;User ID=admin;Password=12345");
            Application.Run(new dangnhap());
        }
    }
}
