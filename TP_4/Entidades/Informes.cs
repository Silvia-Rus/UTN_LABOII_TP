using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Informes

    {
        //public delegate void EventHandler(object sender, EventArgs e);
        public delegate  void DelegadoEstadisticas(List<Documento> lista);
        //public event EventHandler Click;
        public event DelegadoEstadisticas EventoEstadisticas;
        //this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
        //this.ALGO.EventoEstadisticas +=  new DelegadoEstadisticas(UNA FUNCIÓN QUE HACE ALGO DENTRO DE LA PROPIA CLASE y que debe tener los mismos parámetros));
        //private void btnAccionModificar_Click(object sender, EventArgs e)
        //X EJ: private void ImprimirCifrasTotales(la lista) - ponerlo en el text del label.



        public static int TotalPaginas(List<Documento> lista)
        {
            int totalPaginas = 0;

           if(!(lista is null))
           {
                foreach (Documento item in lista)
                {
                    totalPaginas += item.NumeroPaginas;
                }
           }
            return totalPaginas;
        }

        public static int TotalDocumentos(List<Documento> lista)
        {
            
            
            if (!(lista is null))
            {
                return lista.Count();
            }

            return 0;
               
        }

        public static int TotalArticulos(List<Documento> lista)
        {
            int totalArticulos = 0;

            if (!(lista is null))
            {
                foreach (Documento item in lista)
                {
                    if (item is Articulo)
                    {
                        totalArticulos++;
                    }

                }
            }              
            return totalArticulos;
        }

        //public static int SacarUnaEstadistica(LA LISTA, el método de la condición dentro del foreach)

        public static int TotalLibros(List<Documento> lista)
        {
            int totalLibros = 0;

            if (!(lista is null))
            {
                foreach (Documento item in lista)
                {
                    if (item is Libro)
                    {
                        totalLibros++;
                    }
                }
            }
               
            return totalLibros;
        }

    }
}
