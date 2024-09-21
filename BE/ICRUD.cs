using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICRUD<T>
    {
        List<T> ObtenerTodo();
        void Agregar(T agregar);
        void Modificar(T modificar);
        void Eliminar(T Eliminar);
    }
}
