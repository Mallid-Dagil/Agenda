using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Telefono
    {
        public int id { get; set; }
        [DisplayName("Tipo de Telefono")]

        public TelefonoTipo telefonoTipo { get; set; }
        [DisplayName("Contacto")]

        public Contacto contacto { get; set; }

        [DisplayName("Numero de Contacto")]
        public string NumeroContacto { get; set; }
    }
}
