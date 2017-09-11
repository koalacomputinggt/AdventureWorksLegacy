using System;
using System.Collections.Generic;
using System.Text;

using AdventureWorksModel;
using AdventureWorksDAL;
using AdventureWorksCaching;

namespace AdventureWorksBLL
{
    public class OnlineStore
    {
        public List<AdventureWorksModel.Product> GetProductsWithThumbnails(int subcategoryId, bool isCacheEnabled, string appRootPhysicalPath)
        {
            AdventureWorksDAL.Product productDal = new AdventureWorksDAL.Product();

            return productDal.GetProductsWithThumbnails(subcategoryId, appRootPhysicalPath);
        }

        public List<AdventureWorksModel.Product> GetProducts(int subcategoryId, bool isCacheEnabled)
        {
            AdventureWorksDAL.Product productDal = new AdventureWorksDAL.Product();

            return productDal.GetProducts(subcategoryId);
        }

        public AdventureWorksModel.Product GetProduct (int productId, bool isCacheEnabled)
        {
            AdventureWorksDAL.Product productDal = new AdventureWorksDAL.Product();

            return productDal.GetProduct(productId);
        }
    }
}
