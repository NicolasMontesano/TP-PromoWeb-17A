using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArtic
{
    public partial class Exito : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Request.QueryString["nombre"] != null)
                {
                    string nombre = Request.QueryString["nombre"];
                    litMensajeExito.Text = "Registro exitoso " + nombre + "!";
                }
                else
                {
                    litMensajeExito.Text = " Registro exitoso!";
                }
            }
        }
    }
}