using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.controller;

namespace quanLyTieuDungDn.views.userControll
{
    public partial class SuaTieuDung : UserControl
    {
        private int id_ndung;
        private nhanvienController nhanvienController = new nhanvienController();
        public SuaTieuDung()
        {
            InitializeComponent();
        }

        public void setUserName(int id_nd)
        {
            this.id_ndung = id_nd;
            Console.WriteLine(id_nd);
            this.dgvTieuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTieuDung.DataSource = nhanvienController.dataTableTieuDung(id_ndung);
            dgvTieuDung.Columns["id"].Visible = false;
        }
        private void SuaTieuDung_Load(object sender, EventArgs e)
        {

        }

        private void dgvTieuDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTieuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                DataGridViewRow row = this.dgvTieuDung.Rows[e.RowIndex];
                Console.WriteLine(row.Cells[0].Value.ToString());
                Console.WriteLine(e.RowIndex);
            }
        }
    }
}
