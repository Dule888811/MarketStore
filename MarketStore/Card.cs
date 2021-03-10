using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public abstract class Card
    {
        public int Id { get; set; }
        public decimal Turnover { get; set; }
        public decimal Discount { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User { get; set; }

        public override string ToString()
        {
            return " [id=" + this.Id + ", Turnover=" + this.Turnover.ToString() + ", Discount=" + this.Discount.ToString() + "]";
        }
    }
}
