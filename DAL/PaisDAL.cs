using BE;
using DAL.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaisDAL
    {
        public List<Pais> ObtenerTodo()
        {
            PaisDAOS paisDAOS = new PaisDAOS();
            return paisDAOS.ObtenerTodo();
        }
    }
}
