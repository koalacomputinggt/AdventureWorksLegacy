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
        public List<Category> GetCategories(bool isCacheEnabled)
        {
            AdventureWorksDAL.Catalog catalogDal = new AdventureWorksDAL.Catalog();

            if (isCacheEnabled)
            {
                //object cacheObj = Cache.Instance.Read("saludo");
                Memcached cache = new Memcached();
                object obj = cache.Read("best_dev");
            }

            return catalogDal.GetCategories();
        }

        public List<Subcategory> GetSubcategories(int categoryId, bool isCacheEnabled)
        {
            AdventureWorksDAL.Catalog catalogDal = new AdventureWorksDAL.Catalog();

            return catalogDal.GetSubcategories(categoryId);
        }
    }
}
