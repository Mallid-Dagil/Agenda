using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class LocalidadMappers
    {
        public List<Localidad> ObtenerTodo()
        {
            List<Localidad> listaLocalidad = new List<Localidad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT L.intId as IdLocalidad, L.intIdPais as IdPais, L.intIdProvincia as IdProvincia, L.varDescripcion as NombreLocalidad, PR.varDescripcion as NombreProvincia, P.varDescripcion as NombrePais FROM Localidad L INNER JOIN Provincia PR ON PR.intId = L.intIdProvincia INNER JOIN Pais P ON P.intId = L.intIdPais");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Localidad aux = new Localidad();
                    aux.id = (int)datos.Lector["IdLocalidad"];
                    aux.nombre = (string)datos.Lector["NombreLocalidad"];
                    aux.pais = new Pais();
                    aux.pais.id = (int)datos.Lector["IdPais"];
                    aux.pais.nombre = (string)datos.Lector["NombrePais"];
                    aux.provincia = new Provincia();
                    aux.provincia.id = (int)datos.Lector["IdProvincia"];
                    aux.provincia.nombre = (string)datos.Lector["NombreProvincia"];
                    listaLocalidad.Add(aux);
                }

                return listaLocalidad;
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
