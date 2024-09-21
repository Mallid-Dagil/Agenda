using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Provincia
    {
        public int id { get; set; }
        public Pais pais { get; set; }
        public string nombre { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
