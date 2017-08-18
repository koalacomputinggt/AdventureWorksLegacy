using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorksBLL;
using AdventureWorksModel;

namespace AdventureWorksPresenters
{
    public class DefaultPresenter
    {
        public DefaultPresenter(IDefaultView view) 
        {
		    if (view == null) throw new ArgumentNullException("view may not be null");

		    this.view = view;
        }

	    public void InitView(bool isPostBack) {
		    if (! isPostBack) {

                AdventureWorksBLL.Catalog catalogBll = new Catalog();

                List<Category> categoriesList = new List<Category>();

                categoriesList = catalogBll.GetCategories();

                view.CategoriesList = categoriesList;
		    }
	    }

        public void SelectCategory(string categoryId, bool isPageValid)
        {
            if (isPageValid)
            {
                // Set subcategories
                return;
            }
        }

	    private IDefaultView view;
    }
}
