using System;
using System.Collections.Generic;
using NUnit.Framework;
using AdventureWorksPresenters;
using AdventureWorksModel;

[TestFixture]
public class DefaultPresenterTests
{
    [Test]
    public void TestInitView()
    {
        MockDefaultView view = new MockDefaultView();
        DefaultPresenter presenter = new DefaultPresenter(view);
        presenter.InitView(false);

        Category cat1 = new Category();
        cat1.ProductCategoryId = 1;
        cat1.Name = "Bikes";
        view.CategoriesList.Add(cat1);

        Category cat2 = new Category();
        cat2.ProductCategoryId = 2;
        cat2.Name = "Components";
        view.CategoriesList.Add(cat2);

        Assert.IsTrue(view.CategoriesList.Count > 0);
    }

    private class MockDefaultView : IDefaultView
    {
        public List<Category> CategoriesList
        {
            set 
            {
                categoriesList = value; 
            }

            get 
            { 
                return categoriesList; 
            }
        }

        public List<Subcategory> SubcategoriesList
        {
            set
            {
                subcategoriesList = value;
            }

            get
            {
                return subcategoriesList;
            }
        }

        public List<Product> ProductsList
        {
            set
            {
                productsList = value;
            }

            get
            {
                return productsList;
            }
        }

        public bool CacheEnabled
        {
            set { }
            get { return false; }
        }

        public void AttachPresenter(DefaultPresenter presenter) { }

        private List<Category> categoriesList = new List<Category>();
        private List<Subcategory> subcategoriesList = new List<Subcategory>();
        private List<Product> productsList = new List<Product>();
    }
}