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
    internal class Pegawai
    {
        public string id_pegawai;
        public string nama_pegawai;
        public string gender;
        public string alamat;
        public int usia;
        public string username;
        public string password;

        Connect conn = new Connect();

        public void create() 
        {
            try 
            {
                conn.OpenConnection();
                string query = "INSERT INTO pegawai VALUES (@id, @nama, @gender, @alamat, @usia, @usn, @pw)";
                SqlCommand com = new SqlCommand(query, conn.con);
                com.Parameters.AddWithValue("@id", id_pegawai);
                com.Parameters.AddWithValue("@nama", nama_pegawai);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@alamat", alamat);
                com.Parameters.AddWithValue("@usia", usia);
                com.Parameters.AddWithValue("@usn", username);
                com.Parameters.AddWithValue("@pw", password);

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
                string query = "SELECT * FROM pegawai";
                SqlCommand cm = new SqlCommand(query, conn.con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(ds, "pegawai");
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
                string query = "UPDATE pegawai SET nama_pegawai = @nama, gender=@gender, alamat=@alamat, usia=@usia, username=@usn, password=@pw WHERE id_pegawai = @id";
                SqlCommand com = new SqlCommand(query, conn.con);
                com.Parameters.AddWithValue("@id", id_pegawai);
                com.Parameters.AddWithValue("@nama", nama_pegawai);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@alamat", alamat);
                com.Parameters.AddWithValue("@usia", usia);
                com.Parameters.AddWithValue("@usn", username);
                com.Parameters.AddWithValue("@pw", password);

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
                string query = "DELETE pegawai WHERE id_pegawai = @id";
                SqlCommand com = new SqlCommand(query, conn.con);
                com.Parameters.AddWithValue("@id", id_pegawai);

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
