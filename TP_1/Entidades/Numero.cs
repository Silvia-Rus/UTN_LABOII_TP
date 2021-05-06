using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Setter del numero. Valida que no sea texto.
        /// </summary>
        public string setNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }
        /// <summary>
        /// Convierte un binario a decimal previa validación de que es un número binario. 
        /// Solo opera números enteros positivos.
        /// </summary>
        /// <param name="binario">Valor a convertir.</param>
        /// <returns>Valor convertido o "Valor inválido" si no recibió un binario.</returns>
        public string BinarioDecimal(string binario)
        {
            int intResultado = 0;
            char[] charNumero = binario.ToCharArray();
            Array.Reverse(charNumero);
            string strResultado;

            if (EsBinario(binario))
            {
                for (int i = 0; i < charNumero.Length; i++)
                {
                    if (charNumero[i] == '1')
                    {
                        intResultado += (int)Math.Pow(2, i);
                    }
                }
                strResultado = intResultado.ToString();
            }
            else
            {
                strResultado = "Valor inválido";
            }

            return strResultado;
        }
        /// <summary>
        /// Convierte a binario un valor recibido en decimal.
        /// Solo opera números enteros positivos.
        /// </summary>
        /// <param name="numero">Valor a convertir.</param>
        /// <returns>El valor convertido o "Valor inválido" si no recibió un entero positivo.</returns>
        public string DecimalBinario(string numero)
        {
            double dblNumero;
            string resultado;
            bool esEntero = false;
            char[] charNumero = numero.ToCharArray();

            foreach (char caracter in charNumero)
            {
                if (caracter.Equals(','))
                {
                    esEntero = false;
                    break;
                }
                else
                {
                    esEntero = true;
                }
            }


            if (double.TryParse(numero, out dblNumero) && esEntero) 
            {
                resultado = DecimalBinario(dblNumero);
            }
            else
            {
               resultado = "Valor inválido";
            }
            return resultado;
        }
        /// <summary>
        /// Convierte a binario un valor recibido en decimal.
        /// Solo opera números enteros positivos.
        /// </summary>
        /// <param name="numero">Valor a convertir.</param>
        /// <returns>El valor convertido o "Valor inválido" si no recibió un entero positivo.</returns>
        public string DecimalBinario(double numero)
        {
            string resultado = null;
            int numeroEntero = (int)numero;

            if (numeroEntero > 0)
            {
                do
                {
                    if (numeroEntero % 2 == 1)
                    {
                        resultado = "1" + resultado;
                    }
                    else if (numeroEntero % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    numeroEntero = numeroEntero / 2;
                } while (numeroEntero != 0);
            }
            else
            {
                resultado = "Valor inválido";
            }
            return resultado;
        }
        /// <summary>
        /// Validará que la cadena de caractere esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="strNumero">Cadena a validar.</param>
        /// <returns>Verdadero si es binario, falso si no lo és.</returns>
        private bool EsBinario(string strNumero)
        {
            bool retorno = false;
            char[] charNumero = strNumero.ToCharArray();

            foreach (char caracter in charNumero)
            {
                if (!caracter.Equals('0') && !caracter.Equals('1'))
                {
                    retorno = false;
                    break;
                }
                else
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Constructor por defecto. Asigna 0 al atributo número.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Asigna un valor al atributo número;
        /// </summary>
        /// <param name="numero">Valor que se quiere asignar.</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Asigna un valor al atributo número;
        /// </summary>
        /// <param name="numero">Valor que se quiere asignar.</param>
        public Numero(string numero)
        {
            this.setNumero = numero;

        }
        /// <summary>
        /// Comprueba que el valor recibido es numérico. Reemplaza la "," por ".",
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el valor en formato doble en casi de ser un número. En caso contrario retorna 0.</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno;

            if (double.TryParse(strNumero.Replace(".", ","), out retorno))
            {
                return retorno;
            }
            else
            {
                retorno = 0;
                return retorno;
            }
        }
        /// <summary>
        ///  Suma dos valores.
        /// </summary>
        /// <param name="n1">Primer valor.</param>
        /// <param name="n2">Segundo valor.</param>
        /// <returns>Resultado:</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        ///  Resta dos valores.
        /// </summary>
        /// <param name="n1">Primer valor.</param>
        /// <param name="n2">Segundo valor.</param>
        /// <returns>La resta de los dos operandos</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        ///  Divide un valor entre el otro. Valida que el segundo no sea "0". 
        /// </summary>
        /// <param name="n1">Primer valor.</param>
        /// <param name="n2">Segundo valor.</param>
        /// <returns>Resultado o double.MinValue si el segundo operando es 0.</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        /// <summary>
        ///  Multiplica dos valores.
        /// </summary>
        /// <param name="n1">Primer valor.</param>
        /// <param name="n2">Segundo valor.</param>
        /// <returns>Resultado de la multiplicación.</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }







    }

}
