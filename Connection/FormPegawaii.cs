using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp
{
    public partial class FormPegawai : Form
    {
        public FormPegawai()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            Pegawai pg = new Pegawai();
            DataSet ds = new DataSet();
            ds = pg.read();
            gvTbPg.DataSource = ds;
            gvTbPg.DataMember = "pegawai";
        }

        void ClearData()
        {
            txIdPg.Text = "";
            txNamaPg.Text = "";
            cbGender.SelectedIndex = -1;
            txAlamat.Text = "";
            numUsia.Value = 0;
            txUsn.Text = "";
            txPw.Text = "";
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvTbPg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < gvTbPg.RowCount - 1)
            {
                txIdPg.Text = gvTbPg.Rows[e.RowIndex].Cells[0].Value.ToString();
                txNamaPg.Text = gvTbPg.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGender.SelectedItem = gvTbPg.Rows[e.RowIndex].Cells[2].Value.ToString();
                txAlamat.Text = gvTbPg.Rows[e.RowIndex].Cells[3].Value.ToString();
                numUsia.Value = Convert.ToInt32(gvTbPg.Rows[e.RowIndex].Cells[4].Value.ToString());
                txUsn.Text = gvTbPg.Rows[e.RowIndex].Cells[5].Value.ToString();
                txPw.Text = gvTbPg.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            Pegawai pg = new Pegawai();
            pg.id_pegawai = txIdPg.Text;
            pg.nama_pegawai = txNamaPg.Text;
            pg.gender = Convert.ToString(cbGender.SelectedItem);
            pg.alamat = txAlamat.Text;
            pg.usia = Convert.ToInt32(numUsia.Value);
            pg.username = txUsn.Text;
            pg.password = txPw.Text;

            pg.create();
            LoadData();
            ClearData();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Pegawai pg = new Pegawai();
            pg.id_pegawai = txIdPg.Text;
            pg.nama_pegawai = txNamaPg.Text;
            pg.gender = Convert.ToString(cbGender.SelectedItem);
            pg.alamat = txAlamat.Text;
            pg.usia = Convert.ToInt32(numUsia.Value);
            pg.username = txUsn.Text;
            pg.password = txPw.Text;

            pg.update();
            LoadData();
            ClearData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Pegawai pg = new Pegawai();
            pg.id_pegawai = txIdPg.Text;

            pg.delete();
            LoadData();
            ClearData();
        }
    }
}
