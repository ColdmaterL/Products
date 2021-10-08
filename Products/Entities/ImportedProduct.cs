using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return $"{Name} $ {TotalPrice():F2} (Custom fee: $ {CustomsFee:F2})";
        }
    }
}
