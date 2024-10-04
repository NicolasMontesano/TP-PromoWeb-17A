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
        public bool ExisteClientePorDNI(string dni)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Clientes WHERE Documento = @DNI");
                datos.setearParametro("@DNI", dni);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int count = (int)datos.Lector[0];
                    return count > 0; 
                }
                else
                {
                    return false; 
                }
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


        public Cliente ObtenerClientePorDNI(string dni)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes WHERE Documento = @DNI");
                datos.setearParametro("@DNI", dni);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        DNI = (string)datos.Lector["Documento"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Apellido = (string)datos.Lector["Apellido"],
                        Mail = (string)datos.Lector["Email"],
                        Direccion = (string)datos.Lector["Direccion"],
                        Ciudad = (string)datos.Lector["Ciudad"],
                        CP = (int)datos.Lector["CP"]
                    };
                    return cliente;
                }
                return null;
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
