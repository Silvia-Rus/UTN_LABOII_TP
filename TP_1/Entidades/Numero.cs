using System;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        //Los métodos BinarioDecimal y DecimalBinario convertirán el Resultado,
        //trabajarán con enteros positivos, quedándose para esto con el valor
        //absoluto y entero del double recibido:

        //El método BinarioDecimal validará que se trate de un binario y luego
        //convertirá ese número binario a decimal, en caso de ser posible.Caso
        //contrario retornará "Valor inválido".
        public string BinarioDecimal(string binario)
        {

        }
        //Ambas opciones del método DecimalBinario convertirán un número
        //decimal a binario, en caso de ser posible.Caso contrario retornará
        //"Valor inválido". Reutilizar código.
        public string DecimalBinario(double Numero)
        {

        }

        public string DecimalBinario(string Numero)
        {

        }

        //El método privado EsBinario validará que la cadena de caracteres
        //esté compuesta SOLAMENTE por caracteres '0' o '1'.
        private bool EsBinario(string strNumero)
        {

        }
        //El constructor por defecto (sin parámetros)
        //asignará valor 0 al atributo numero.
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {

        }

        public Numero(string numero)
        {

        }


        //ValidarNumero comprobará que el valor recibido sea numérico,
        //y lo retornará en
        //formato double. Caso contrario, retornará 0.
        private double ValidarNumero(string strNumero)
        {

            double retorno;

            if(double.TryParse(strNumero, out retorno))
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

      

       




    }

}
