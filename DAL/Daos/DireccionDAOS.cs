using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Daos
{
    internal class DireccionDAOS : ICRUD<Direccion>
    {
        public void Agregar(Direccion agregar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into Direccion (intIdPais, intIdProvincia, varCalle, varAltura, varPiso, varDepartmento, intIdLocalidad, intIdContacto) values (@idpais, @idprovincia, @calle, @altura, @Piso, @departamento, @idlocalidad, @idcontacto)");
                datos.SetearParametro("@idpais", agregar.pais.id);
                datos.SetearParametro("@idprovincia", agregar.provincia.id);
                datos.SetearParametro("@calle", agregar.calle);
                datos.SetearParametro("@altura", agregar.altura);
                datos.SetearParametro("@Piso", agregar.piso);
                datos.SetearParametro("@departamento", agregar.departamento);
                datos.SetearParametro("@idlocalidad", agregar.localidad.id);
                datos.SetearParametro("@idcontacto", agregar.contacto.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(Direccion Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from Direccion where intId = @id");
                datos.SetearParametro("@id", Eliminar.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Modificar(Direccion modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update Direccion set intIdPais = @idPais, intIdProvincia = @idProvincia, varCalle = @Calle, varAltura = @Altura, varPiso = @Piso, varDepartmento = @Departamento, intIdLocalidad = @idLocalidad, intIdContacto = @idcontacto where intId = @id");
                datos.SetearParametro("@id", modificar.id);
                datos.SetearParametro("@idPais", modificar.pais.id);
                datos.SetearParametro("@idProvincia", modificar.provincia.id);
                datos.SetearParametro("@Calle", modificar.calle);
                datos.SetearParametro("@Altura", modificar.altura);
                datos.SetearParametro("@Piso", modificar.piso);
                datos.SetearParametro("@Departamento", modificar.departamento);
                datos.SetearParametro("@idLocalidad", modificar.localidad.id);
                datos.SetearParametro("@idcontacto", modificar.contacto.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Direccion> ObtenerTodo()
        {
            DireccionMappers direccionMappers = new DireccionMappers();
            return direccionMappers.ObtenerTodo();
        }

        public void EliminarDireccionPorCascada(int idcontacto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM Direccion WHERE intIdContacto IN (SELECT intId FROM Contacto WHERE intIdContacto = @ContactoId);");
                datos.SetearParametro("@ContactoId", idcontacto);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarDireccion(int idContacto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM Direccion WHERE intIdContacto = @ContactoId;");
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
