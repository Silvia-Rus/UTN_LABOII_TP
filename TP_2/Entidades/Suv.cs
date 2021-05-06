using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor de los Suv. Asigna la marca, el chasis y el color. 
        /// </summary>
        /// <param name="marca">Marca a asignar.</param>
        /// <param name="chasis">Chasis a asignar.</param>
        /// <param name="color">Color a asignar.</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }
        /// <summary>
        ///  Asigna el tamaño "grande" a las SUV.
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
            set
            {
                value = ETamanio.Grande;
            }
        }
        /// <summary>
        /// Muestra los datos de la SUV.
        /// </summary>
        /// <returns>Los datos de la SUV</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
