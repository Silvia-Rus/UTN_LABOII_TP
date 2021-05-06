using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta de la que derivan las clases de los tipso de vehículo.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Lista controlada de marcas de vehículos.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Lista controlada de tamaños de vehículo.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        EMarca marca;
        string chasis;
        ConsoleColor color;

        /// <summary>
        /// Propiedad get y set para el tamaño del vehículo.
        /// </summary>
        public abstract ETamanio Tamanio { get; set; }
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// Le da formato a los datos del vehículo.
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");
            sb.AppendLine("");
            sb.AppendFormat("TAMAÑO : {0}", p.Tamanio);

            return sb.ToString();
        }
        /// <summary>
        /// Se hace que dos vehiculos sean iguales si comparten el mismo chasis.
        /// </summary>
        /// <param name="v1">El primero vehículo a comparar.</param>
        /// <param name="v2">El segundo vehículo a comparar.</param>
        /// <returns>True si son el mismo vehículo. False si no lo son.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Se hace que dos vehiculos sean distintos si tienen distinto chasis.
        /// </summary>
        /// <param name="v1">El primero vehículo a comparar.</param>
        /// <param name="v2">El segundo vehículo a comparar.</param>        
        /// <returns>True si son distinto vehículo. False si lo son.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Constructor. Asigna la marca, el chasis y el color.
        /// </summary>
        /// <param name="marca">La marca a asignar.</param>
        /// <param name="chasis">El chasis a asignar.</param>
        /// <param name="color">El color a asignar.</param>
        public Vehiculo(EMarca marca, string chasis,  ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
    }
}
