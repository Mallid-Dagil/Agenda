using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LocalidadBLL
    {
        public List<Localidad> ObtenerTodo()
        {
            LocalidadDAL localidadDAL = new LocalidadDAL();
            return localidadDAL.ObtenerTodo();
        }

        public List<Localidad> LocalidadFiltrado(int LocalidadId)
        {
            List<Localidad> localidadFiltrada = ObtenerTodo().Where(localidad => localidad.provincia.id == LocalidadId).ToList();
            return localidadFiltrada;
        }
    }
}
