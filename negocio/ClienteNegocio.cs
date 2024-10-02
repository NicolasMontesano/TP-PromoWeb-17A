using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ClienteNegocio
    {
        public void AgregarCliente(Cliente nuevoCliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                                     "VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");

                datos.setearParametro("@Documento", nuevoCliente.DNI);
                datos.setearParametro("@Nombre", nuevoCliente.Nombre);
                datos.setearParametro("@Apellido", nuevoCliente.Apellido);
                datos.setearParametro("@Email", nuevoCliente.Mail);
                datos.setearParametro("@Direccion", nuevoCliente.Direccion);
                datos.setearParametro("@Ciudad", nuevoCliente.Ciudad);
                datos.setearParametro("@CP", nuevoCliente.CP);

                datos.ejecutarAccion();
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
