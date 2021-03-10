using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class GetData
    {
      
        public static void valueOfPurchase (Card Card,int purchase)
        {
            //  List<decimal> AllValues = new List<decimal>();
            var DiscountRate = GetDiscountRate(Card);
            var Total = GetTotal(DiscountRate, purchase);
            var Discount = purchase - Total;
            Console.WriteLine(String.Format("DiscountRate = {0}, Total = {1}, Discount = {2},Purchase = {3}",
      DiscountRate, Total, Discount, purchase));
            Console.ReadLine();



        }

        static decimal GetTotal(decimal DiscountRate, int purchase)
        {
            if (DiscountRate != 0)
            {
                var Total = purchase - ((DiscountRate * purchase) / 100);
                return Total;
            }
            else
            {
                var Total = purchase;
                return Total;
            }
        }

        static decimal GetDiscountRate(Card Card)
        {
              if (Card.GetType() == typeof(MarketStore.Bronze))
                {
                    if (Card.Discount < 100)
                    {
                        return 0;
                    }
                    else if (Card.Discount >= 100 && Card.Discount <= 300)
                    {
                        return 1;
                    } else
                    {
                        return 2.5M ;
                     }

            }
            else if(Card.GetType() == typeof(MarketStore.Silver)) 
                {
                    if(Card.Turnover <300)
                        {
                            return 2;
                        }
                        else 
                        {
                            return 3.5M;
                        }
                }else 
                 {
                if(Card.Turnover >100)
                     {
                      var counter = Math.Floor(Card.Turnover / 100);
                        if(counter > 8)
                    {
                        return 10;
                        }else
                        {
                            return 2 + counter;
                        }
                }
                        else
                        {
                            return 2;
                        }
          
                }
            
}
       
       
           
        }
    
           
    }

