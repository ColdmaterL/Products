using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }
    
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureddate) : base(name, price)
        {
            ManufacturedDate = manufactureddate;
        }

        public sealed override string PriceTag()
        {
            return $"{Name} (used) $ {Price:F2} (Manufactured date: {ManufacturedDate.ToString("dd/MM/yyyy")})";
        }
    }
}
