using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para serializar
using System.Runtime.Serialization.Formatters.Binary; //para guardar en binario
using System.IO;                                      //Input/Output. para hacer el stream


namespace Entidades
{
    [Serializable]
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
        private DateTime fechaIntroducción;
        private DateTime fechaDistribucion;
        private DateTime fechaGuillotinado;
        private DateTime fechaRevision;
        private DateTime fechaAprobacion;

        #region Gets y sets para el formato de la tabla
        /// <summary>
        /// Propiedad que devuelve el tipo de documento en formato string para la tabla.
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

        public string Titulo {get { return this.titulo; }}

        public string Autor { get { return this.autor; } }

        public short Anio { get { return this.anio; } }

        public string NumeroPaginasString
        {
            get           
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.numeroPaginas} p.");            
                return sb.ToString();            
            }
        }

        public string Id { get { return this.id; }}

        public int Barcode { get { return this.barcode; } }
          
        public string EstadoEncuadernacionString
        {
            get
            {
                string retorno = "";
                StringBuilder sb = new StringBuilder();
                if(this.estadoEncuadernacion == Encuadernacion.encuadernado)
                {
                    retorno = "Sí. NO guillotinar";
                }
                else if(this.estadoEncuadernacion == Encuadernacion.hojasSueltas)
                {
                    retorno =  "No";
                }
                else if(this.estadoEncuadernacion == Encuadernacion.paraGuillotinar)
                {
                    retorno = "Sí. Guillotinar";
                }
                return retorno;                             
            }
            set
            {
                if(value.Equals("Sí. NO guillotinar"))
                {
                    this.estadoEncuadernacion = Encuadernacion.encuadernado;
                }
                else if(value.Equals("No"))
                {
                    this.estadoEncuadernacion = Encuadernacion.hojasSueltas;
                }
                else if (value.Equals("Sí. Guillotinar"))
                {
                    this.estadoEncuadernacion = Encuadernacion.paraGuillotinar;
                }
            }
        }

        public PasosProceso FaseProceso
        {
            set
            {
                this.pasoProceso = value;
            }
            get
            {
                return this.pasoProceso;
            }
        }


        #endregion

        #region Resto de gets y sets
        public Encuadernacion EstadoEncuadernacion { get { return this.estadoEncuadernacion;}}

        public short NumeroPaginas {get { return this.numeroPaginas; }}
        #endregion

        public Encuadernacion ConversorEncuadernacion(string origen)
        {
            Encuadernacion retorno = Encuadernacion.paraGuillotinar;

            if (origen.Equals("Sí. NO guillotinar"))
            {
                retorno = Encuadernacion.encuadernado;
            }
            else if (origen.Equals("No"))
            {
                retorno = Encuadernacion.hojasSueltas;
            }
            else if (origen.Equals("Sí. Guillotinar"))
            {
                retorno = Encuadernacion.paraGuillotinar;
            }

            return retorno;
        }

        /*public virtual bool AniadirDocumento(Documento documento,
                                     string titulo,
                                     string autor,
                                     string anio,
                                     string numeroPaginas,
                                     string id,
                                     string barcode,
                                     string notas,
                                     string encuadernacion,
                                     string fuente)
        {


            if(int.TryParse(barcode, out int barcodeInt) &&
               short.TryParse(anio, out short anioShort)  &&
                short.TryParse(numeroPaginas, out short numeroPaginasShort))
            {
                Encuadernacion encuadernacionConvertida = ConversorEncuadernacion(encuadernacion);
                if(tipo.Equals("Libro"))
                {                 
                    documentoGenerado = new Libro(titulo, autor, anioShort, numeroPaginasShort, id, barcodeInt, notas, encuadernacionConvertida);
                }
                else if(tipo.Equals("Artículo"))
                {
                    documentoGenerado = new Articulo(titulo, autor, anioShort, numeroPaginasShort, id, barcodeInt, notas, encuadernacionConvertida, fuente);
                }

            }

            return documentoGenerado;
        }*/

        /// <summary>
        /// Constructor por defecto. Asigna el primer paso del proceso (introducido).
        /// </summary>
        public Documento()
        {
            this.pasoProceso = PasosProceso.Distribuir;
            this.fechaIntroducción = DateTime.Now;
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
        public Documento(string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, string notas,
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

        public Documento (string titulo, string autor, string anio, string numeroPaginas, string id, string barcode, string notas,
            Encuadernacion encuadernacion) : this(titulo, autor,  short.Parse(anio), short.Parse(numeroPaginas), id, int.Parse(barcode), notas, encuadernacion)
        {

        }



        public Documento (PasosProceso paso)
        {
            this.FaseProceso = paso;
        }



        /*public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Título: {this.titulo}. Autor: {this.autor}. Año de publicación: {this.anio}.  " +
                          $"Identificador único: {this.id}. Código de barras: {this.barcode}" +
                          $"Tipo de documento: {this.tipoDocumento}");
            return sb.ToString();
        }*/

        #region operadores

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
                //if(item.id.Equals(d.id) || item.barcode.Equals(d.barcode))
                if ((item.id.Equals(d.id) || item == d))
                {                  
                    retorno = true;
                    break;
                }
            }              
            return retorno;
        }

        public static bool operator ==(Documento a, Documento b)
        {
            bool retorno = false;
            if(a.barcode == b.barcode)
            {
                retorno = true;
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

        public static bool operator !=(Documento a, Documento b)
        {
            return !(a == b);
        }
        #endregion
    }
}
