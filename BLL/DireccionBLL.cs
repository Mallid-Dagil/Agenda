using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DireccionBLL : ICRUD<Direccion>
    {
        DireccionDAL direccionDAL = new DireccionDAL();

        private bool ExisteDireccion(Direccion nuevoDireccion)
        {
            var direcciones = direccionDAL.ObtenerTodo().Where(d =>
                d.calle.Equals(nuevoDireccion.calle, StringComparison.OrdinalIgnoreCase) &&
                d.altura == nuevoDireccion.altura &&
                d.piso.Equals(nuevoDireccion.piso, StringComparison.OrdinalIgnoreCase) &&
                d.departamento.Equals(nuevoDireccion.departamento, StringComparison.OrdinalIgnoreCase) &&
                d.pais.id == nuevoDireccion.pais.id &&
                d.provincia.id == nuevoDireccion.provincia.id &&
                d.localidad.id == nuevoDireccion.localidad.id &&
                d.contacto.id == nuevoDireccion.contacto.id);

            return direcciones.Any();
        }

        public void Agregar(Direccion agregar)
        {
            if (!ExisteDireccion(agregar))
            {
                direccionDAL.Agregar(agregar);
            }
            else
            {
                throw new Exception("esa direccion ya existe");
            }
               
        }

        public void Eliminar(Direccion Eliminar)
        {
            direccionDAL.Eliminar(Eliminar);
        }

        public void Modificar(Direccion modificar)
        {
            direccionDAL.Modificar(modificar);
        }

        public List<Direccion> ObtenerTodo()
        {
            return direccionDAL.ObtenerTodo();
        }

        public void EliminarDireccionPorCascada(int idContacto)
        {
            direccionDAL.EliminarDireccionPorCascada(idContacto);
        }

        public void EliminarDireccion(int idContacto)
        {
            direccionDAL.EliminarDireccion(idContacto);
        }
    }
}
