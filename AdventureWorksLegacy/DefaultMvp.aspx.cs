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
    public partial class DefaultMvp : System.Web.UI.Page, IDefaultView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
        }

        private DefaultPresenter presenter;

        protected void DdlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (presenter == null) throw new FieldAccessException("presenter has not yet been initialized");

            presenter.SelectCategory(DdlCategories.SelectedValue, Page.IsValid);
        }

        //protected void BtnSubmit_OnClick(object sender, EventArgs e)
        //{
        //    if (presenter == null) throw new FieldAccessException("presenter has not yet been initialized");

        //    presenter.SubmitForm(Page.IsValid);
        //}
    }
}
