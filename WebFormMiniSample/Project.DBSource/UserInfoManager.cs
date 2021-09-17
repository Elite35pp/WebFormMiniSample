using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DBSource
{
    public class UserInfoManager
    {
        public static string GetConnectionString()
        {
            string val = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return val;
        }

        public static DataRow GetUserInfoByAccount(string account)
        {
            string connectionString = GetConnectionString();
            string dbCommandString = @"SELECT [Account],[PWD]
                                       FROM UserInfo 
                                       WHERE [Account]  = @account
                                       ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(dbCommandString, connection))
                {
                    command.Parameters.AddWithValue("@account", account);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();

                        if (dt.Rows.Count == 0)
                            return null;

                        DataRow dr = dt.Rows[0];
                        return dr;

                        //return dt;
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(ex);
                        return null;
                    }
                }
            }
        }

        public static void CreateAccount( string Account,string PWD)
        {
            string connStr = GetConnectionString();
            string dbCommand =
                               $@"INSERT INTO [dbo].[UserInfo]
                                (
                                Account
                                ,PWD
                                )
                                VALUES
                                (
                                @Account
                                ,@PWD
                                )";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbCommand, conn))
                {
                    comm.Parameters.AddWithValue("@Account", Account);
                    comm.Parameters.AddWithValue("@PWD", PWD);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(ex);
                    }
                }
            }
        }
    }
}
