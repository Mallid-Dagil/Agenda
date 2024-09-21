using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class AgendaBLL : ICRUD<Agenda>
    {
        AgendaDAL agendaDAL = new AgendaDAL();
        private bool ExisteAgenda(Agenda nuevaAgenda)
        {
            return agendaDAL.ObtenerTodo().Any(a => a.nombreAgenda.Equals(nuevaAgenda.nombreAgenda, StringComparison.OrdinalIgnoreCase));
        }
        public void Agregar(Agenda agregar)
        {
            
            if(!ExisteAgenda(agregar))
            {
                agendaDAL.Agregar(agregar);
            }
            else
            {
                throw new Exception($"La agenda {agregar}, ya existe.");
            }
            
        }

        public void Eliminar(Agenda Eliminar)
        {
            agendaDAL.Eliminar(Eliminar);
        }

        public void Modificar(Agenda modificar)
        {
            agendaDAL.Modificar(modificar);
        }

        public List<Agenda> ObtenerTodo()
        {
            return agendaDAL.ObtenerTodo();
        }

    }
}
