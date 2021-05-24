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
    public partial class FrmAltaDocumento : Form
    {
        public enum TipoDeFormAlta { articulo, libro, modificar }
        
        public FrmAltaDocumento()
        {
            InitializeComponent();
        }

        
        public FrmAltaDocumento(TipoDeFormAlta tipoDeFormAlta) : this()
        {
            if (tipoDeFormAlta.Equals(TipoDeFormAlta.articulo))
            {
                //lo que se tiene que ver para los artículos
                this.Text = "Alta de Artículo";
                          
            }
            else if (tipoDeFormAlta.Equals(TipoDeFormAlta.libro))
            {
                //lo que se tiene que ver para los libros
                this.Text = "Alta de Libro";
                this.lblFuenteDocumento.Visible = false;
                this.txtFuenteDocumento.Visible = false;

            }
            else if (tipoDeFormAlta.Equals(TipoDeFormAlta.modificar))
            {
                //lo que se tiene que ver para modificar
                this.Text = "Modificación";

            }

        }

        private void FrmAltaDocumento_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabarDocumento_Click(object sender, EventArgs e)
        {

            //falta hacer que todos los campos se graben etc.

            //si los campos están ok
            this.DialogResult = DialogResult.OK;

            //si no 

            //MessageBox.Show("Revise los campos");

        }

        private void btnCancelarDocumento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
