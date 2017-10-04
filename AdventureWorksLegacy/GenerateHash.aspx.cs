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

namespace AdventureWorksLegacy
{
    public partial class GenerateHash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGenerateHash_Click(object sender, EventArgs e)
        {
            string hashed = BCrypt.HashPassword(TxtPwd.Text.Trim(), BCrypt.GenerateSalt());
            TxtHash.Text = "[" + hashed + "]";
        }

        protected void BtnSignIn_Click(object sender, EventArgs e)
        {
            bool matches = BCrypt.CheckPassword(TxtPwd.Text.Trim(), TxtHash.Text.Trim());
            if (matches)
                LblResult.Text = "Logged On!";
            else
                LblResult.Text = "Failed";
        }
    }
}
