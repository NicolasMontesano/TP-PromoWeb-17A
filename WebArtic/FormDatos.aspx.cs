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

                ClienteNegocio negocio = new ClienteNegocio();
                try
                {
                    Voucher voucher = new Voucher();

                    string sIdArticulo = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";

                    if (sIdArticulo != "" && !String.IsNullOrEmpty(Session["voucher"].ToString()))
                    {
                        voucher.codigo = Session["voucher"].ToString();
                        voucher.idArticulo = Convert.ToInt32(sIdArticulo);
                        
                        if (!negocio.ExisteClientePorDNI(nuevoCliente.DNI))
                        {
                            negocio.AgregarCliente(nuevoCliente);
                        }

                        int idCliente = negocio.ObtenerClientePorDNI(nuevoCliente.DNI).ID;

                        voucher.idCliente = idCliente;
                        voucher.fechaCanje = DateTime.Now;

                        VoucherNegocio voucherNegocio = new VoucherNegocio();
                        voucherNegocio.ActualizarVoucher(voucher);

                        Response.Redirect("Exito.aspx?nombre=" + nuevoCliente.Nombre, false);
                    }
                    else//error falta idArticulo
                    {

                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message + "<br />" + ex.StackTrace);
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
