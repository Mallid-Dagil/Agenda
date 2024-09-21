using BE;
using DAL.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class TelefonoDAL : ICRUD<Telefono>
    {
        public void Agregar(Telefono agregar)
        {
            TelefonoDAOS telefonoDAOS = new TelefonoDAOS();
            telefonoDAOS.Agregar(agregar);
        }

        public void Eliminar(Telefono Eliminar)
        {
            TelefonoDAOS telefonoDAOS = new TelefonoDAOS();
            telefonoDAOS.Eliminar(Eliminar);
        }

        public void Modificar(Telefono modificar)
        {
            TelefonoDAOS telefonoDAOS = new TelefonoDAOS();
            telefonoDAOS.Modificar(modificar);
        }

        public List<Telefono> ObtenerTodo()
        {
            TelefonoDAOS telefonoDAOS = new TelefonoDAOS();
            return telefonoDAOS.ObtenerTodo();
        }

        public void EliminarTelefonoPorCascada(int idContacto)
        {
            TelefonoDAOS telefonoDAOS = new TelefonoDAOS();
            telefonoDAOS.EliminarTelefonoPorCascada(idContacto);
        }

        public void EliminarTelefono(int idContacto)
        {
            TelefonoDAOS telefonoDAOS= new TelefonoDAOS();
            telefonoDAOS.EliminarTelefono(idContacto);
        }
    }
}
