using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para serializar
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;                                      
using System.Xml;
using System.Xml.Serialization;
using Serializador;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Articulo))]
    [XmlInclude(typeof(Libro))]

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
        private DateTime fechaCarga;
        private DateTime fechaDistribucion;
        private DateTime fechaGuillotinado;
        private DateTime fechaEscaneo;
        private DateTime fechaRevision;
        private DateTime fechaAprobacion;

        #region Gets y sets para el formato de la tabla
        /// <summary>
        /// Get y set de la Fase del proceso en la que se encuentra el documento. Todos se inician en "Distribuir".
        /// </summary>
        public PasosProceso FaseProceso { get { return this.pasoProceso; } set { this.pasoProceso = value; } }
        /// <summary>
        /// Propiedad que devuelve el tipo de documento en formato string para el Datagrid.
        /// </summary>
        public string TipoDeDocumentoString
        {
            get
            {
                string retorno = "";
                if(this is Libro)
                {
                    retorno = "Libro";
                }
                else if(this is Articulo)
                {
                    retorno = "Artículo";
                }               
                return retorno;
            }
        }
        /// <summary>
        /// Get y set del código de barras.
        /// </summary>
        public int Barcode { set { this.barcode = value; } get { return this.barcode; } }
        /// <summary>
        /// Get y set del título del documento.
        /// </summary>
        public string Titulo {get { return this.titulo; } set { this.titulo = value; } }
        /// <summary>
        /// Get y set del autor del documento.
        /// </summary>
        public string Autor { get { return this.autor; } set { this.autor = value;  } }
        /// <summary>
        /// Get y set del autor del documento.
        /// </summary>
        public short Anio { get { return this.anio; } set { this.anio = value; } }
        /// <summary>
        /// Get y set de la encuadernación. Se toma del enumerado y tiene influencia sobre el proceso.
        /// </summary>
        public Encuadernacion Encuadernado { get { return this.estadoEncuadernacion;  }  set { this.estadoEncuadernacion = value; } }
        /// <summary>
        /// Transforma el número de páginas del documento en un string y le añade "p." al final para que se muestre en el Datagrid.
        /// </summary>
        public string NumeroPaginasString
        {
            get           
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.numeroPaginas} p.");            
                return sb.ToString();            
            }
        }
        /// <summary>
        /// Id del documento.
        /// </summary>
        public string Id { get { return this.id; } set { this.id = value; } }
             
        #endregion

        #region Resto de gets y sets
        /// <summary>
        /// Estado de la encuadernación del documento.
        /// </summary>
        public Encuadernacion EstadoEncuadernacion { set { this.estadoEncuadernacion = value; } get { return this.estadoEncuadernacion;}}
        /// <summary>
        /// Get y set de las páginas del documento.
        /// </summary>
        public short NumeroPaginas { set { this.numeroPaginas = value; }  get { return this.numeroPaginas; }}
        /// <summary>
        /// Get y set de las notas del documento.
        /// </summary>
        public string Notas { set { this.notas = value; } get { return this.notas; } }
        /// <summary>
        /// Get y set de la fecha de introducción del documento. Solo se puede setear desde el constructor por defecto de cada documento.
        /// </summary>
        public DateTime FechaCarga  { set { this.fechaCarga = value; } get { return this.fechaCarga; } }
        /// <summary>
        /// Get y set de la fecha de distribución.
        /// </summary>
        public DateTime FechaDistribucion { set { this.fechaDistribucion = value; } get { return this.fechaDistribucion; } }
        /// <summary>
        /// Get y set de la fecha de guillotinado. Si el documento no es guillotinado, queda en DateTime.MinValue.
        /// </summary>
        public DateTime FechaGuillotinado { set { this.fechaGuillotinado = value; } get { return this.fechaGuillotinado; } }  
        /// <summary>
        /// Get y set de la fecha de escaneo.
        /// </summary>
        public DateTime FechaEscaneo { set { this.fechaEscaneo = value; } get { return this.fechaEscaneo; } }
        /// <summary>
        /// Get y set de la fecha de escaneo.
        /// </summary>
        public DateTime FechaRevision { set { this.fechaRevision = value; } get { return this.fechaRevision; } }
        /// <summary>
        /// Get y set de la fecha de aprobación.
        /// </summary>
        public DateTime FechaAprobacion { set { this.fechaAprobacion = value; } get { return this.fechaAprobacion; } }

        #endregion
    
        #region Constructores
        /// <summary>
        /// Constructor por defecto. Asigna el primer paso del proceso (Distribuir) y le asigna la fecha de carga.
        /// </summary>
        public Documento()
        {
            this.pasoProceso = PasosProceso.Distribuir;
            this.FechaCarga = DateTime.Now;
            this.FechaAprobacion = DateTime.MinValue;
            this.FechaDistribucion = DateTime.MinValue;
            this.FechaEscaneo = DateTime.MinValue;
            this.FechaGuillotinado = DateTime.MinValue;
            this.FechaRevision = DateTime.MinValue;

        }
        /// <summary>
        /// Constructor del documento.
        /// </summary>
        /// <param name="titulo">Título del documento.</param>
        /// <param name="autor">Autor del documento.</param>
        /// <param name="anio">Año de publicación del documento.</param>
        /// <param name="numeroPaginas">Número de páginas del documento.</param>
        /// <param name="id">Identificador del documento.</param>
        /// <param name="barcode">Código de barras del documento.</param>
        /// <param name="notas">Notas del documento.</param>
        /// <param name="estadoEncuadernacion">Estado del documento.</param>
        protected Documento(string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, string notas,
                         Encuadernacion estadoEncuadernacion) 
            : this()
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numeroPaginas = numeroPaginas;
            this.id = id;
            this.barcode = barcode;
            this.notas = notas;
            this.estadoEncuadernacion = estadoEncuadernacion;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Comprueba que dos documentos tienen el mismo código de barras. 
        /// </summary>
        /// <param name="a">Primer documento a comparar.</param>
        /// <param name="b">Segundod documento a comparar</param>
        /// <returns>True si tienen el mismo código de barras. False si no.</returns>
        public static bool operator ==(Documento a, Documento b)
        {
            bool retorno = false;
                     
            if (a is null || b is null)
            {
                retorno = false;
            }
            else
            {
                if (a.barcode == b.barcode)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Comprueba si un documento  ya existe en una lista 
        /// </summary>
        /// <param name="documentos">Lista de documentos.</param>
        /// <param name="d">Documento que se comprueba.</param>
        /// <returns>Devuelve true si ya existe en la lista un documento con el mismo barcode y/o Id del que se compara. False si no.</returns>
        public static bool operator ==(List<Documento> documentos, Documento d)
        {
            bool retorno = false;

            if (!(documentos is null) && !(d is null))
            {
                foreach (Documento item in documentos)
                {
                    if ((item.id.Equals(d.id) || item == d))
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Comprueba si un documento no existe en una lista 
        /// </summary>
        /// <param name="documentos">Lista de documentos.</param>
        /// <param name="d">Documento que se comprueba.</param>
        /// <returns>Devuelve false si ya existe en la lista un documento con el mismo barcode y/o Id del que se compara.True si no.</returns>
        public static bool operator !=(Documento a, Documento b)
        {
            return !(a == b);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator !=(List<Documento> documentos, Documento d)
        {
            return !(documentos == d);
        }


        #endregion

        #region Procesadores de datos
        /// <summary>
        /// Toma el valor del índice del combobox y devuelve el valor del enumerado de Encuadernacion.
        /// </summary>
        /// <param name="enc"></param>
        /// <returns></returns>
        protected static Encuadernacion getEncuadernado(int enc)
        {
            Encuadernacion encuadernado = Entidades.Encuadernacion.No;
            foreach (Encuadernacion item in Enum.GetValues(typeof(Encuadernacion)))
            {
                if (enc == (int)item)
                {
                    encuadernado = item;
                }
            }
            return encuadernado;
        }
        /// <summary>
        /// Convierte un string en un barcode. Comprueba que el string está formado por cifras mayores de -1.
        /// </summary>
        /// <param name="barcode">Cadena a validar y convertir.</param>
        /// <returns>El barcode en formato int. Devuelve -1 si no pudo validarse.</returns>
        private static int ConversorBarcode(string barcode)
        {
            int retorno = -1;

            if(int.TryParse(barcode, out int b) && b > -1)
            {
                retorno = b;
            }
            return retorno;
        }
        /// <summary>
        /// Convierte un string en un short. Valida que el string contenga cifras y la fecha de publicación no sea mayor al año actual.
        /// </summary>
        /// <param name="anio">Cadena a validar y convertir.</param>
        /// <returns>El año en formato short.</returns>
        private static short ConversorAnio(string anio)
        {
            short retorno = -1;
            short anioActual = Convert.ToInt16(DateTime.Now.Year);           

            if(short.TryParse(anio, out short a) && a >- 1 && a <anioActual+1)
            {
                retorno = a;
            }
            return retorno;
        }
        /// <summary>
        /// Convierte un string en un int. Comprueba que el string está formado por cifras mayores de 0.
        /// </summary>
        /// <param name="paginas">Cadena a validar y convertir.</param>
        /// <returns>Las páginas en formato short. Devuelve 0 si no pudo validarse.</returns>
        private static short ConversorPaginas(string paginas)
        {
            short retorno = 0;

            if (short.TryParse(paginas, out short p) && p > 0)
            {
                retorno = p;
            }
            return retorno;
        }
        /// <summary>
        /// Valida todos los datos que entran por parámetro.
        /// </summary>
        /// <param name="titulo">Título (no puede ser null)</param>
        /// <param name="anio">Año (deben ser cifras, mayor a -1 y no suceder en un aó por venir.</param>
        /// <param name="numeroPaginas">Número de páginas (deben ser cifras y mayor a 0)</param>
        /// <param name="encIndice">Valida el índice del combox del estado de encuadernación.</param>
        /// <returns></returns>
        private static bool ValidadorEntradaDatos(string titulo, string anio, string numeroPaginas, int encIndice)
        {
            bool retorno = false;

            if (titulo.Length > 0 &&
                ConversorAnio(anio) > -1 &&
                ConversorPaginas(numeroPaginas) > 0 &&
                encIndice > -1)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Genera un documento del que tenemos sus atributos en string. Valida todos los strings.
        /// </summary>
        /// <param name="tipo">Tipo de documento a generar.</param>
        /// <param name="titulo">Título del documento.</param>
        /// <param name="autor">Autor del documento.</param>
        /// <param name="anio">Año de publicación del documento.</param>
        /// <param name="numeroPaginas">Número de páginas del documento.</param>
        /// <param name="id">Id del documento.</param>
        /// <param name="barcode">Barcode del documento.</param>
        /// <param name="notas">Notas del documentos.</param>
        /// <param name="encIndex">ïndice del combobox del estado de encuadernación.</param>
        /// <returns>El documento formado.</returns>
        public static Documento GenerarDocumento(string tipo,
                                                string titulo,
                                                string autor,
                                                string anio,
                                                string numeroPaginas,
                                                string id,
                                                string barcode,
                                                string notas,
                                                int encIndex)
        {
            if (ConversorBarcode(barcode) > -1 && ValidadorEntradaDatos(titulo, anio, numeroPaginas, encIndex))
            {
                if(tipo.Equals("Libro"))
                {
                    return new Libro(titulo, autor, ConversorAnio(anio), ConversorPaginas(numeroPaginas), id, ConversorBarcode(barcode), notas, getEncuadernado(encIndex));
                }
                else if (tipo.Equals("Articulo"))
                {
                    return new Articulo(titulo, autor, ConversorAnio(anio), ConversorPaginas(numeroPaginas), id, ConversorBarcode(barcode), notas, getEncuadernado(encIndex));
                }
            }
            else
            {
                Console.WriteLine("Error generando un nuevo Documento");
            }

            return null;
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
        /// <returns>Devuelve true si los datos modificados son válidos. False si no.</returns>
        public static bool ModificarDocumento(Documento doc,
                                              string titulo,
                                              string autor,
                                              string anio,
                                              string numeroPaginas,
                                              string id,
                                              string notas,
                                              int encIndex)
        {
            bool retorno = false;
            if (ValidadorEntradaDatos(titulo, anio, numeroPaginas, encIndex))
            {
                doc.Titulo = titulo;
                doc.Autor = autor;
                doc.Anio = ConversorAnio(anio);
                doc.NumeroPaginas = ConversorPaginas(numeroPaginas);
                doc.Id = id;
                doc.Notas = notas;
                doc.Encuadernado = getEncuadernado(encIndex);
                retorno = true;
            }
            else
            {
                Console.WriteLine("Error generando un nuevo artículo");
            }
            return retorno;
        }
        #endregion
       
        #region Impresiones
        /// <summary>
        /// Imprime los atributos de un Documento que entra por parámtero.
        /// </summary>
        /// <param name="a">Documento del cual queremos imprimir los datos.</param>
        /// <returns>String con los datos.</returns>
        /*public static string ImprimirDocumento(Documento a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {a.TipoDeDocumentoString}");
            sb.AppendLine($"Título: {a.Titulo}");
            sb.AppendLine($"Autor: {a.Autor}");
            sb.AppendLine($"Año: {a.Anio}");
            sb.AppendLine($"Barcode: {a.Barcode}");
            sb.AppendLine($"Id: {a.Id}");
            sb.AppendLine($"Barcode: {a.Barcode}");
            sb.AppendLine($"Enc: {a.EstadoEncuadernacion}");
            sb.AppendLine($"Fase proceso: {a.FaseProceso}");
            sb.AppendLine($"Fecha de carga: {a.FechaCarga}");
            return sb.ToString();

        }*/
        /// <summary>
        /// Imprime las fechas del proceso.
        /// </summary>
        public string HistorialProceso
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Fecha de carga: {this.fechaCarga}.");
                if(this.FechaDistribucion != DateTime.MinValue)
                {
                    sb.AppendLine($"Fecha de distribución: {this.FechaDistribucion}.");
                    if(this.FechaGuillotinado != DateTime.MinValue)
                    {
                        sb.AppendLine($"Fecha de guillotinado: {this.FechaGuillotinado}.");
                    }
                        if (this.FechaEscaneo != DateTime.MinValue)
                        {
                            sb.AppendLine($"Fecha de escaneo: {this.FechaEscaneo}.");
                            if (this.FechaRevision != DateTime.MinValue)
                            {
                                sb.AppendLine($"Fecha de revisión: {this.FechaRevision}");
                                if (this.FechaAprobacion != DateTime.MinValue)
                                {
                                    sb.AppendLine($"Fecha de aprobación: {this.FechaAprobacion}.");
                                }
                            }
                        }                                  
                }
                return sb.ToString();
            }
        }
        #endregion

        /// <summary>
        /// Devuelve un documento de una lista cuyo barcode entra en forma de string por parámetro.
        /// </summary>
        /// <param name="lista">Lista en la que buscar el documento.</param>
        /// <param name="barcode">Barcode a buscar.</param>
        /// <returns>Devuelve el documento encontrado.</returns>
        public static Documento GetByBarcode(List<Documento> lista, string barcode)
        {
            Documento retorno = null;

            if (ConversorBarcode(barcode) > -1)
            {
                foreach (Documento item in lista)
                {
                    if (item.Barcode == ConversorBarcode(barcode))
                    {
                        retorno = item;
                        break;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Expprta a XML un listado de documentos.
        /// </summary>
        /// <param name="datos">El listado de documentos a exportar.</param>
        /// <returns>True si los exportó (la lista tiene contenido). False si no.</returns>
        public static bool ExportarDocumentos(List<Documento> datos)
        {
            bool retorno = false;
            Xml<List<Documento>> miVariable = new Xml<List<Documento>>();
            if (datos.Count > 0 && miVariable.Exportar(datos))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
