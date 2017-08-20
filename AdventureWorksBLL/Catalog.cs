using System;
using System.Collections.Generic;
using System.Text;

using AdventureWorksModel;
using AdventureWorksDAL;
using AdventureWorksCaching;

namespace AdventureWorksBLL
{
    public class Catalog
    {
        public List<Category> GetCategories()
        {
            AdventureWorksDAL.Catalog catalogDal = new AdventureWorksDAL.Catalog();

            object cacheObj = Cache.Instance.Read("saludo");

            return catalogDal.GetCategories();
        }

        public List<Subcategory> GetSubcategories(int categoryId)
        {
            AdventureWorksDAL.Catalog catalogDal = new AdventureWorksDAL.Catalog();

            return catalogDal.GetSubcategories(categoryId);
        }
    }
}
