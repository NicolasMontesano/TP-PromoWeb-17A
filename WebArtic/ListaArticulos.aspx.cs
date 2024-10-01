using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace WebArtic
{
    public partial class ListaArticulos : System.Web.UI.Page
    {
        public List<Articulo> ListArt { get; set; }
        public List<Imagen> ListImg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            ListArt = negocio.listar();
            ListImg = negocio.listarImagen();

        }

      
    }
}