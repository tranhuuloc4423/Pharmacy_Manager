﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Constants
{
    public class Procedures
    {
        private static Procedures instance;

        public static Procedures Instance
        {
            get { if (instance == null) instance = new Procedures(); return Procedures.instance; }
            private set { Procedures.instance = value; }
        }

        private Procedures() { }

        private string connectionSTR = "Data Source=ROKU\\SQLEXPRESS;Initial Catalog=Project_QLTT;Integrated Security=True;Trust Server Certificate=True";

        public DataTable ExecuteStoredProcedure(string storedProcedureName, ref string error, SqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(storedProcedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }

                return data;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable ExecuteQuery(string query, ref string error, object[] parameter = null)
        {
            DataTable data = new DataTable();
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                }

                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi loi: " + ex.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        public int ExecuteNonQuery(string query, ref string error , object[] parameter = null)
        {
            int data = 0;
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();

                }

                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi loi: " + ex.Message;
                return 0;
            }
            finally
            {
                connection.Close();
            }

        }

        public object ExecuteScalar(string query,ref string error, object[] parameter = null)
        {
            object data = 0;
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();

                }
                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi loi: " + ex.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
