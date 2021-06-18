using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmAyuda :  MetroFramework.Forms.MetroForm
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            rtbAyuda.Text = TextoAyuda();
        }

        private string TextoAyuda()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Primera linea de ayuda.");
            sb.AppendLine("Segunda linea de ayuda.");

            return sb.ToString();
        }
    }
}
