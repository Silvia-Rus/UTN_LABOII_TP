using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida y realiza la operación pedida entre dos números.
        /// </summary>
        /// <param name="num1">Primer número.</param>
        /// <param name="num2">Segundo número.</param>
        /// <param name="operador">Operador.</param>
        /// <returns>Resultado de la operación.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            char operadorValido;

            if (char.TryParse(operador, out operadorValido) || operador == "")
            {
                switch (ValidarOperador(operadorValido))
                {
                    case " ":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                    default:
                        resultado = num1 + num2;
                        break;
                }
                return resultado;
            }
            else
            {
                return resultado;
            }
        }
        /// <summary>
        /// Valida que el operador recibido sea  +, -, / o*.
        /// </summary>
        /// <param name="operador">Operador a validar.</param>
        /// <returns>El operador o en caso de que no sea válido, "+".</returns>
        private static string ValidarOperador(char operador)
        {
            if (operador.Equals('-') || operador.Equals('*') || operador.Equals('/') || operador.Equals('+'))
            {
                return operador.ToString();
            }
            else
            {
                return "+";
            }
        }
    }
}
