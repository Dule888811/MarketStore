using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class InsertCardData
    {
        public static void InsertDataInDatabase()
        {



            try
            {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(LocalDb)\\MSSQLLocalDB";   // update me
                builder.UserID = "";              // update me
                builder.Password = "";      // update me
                builder.InitialCatalog = "martketStoreDB";
                using (MarketContext context = new MarketContext(builder.ConnectionString))
                {
                    Bronze Bronze = new Bronze { Id = 1, Turnover = 0, Discount = 0, User_Id = 1 };
                    GetData.valueOfPurchase(Bronze, 150);
                            try 
                            {
                                context.Bronze.Add(Bronze);
                                context.SaveChanges();
                            }
                            catch (SqlException e)
                            {
                                Console.WriteLine(e.ToString());
                            }

                    Silver Silver = new Silver { Id = 1, Turnover = 600, Discount = 2, User_Id = 2 };
                    GetData.valueOfPurchase(Silver, 850);
                            try 
                            {
                                context.Silver.Add(Silver);
                                context.SaveChanges();
                            }
                            catch (SqlException e)
                            {
                                Console.WriteLine(e.ToString());
                            }

                    Gold Gold = new Gold { Id = 1, Turnover = 1500, Discount = 2, User_Id = 3 };
                    GetData.valueOfPurchase(Gold, 1300);
                            try 
                            {
                                context.Gold.Add(Gold);
                                context.SaveChanges();
                            }
                            catch (SqlException e)
                            {
                                Console.WriteLine(e.ToString());
                            }

                    Console.WriteLine("Done");

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }

    }

}

