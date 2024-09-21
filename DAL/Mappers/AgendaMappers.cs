using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class AgendaMappers
    {
        
        public List<Agenda> ObtenerTodo()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Agenda> ListaAgenda  = new List<Agenda>();

            try
            {
                datos.SetearConsulta("select intId id, varDescripcion NombreAgenda from Agenda");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Agenda aux = new Agenda();
                    aux.id = (int)datos.Lector["id"];
                    aux.nombreAgenda = (string)datos.Lector["NombreAgenda"];

                    ListaAgenda.Add(aux);
                }
                return ListaAgenda;
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
