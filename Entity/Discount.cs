using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Entity
{
    public class Discount:IEntity
    {
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public int DiscountRatio { get; set; }
    }
}
