using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contacto
    {
        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Segundo Nombre")]
        public string segundoNombre { get; set; }

        [DisplayName("Apellido")]
        public string Apellido { get; set; }

        [DisplayName("Agenda")]
        public Agenda agenda { get; set; }

        public int AgendaId
        {
            get { return agenda != null ? agenda.id : 0; }
            set
            {
                if (agenda == null)
                {
                    agenda = new Agenda();
                }
                agenda.id = value;
            }
        }


        public override string ToString()
        {
            return Apellido;
        }
    }
}
