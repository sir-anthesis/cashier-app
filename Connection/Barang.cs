using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CashierApp
{
    internal class Barang
    {
        public string id_barang;
        public string nama_barang;
        public int harga;
        public DateTime expired;
        public int stock;

        Connect conn = new Connect();

        public void create() 
        {
            try 
            {
                conn.OpenConnection();
                string query = "INSERT INTO barang VALUES (@id, @nama, @harga, @expired, @stock)";
                SqlCommand com = new SqlCommand(query, conn.con);
                com.Parameters.AddWithValue("@id", id_barang);
                com.Parameters.AddWithValue("@nama", nama_barang);
                com.Parameters.AddWithValue("@harga", harga);
                com.Parameters.AddWithValue("@expired", expired);
                com.Parameters.AddWithValue("@stock", stock);

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil dimasukan");
                }
                else
                {
                    MessageBox.Show("Data gagal dimasukan");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally 
            {
                conn.CloseConnection();
            }
        }

        public DataSet read() 
        {
            DataSet ds = new DataSet();

            try 
            {
                string query = "SELECT * FROM barang";
                SqlCommand cm = new SqlCommand(query, conn.con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(ds,"barang");
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }

            return ds;
        }

        public void update() 
        {
            try
            {
                conn.OpenConnection();
                string query = "UPDATE barang SET nama_barang = @nama, harga=@harga, expired=@expired, stock=@stock WHERE id_barang = @id";
                SqlCommand com = new SqlCommand(query, conn.con);
                com.Parameters.AddWithValue("@id", id_barang);
                com.Parameters.AddWithValue("@nama", nama_barang);
                com.Parameters.AddWithValue("@harga", harga);
                com.Parameters.AddWithValue("@expired", expired);
                com.Parameters.AddWithValue("@stock", stock);

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil diubah");
                }
                else
                {
                    MessageBox.Show("Data gagal diubah");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally 
            {
                conn.CloseConnection();
            }
        }

        public void delete() 
        {
            try
            {
                conn.OpenConnection();
                string query = "DELETE barang WHERE id_barang = @id";
                SqlCommand com = new SqlCommand(query, conn.con);
                com.Parameters.AddWithValue("@id", id_barang);

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil dihapus");
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}
