using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Serializador;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prueba: el método generar documentos, genera o no genera.
            Libro libro = new Libro();
            Articulo articulo = new Articulo();

            libro = (Libro)Documento.GenerarDocumento("Libro", "Título Libro", "Autor Libro", "1956", "50", "id", "35", "notas", 1);
            articulo = (Articulo)Documento.GenerarDocumento("Articulo", "Título Artículo", "Autor Artículo", "1956", "50", "id", "35", "notas", 1);

            Console.WriteLine("---LIBRO---");
            Console.WriteLine(Documento.ImprimirDocumento(libro));

            Console.WriteLine("---ARTÍCULO---");
            Console.WriteLine(Documento.ImprimirDocumento(articulo));

            Console.ReadKey();
        }
    }
}
