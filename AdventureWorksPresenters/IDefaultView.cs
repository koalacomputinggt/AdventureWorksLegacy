using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorksModel;
using AdventureWorksBLL;

namespace AdventureWorksPresenters
{
    public interface IDefaultView
    {
        List<Category> CategoriesList { set; }
        void AttachPresenter(DefaultPresenter presenter);
    }
}
