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
        public enum TipoDeFormDocumento { altaArticulo, altaLibro, modificarArticulo, modificarLibro }

        Documento miDoc;

        /// <summary>
        /// Devuelve los documentos generados.
        /// </summary>
        public Documento ObtenerDoc { get { return miDoc; } }
        /// <summary>
        /// Añade un título a un documento.
        /// </summary>
        public string Titulo { set { txtTituloDocumento.Text = value; } }
        /// <summary>
        /// Añade un autor a un documento.
        /// </summary>
        public string Autor { set { txtAutorDocumento.Text = value; } }
        /// <summary>
        /// Añade un año a un documento.
        /// </summary>
        public string Anio { set { txtAnioDocumento.Text = value; } }
        /// <summary>
        /// Añade un número de páginas a un documento.
        /// </summary>
        public string NumeroPaginas { set { txtNumeroPaginasDocumento.Text = value; } }
        /// <summary>
        /// Añade un barcode a un documento.
        /// </summary>
        public string Barcode { set { txtBarcodeDocumento.Text = value; } }
        /// <summary>
        /// Añade notas al documento.
        /// </summary>
        public string Notas { set { rtbNotasDocumento.Text = value;  } }
        /// <summary>
        /// Añade la fuente al artículo.
        /// </summary>
        public string Fuente { set { txtFuenteDocumento.Text = value; } }
        /// <summary>
        /// Añade un id al documento.
        /// </summary>
        public string Id { set { txtIdentificadorDocumento.Text = value; } }
        /// <summary>
        /// Añade la encuadernación a un documento.
        /// </summary>
        public string Encuadernacion { set { cmbEncuadernacionDocumento.Text = value; } }
        /// <summary>
        /// Añade el historial de revisión de un documento.
        /// </summary>
        public string Historial { set { rtbHistorialDocumento.Text = value; } }

        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public FrmDocumento()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor sobrecargado con los tipos de formulario de alta.
        /// </summary>
        /// <param name="tipoDeFormDocumento"></param>
        public FrmDocumento(TipoDeFormDocumento tipoDeFormDocumento) : this()
        {
            if (tipoDeFormDocumento.Equals(TipoDeFormDocumento.altaArticulo))
            {
                //lo que se tiene que ver para los artículos
                this.Text = "Alta de Artículo";
                this.btnAccion.Click += new System.EventHandler(this.btnAccionAnadirArticulo_Click);
            }
            else if (tipoDeFormDocumento.Equals(TipoDeFormDocumento.altaLibro))
            {
                //lo que se tiene que ver para los libros
                this.Text = "Alta de Libro";
                this.lblFuenteDocumento.Visible = false;
                this.txtFuenteDocumento.Visible = false;
                this.btnAccion.Click += new System.EventHandler(this.btnAccionAnadirLibro_Click);
            }
        }
        /// <summary>
        /// Constructor sobrecargado con los tipos de formulario de modificación y el documento a modificar.
        /// </summary>
        /// <param name="tipoDeFormDocumento">Form a lanzar.</param>
        /// <param name="documento">Documento a modificar.</param>
        public FrmDocumento(TipoDeFormDocumento tipoDeFormDocumento, Documento documento) : this(tipoDeFormDocumento)
        {
           if(!(documento is null))
           {
                this.btnAccion.Text = "Modificar";
                this.txtBarcodeDocumento.Enabled = false;
                this.btnAccion.Click += new System.EventHandler(this.btnAccionModificar_Click);
                this.miDoc = documento;

                if (tipoDeFormDocumento.Equals(TipoDeFormDocumento.modificarLibro))
                {
                    this.lblFuenteDocumento.Visible = false;
                    this.txtFuenteDocumento.Visible = false;
                }
           }
        }
        /// <summary>
        /// Carga el formulario y configura el combo del estado de encuadernación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaDocumento_Load(object sender, EventArgs e)
        {
            this.cmbEncuadernacionDocumento.DataSource = Enum.GetValues(typeof(Encuadernacion));
        }
        /// <summary>
        /// Cancela la operación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarDocumento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Devuelve ok.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Genera un artículo nuevo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccionAnadirArticulo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            miDoc = Articulo.GenerarArticulo(txtTituloDocumento.Text,
                                                                txtAutorDocumento.Text,
                                                                txtAnioDocumento.Text,
                                                                txtNumeroPaginasDocumento.Text,
                                                                txtIdentificadorDocumento.Text,
                                                                txtBarcodeDocumento.Text,
                                                                rtbNotasDocumento.Text,
                                                                cmbEncuadernacionDocumento.SelectedIndex,
                                                                txtFuenteDocumento.Text);
                if(!(miDoc is null))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Revise los campos");
                    this.DialogResult = DialogResult.None;
                }
        }
        /// <summary>
        /// Genera un libro nuevo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccionAnadirLibro_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            miDoc = (Libro)Documento.GenerarDocumento("Libro",
                                                txtTituloDocumento.Text,
                                                txtAutorDocumento.Text,
                                                txtAnioDocumento.Text,
                                                txtNumeroPaginasDocumento.Text,
                                                txtIdentificadorDocumento.Text,
                                                txtBarcodeDocumento.Text,
                                                rtbNotasDocumento.Text,
                                                cmbEncuadernacionDocumento.SelectedIndex);
            if (!(miDoc is null))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Revise los campos");
                this.DialogResult = DialogResult.None;
            }
        }
        /// <summary>
        /// Modifica el documento mostrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccionModificar_Click(object sender, EventArgs e)
        {
            if(miDoc is Articulo)
            {
                this.DialogResult = DialogResult.None;

               if( Articulo.ModificarArticulo(miDoc,
                                           txtTituloDocumento.Text,
                                           txtAutorDocumento.Text,
                                           txtAnioDocumento.Text,
                                           txtNumeroPaginasDocumento.Text,
                                           txtIdentificadorDocumento.Text,
                                           rtbNotasDocumento.Text,
                                           cmbEncuadernacionDocumento.SelectedIndex,
                                           txtFuenteDocumento.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }           
            }
            else if (miDoc is Libro)
            {
                this.DialogResult = DialogResult.None;

                if (Documento.ModificarDocumento(miDoc,
                                            txtTituloDocumento.Text,
                                            txtAutorDocumento.Text,
                                            txtAnioDocumento.Text,
                                            txtNumeroPaginasDocumento.Text,
                                            txtIdentificadorDocumento.Text,
                                            rtbNotasDocumento.Text,
                                            cmbEncuadernacionDocumento.SelectedIndex))
                {
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

    }
}
