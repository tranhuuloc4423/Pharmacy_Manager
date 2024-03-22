using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL.Repositories
{
    public class authRepository
    {
        string connectionString = "Data Source=ROKU\\SQLEXPRESS;Initial Catalog=Project_QLTT;Integrated Security=True;Trust Server Certificate=True";


        public string dangNhap()
        {
            string role = null;
            try
            {
            }
            catch (Exception)
            {

                throw;
            }


            return role;
        }
    }
}
