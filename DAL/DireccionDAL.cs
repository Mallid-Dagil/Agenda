using BE;
using DAL.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DireccionDAL : ICRUD<Direccion>
    {
        DireccionDAOS direccionDAOS = new DireccionDAOS();
        public void Agregar(Direccion agregar)
        {
            direccionDAOS.Agregar(agregar);
        }

        public void Eliminar(Direccion Eliminar)
        {
            direccionDAOS.Eliminar(Eliminar);
        }

        public void Modificar(Direccion modificar)
        {
            direccionDAOS.Modificar(modificar);
        }

        public List<Direccion> ObtenerTodo()
        {
            return direccionDAOS.ObtenerTodo();
        }

        public void EliminarDireccionPorCascada(int idContacto)
        {
            direccionDAOS.EliminarDireccionPorCascada(idContacto);
        }

        public void EliminarDireccion(int idContacto)
        {
            direccionDAOS.EliminarDireccion(idContacto);
        }
    }
}
