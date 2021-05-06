using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor de los ciclomotores. Asigna la marca, el chasis y el color. 
        /// </summary>
        /// <param name="marca">Marca a asignar.</param>
        /// <param name="chasis">Chasis a asignar.</param>
        /// <param name="color">Color a asignar.</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }
        /// <summary>
        ///  Asigna el tamaño "chico" a los ciclomotores.
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
            set
            {
                value = ETamanio.Chico;
            }
        }
        /// <summary>
        /// Muestra los datos del ciclomotor.
        /// </summary>
        /// <returns>Los datos del ciclomotor.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());         
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
