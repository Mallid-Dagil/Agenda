﻿using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TelefonoTipoBLL
    {
        public List<TelefonoTipo> ObtenerTodo()
        {
            TelefonoTipoDAL telefonoTipoDAL = new TelefonoTipoDAL();
            return telefonoTipoDAL.ObtenerTodo();
        }
    }
}
