using BE;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.xml
{
    public class xmlDAL 
    {
        XmlHelpers xmlHelpers = new XmlHelpers();
        public void EscribirArchivoTexto(string path, string contenido)
        {
            xmlHelpers.EscribirArchivoTexto(path, contenido);
        }

        public string LeerArchivoTexto(string path)
        {
            return xmlHelpers.LeerArchivoTexto(path);
        }

        public void EscribirArchivoXml<T>(string path, T objeto)
        {
            xmlHelpers.EscribirArchivoXml(path, objeto);
        }

        public T LeerArchivoXml<T>(string path)
        {
            return xmlHelpers.LeerArchivoXml<T>(path);
        }
    }
}
