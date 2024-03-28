using Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp
{
    public partial class Form1 : Form
    {
        Connect conn = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void btopen_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            conn.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txbarang.Text;
            conn.OpenConnection();

            try 
            {
                string query = "SELECT nama_barang, harga FROM barang WHERE id_barang = @code";
                SqlCommand com = new SqlCommand(query, conn.con);
                com.Parameters.AddWithValue("@code", id);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    string nama = dr[0].ToString();
                    string harga = dr[1].ToString();

                    MessageBox.Show(nama + " dengan harga Rp. " + harga);
                }
                else
                {
                    MessageBox.Show("ID Barang Tidak ditemukan");
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error = " + ex.Message);
            }

            conn.CloseConnection();

        }
    }
}
