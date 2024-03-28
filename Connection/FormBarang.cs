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
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            Barang br = new Barang();
            DataSet ds = new DataSet();
            ds = br.read();
            gvTbBr.DataSource = ds;
            gvTbBr.DataMember = "barang";
        }

        void ClearData()
        {
            txIdBr.Text = "";
            txNamaBr.Text = "";
            numHargaBr.Value = 0;
            dtExBr.Value = DateTime.Now;
            numStBr.Value = 0;
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvTbBr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < gvTbBr.RowCount - 1)
            {
                txIdBr.Text = gvTbBr.Rows[e.RowIndex].Cells[0].Value.ToString();
                txNamaBr.Text = gvTbBr.Rows[e.RowIndex].Cells[1].Value.ToString();
                numHargaBr.Value = Convert.ToInt32(gvTbBr.Rows[e.RowIndex].Cells[2].Value.ToString());
                dtExBr.Value = Convert.ToDateTime(gvTbBr.Rows[e.RowIndex].Cells[3].Value.ToString());
                numStBr.Value = Convert.ToInt32(gvTbBr.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            Barang br = new Barang();
            br.id_barang = txIdBr.Text;
            br.nama_barang = txNamaBr.Text;
            br.harga = Convert.ToInt32(numHargaBr.Value);
            br.expired = Convert.ToDateTime(dtExBr.Value);
            br.stock = Convert.ToInt32(numStBr.Value);

            br.create();
            LoadData();
            ClearData();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Barang br = new Barang();
            br.id_barang = txIdBr.Text;
            br.nama_barang = txNamaBr.Text;
            br.harga = Convert.ToInt32(numHargaBr.Value);
            br.expired = Convert.ToDateTime(dtExBr.Value);
            br.stock = Convert.ToInt32(numStBr.Value);

            br.update();
            LoadData();
            ClearData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Barang br = new Barang();
            br.id_barang = txIdBr.Text;

            br.delete();
            LoadData();
            ClearData();
        }
    }
}
