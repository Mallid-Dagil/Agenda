using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Direccion
    {
        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Pais")]
        public Pais pais { get; set; } = new Pais();

        [DisplayName("Provincia")]
        public Provincia provincia { get; set; } = new Provincia();

        [DisplayName("Calle")]
        public string calle { get; set; }

        [DisplayName("Altura")]
        public int altura { get; set; }

        [DisplayName("Piso")]
        public string piso { get; set; }

        [DisplayName("Departamento")]
        public string departamento { get; set; }

        [DisplayName("Localidad")]
        public Localidad localidad { get; set; } = new Localidad();

        [DisplayName("Contacto")]
        public Contacto contacto { get; set; } = new Contacto();


    }
}
