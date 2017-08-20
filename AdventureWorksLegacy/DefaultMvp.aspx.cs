using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using AdventureWorksPresenters;
using AdventureWorksModel;

using Memcached.ClientLibrary;

namespace AdventureWorksLegacy
{
    public partial class DefaultMvp : System.Web.UI.Page, IDefaultView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestCache();

            InitDefaultView();
        }

        private void InitDefaultView()
        {
            DefaultPresenter presenter = new DefaultPresenter(this);
            this.AttachPresenter(presenter);
            presenter.InitView(IsPostBack);
        }

        public void AttachPresenter(DefaultPresenter presenter)
        {
            if (presenter == null) throw new ArgumentNullException("presenter may not be null");

            this.presenter = presenter;
        }

        public List<Category> CategoriesList
        {
            set 
            {
                DdlCategories.Items.Clear();
                DdlCategories.DataSource = value;
                DdlCategories.DataValueField = "ProductCategoryId";
                DdlCategories.DataTextField = "Name";
                DdlCategories.DataBind();
            }
            get 
            {
                if (DdlCategories.Items.Count > 0)
                {
                    List<Category> categoriesList = new List<Category>();
                    foreach (ListItem item in DdlCategories.Items)
                    {
                        Category cat = new Category();
                        cat.ProductCategoryId = Convert.ToInt32(item.Value);
                        cat.Name = item.Text;
                        categoriesList.Add(cat);
                    }
                    return categoriesList;
                }
                else return null;
            }
        }

        public List<Subcategory> SubcategoriesList
        {
            set
            {
                DdlSubcategories.Items.Clear();
                DdlSubcategories.DataSource = value;
                DdlSubcategories.DataValueField = "ProductSubcategoryId";
                DdlSubcategories.DataTextField = "Name";
                DdlSubcategories.DataBind();
            }
        }
        

        private DefaultPresenter presenter;

        protected void DdlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (presenter == null) throw new FieldAccessException("presenter has not yet been initialized");

            this.Validate();

            int categoryId = Convert.ToInt32(DdlCategories.SelectedValue);

            presenter.SelectCategory(categoryId, Page.IsValid, Convert.ToBoolean(Application["CacheEnabled"].ToString()));
        }

        protected void DdlSubcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
            // Drill down products
        }

        //protected void BtnSubmit_OnClick(object sender, EventArgs e)
        //{
        //    if (presenter == null) throw new FieldAccessException("presenter has not yet been initialized");

        //    presenter.SubmitForm(Page.IsValid);
        //}

        private void TestCache()
        {
            string cacheHostPort = ConfigurationManager.AppSettings["CacheHostPort"].ToString();

            string[] serverlist = { cacheHostPort };

            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(serverlist);

            pool.InitConnections = 3;
            pool.MinConnections = 3;
            pool.MaxConnections = 5;

            pool.SocketConnectTimeout = 1000;
            pool.SocketTimeout = 3000;

            pool.MaintenanceSleep = 30;
            pool.Failover = true;

            pool.Nagle = false;
            pool.Initialize();

            //Read cache
            MemcachedClient mc = new MemcachedClient();
            mc.EnableCompression = false;

            object returnObj = mc.Get("saludo");

            SockIOPool.GetInstance().Shutdown();
        }
    }
}
