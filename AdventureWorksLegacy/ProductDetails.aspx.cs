using System;
using System.Data;
using System.Configuration;
using System.Collections;
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
    public partial class ProductDetails : System.Web.UI.Page, IProductDetailsView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    int productId = Convert.ToInt32(Request.QueryString["prod_id"]);
                    InitProductDetailsView(productId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void InitProductDetailsView(int productId)
        {
            this.cacheEnabled = Convert.ToBoolean(Application["CacheEnabled"].ToString());
            ProductDetailsPresenter presenter = new ProductDetailsPresenter(this);
            this.AttachPresenter(presenter);
            presenter.InitView(IsPostBack);
            presenter.GetProduct(productId, HttpContext.Current.Server.MapPath("~"));
        }

        public void AttachPresenter(ProductDetailsPresenter _presenter)
        {
            if (_presenter == null) throw new ArgumentNullException("presenter may not be null");

            presenter = _presenter;
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

        public Product Product
        {
            set
            {
                product = value;
                ImgLargePhoto.ImageUrl = product.LargePhotoUrl;
                LitDescription.Text = product.Name;
                LitListPrice.Text = string.Format("{0:#.00}", product.ListPrice);
            }
            get
            {
                return product;
            }

        }

        private bool cacheEnabled;
        private ProductDetailsPresenter presenter;
        private Product product;
    }
}
