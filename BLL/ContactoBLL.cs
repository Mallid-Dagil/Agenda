using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContactoBLL : ICRUD<Contacto>
    {
        ContactoDAL contactoDAL = new ContactoDAL();

        private bool ExisteContacto(Contacto nuevoContacto)
        {
            var contactosExistentes = contactoDAL.ObtenerTodo().Where(c => 
            c.nombre.Equals(nuevoContacto.nombre, StringComparison.OrdinalIgnoreCase) &&
            c.segundoNombre.Equals(nuevoContacto.segundoNombre, StringComparison.OrdinalIgnoreCase) &&
            c.Apellido.Equals(nuevoContacto.Apellido, StringComparison.OrdinalIgnoreCase)
            );

            foreach ( var contactos in contactosExistentes)
            {
                if(contactos.agenda.id == nuevoContacto.agenda.id)
                {
                    return true;
                }
            }
            return false;
        }

        public void Agregar(Contacto agregar)
        {
            if (!ExisteContacto(agregar))
            {
                contactoDAL.Agregar(agregar);
            }
            else
            {
                throw new Exception($"El contactos {agregar.nombre}, {agregar.Apellido}. Ya existe");
            }

                
        }

        public void Eliminar(Contacto Eliminar)
        {
            contactoDAL.Eliminar(Eliminar);
        }

        public void Modificar(Contacto modificar)
        {
            contactoDAL.Modificar(modificar);
        }

        public List<Contacto> ObtenerTodo()
        {
            return contactoDAL.ObtenerTodo();
        }

        public List<Contacto> ContactoFiltrado(int agendaid)
        {
            List<Contacto> contactoFiltrado = ObtenerTodo().Where(contacto => contacto.agenda.id == agendaid).ToList();
            return contactoFiltrado;
        }

        public void EliminarContactoPorCascada(int idAgenda)
        {
            contactoDAL.EliminarContactoPorCascada(idAgenda);
        }
    }
}
