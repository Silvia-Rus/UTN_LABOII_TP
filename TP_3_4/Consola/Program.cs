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
            
            Libro a = new Libro("La casa de Bernarda Alba", "Lorca", 1995, 54, "0000", 1234, "uuu", Encuadernacion.No);
            Libro b = new Libro("Yerma", "Lorca", 1995, 54, "0001", 1235, "uuu", Encuadernacion.No);

            Procesador procesador = new Procesador("Procesador");

            bool pudo = procesador + a;
            pudo = procesador + b;

            List<Documento> listaPrueba = new List<Documento>();

            Xml<List<Documento>> miVariable = new Xml<List<Documento>>();

            try
            {
                miVariable.Importar(Environment.CurrentDirectory + @"\ImportXML\rus.xml", out listaPrueba);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();



        }
    }
}
