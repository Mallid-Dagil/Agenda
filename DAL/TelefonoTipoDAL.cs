using BE;
using DAL.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TelefonoTipoDAL
    {
        public List<TelefonoTipo> ObtenerTodo()
        {
            TelefonoTipoDAOS telefonoTipoDAOS = new TelefonoTipoDAOS();
            return telefonoTipoDAOS.ObtenerTodo();
        }
    }
}
