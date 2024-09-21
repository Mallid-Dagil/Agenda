using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class DireccionMappers
    {
        public List<Direccion> ObtenerTodo()
        {
            List<Direccion> listaDireccion = new List<Direccion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select D.intId id, P.varDescripcion Pais, P.intId idpais, B.intIdPais idprovincia, B.varDescripcion Provincia, D.varCalle Calle, D.varAltura Altura, D.varPiso Piso, D.varDepartmento Departamento, L.intIdProvincia idlugar, L.varDescripcion Lugar, C.intId idcontacto, C.varApellido Apellido from Direccion D, Pais P, Provincia B, Localidad L, Contacto C where D.intIdPais = P.intId and D.intIdProvincia = B.intId and D.intIdLocalidad = L.intId and D.intIdContacto = C.intId");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Direccion aux = new Direccion();
                    aux.id = (int)datos.Lector["id"];
                    aux.pais = new Pais();
                    aux.pais.id = (int)datos.Lector["idpais"];
                    aux.pais.nombre = (string)datos.Lector["Pais"];
                    aux.provincia = new Provincia();
                    aux.provincia.id = (int)datos.Lector["idprovincia"];
                    aux.provincia.nombre = (string)datos.Lector["Provincia"];
                    aux.calle = (string)datos.Lector["Calle"];
                    aux.altura = (int)datos.Lector["Altura"];

                    if (!(datos.Lector["Piso"] is DBNull))
                    {
                        aux.piso = (string)datos.Lector["Piso"];
                    }

                    if (!(datos.Lector["Departamento"] is DBNull))
                    {
                        aux.departamento = (string)datos.Lector["Departamento"];
                    }

                    aux.localidad = new Localidad();
                    aux.localidad.id = (int)datos.Lector["idlugar"];
                    aux.localidad.nombre = (string)datos.Lector["Lugar"];
                    aux.contacto = new Contacto();
                    aux.contacto.id = (int)datos.Lector["idcontacto"];
                    aux.contacto.Apellido = (string)datos.Lector["Apellido"];

                    listaDireccion.Add(aux);
                }
                return listaDireccion;
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
