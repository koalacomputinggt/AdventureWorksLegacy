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
            this.categoriesList = view.CategoriesList;
        }

	    public void InitView(bool isPostBack) {
		    if (! isPostBack) {

                AdventureWorksBLL.Catalog catalogBll = new Catalog();

                List<Category> categoriesList = new List<Category>();

                categoriesList = catalogBll.GetCategories(view.CacheEnabled);

                view.CategoriesList = categoriesList;
		    }
	    }

        public void SelectCategory(int categoryId, bool isPageValid)
        {
            if (isPageValid)
            {
                AdventureWorksBLL.Catalog catalogBll = new Catalog();

                List<Subcategory> subcategoriesList = new List<Subcategory>();

                subcategoriesList = catalogBll.GetSubcategories(categoryId, view.CacheEnabled);

                view.SubcategoriesList = subcategoriesList;
            }
        }

        public void SelectSubcategory(int subcategoryId, bool isPageValid)
        {
            if (isPageValid)
            {
                AdventureWorksBLL.OnlineStore storeBll = new OnlineStore();

                List<Product> productsList = new List<Product>();

                productsList = storeBll.GetProducts(subcategoryId, view.CacheEnabled);

                view.ProductsList = productsList;
            }
        }

	    private IDefaultView view;
        private List<Category> categoriesList;
    }
}
