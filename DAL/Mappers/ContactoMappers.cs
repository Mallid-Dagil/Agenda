using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class ContactoMappers 
    {
        public List<Contacto> ObtenerTodo()
        {
            List<Contacto> listaContacto = new List<Contacto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select C.intId id, C.varNombre Nombre, C.varSegundoNombre SegundoNombre, C.varApellido Apellido, A.intId idAgenda, A.varDescripcion Agenda from Contacto C, Agenda A where C.intIdAgenda = A.intId");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Contacto aux = new Contacto();
                    aux.id = (int)datos.Lector["id"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.segundoNombre = (string)datos.Lector["SegundoNombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.agenda = new Agenda();
                    aux.agenda.id = (int)datos.Lector["idAgenda"];
                    aux.agenda.nombreAgenda = (string)datos.Lector["Agenda"];
                    listaContacto.Add(aux);
                }
                return listaContacto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
