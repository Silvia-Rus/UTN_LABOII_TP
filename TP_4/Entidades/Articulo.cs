using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo : Documento
    {
        private string fuente;

        /// <summary>
        /// Get y set de la fuente.
        /// </summary>
        public string Fuente { get { return this.fuente; } set { this.fuente = value; } }

        #region Constructores


        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Articulo() : base() { }

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
        public Articulo(string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, string notas,
                         Encuadernacion estadoEncuadernacion) : base(titulo, autor, anio, numeroPaginas, id, barcode, notas, estadoEncuadernacion)
        { }
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
        /// <param name="fuente">Fuente del artículo.</param>
        public Articulo(string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, string notas,
                         Encuadernacion estadoEncuadernacion, string fuente)
            : base (titulo, autor, anio, numeroPaginas, id, barcode, notas, estadoEncuadernacion)
        {
            this.fuente = fuente;
        }
        #endregion

        #region Procesadores de datos
        /// <summary>
        /// Genera un documento del que tenemos sus atributos en string. Valida todos los strings.
        /// </summary>
        /// <param name="titulo">Título del documento.</param>
        /// <param name="autor">Autor del documento.</param>
        /// <param name="anio">Año de publicación del documento.</param>
        /// <param name="numeroPaginas">Número de páginas del documento.</param>
        /// <param name="id">Id del documento.</param>
        /// <param name="barcode">Barcode del documento.</param>
        /// <param name="notas">Notas del documentos.</param>
        /// <param name="encIndex">Índice del combobox del estado de encuadernación.</param>
        /// <param name="fuente">Fuente del artículo.</param>
        /// <returns>Artículo generado.</returns>
        public static Articulo GenerarArticulo(string titulo,
                                                string autor,
                                                string anio,
                                                string numeroPaginas,
                                                string id,
                                                string barcode,
                                                string notas,
                                                int encIndex,
                                                string fuente)
        {
            Articulo articulo = (Articulo)GenerarDocumento("Articulo",titulo, autor, anio, numeroPaginas, id, barcode, notas, encIndex);
            if(!(articulo is null))
            {
                articulo.Fuente = fuente;

            }
            return articulo;
        }
        /// <summary>
        /// Modifica un documento que entra por parámetro con los datos que entran por parámetro.
        /// </summary>
        /// <param name="doc">Documento a modificar.</param>
        /// <param name="titulo">Título a asignar.</param>
        /// <param name="autor">Autor a asignar.</param>
        /// <param name="anio">Año a asignar.</param>
        /// <param name="numeroPaginas">Número de páginas a asignar.</param>
        /// <param name="id">Id a asignar-</param>
        /// <param name="notas">Notas a asignar.</param>
        /// <param name="encIndex">ïndice del combobox del estado de encuadernación.</param>
        /// <param name="fuente">Fuente del documento.</param>
        /// <returns>Devuelve true si los datos modificados son válidos. False si no.</returns>
        public static bool ModificarArticulo(Documento art,
                                                string titulo,
                                               string autor,
                                               string anio,
                                               string numeroPaginas,
                                               string id,
                                               string notas,
                                               int encIndex,
                                               string fuente) 
        {
            bool retorno = false;
            if (ModificarDocumento(art, titulo, autor, anio, numeroPaginas, id, notas, encIndex))
            {
                Articulo docAux = (Articulo)art;
                docAux.Fuente = fuente;
                retorno = true;
            }
            else
            {
                Console.WriteLine("Error generando un nuevo artículo");
            }
            return retorno;
        }
        #endregion
    }
}
