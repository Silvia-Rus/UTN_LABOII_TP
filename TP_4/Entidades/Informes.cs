using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes

    {
        /// <summary>
        /// Devuelve un entero con las suma de las páginas de la lista que entra por parámetro.
        /// </summary>
        /// <param name="lista">Lista de documentos.</param>
        /// <returns>Total de páginas.</returns>
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
        /// <summary>
        /// Devuelve un entero el total de registros contenidos en la lista que entra por parámetro.
        /// </summary>
        /// <param name="lista">Lista de documentos.</param>
        /// <returns>Total de documentos.</returns>
        public static int TotalDocumentos(List<Documento> lista)
        {                    
            if (!(lista is null))
            {
                return lista.Count();
            }
            return 0;              
        }
        /// <summary>
        /// Devuelve un entero con las suma de los artículos contenidos en la lista que entra por parámetro.
        /// </summary>
        /// <param name="lista">Lista de documentos.</param>
        /// <returns>Total de artículos.</returns>
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
        /// <summary>
        /// Devuelve un entero con las suma de los libros contenidos en la lista que entra por parámetro.
        /// </summary>
        /// <param name="lista">Lista de documentos.</param>
        /// <returns>Total de artículos.</returns>
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
