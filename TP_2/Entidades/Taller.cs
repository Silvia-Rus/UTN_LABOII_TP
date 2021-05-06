using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return "Llego a taller.ToString";
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {                    
            StringBuilder sb = new StringBuilder();

            int espacioTotal = taller.vehiculos.Count + taller.espacioDisponible;
            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, espacioTotal);
            sb.AppendLine("");

            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if(v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }                   
                        break;
                    case ETipo.Sedan:
                        if(v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }                     
                        break;
                    case ETipo.SUV:
                        if(v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="t">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            bool esDuplicado = false;

            //se comprueba si tenemos espacio
            if(t.espacioDisponible>0)
            {
                //se comprueba si tiene un duplicado
                foreach (Vehiculo v in t.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        //encontramos un duplicado
                        esDuplicado = true;
                        break;                   
                    }
                }
                //si no lo encontramos añadimos un vehículo y restamos un espacio.
                if(esDuplicado == false)
                {
                    t.vehiculos.Add(vehiculo);
                    t.espacioDisponible -= 1;
                }
            }
            return t;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="vehiculos">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            //buscamos el vehículo
            foreach (Vehiculo v in t.vehiculos)
            {
                //lo encontramos
                if (v == vehiculo)
                {
                    //borramos el vehículo
                    t.vehiculos.Remove(v);
                    //sumamos un espacio
                    t.espacioDisponible += 1;
                    break;
                }
            }
            return t;
        }
        #endregion
    }
}
