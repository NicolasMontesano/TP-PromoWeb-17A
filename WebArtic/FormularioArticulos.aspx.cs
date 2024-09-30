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
    public partial class FormularioDiscos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;  
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Precio = int.Parse(txtPrecio.Text);
            nuevo.Codigo = txtCodigo.Text;
            nuevo.ImagenUrl = txtImagen.Text;
            nuevo.Nombre = txtNombre.Text;

            negocio.agregar(nuevo);
            Response.Redirect("ListaArticulos.aspx", false);

        }

        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}