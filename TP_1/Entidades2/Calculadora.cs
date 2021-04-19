using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        //validará y realizará la operación pedida entre
        //ambos números.
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            char operadorValido;

            if (char.TryParse(operador, out operadorValido))//parseamos el string a char (lo pide así ValidarOperador)
            {
                switch (ValidarOperador(operadorValido))//lo validamos
                {
                    case "+":
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
                }

                return resultado;
            }
            else
            {
                
                return -1;
            }
        }
        //Deberá validar que el operador
        //recibido sea +, -, / o*. Caso contrario retornará +.
        private static string ValidarOperador(char operador)
        {
            if (operador.Equals('-') || operador.Equals('*') || operador.Equals('/'))
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

