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
          //  this.categoriesList = view.CategoriesList;
        }

	    public void InitView(bool isPostBack) {
		    if (! isPostBack) {

                AdventureWorksBLL.Catalog catalogBll = new Catalog();

                List<Category> categoriesList = new List<Category>();

                categoriesList = catalogBll.GetCategories(view.CacheEnabled);

             //   view.CategoriesList = categoriesList;
		    }
	    }

        public void SelectCategory(int categoryId, bool isPageValid)
        {
            if (isPageValid)
            {
                AdventureWorksBLL.Catalog catalogBll = new Catalog();

                List<Subcategory> subcategoriesList = new List<Subcategory>();

                subcategoriesList = catalogBll.GetSubcategories(categoryId, view.CacheEnabled);

               // view.SubcategoriesList = subcategoriesList;
            }
        }

        public List<Subcategory> GetSubCategories(int categoryId)
        {
            AdventureWorksBLL.Catalog catalogBll = new Catalog();
            List<Subcategory> subcategoriesList = new List<Subcategory>();
            subcategoriesList = catalogBll.GetSubcategories(categoryId, view.CacheEnabled);
            return subcategoriesList;
        }

        public List<Category> GetCategories()
        {
            AdventureWorksBLL.Catalog catalogBll = new Catalog();
            return catalogBll.GetCategories(view.CacheEnabled);
        }

        public void SelectSubcategoryWithThumbnails(int subcategoryId, bool isPageValid, string appRootPhysicalPath)
        {
            if (isPageValid)
            {
                AdventureWorksBLL.OnlineStore storeBll = new OnlineStore();

                List<Product> productsList = new List<Product>();

                productsList = storeBll.GetProductsWithThumbnails(subcategoryId, view.CacheEnabled, appRootPhysicalPath);

                view.ProductsList = productsList;
            }
        }

        public int GetInitialSubCategory(int categoryIndex, int subCategoryIndex)
        {
            List<Category> category = GetCategories();
            List<Subcategory> subCategory = GetSubCategories(category[categoryIndex].ProductCategoryId);
            int subCategoryId = subCategory[subCategoryIndex].ProductSubcategoryId;
            return subCategoryId;
        }

        public User AuthenticateUser(string email, string pwd, bool isPageValid)
        {
            if (isPageValid)
            {
                Membership membership = new Membership();
                User userInfo = new User();

                userInfo = membership.GetUser(email);

                return userInfo;
            }
        }

	    private IDefaultView view;
        private List<Category> categoriesList;
    }
}
