using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Daos
{
    internal class TelefonoTipoDAOS
    {
        public List<TelefonoTipo> ObtenerTodo()
        {
            try
            {
                TelefonoTipoMappers telefonoTipoMappers = new TelefonoTipoMappers();
                return telefonoTipoMappers.ObtenerTodo();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
