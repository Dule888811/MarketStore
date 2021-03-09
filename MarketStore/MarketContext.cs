using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    
    public class MarketContext : DbContext
    {
        public MarketContext(string connectionString)
        {
            System.Data.Entity.Database.SetInitializer<MarketContext>(null);
            this.Database.Connection.ConnectionString = connectionString;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Bronze> Bronze { get; set; }

        public DbSet<Gold> Gold { get; set; }

        public DbSet<Silver> Silver { get; set; }
    }
}
