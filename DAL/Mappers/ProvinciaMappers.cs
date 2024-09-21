using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class ProvinciaMappers
    {
        public List<Provincia> ObtenerTodo()
        {
            List<Provincia> ListaProvincias = new List<Provincia>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT P.intId AS idPais, P.varDescripcion AS NombrePais, PR.intId AS IdProvincia, PR.intIdPais AS PaisId, PR.varDescripcion AS NombreProvincia FROM Pais P INNER JOIN Provincia PR ON P.intId = PR.intIdPais");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Provincia aux = new Provincia();
                    aux.pais = new Pais();
                    aux.pais.id = (int)datos.Lector["idPais"];
                    aux.pais.nombre = (string)datos.Lector["NombrePais"];
                    aux.id = (int)datos.Lector["IdProvincia"];
                    aux.nombre = (string)datos.Lector["NombreProvincia"];
                    ListaProvincias.Add(aux);
                }

                return ListaProvincias;
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
