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

        protected void btnVerificarDNI_Click(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            string dni = txtDNI.Text;

            if (!string.IsNullOrEmpty(dni))
            {
                Cliente clienteExistente = negocio.ObtenerClientePorDNI(dni);

                if (clienteExistente != null)
                {
                    txtNombre.Text = clienteExistente.Nombre;
                    txtApellido.Text = clienteExistente.Apellido;
                    txtEmail.Text = clienteExistente.Mail;
                    txtDireccion.Text = clienteExistente.Direccion;
                    txtCiudad.Text = clienteExistente.Ciudad;
                    txtCP.Text = clienteExistente.CP.ToString();
                }
                else
                {
                    lblError.Text = "No se encontró ningún cliente con ese DNI. Por favor, ingrese sus datos.";
                    lblError.Visible = true;
                }

                formularioDatos.Visible = true;
            }
            else
            {
                lblError.Text = "Por favor, ingrese un DNI válido.";
                lblError.Visible = true;
            }
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ClienteNegocio negocio = new ClienteNegocio();

                Cliente nuevoCliente = new Cliente
                {
                    DNI = txtDNI.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Mail = txtEmail.Text,
                    Direccion = txtDireccion.Text,
                    Ciudad = txtCiudad.Text,
                    CP = int.Parse(txtCP.Text)
                };

                try
                {
                    negocio.AgregarCliente(nuevoCliente);
                    Response.Redirect("Exito.aspx?nombre=" + nuevoCliente.Nombre);
                }
                catch (Exception ex)
                {
                    string error = Server.UrlEncode(ex.Message);
                    Response.Redirect("ErrorPage.aspx?error=" + error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtCiudad.Text) ||
                string.IsNullOrEmpty(txtCP.Text))
            {
                lblError.Text = "Por favor, complete todos los campos.";
                lblError.Visible = true;
                return false;
            }
            return true;
        }
    }
}