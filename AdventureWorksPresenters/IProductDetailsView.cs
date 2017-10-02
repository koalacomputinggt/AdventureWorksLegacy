using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorksModel;
using AdventureWorksBLL;

namespace AdventureWorksPresenters
{
    public interface IProductDetailsView
    {       
        bool CacheEnabled { set; get; }
        void AttachPresenter(ProductDetailsPresenter presenter);
        Product Product { set; get; }
    }
}
