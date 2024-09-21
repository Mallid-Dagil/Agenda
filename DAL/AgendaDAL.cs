using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Daos;

namespace DAL
{
    public class AgendaDAL : ICRUD<Agenda>
    {
        AgendaDAOS agendaDAOS = new AgendaDAOS();
        public void Agregar(Agenda agregar)
        {
            agendaDAOS.Agregar(agregar);
        }

        public void Eliminar(Agenda Eliminar)
        {
            agendaDAOS.Eliminar(Eliminar);
        }

        public void Modificar(Agenda modificar)
        {
            agendaDAOS.Modificar(modificar);
        }

        public List<Agenda> ObtenerTodo()
        {
            return agendaDAOS.ObtenerTodo();
        }
    }
}
