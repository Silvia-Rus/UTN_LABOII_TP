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

        public string setNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        //Los métodos BinarioDecimal y DecimalBinario convertirán el Resultado,
        //trabajarán con enteros positivos, quedándose para esto con el valor
        //absoluto y entero del double recibido:

        //El método BinarioDecimal validará que se trate de un binario y luego
        //convertirá ese número binario a decimal, en caso de ser posible.Caso
        //contrario retornará "Valor inválido".
        public string BinarioDecimal(string binario)
        {
            int intResultado = 0;
            char[] charNumero = binario.ToCharArray();
            Array.Reverse(charNumero);
            string strResultado;

            if(EsBinario(binario))
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
        //Ambas opciones del método DecimalBinario convertirán un número
        //decimal a binario, en caso de ser posible.Caso contrario retornará
        //"Valor inválido". Reutilizar código.
        /*public string DecimalBinario(double numero)
        {
            string retorno = 'ok';
            return numero.ToString;
        }*/

        public string DecimalBinario(string numero)
        {
            return numero;
        }

        //El método privado EsBinario validará que la cadena de caracteres
        //esté compuesta SOLAMENTE por caracteres '0' o '1'.
        private bool EsBinario(string strNumero)
        {
            bool retorno = false;
            char[] charNumero = strNumero.ToCharArray();
           
            foreach (char caracter in charNumero)
            {
                if(!caracter.Equals('0') && !caracter.Equals('1'))
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
        //El constructor por defecto (sin parámetros)
        //asignará valor 0 al atributo numero.
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.setNumero = numero;
         
        }

       


        //ValidarNumero comprobará que el valor recibido sea numérico,
        //y lo retornará en
        //formato double. Caso contrario, retornará 0.
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

        //PROPIEDAD SETNUMERO
        //La propiedad SetNumero asignará un valor al atributo número, previa validación.
        //En este lugar será el único en todo el código que llame al método ValidarNumero.

        /// <summary>
        ///  Metodo para realizar una suma entre dos operandos.
        /// </summary>
        /// <param name="n1">Valor correspondiente al primer operando</param>
        /// <param name="n2">Valor correspondiente al segundo operando</param>
        /// <returns>La suma de los dos operandos</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        ///  Metodo para realizar una resta entre dos operandos.
        /// </summary>
        /// <param name="n1">Valor correspondiente al primer operando</param>
        /// <param name="n2">Valor correspondiente al segundo operando</param>
        /// <returns>La resta de los dos operandos</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        ///  Metodo para realizar una division entre dos operandos.
        /// </summary>
        /// <param name="n1">Valor correspondiente al primer operando</param>
        /// <param name="n2">Valor correspondiente al segundo operando</param>
        /// <returns>La division de los dos operandos</returns>
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
        ///  Metodo para realizar una multiplicacion entre dos operandos.
        /// </summary>
        /// <param name="n1">Valor correspondiente al primer operando</param>
        /// <param name="n2">Valor correspondiente al segundo operando</param>
        /// <returns>La multiplicacion de los dos operandos</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }







    }

}

