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
        public void ThucThi(string SQL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
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
        public string GetValue(string SQL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    return "0"; // Hoặc giá trị mặc định bạn muốn trả về nếu không có ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi thất bại: " + ex.Message);
                return "0";
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
