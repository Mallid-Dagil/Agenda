using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProvinciaBLL
    {
        public List<Provincia> ObtenerTodo()
        {
            ProvinciaDAL provinciaDAL = new ProvinciaDAL();
            return provinciaDAL.ObtenerTodo();
        }

        public List<Provincia> ContactoFiltrado(int provinciaID)
        {
            List<Provincia> ProvinciaFiltrada = ObtenerTodo().Where(provincia => provincia.pais.id == provinciaID).ToList();
            return ProvinciaFiltrada;
        }
    }
}
