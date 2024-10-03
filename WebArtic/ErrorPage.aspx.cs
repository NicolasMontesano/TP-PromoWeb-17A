using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArtic
{
    public partial class ErrorPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["error"] != null)
                {
                    string errorMessage = Request.QueryString["error"];
                    litErrorMessage.Text = "Detalles técnicos: " + Server.HtmlEncode(errorMessage);
                    litErrorMessage.Visible = true;
                }
            }
        }
    }
}