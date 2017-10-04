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

        public AdventureWorksModel.Product GetProductWithPhoto(int productId, bool isCacheEnabled, string appRootPhysicalPath) 
        {
            AdventureWorksDAL.Product productDal = new AdventureWorksDAL.Product();

            return productDal.GetProductWithPhoto(productId, appRootPhysicalPath);
        }

        public List<AdventureWorksModel.Product> GetProductsActiveOffer(bool isCacheEnabled, string appRootPhysicalPath)
        {
            AdventureWorksDAL.Product productDal = new AdventureWorksDAL.Product();

            Offer activeOffer = new Offer();
            DateTime toDate = DateTime.Now;

            activeOffer = productDal.GetSpecialOffer(toDate);
            if (activeOffer != null)
            {
                List<AdventureWorksModel.Product> productsList = productDal.GetProductsSpecialOffer(activeOffer.SpecialOfferId, appRootPhysicalPath);
                foreach (AdventureWorksModel.Product product in productsList)
                {
                    product.ListPrice = product.ListPrice - (product.ListPrice * activeOffer.DiscountPct);
                }

                return productsList;
            }
            else
            {
                return null;
            }
        }
    }
}
