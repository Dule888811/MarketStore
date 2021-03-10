using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;

namespace MarketStore
{
   public class InsertUserData
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
                            User newUser = new User {Id = 1, FirstName = "Anna", LastName = "Shrestinian" };
                            context.Users.Add(newUser);
                             context.SaveChanges();
                    User FirstUser = new User { Id = 2, FirstName = "Aa", LastName = "Shrestin" };
                            context.Users.Add(FirstUser);
                            context.SaveChanges();
                    User NewUser = new User { Id = 3, FirstName = "Ann", LastName = "Shre" };
                            context.Users.Add(NewUser);
                            context.SaveChanges();
                    User OneMorenewUser = new User { Id = 4, FirstName = "Ana", LastName = "Shtinian" };                                                                                                      
                            context.Users.Add(OneMorenewUser);
                            context.SaveChanges();
                }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                    }

        }

            }
           
        }
    


