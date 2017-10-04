using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorksBLL;
using AdventureWorksModel;

namespace AdventureWorksPresenters
{
    public class OffersPresenter
    {
        public OffersPresenter(IOffersView view)
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

        public void GetProductsActiveOffer(string appRootPhysicalPath)
        {
            AdventureWorksBLL.OnlineStore storeBll = new OnlineStore();

            List<Product> productsList = new List<Product>();

            productsList = storeBll.GetProductsActiveOffer(view.CacheEnabled, appRootPhysicalPath);

            view.ProductsList = productsList;
        }

        private IOffersView view;
    }
}
