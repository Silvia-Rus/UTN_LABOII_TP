using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Serializador
{
    public class Xml<T> : IArchivoImportableExportable<T>
    {

        readonly string pathBase;

        public Xml()
        {
            pathBase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RusApp\";
        }

        public bool Exportar(T datos)
        {
            bool retorno = false;
            string pathArchivo = pathBase + @"\ExportXml\";

            try
            {

                if (!Directory.Exists(pathArchivo))
                {
                    Directory.CreateDirectory(pathArchivo);
                }

                pathArchivo += @"ExportXml_" + DateTime.Now.ToString("yyyy-MM-dd_H-m-ss") + ".xml";

                if (pathArchivo != null)
                {
                    using (XmlTextWriter auxWriter = new XmlTextWriter(pathArchivo, Encoding.UTF8))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        nuevoXml.Serialize(auxWriter, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error al querer Guardar el archivo: {pathArchivo}.");
            }
            return retorno;
        }

        public bool Importar(string ruta, out T datos)
        {
            bool retorno = false;
            datos = default;
            string pathArchivo = pathBase + @"\ImportXML\";
            try
            {
                if (ruta != null)
                {
                    using (XmlTextReader auxReader = new XmlTextReader(ruta))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        datos = (T)nuevoXml.Deserialize(auxReader);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error al querer Leer el achivo desde el archivo: {ruta}.");
            }
            return retorno;
        }
    }
}

