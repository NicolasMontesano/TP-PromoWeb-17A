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
    public partial class FormDatos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                Cliente nuevoCliente = new Cliente
                {
                    DNI = txtDNI.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Mail = txtEmail.Text + "@" + txtEmailDomain.Text,
                    Direccion = txtDireccion.Text,
                    Ciudad = txtCiudad.Text,
                    CP = int.Parse(txtCP.Text)
                };

                ClienteNegocio negocio = new ClienteNegocio();
                try
                {
                    negocio.AgregarCliente(nuevoCliente);
                    Response.Redirect("Exito.aspx?nombre=" + nuevoCliente.Nombre);
                }
                catch (Exception)
                {
                    Response.Redirect("ErrorPage.aspx");
                }
            } 
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                lblMensajeError.Text = "El campo DNI es obligatorio.";
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lblMensajeError.Text = "El campo Nombre es obligatorio.";
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                lblMensajeError.Text = "El campo Apellido es obligatorio.";
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtEmailDomain.Text))
            {
                lblMensajeError.Text = "El campo mail es obligatorio.";
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                lblMensajeError.Text = "El campo Dirección es obligatorio.";
                return false;
            }
            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                lblMensajeError.Text = "El campo Ciudad es obligatorio.";
                return false;
            }
            if (string.IsNullOrEmpty(txtCP.Text))
            {
                lblMensajeError.Text = "El campo Codifgo Postal es obligatorio.";
                return false;
            }
            if (!chkAceptar.Checked)
            {
                lblMensajeError.Text = "Debe aceptar los terminos y condiciones.";
                return false;
            }

            return true;
        }

    }
}