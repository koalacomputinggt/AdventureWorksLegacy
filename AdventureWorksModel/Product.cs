using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{
    public class Product
    {
        private int productId;
        private string name;
        private Decimal listPrice;
        private int productSubcategoryId;

        public int ProductId {
            get { return productId; }
            set { productId = value; } 
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public Decimal ListPrice
        {
            get { return listPrice; }
            set { listPrice = value; }
        }

        public int ProductSubcategoryId {
            get { return productSubcategoryId; }
            set { productSubcategoryId = value; }
        }
    }
}
