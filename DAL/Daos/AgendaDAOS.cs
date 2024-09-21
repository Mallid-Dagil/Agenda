using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL.Mappers;

namespace DAL.Daos
{
    internal class AgendaDAOS : ICRUD<Agenda>
    {
        
        public void Agregar(Agenda agregar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into Agenda (varDescripcion) values (@NombreAgenda)");
                datos.SetearParametro("@NombreAgenda", agregar.nombreAgenda);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(Agenda Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from Agenda where intId = @id");
                datos.SetearParametro("@id", Eliminar.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificar(Agenda modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update Agenda set varDescripcion = @NombreAgenda where intId = @id");
                datos.SetearParametro("@id", modificar.id);
                datos.SetearParametro("@NombreAgenda", modificar.nombreAgenda);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Agenda> ObtenerTodo()
        {
            AgendaMappers agendaMappers = new AgendaMappers();
            return agendaMappers.ObtenerTodo();
        }
    }
}
