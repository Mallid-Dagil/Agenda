using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Agenda
    {
        public delegate void CantidadContactosDelegate(Contacto contacto);
        public event CantidadContactosDelegate CantidadContactosEvento;

        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Nombre Agenda")]
        public string nombreAgenda { get; set; }


        //public Contacto contacto { get; set; }

        public override string ToString()
        {
            return nombreAgenda;
        }
    }
}
