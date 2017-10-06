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

using System.Web.Services;

namespace AdventureWorksLegacy
{
    public partial class DefaultMvp : System.Web.UI.Page, IDefaultView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TestCache();

            InitDefaultView();
        }

        private void InitDefaultView()
        {
            this.cacheEnabled = Convert.ToBoolean(Application["CacheEnabled"].ToString());
            DefaultPresenter presenter = new DefaultPresenter(this);
            this.AttachPresenter(presenter);
            presenter.InitView(IsPostBack);
            presenter.SelectSubcategoryWithThumbnails(presenter.GetInitialSubCategory(CurrentCategoryIndex, CurrentSubCategoryIndex), true, HttpContext.Current.Server.MapPath("~"));
        }

        public void AttachPresenter(DefaultPresenter _presenter)
        {
            if (_presenter == null) throw new ArgumentNullException("presenter may not be null");

            presenter = _presenter;
        }

        public int CurrentCategoryIndex
        {
            get
            {
                string category = Request.QueryString["categoryIndex"];
                if (category == null) return 0;
                return Convert.ToInt32(category);
            }
        }

        public int CurrentSubCategoryIndex
        {
            get
            {
                string subCategory = Request.QueryString["subCategoryIndex"];
                if (subCategory == null) return 0;
                return Convert.ToInt32(subCategory);
            }
        }

        public List<Product> ProductsList
        {
            set
            {
                DlProducts.DataSource = value;
                DlProducts.DataBind();
            }
        }

        public string CategoryListTabData
        {
            get
            {
                string[] result = new string[]{"",""};
                List<Category> categories = presenter.GetCategories();
                if (categories.Count > 0)
                {
                    foreach (Category item in categories)
                    {
                        if (!result[0].Equals(""))
                            result[0] += ",";
                        if (!result[1].Equals(""))
                            result[1] += ",";
                        result[0] += item.Name;
                        result[1] += item.ProductCategoryId;
                    }
                }
                return result[0]+"|"+result[1];
            }
        }

        public string SubCategoryListAccordionData
        {
            get
            {
                
                string[] result = new string[] { "", "" };
                List<Category> categories = presenter.GetCategories();
                List<Subcategory> subCategoryList = presenter.GetSubCategories(categories[CurrentCategoryIndex].ProductCategoryId);
                foreach (Subcategory item in subCategoryList)
                {
                    if (!result[0].Equals(""))
                        result[0] += ",";
                    if (!result[1].Equals(""))
                        result[1] += ",";
                    result[0] += item.Name;
                    result[1] += item.ProductSubcategoryId;
                }
                return result[0] + "|" + result[1];
            }
        }

        public bool CacheEnabled
        {
            set
            {
                cacheEnabled = value;
            }
            get
            {
                return cacheEnabled;
            }
        }

        public bool IsUserAuthenticated
        {
            set
            {
                hdnIsUserAuthenticated.Value = Convert.ToString(value);
              
                if (value)
                {
                    divAnonymous.Visible = false;
                    divLogged.Visible = true;
                    LblLoggedUser.Text = string.Format("Welcome {0} {1}!", this.UserInfo.FirstName, this.userInfo.LastName);
                }
                else
                {
                    divAnonymous.Visible = true;
                    divLogged.Visible = false;
                }
            }
            get
            {
                if (hdnIsUserAuthenticated.Value == null) 
                    return false;
                else
                    return Convert.ToBoolean(hdnIsUserAuthenticated.Value);
            }
        }

        private bool cacheEnabled;
        private DefaultPresenter presenter;
        private User userInfo;

        protected void DlProducts_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                Response.Redirect("ProductDetails.aspx?prod_id=" + e.CommandArgument.ToString());
            }
        }

        protected void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (presenter == null) throw new FieldAccessException("presenter has not yet been initialized");

            AdventureWorksModel.User userInfo = new User();

            presenter.AuthenticateUser(TxtEmail.Text.Trim(), TxtPwd.Text.Trim(), true);

            Session["UserInfo"] = userInfo;
            

            //TODO
            //if (this.LoginMessage != string.Empty)
            //{

            //}
        }

        public User UserInfo
        {
            set
            {
                userInfo = value;
            }
            get
            {
                return userInfo;
            }
        }

        /*private void TestCache()
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

            object returnObj = mc.Get("best_dev");

            SockIOPool.GetInstance().Shutdown();
        }*/

        protected void BtnSignOut_Click(object sender, EventArgs e)
        {

        }



        
    }
}
