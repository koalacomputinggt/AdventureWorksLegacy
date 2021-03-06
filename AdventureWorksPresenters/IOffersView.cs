using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorksModel;
using AdventureWorksBLL;

namespace AdventureWorksPresenters
{
    public interface IOffersView
    {
       
        List<Product> ProductsList { set;  }
        bool CacheEnabled { set; get; }
        void AttachPresenter(OffersPresenter presenter);
    }
}
