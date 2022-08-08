using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ATMLib
{
    public class MultipleOptionsDataStore : IMultipleOptionsDataStore
    {
        SqlConnection sqlConnection = null;

        SqlDataReader sqlDataReader = null;
        public MultipleOptionsDataStore(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public double ViewAccountBalance(int userId)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string sql = "SELECT ACCBAL FROM USERDETAILS WHERE USERID = @userid";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("userid", userId);
                sqlDataReader = cmd.ExecuteReader();

                User user = null;
                if (sqlDataReader.Read())
                {
                    user = new User();
                    user.AccBal = Convert.ToDouble(sqlDataReader["AccBal"].ToString());
                    return user.AccBal;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }

        public int CashDeposit(int userId, double amount)
        {
            var dateTime = DateTime.Now;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string sql = "UPDATE UserDetails SET ACCBAL = ACCBAL + @amount WHERE USERID = @userid";
                string sql1 = "INSERT INTO TranDetails(Userid, Trandate, Amt, TranType) VALUES(@userid, @date, @amount, @type)";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("userid", userId);
                cmd.Parameters.AddWithValue("amount", amount);
                SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
                cmd1.Parameters.AddWithValue("userid", userId);
                cmd1.Parameters.AddWithValue("amount", amount);
                cmd1.Parameters.AddWithValue("date", dateTime.ToShortDateString());
                cmd1.Parameters.AddWithValue("type", 0);
                int count = cmd.ExecuteNonQuery() + cmd1.ExecuteNonQuery();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int CashWithdraw(int userId, double amount)
        {
            var dateTime = DateTime.Now;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string sql2 = "SELECT COUNT(1) FROM TranDetails WHERE Userid=@userid AND TRANDATE=@datetime group by TRANDATE";
                SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
                cmd2.Parameters.AddWithValue("userid", userId);
                cmd2.Parameters.AddWithValue("datetime", dateTime);
                sqlDataReader = cmd2.ExecuteReader();
                int cnt = 0;
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        cnt++;
                    }

                    
                    if (cnt < 2)
                    {
                        double balance = ViewAccountBalance(userId);
                        if (balance < amount)
                        {
                            return 0;
                        }
                        else
                        {
                            string sql = "UPDATE UserDetails SET ACCBAL = ACCBAL - @amount WHERE USERID = @userid";
                            string sql1 = "INSERT INTO TranDetails(Userid, Trandate, Amt, TranType) VALUES(@userid, @date, @amount, @type)";
                            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                            cmd.Parameters.AddWithValue("userid", userId);
                            cmd.Parameters.AddWithValue("amount", amount);
                            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
                            cmd1.Parameters.AddWithValue("userid", userId);
                            cmd1.Parameters.AddWithValue("amount", amount);
                            cmd1.Parameters.AddWithValue("date", dateTime.ToShortDateString());
                            cmd1.Parameters.AddWithValue("type", 1);
                            int count = cmd.ExecuteNonQuery() + cmd1.ExecuteNonQuery();
                            return count;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                   
                }
                else
                {
                    return 0;
                }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    


        public List<Transactions> PrevTransactionDetails(int userId)
        {
            Transactions transactions = null;
            List<Transactions> tran = new List<Transactions>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                string sql = "SELECT Top(3) TRANDATE, AMT, TRANTYPE FROM TRANDETAILS WHERE USERID = @userid ORDER BY TRANDATE DESC";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("userid", userId);
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    transactions = new Transactions();
                    transactions.TranDate = sqlDataReader["TRANDATE"].ToString();
                    transactions.Amount = Convert.ToInt32(sqlDataReader["AMT"].ToString());
                    transactions.Type = Convert.ToInt32(sqlDataReader["TRANTYPE"].ToString());
                    tran.Add(transactions);
                }
                return tran;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
