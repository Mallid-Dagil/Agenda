using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Daos
{
    internal class PaisDAOS
    {
        public List<Pais> ObtenerTodo()
        {
            PaisMappers paisMappers = new PaisMappers();
            return paisMappers.ObtenerTodo();
        }
    }
}
