using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class TelefonoTipoMappers
    {
        public List<TelefonoTipo> ObtenerTodo()
        {
            List<TelefonoTipo> listaTelefonoTipo = new List<TelefonoTipo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select intId, varDescripcion Tipo from TelefonoTipo");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    TelefonoTipo aux = new TelefonoTipo();
                    aux.id = (int)datos.Lector["intId"];
                    aux.Tipo = (string)datos.Lector["Tipo"];

                    listaTelefonoTipo.Add(aux);
                }

                return listaTelefonoTipo;
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
