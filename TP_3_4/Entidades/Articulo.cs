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

        public bool AniadirArticulo(Articulo a,
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
            bool retorno = false;
            if (int.TryParse(barcode, out int barcodeInt) &&
               short.TryParse(anio, out short anioShort) &&
               short.TryParse(numeroPaginas, out short numeroPaginasShort))
            {
                Encuadernacion encuadernacionConvertida = ConversorEncuadernacion(encuadernacion);
                a = new Articulo(titulo, autor, anioShort, numeroPaginasShort, id, barcodeInt, notas, encuadernacionConvertida, fuente);
                retorno = true;
            }
            return retorno;
        }
    }
}
