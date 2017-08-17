using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{
    public class Subcategory
    {
        private int productSubcategoryId;
        private string name;
        private int productCategoryId;
        private ICollection<Product> products;

        public int ProductSubcategoryId {
            get { return productSubcategoryId; }
            set { productSubcategoryId = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int ProductCategoryId {
            get { return productCategoryId; }
            set { productCategoryId = value; }
        }

        public ICollection<Product> Products {
            get { return products; }
            set { products = value; }
        }
    }
}
