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
                connectStr = "Data Source=ROKU\\SQLEXPRESS;Initial Catalog=Project_QLTT;Integrated Security=True";
                //connectStr = "Data Source=.;Initial Catalog=Project_QLTT;Integrated Security=True";
                connect = new SqlConnection(connectStr);
                command = new SqlCommand();
                command.Connection = connect;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetData(string sql, ref string error, SqlParameter[] parameters = null)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
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

        public int ThemPhieu(string procedureName, ref string error, string output, SqlParameter[] parameters = null)
        {
            try
            {
                connect.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedureName;
                command.Parameters.Clear();
                command.Parameters.AddRange(parameters);

                SqlParameter outputParameter = new SqlParameter(output, SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParameter);

                command.ExecuteNonQuery();

                return (int)command.Parameters[output].Value;
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                return 0;
            }
            finally
            {
                connect.Close();
            }
        }

        public DataTable ExecuteReader(string procedureName,CommandType type,ref string error, SqlParameter[] parameters = null)
        {
            try
            {
                connect.Open();
                using (SqlCommand command = new SqlCommand(procedureName, connect))
                {
                    command.CommandType = type;
                    command.CommandText = procedureName;
                    command.Parameters.AddRange(parameters);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        return data;
                    }
                    else
                    {
                        return null;
                    }
                }

            } catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public object ExecuteScalar(string procedureName, CommandType type, ref string error, SqlParameter[] parameters = null)
        {
            try
            {
                connect.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedureName;
                command.Parameters.AddRange(parameters);
                object data = command.ExecuteScalar();
                return data;

            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public bool ExecuteNonQuery(string procedureName, CommandType type, ref string error, SqlParameter[] parameters = null)
        {
            try
            {
                connect.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedureName;
                command.Parameters.Clear();
                command.Parameters.AddRange(parameters);
                int row = command.ExecuteNonQuery();
                if(row == 0)
                {
                    return false;
                } else 
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                return false;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
