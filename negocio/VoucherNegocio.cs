using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VoucherNegocio
    {
        public Voucher listarVoucherByCodigo(string codigo)
        {
            
            AccesoDatos datos = new AccesoDatos();//hago la consulta a la base de datos
            string consulta = "select CodigoVoucher,IdCliente,FechaCanje,IdArticulo from vouchers where CodigoVoucher =@codigo";
            try
            {
                datos.setearConsulta(consulta);
                datos.setearParametro("@codigo", codigo);
                datos.ejecutarLectura();
                
                Voucher voucher = new Voucher();
                
                while (datos.Lector.Read())//si tiene algun dato lo recorro
                {
                    voucher.codigo = (string)datos.Lector["CodigoVoucher"];
                    
                    if(!(datos.Lector["IdCliente"] is DBNull))
                        voucher.idCliente = (int)datos.Lector["IdCliente"];
                    
                    if (!(datos.Lector["FechaCanje"] is DBNull))
                        voucher.fechaCanje = DateTime.Parse(datos.Lector["FechaCanje"].ToString());
                    
                    if (!(datos.Lector["IdArticulo"] is DBNull))
                        voucher.idArticulo = (int)datos.Lector["IdArticulo"];
                }

                return voucher;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
