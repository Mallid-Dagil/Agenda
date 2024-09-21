using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class PaisMappers
    {
        public List<Pais> ObtenerTodo()
        {
            List<Pais> listaPais = new List<Pais>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select intId, varDescripcion from Pais");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Pais aux = new Pais();
                    aux.id = (int)datos.Lector["intId"];
                    aux.nombre = (string)datos.Lector["varDescripcion"];

                    listaPais.Add(aux);
                }

                return listaPais;
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
