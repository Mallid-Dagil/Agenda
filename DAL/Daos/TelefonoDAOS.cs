using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Daos
{
    internal class TelefonoDAOS : ICRUD<Telefono>
    {
        public void Agregar(Telefono agregar)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("insert into Telefono (intIdTipo, varNumero, intIdContacto) values (@idTipo, @Numero, @idContacto)");
            datos.SetearParametro("@idTipo", agregar.telefonoTipo.id);
            datos.SetearParametro("@Numero", agregar.NumeroContacto);
            datos.SetearParametro("@idContacto", agregar.contacto.id);
            datos.ejecutarAccion();
        }

        public void Eliminar(Telefono Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("delete from Telefono where intId = @id");
            datos.SetearParametro("@id", Eliminar.id);
            datos.ejecutarAccion();
        }

        public void Modificar(Telefono modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("update Telefono set intIdTipo = @idTipo, varNumero = @Numero, intIdContacto = @idContacto where intId = @Id");
            datos.SetearParametro("@Id", modificar.id);
            datos.SetearParametro("@idTipo", modificar.telefonoTipo.id);
            datos.SetearParametro("@Numero", modificar.NumeroContacto);
            datos.SetearParametro("@idContacto", modificar.contacto.id);
            datos.ejecutarAccion();
        }

        public List<Telefono> ObtenerTodo()
        {
            TelefonoMappers telefonoMappers = new TelefonoMappers();
            return telefonoMappers.ObtenerTodo();
        }

        public void EliminarTelefonoPorCascada(int idcontacto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM Telefono WHERE intIdContacto IN (SELECT intId FROM Contacto WHERE intIdContacto = @ContactoId)");
                datos.SetearParametro("@ContactoId", idcontacto);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarTelefono(int idContacto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM Telefono WHERE intIdContacto = @ContactoId;");
                datos.SetearParametro("@ContactoId", idContacto);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
