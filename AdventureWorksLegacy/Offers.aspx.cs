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


namespace AdventureWorksLegacy
{
    public partial class Offers : System.Web.UI.Page, IOffersView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitOffersView();
        }

        private void InitOffersView()
        {
            this.cacheEnabled = Convert.ToBoolean(Application["CacheEnabled"].ToString());
            OffersPresenter presenter = new OffersPresenter(this);
            this.AttachPresenter(presenter);
            presenter.InitView(IsPostBack);
            presenter.GetProductsActiveOffer(HttpContext.Current.Server.MapPath("~"));
        }

        public void AttachPresenter(OffersPresenter _presenter)
        {
            if (_presenter == null) throw new ArgumentNullException("presenter may not be null");

            presenter = _presenter;
        }

        public List<Product> ProductsList
        {
            set
            {
                DlProducts.DataSource = value;
                DlProducts.DataBind();
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

        private bool cacheEnabled;
        private OffersPresenter presenter;
    }
}
