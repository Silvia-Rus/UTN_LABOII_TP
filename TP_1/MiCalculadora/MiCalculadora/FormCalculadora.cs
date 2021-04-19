using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        //PARTE LÓGICA
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        //El botón btnCerrar deberá cerrar el formulario.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //El evento click del botón btnConvertirABinario convertirá
        //el resultado, de existir, a binario.
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Numero().DecimalBinario(this.lblResultado.Text);


        }
        //El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y
        //ser binario, a decimal.
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numeroAConvertir = new Numero();
            string resultado = numeroAConvertir.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = resultado;

        }
        //El método Limpiar será llamado por el evento click del botón btnLimpiar
        //y borrará los datos de los TextBox, ComboBox y Label de la pantalla
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //El método Operar será estático recibirá los dos números y el operador para luego
        //llamar al método Operar de Calculadora y retornar el resultado al método de
        //evento del botón btnOperar que reflejará el resultado en el Label txtResultado
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            this.lblResultado.Text = resultado.ToString();
        }
        //METODO LIMPIAR - private
        //es un método
        //y borrará los datos de los TextBox, ComboBox y Label de la pantalla
        //solo se va a usar en la propia clase
        private void Limpiar()
        {
            this.txtNumero1.Text = null;
            this.txtNumero2.Text = null;
            this.cmbOperador.Text = null;
            this.lblResultado.Text = null;


        }
        //MÉTODO OPERAR -. private
        //El método Operar será estático recibirá los dos números y el operador para luego
        //llamar al método Operar de Calculadora y retornar el resultado al método de
        //evento del botón btnOperar que reflejará el resultado en el Label txtResultado
        static private double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            Numero numero1Convertido = new Numero(numero1);
            Numero numero2Convertido = new Numero(numero2);
            resultado = Calculadora.Operar(numero1Convertido, numero2Convertido, operador);
            return resultado;
        }
    }
}