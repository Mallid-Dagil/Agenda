using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.xml;

namespace BLL.xml
{
    public class xmlBLL
    {
        xmlDAL xmlDAL = new xmlDAL();
        public void EscribirArchivoTexto(string path, string contenido)
        {
            xmlDAL.EscribirArchivoTexto(path, contenido);
        }

        public string LeerArchivoTexto(string path)
        {
            return xmlDAL.LeerArchivoTexto(path);
        }

        public void EscribirArchivoXml<T>(string path, T objeto)
        {
            xmlDAL.EscribirArchivoXml(path, objeto);
        }

        public T LeerArchivoXml<T>(string path)
        {
            return xmlDAL.LeerArchivoXml<T>(path);
        }
    }
}
