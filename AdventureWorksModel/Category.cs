using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{
    public class Category
    {
        private int productCategoryId;
        private string name;
        private ICollection<Subcategory> subcategories;

        public int ProductCategoryId {
            get { return productCategoryId; }
            set { productCategoryId = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public ICollection<Subcategory> Subcategories {
            get { return subcategories; }
            set { subcategories = value; }
        }
    }
}
