using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WindowsFormsApp.negocio;

namespace WebArtic
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        public List<Imagen> ListaImg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string sIdArticulo = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";

            int idArticulo = 0;
            if (sIdArticulo != "") idArticulo = int.Parse(sIdArticulo);

            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> listarImg = new List<Imagen>();

            try
            {
                ListaImg = negocio.listarImagenByIdArticulo(idArticulo);

                ArticuloNegocio artNegocio = new ArticuloNegocio();
                List<Articulo> listArt = new List<Articulo>();
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();


                if (!IsPostBack)
                {
                    //repRepetidor.DataSource = negocio.listarImagenByIdArticulo(idArticulo);
                    //repRepetidor.DataBind();

                    ddlCategoria.DataSource = categoriaNegocio.listar();
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataTextField = "Descripcion";
                    ddlCategoria.DataBind();

                    ddlMarca.DataSource = marcaNegocio.listar();
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataBind();

                    Articulo art = artNegocio.listar(sIdArticulo)[0];
                    //if (art.Marca.Descripcion == null) art.Marca.Descripcion = "";
                    if (art.Marca == null) art.Marca.Descripcion = "";
                    if (art.Descripcion == null) art.Descripcion = "";
                    if (art.Codigo == null) art.Codigo = "";
                    if (art.Nombre == null) art.Nombre = "";
                    if (art.Categoria.Descripcion == null) art.Categoria.Descripcion = "";

                    txtId.Text = sIdArticulo;
                    txtNombre.Text = art.Nombre;
                    txtDescripcion.Text = art.Descripcion;
                    ddlCategoria.SelectedValue = art.Categoria.Id.ToString();
                    txtCodigo.Text = art.Codigo;
                    ddlMarca.SelectedValue = art.Marca.Id.ToString();
                    txtPrecio.Text = art.Precio.ToString();

                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string sIdArticulo = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";

            if (sIdArticulo != "")
            {
                Response.Redirect("FormDatos.aspx?id=" + sIdArticulo, false);
            }
            else //error falta articulo
            {

            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaArticulos.aspx", false);
        }
    }
}