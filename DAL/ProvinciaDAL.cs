using BE;
using DAL.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProvinciaDAL
    {
        public List<Provincia> ObtenerTodo()
        {
            ProvinciaDAOS provinciaDAOS = new ProvinciaDAOS();
            return provinciaDAOS.ObtenerTodo();
        }
    }
}
