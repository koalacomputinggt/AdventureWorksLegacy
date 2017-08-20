using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using AdventureWorksBLL;
using AdventureWorksModel;

namespace AdventureWorksLegacy
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AdventureWorksBLL.Catalog catalogBll = new Catalog();

                List<Category> categoriesList = new List<Category>();

                categoriesList = catalogBll.GetCategories(false);

                DdlCategories.Items.Clear();
                DdlCategories.DataSource = categoriesList;
                DdlCategories.DataValueField = "ProductCategoryId";
                DdlCategories.DataTextField = "Name";
                DdlCategories.DataBind();

            }
        }
    }
}
