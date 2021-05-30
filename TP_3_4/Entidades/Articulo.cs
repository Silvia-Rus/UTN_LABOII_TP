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

    }
}
