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
    public class AccountingManager
    {
        public static string GetConnectionString()
        {
            string val = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return val;
        }

        public static DataTable GetProductList(string UserID)
        {
            string connStr = GetConnectionString();
            string dbCommand =
                    $@"SELECT
                    ID,
                    Name,
                    Description,
                    CategoryID,
                    PublishDate,
                    Price,
                    Quantity
                    FROM Products
                    ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbCommand, conn))
                {
                    comm.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        conn.Open();
                        var reader = comm.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        return dt;
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(ex);
                        return null;
                    }
                }
            }
        }

        public static void CreatProduct(string userID,string name,string description,string categoryID,int price,string status,string defaultImageId,string quantity)
        {
            string connStr = GetConnectionString();
            string dbCommand =
                   $@"INSERT INTO [dbo].[Products]
                       (
                        UserID
                       ,Name
                       ,Description
                       ,CategoryID
                       ,Price
                       ,PublishDate
                       ,Status
                       ,DefaultImageId
                       ,Quantity
                        )
                    VALUES
                       (
                        @userID,
                       ,@name,
                       ,@description,
                       ,@categoryID,
                       ,@price,
                       ,@publishDate,
                       ,@status,
                       ,@defaultImageId,
                       ,@quantity,
                        )";



            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbCommand, conn))
                {
                    comm.Parameters.AddWithValue("@userID", userID);
                    comm.Parameters.AddWithValue("@name", name);
                    comm.Parameters.AddWithValue("@description", description);
                    comm.Parameters.AddWithValue("@categoryID", categoryID);
                    comm.Parameters.AddWithValue("@price", price);
                    comm.Parameters.AddWithValue("@publishDate", DateTime.Now);
                    comm.Parameters.AddWithValue("@defaultImageId", defaultImageId);
                    comm.Parameters.AddWithValue("@quantity", quantity);

                    try
                    {
                        conn.Open();
                        var reader = comm.ExecuteNonQuery();
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
