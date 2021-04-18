using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCaculadora : Form
    {
        //PARTE LÓGICA
        public FormCaculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        //El botón btnCerrar deberá cerrar el formulario.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //esto va con un dispose
        }
        //El evento click del botón btnConvertirABinario convertirá
        //el resultado, de existir, a binario.
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }
        //El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y
        //ser binario, a decimal.
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }
        //El método Limpiar será llamado por el evento click del botón btnLimpiar
        //y borrará los datos de los TextBox, ComboBox y Label de la pantalla
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
         
        }
        //El método Operar será estático recibirá los dos números y el operador para luego
        //llamar al método Operar de Calculadora y retornar el resultado al método de
        //evento del botón btnOperar que reflejará el resultado en el Label txtResultado
        private void btnOperar_Click(object sender, EventArgs e)
        {

        }
        //METODO LIMPIAR - private
        //es un método
        //y borrará los datos de los TextBox, ComboBox y Label de la pantalla
        //solo se va a usar en la propia clase
        private void Limpiar()
        {

        }
        //MÉTODO OPERAR -. private
        //El método Operar será estático recibirá los dos números y el operador para luego
        //llamar al método Operar de Calculadora y retornar el resultado al método de
        //evento del botón btnOperar que reflejará el resultado en el Label txtResultado
        static private double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
 

            switch(operador)
            {
                //hay que castear los números bb
            }

            //un switch con las operaciones

            return resultado;


        }       
    }
}
