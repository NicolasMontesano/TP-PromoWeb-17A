using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArtic
{
    public partial class FormDatos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnParticipar_Click(object sender, EventArgs e)
        {
          /*  string dni = txtDNI.Text; 
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = $"{txtEmail.Text}@{txtEmailDomain.Text}";
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            string cp = txtCP.Text;*/
            bool aceptarTerminos = chkAceptar.Checked;

            if (!aceptarTerminos)
            {
                Response.Write("<script>alert('Debe aceptar los términos y condiciones.');</script>");
            }
            else
            {
                Response.Write("<script>alert('Datos enviados correctamente.');</script>");
            }
        }

    }
}