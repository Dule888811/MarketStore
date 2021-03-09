using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class User
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public virtual IList<Bronze> Bronze { get; set; }

        public virtual IList<Silver> Silver { get; set; }

        public virtual IList<Gold> Gold { get; set; }
        public String GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public override string ToString()
        {
            return "User [id=" + this.Id + ", name=" + this.GetFullName() + "]";
        }
    }
}
