using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Daos;

namespace DAL
{
    public class LocalidadDAL
    {
        public List<Localidad> ObtenerTodo()
        {
            LocalidadDAOS localidadDAOS = new LocalidadDAOS();
            return localidadDAOS.ObtenerTodo();
        }
    }
}
