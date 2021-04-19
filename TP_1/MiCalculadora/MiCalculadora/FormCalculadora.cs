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
        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //El botón btnCerrar deberá cerrar el formulario.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Convierte a binario el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Numero().DecimalBinario(this.lblResultado.Text);
        }
        /// <summary>
        /// Convertirá el resultado, de existir y ser binario, a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numeroAConvertir = new Numero();
            string resultado = numeroAConvertir.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = resultado;

        }
        /// <summary>
        /// Llama por el evento click del botón btnLimpiar y borra los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Recibirá los dos números y el operador para luego llamar al método Operar de Calculadora y retornar el resultado al método de
        /// evento del botón btnOperar que reflejará el resultado en el Label txtResultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            this.lblResultado.Text = resultado.ToString();
        }
        /// <summary>
        /// Borra los datos de los TextBox, ComboBox y Label de la pantalla
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = null;
            this.txtNumero2.Text = null;
            this.cmbOperador.Text = null;
            this.lblResultado.Text = null;
        }
        /// <summary>
        /// Recibe los dos números y el operador para luego
        /// llamar al método Operar de Calculadora y retornar el resultado al método de
        /// evento del botón btnOperar que reflejará el resultado en el Label txtResultado
        /// </summary>
        /// <param name="numero1">Primer valor.</param>
        /// <param name="numero2">Segundo valor.</param>
        /// <param name="operador">Operador a usar.</param>
        /// <returns>Resultado de la operación.</returns>
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