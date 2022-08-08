using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ATMLib
{
    public class UserDetails : IUserDetails
    {
        SqlConnection sqlConnection = null;

        SqlDataReader sqlDataReader = null;

        public UserDetails(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int VaildateUser(string cardno, string pin)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string sql = "SELECT USERID, CARDNO, PIN FROM USERDETAILS WHERE CARDNO=@cardno AND PIN=@pin";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("cardno", cardno);
            cmd.Parameters.AddWithValue("pin", pin);
            sqlDataReader = cmd.ExecuteReader();

            User user = null;
            if (sqlDataReader.Read())
            {
                user = new User();
                user.CardNo = sqlDataReader["cardno"].ToString();
                user.Pin = sqlDataReader["pin"].ToString();
                user.UserID = Convert.ToInt32(sqlDataReader["userid"].ToString());
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                return user.UserID;
            }
            else
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                return -1;
            }
        }

        
    }
}
