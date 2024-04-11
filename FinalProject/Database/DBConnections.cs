using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject
{
    class DBConnections
    {
        
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public void ThucThi(string SQL, List<SqlParameter> parameters)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddRange(parameters.ToArray());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thuc thi thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string SQL)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int GetValue(string SQL)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int value = 1;
                if (cmd.ExecuteScalar() != null)
                {
                    value = (int)cmd.ExecuteScalar();
                }
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
                return 1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
