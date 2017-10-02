using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorksBLL;
using AdventureWorksModel;

namespace AdventureWorksPresenters
{
    public class ProductDetailsPresenter
    {
        public ProductDetailsPresenter(IProductDetailsView view)
        {
            if (view == null) throw new ArgumentNullException("view may not be null");

            this.view = view;
        }

        public void InitView(bool isPostBack)
        {
            if (!isPostBack)
            {
                return;
            }
        }

        public void GetProduct(int productID, string appRootPhysicalPath)
        {
            AdventureWorksBLL.OnlineStore storeBll = new OnlineStore();

            Product product = new Product();

            product = storeBll.GetProductWithPhoto(productID, view.CacheEnabled, appRootPhysicalPath);

            view.Product = product;
        }

        private IProductDetailsView view;
    }
}
