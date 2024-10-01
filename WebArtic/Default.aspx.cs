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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            string codigo = "";
            codigo = txtvoucher.Text;

            if (!String.IsNullOrEmpty(codigo))
            {
                VoucherNegocio negocio = new VoucherNegocio();
                
                Voucher voucher = null;

                try
                {
                    voucher = negocio.listarVoucherByCodigo(codigo);
                }
                catch (Exception ex)
                {
                    //error bd
                }

                if(voucher.codigo != null) //existe voucher
                {
                    DateTime fecha = new DateTime();
                    
                    if(!(voucher.idCliente > 0 && voucher.idArticulo > 0 && voucher.fechaCanje != fecha)) //no se utilizó aún
                    {
                        Session.Add("voucher", voucher); //envío el voucher por session y lo recuperamos desde las demás páginas
                        Response.Redirect("ListaArticulos.aspx");
                    }
                    else //voucher utilizado
                    {
                        //redirigir a pagina de error
                    }
                }
                else //voucher equivocado
                {
                    //redirigir a pagina de error
                }
            }
            else
            {
                //redirigir o dar mensaje de error
            }
        }
    }
}