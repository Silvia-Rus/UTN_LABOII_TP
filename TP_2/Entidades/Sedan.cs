using System;
using System.Text;

namespace Entidades
{
    //se pasó a public
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;

        #region Constructores
        /// <summary>
        /// Constructor de los Sedan. Asigna la marca, el chasis y el color que entran por paramétro. Se asigna el tipo por defecto "CuatroPuertas".
        /// </summary>
        /// <param name="marca">Marca a asignar.</param>
        /// <param name="chasis">Chasis a asignar.</param>
        /// <param name="color">Color a asignar.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Constructor de los Sedan. Asigna la marca, el chasis el color y el tipo.".
        /// </summary>
        /// <param name="marca">Marca a asignar.</param>
        /// <param name="chasis">Chasis a asignar.</param>
        /// <param name="color">Color a asignar.</param>
        /// <param name="tipo">Tipo a asignar.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
           : base(marca, chasis, color)
        {
            this.tipo = tipo;
        }
        #endregion

        /// <summary>
        ///  Asigna el tamaño "mediano" al Sedan.
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
            set
            {
                value = ETamanio.Mediano;
            }
        }
        /// <summary>
        /// Muestra los datos del Sedan.
        /// </summary>
        /// <returns>Los datos del Sedan.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine($"TIPO : {tipo}");
            //sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
