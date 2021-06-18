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

        /// <summary>
        /// Constructor con la ruta básica.
        /// </summary>
        public Xml()
        {
            pathBase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RusApp\";
        }
        /// <summary>
        /// Exporta en xml los datos que entran por parámetro.
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Importa los datos en xml que encuentra en la ruta que entra por parámetro.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Importar(string ruta, out T datos)
        {
            bool retorno = false;
            datos = default;

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

