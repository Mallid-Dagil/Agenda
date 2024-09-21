using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TelefonoBLL : ICRUD<Telefono>
    {
        private bool ExisteTelefono(Telefono nuevoTelefono)
        {
            TelefonoDAL telefonoDAL = new TelefonoDAL();
            var telefonos = telefonoDAL.ObtenerTodo().Where(t =>
                t.NumeroContacto.Equals(nuevoTelefono.NumeroContacto, StringComparison.OrdinalIgnoreCase)
            );

            foreach (var item in telefonos)
            {
                if (item.contacto.id == nuevoTelefono.contacto.id)
                {
                    return true;
                }
            }

            return false;
        }
        public void Agregar(Telefono agregar)
        {
            TelefonoDAL telefonoDAL = new TelefonoDAL();
            if (!ExisteTelefono(agregar))
            {
                telefonoDAL.Agregar(agregar);
            }
            else
            {
                throw new Exception($"El numero de telefono {agregar.contacto.Apellido}. Ya existe");
            }
            
        }

        public void Eliminar(Telefono Eliminar)
        {
            TelefonoDAL telefonoDAL = new TelefonoDAL();
            telefonoDAL.Eliminar(Eliminar);
        }

        public void Modificar(Telefono modificar)
        {
            TelefonoDAL telefonoDAL = new TelefonoDAL();
            telefonoDAL.Modificar(modificar);
        }

        public List<Telefono> ObtenerTodo()
        {
            TelefonoDAL telefonoDAL = new TelefonoDAL();
            return telefonoDAL.ObtenerTodo();
        }

        public void EliminarTelefonoPorCascada(int idContacto)
        {
            TelefonoDAL telefonoDAL = new TelefonoDAL();
            telefonoDAL.EliminarTelefonoPorCascada(idContacto);
        }

        public void EliminarTelefono(int idContacto)
        {
            TelefonoDAL telefonoDAL = new TelefonoDAL();
            telefonoDAL.EliminarTelefono(idContacto);
        }

    }
}
