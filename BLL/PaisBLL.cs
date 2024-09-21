using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaisBLL
    {
        public List<Pais> ObtenerTodo()
        {
            PaisDAL paisDAL = new PaisDAL();
            return paisDAL.ObtenerTodo();
        }
        //public List<Pais> ContactoFiltrado(int paisId)
        //{
        //    List<Pais> paisFiltrado = ObtenerTodo().Where(pais => pais.id == paisId).ToList();
        //    return paisFiltrado;
        //}
    }
}
