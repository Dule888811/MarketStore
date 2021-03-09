using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
     public static  class Database
    {
         public static void CreateDatabase()
        {
             string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
             SqlConnection sqlConn = new SqlConnection(connectionString);
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
         builder.DataSource = "(LocalDb)\\MSSQLLocalDB";   // update me
            builder.UserID = "";              // update me
            builder.Password = "";      // update me
            builder.InitialCatalog = "Master";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Done.");
                    String sql = "DROP DATABASE IF EXISTS [martketStoreDB]; CREATE DATABASE [martketStoreDB]";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Done.");
                    }
                    StringBuilder sb = new StringBuilder();
                    sb.Append("USE martketStoreDB; ");
                    sb.Append("CREATE TABLE Users ( ");
                    sb.Append(" Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
                    sb.Append(" FirstName NVARCHAR(50), ");
                    sb.Append(" LastName NVARCHAR(50) ");
                    sb.Append("); ");
                    sb.Append("USE martketStoreDB; ");
                    sb.Append("CREATE TABLE Gold ( ");
                    sb.Append(" Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
                    sb.Append(" Turnover DECIMAL(6,2),");
                    sb.Append(" Discount DECIMAL(1,1),");
                    sb.Append("userID int FOREIGN KEY REFERENCES Users(Id)");
                    sb.Append("); ");
                    sb.Append("USE martketStoreDB; ");
                    sb.Append("CREATE TABLE Bronze ( ");
                    sb.Append(" Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
                    sb.Append(" Turnover DECIMAL(6,2),");
                    sb.Append(" Discount DECIMAL(1,1),");
                    sb.Append("userID int FOREIGN KEY REFERENCES Users(Id)");
                    sb.Append("); ");
                    sb.Append("USE martketStoreDB; ");
                    sb.Append("CREATE TABLE Silver  ( ");
                    sb.Append(" Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
                    sb.Append(" Turnover DECIMAL(6,2),");
                    sb.Append(" Discount DECIMAL(1,1),");
                    sb.Append("userID int FOREIGN KEY REFERENCES Users(Id)");
                    sb.Append("); ");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Done.");
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }

                Console.WriteLine("All done. Press any key to finish...");
                Console.ReadKey(true);

            }
            
        }
       
    }
}
