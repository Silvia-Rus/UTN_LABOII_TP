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

namespace Formularios
{
    //public partial class FrmAltaDocumento : Form
    public partial class FrmDocumento :  MetroFramework.Forms.MetroForm
    {
        public enum TipoDeFormDocumento { articulo, libro, modificar }

        Libro libro;
        Articulo articulo;

        public Libro ObtenerLibro { get { return libro; } }
        public Articulo ObtenerArticulo { get { return articulo; } }




        public FrmDocumento()
        {
            InitializeComponent();
        }

        
        public FrmDocumento(TipoDeFormDocumento tipoDeFormAlta) : this()
        {
            if (tipoDeFormAlta.Equals(TipoDeFormDocumento.articulo))
            {
                //lo que se tiene que ver para los artículos
                this.Text = "Alta de Artículo";
                this.btnAccion.Click += new System.EventHandler(this.btnAccionAnadirArticulo_Click);
            }
            else if (tipoDeFormAlta.Equals(TipoDeFormDocumento.libro))
            {
                //lo que se tiene que ver para los libros
                this.Text = "Alta de Libro";
                this.lblFuenteDocumento.Visible = false;
                this.txtFuenteDocumento.Visible = false;
                this.btnAccion.Click += new System.EventHandler(this.btnAccionAnadirLibro_Click);
            }
            else if (tipoDeFormAlta.Equals(TipoDeFormDocumento.modificar))
            {
                //lo que se tiene que ver para modificar
                this.Text = "Modificación";

            }

        }

        private void FrmAltaDocumento_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarDocumento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            //falta hacer que todos los campos se graben etc.
            //GRABAR

           
            //txtTituloDocumento.Text
            //txtAutorDocumento.Text

            //txtIdentificadorDocumento.Text



          




            //si los campos están ok
            this.DialogResult = DialogResult.OK;

            //si no 

            //MessageBox.Show("Revise los campos");

        }

        private void btnAccionAnadirArticulo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ANDA EL BOTÓN DE GRABAR ARTICULO");

            this.DialogResult = DialogResult.None;

            if (txtIdentificadorDocumento.Text.Length > 0 &&
                txtBarcodeDocumento.Text.Length > 0 &&
                short.TryParse(txtAnioDocumento.Text, out short anio) &&
                short.TryParse(txtNumeroPaginasDocumento.Text, out short numeroPaginas) &&
                int.TryParse(txtBarcodeDocumento.Text, out int barcode))
            {
                articulo = new Articulo();
                Encuadernacion encConvertida = articulo.ConversorEncuadernacion(cmbEncuadernacionDocumento.Text);
                articulo = new Articulo(txtTituloDocumento.Text,
                                       txtAutorDocumento.Text,
                                       anio,
                                       numeroPaginas,
                                       txtIdentificadorDocumento.Text,
                                       barcode,
                                       txtNotasDocumento.Text,
                                       encConvertida,
                                       txtFuenteDocumento.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                
                MessageBox.Show("Revise los campos");
            }
           
        }

        private void btnAccionAnadirLibro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ANDA EL BOTÓN DE GRABAR LIBRO");
        }
    }
}
