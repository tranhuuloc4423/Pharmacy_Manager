using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    public class Database
    {
        private string connectStr = null;
        SqlConnection connect = null;
        SqlCommand command = null;
        public Database()
        {
            try
            {
                string connectStr = "Data Source=.;Initial Catalog=Learning_QLBH;Integrated Security=True";
                connect = new SqlConnection(connectStr);
                command = new SqlCommand();
                command.Connection = connect;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetData(string sql, CommandType type,ref string error, SqlParameter[] parameters = null)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = type;
                command.Parameters.Clear();
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                }
                SqlDataReader reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                error = "";
                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public void HandleDataProcedure()
        {
            connect.Open();
            command = new SqlCommand();
        }

        public bool HandleData(string sql, CommandType type, ref string error, SqlParameter[] parameters = null)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = type;
                command.Parameters.Clear();
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                }

                int row = command.ExecuteNonQuery();
                if (row == 0)
                {
                    error = "KHONG TIM THAY TEN MUON XOA";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
