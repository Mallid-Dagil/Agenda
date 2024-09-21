using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Daos
{
    internal class ProvinciaDAOS
    {
        public List<Provincia> ObtenerTodo()
        {
            ProvinciaMappers provinciaMappers = new ProvinciaMappers();
            return provinciaMappers.ObtenerTodo();
        }
    }
}
