using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Helpers
{
    internal class XmlHelpers
    {
        public void EscribirArchivoTexto(string path, string contenido)
        {
            try
            {
                File.WriteAllText(path, contenido);
                Console.WriteLine("Archivo de texto valido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Archivo de texto no valido: {ex.Message}");
            }
        }

        public string LeerArchivoTexto(string path)
        {
            try
            {
                string contenido = File.ReadAllText(path);
                Console.WriteLine("Archivo de texto valdio.");
                return contenido;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Archivo de texto no valido: {ex.Message}");
                return null;
            }
        }

        public void EscribirArchivoXml<T>(string path, T objeto)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(path))
                {
                    serializer.Serialize(writer, objeto);
                }

                Console.WriteLine("Archivo XML valdio.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Archivo XML no valdio: {ex.Message}");
            }
        }

        public T LeerArchivoXml<T>(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(path))
                {
                    T objeto = (T)serializer.Deserialize(reader);
                    Console.WriteLine("Archivo XML valdio.");
                    return objeto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Archivo XML no valdio: {ex.Message}");
                return default(T);
            }
        }
    }
}
