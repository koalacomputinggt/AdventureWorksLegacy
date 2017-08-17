using System;
using System.Collections.Generic;
using System.Text;

using AdventureWorksModel;
using AdventureWorksDAL;

namespace AdventureWorksBLL
{
    public class Catalog
    {
        public List<Category> GetCategories()
        {
            AdventureWorksDAL.Catalog catalogDal = new AdventureWorksDAL.Catalog();

            return catalogDal.GetCategories();
        }
    }
}
