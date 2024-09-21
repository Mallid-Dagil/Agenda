using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Mappers;

namespace DAL.Daos
{
    internal class ContactoDAOS : ICRUD<Contacto>
    {
        public void Agregar(Contacto agregar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into Contacto (varNombre, varSegundoNombre, varApellido, intIdAgenda) values (@Nombre, @SegundoNombre, @Apellido, @IdAgenda)");
                datos.SetearParametro("@Nombre", agregar.nombre);
                datos.SetearParametro("@SegundoNombre", agregar.segundoNombre);
                datos.SetearParametro("@Apellido", agregar.Apellido);
                datos.SetearParametro("@IdAgenda", agregar.agenda.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(Contacto Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from Contacto where intId = @id");
                datos.SetearParametro("@id", Eliminar.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificar(Contacto modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update Contacto set varNombre = @Nombre, varSegundoNombre = @SegundoNombre, varApellido = @Apellido where intId = @Id");
                datos.SetearParametro("@id", modificar.id);
                datos.SetearParametro("@Nombre", modificar.nombre);
                datos.SetearParametro("@SegundoNombre", modificar.segundoNombre);
                datos.SetearParametro("@Apellido", modificar.Apellido);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Contacto> ObtenerTodo()
        {
            ContactoMappers contactoMappers = new ContactoMappers();
            return contactoMappers.ObtenerTodo();
        }

        public void EliminarContactoPorCascada(int idAgenda)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM Contacto WHERE intIdAgenda = @AgendaId;");
                datos.SetearParametro("@AgendaId", idAgenda);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
