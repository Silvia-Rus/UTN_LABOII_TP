using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo : Documento
    {
        //private TipoId tipoId;
        private string fuente;

        public Articulo() : base() { }

        public string Fuente { get { return this.fuente; } set { this.fuente = value;  } }

        public Articulo(string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, string notas,
                         Encuadernacion estadoEncuadernacion, string fuente)
            : base (titulo, autor, anio, numeroPaginas, id, barcode, notas, estadoEncuadernacion)
        {
            //this.tipoId = tipoId;
            this.fuente = fuente;

        }

        /*public Articulo(string titulo, string autor, string anio, string numeroPaginas, string id, string barcode, string notas,
            Encuadernacion encuadernacion, string fuente) : this(titulo, autor, short.Parse(anio), short.Parse(numeroPaginas), id, int.Parse(barcode), notas, encuadernacion, fuente)
        {

        }*/

        public Articulo(string titulo) { }

        public static Articulo GenerarArticulo( string titulo,
                                                string autor,
                                                string anio,
                                                string numeroPaginas,
                                                string id,
                                                string barcode,
                                                string notas,
                                                int encIndex,
                                                string fuente)
        {
            if (ConversorBarcode(barcode) > -1 && ValidadorEntradaDatos(titulo, anio, numeroPaginas, encIndex))
            {
                return new Articulo(titulo, autor, ConversorAnio(anio), ConversorPaginas(numeroPaginas), id, ConversorBarcode(barcode), notas, getEncuadernado(encIndex), fuente);       
            }
            else
            {
                Console.WriteLine("Error generando un nuevo artículo");
            }

            return null ;

        }

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
            if (ValidadorEntradaDatos(titulo, anio, numeroPaginas, encIndex) &&
                ModificarDocumento(art, titulo, autor, anio, numeroPaginas, id, notas, encIndex))
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



    }
}
