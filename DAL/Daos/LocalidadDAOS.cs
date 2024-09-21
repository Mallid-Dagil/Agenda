using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Daos
{
    internal class LocalidadDAOS
    {
        public List<Localidad> ObtenerTodo()
        {
            LocalidadMappers localidadMappers = new LocalidadMappers();
            return localidadMappers.ObtenerTodo();
        }
    }
}
