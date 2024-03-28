using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CashierApp
{
    internal class Connect
    {
        string source;
        public SqlConnection con;

        public Connect()
        {
            try
            {
                source = "Integrated Security=true;Initial Catalog=db_market;Data Source=.";
                con = new SqlConnection(source);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error = " + e.Message);
            }
        }

        public void OpenConnection()
        {
            try
            {
                con.Open();
                //MessageBox.Show("Buka Koneksi Berhasil");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error = " + e.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                con.Close();
                //MessageBox.Show("Tutup Koneksi Berhasil");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error = " + e.Message);
            }
        }
    }
}