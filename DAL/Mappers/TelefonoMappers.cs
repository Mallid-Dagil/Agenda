using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class TelefonoMappers
    {
        public List<Telefono> ObtenerTodo()
        {
            List<Telefono> listaTelefono = new List<Telefono>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select T.intId id, T.intIdTipo IdTipo, T.varNumero Numero, I.varDescripcion Tipo, C.intId idcontacto, C.varApellido Apellido from Telefono T, TelefonoTipo I, Contacto C where T.intIdTipo = I.intId and T.intIdContacto = C.intId");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Telefono aux = new Telefono();
                    aux.id = (int)datos.Lector["id"];
                    aux.telefonoTipo = new TelefonoTipo();
                    aux.telefonoTipo.id = (int)datos.Lector["IdTipo"];
                    aux.NumeroContacto = (string)datos.Lector["Numero"];
                    aux.telefonoTipo.Tipo = (string)datos.Lector["Tipo"];
                    aux.contacto = new Contacto();
                    aux.contacto.id = (int)datos.Lector["idcontacto"];
                    aux.contacto.Apellido = (string)datos.Lector["Apellido"];

                    listaTelefono.Add(aux);
                }

                return listaTelefono;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
