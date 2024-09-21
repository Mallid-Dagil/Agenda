using BE;
using DAL.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContactoDAL : ICRUD<Contacto>
    {
        ContactoDAOS contactoDAOS = new ContactoDAOS();
        public void Agregar(Contacto agregar)
        {
            contactoDAOS.Agregar(agregar);
        }

        public void Eliminar(Contacto Eliminar)
        {
            contactoDAOS.Eliminar(Eliminar);
        }

        public void Modificar(Contacto modificar)
        {
            contactoDAOS.Modificar(modificar);
        }

        public List<Contacto> ObtenerTodo()
        {
            return contactoDAOS.ObtenerTodo();
        }

        public void EliminarContactoPorCascada(int idAgenda)
        {
            contactoDAOS.EliminarContactoPorCascada(idAgenda);
        }
    }
}
