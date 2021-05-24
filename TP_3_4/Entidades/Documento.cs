using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Documento
    {
        private string titulo;
        private string autor;
        private short anio;
        private short numeroPaginas;
        private string id;
        private int barcode;
        private string notas;
        private Encuadernacion estadoEncuadernacion;
        private PasosProceso pasoProceso;

        /// <summary>
        /// Propiedad que devuelve el tipo de documento.
        /// </summary>
        string TipoDeDocumento
        {
            get
            {
                return this.GetType().ToString();
            }
        }
        public Encuadernacion EstadoEncuadernacion
        {
            get
            {
                return this.estadoEncuadernacion;
            }
        }
        public PasosProceso FaseProceso
        {
            set
            {
                FaseProceso = value;
            }
            get
            {
                return this.FaseProceso;
            }
        }

        /// <summary>
        /// Constructor por defecto. Asigna el primer paso del proceso (introducido).
        /// </summary>
        public Documento()
        {
            this.pasoProceso = PasosProceso.introducido;
        }
        /// <summary>
        /// Constructor del documento. 
        /// </summary>
        /// <param name="titulo">Título a asignar.</param>
        /// <param name="autor">Autor a asignar.</param>
        /// <param name="anio">Año a asignar.</param>
        /// <param name="numeroPaginas">Número de páginas a asignar.</param>
        /// <param name="id">Id del documento.</param>
        /// <param name="barcode">Código de barras del documento.</param>
        /// <param name="estadoEncuadernacion">Estado de encuadernación.</param>
        public Documento(string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, 
                         Encuadernacion estadoEncuadernacion) 
            : this()
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numeroPaginas = numeroPaginas;
            this.id = id;
            this.barcode = barcode;
            this.estadoEncuadernacion = estadoEncuadernacion;
        }

        /*public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Título: {this.titulo}. Autor: {this.autor}. Año de publicación: {this.anio}.  " +
                          $"Identificador único: {this.id}. Código de barras: {this.barcode}" +
                          $"Tipo de documento: {this.tipoDocumento}");
            return sb.ToString();
        }*/

        /// <summary>
        /// Averigua si un documento ya está en un listado de documentos. Se considera que un documento está
        ///       en un listado si hay otro con el mismo id o con el mismo código de barras.
        /// </summary>
        /// <param name="documentos"></param>
        /// <param name="d"></param>
        /// <returns>Devuelve verdadero si el documento está en el listado. False si no.</returns>
        public static bool operator ==(List<Documento> documentos, Documento d)
        {
            bool retorno = false;

            foreach (Documento item in documentos)
            {
                if(item.id.Equals(d.id) || item.barcode == d.barcode)
                {                  
                    retorno = true;
                    break;
                }
            }              
            return retorno;
        }
        /// <summary>
        /// Averigua si un documento no está en un listado de documentos. Se considera que un documento no está
        ///       en un listado si no hay otro con el mismo id o con el mismo código de barras.
        /// </summary>
        /// <param name="documentos"></param>
        /// <param name="d"></param>
        /// <returns>Devuelve verdadero si el documento no está en el listado. False si lo está.</returns>
        public static bool operator !=(List<Documento> documentos, Documento d)
        {
            return !(documentos == d);
        }
        /// <summary>
        /// Suma un documento a una lista de documento en el caso de que no esté ya en ella.
        /// </summary>
        /// <param name="documentos">Lista a la que añadir el documento.</param>
        /// <param name="d">Documento a añadir.</param>
        /// <returns>Lista de documentos que entró por parámetro.</returns>
        public static List<Documento> operator +(List<Documento> documentos, Documento d)
        {
            if(documentos != d)
            {
                documentos.Add(d);
            }
            return documentos;
        }
    }
}
