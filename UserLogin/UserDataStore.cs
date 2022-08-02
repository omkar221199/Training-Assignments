using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataDBLib
{
    public class UserDataStore : IUserDataStore
    {
        SqlConnection sqlConnection = null;

        SqlDataReader sqlDataReader = null;

        public UserDataStore(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool ValidateUser(User user)
        {
                
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string sql = "SELECT * FROM USERDATA WHERE USERNAME=@username AND PASSWORD=@password";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("username", user.Username);
                cmd.Parameters.AddWithValue("password", user.Password);
                sqlDataReader = cmd.ExecuteReader();
                
                if (sqlDataReader.Read())
                {
                    user = new User();
                    user.Username = sqlDataReader["Username"].ToString();
                    user.Password = sqlDataReader["Password"].ToString();
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                    return true;
                }
                else
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                    return false;
                }
            
        }
    }
}
