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

        public string Fuente { get { return this.fuente; } }

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

        public static Articulo GenerarArticulo( string titulo,
                                                string autor,
                                                string anio,
                                                string numeroPaginas,
                                                string id,
                                                string barcode,
                                                string notas,
                                                Encuadernacion encuadernacion,
                                                string fuente)
        {


            if (titulo.Length > 0 &&
                ConversorBarcode(barcode) > -1 &&
                short.TryParse(anio, out short anioShort) &&
                short.TryParse(numeroPaginas, out short numeroPaginasShort) && numeroPaginasShort >0)
            {
                return new Articulo(titulo, autor, anioShort, numeroPaginasShort, id, ConversorBarcode(barcode), notas, encuadernacion, fuente);
            
            }
            else
            {
                Console.WriteLine("OJO NO GENERÓ NADA");
            }
            return null;
        }


    }
}
