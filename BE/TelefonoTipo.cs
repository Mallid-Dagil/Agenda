﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TelefonoTipo
    {
        public int id { get; set; }

        public string Tipo { get; set; }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
