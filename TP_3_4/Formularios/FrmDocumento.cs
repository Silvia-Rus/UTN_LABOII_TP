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

        Libro libro;
        Articulo articulo;

        Documento miDoc;

        public Documento ObtenerDoc { get { return miDoc; } }
        public string Titulo { set { txtTituloDocumento.Text = value; } }
        public string Autor { set { txtAutorDocumento.Text = value; } }
        public string Anio { set { txtAnioDocumento.Text = value; } }
        public string NumeroPaginas { set { txtNumeroPaginasDocumento.Text = value; } }
        public string Barcode { set { txtBarcodeDocumento.Text = value; } }
        public string Notas { set { rtbNotasDocumento.Text = value;  } }
        public string Fuente { set { txtFuenteDocumento.Text = value; } }
        public string Id { set { txtIdentificadorDocumento.Text = value; } }
        public string Encuadernacion { set { cmbEncuadernacionDocumento.Text = value; } }
        public string Historial { set { rtbHistorialDocumento.Text = value; } }


        public FrmDocumento()
        {
            InitializeComponent();
        }

        //PONER IF DOC ES NULL?
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

        public FrmDocumento(TipoDeFormDocumento tipoDeFormDocumento, Documento documento) : this(tipoDeFormDocumento)
        {
           if(!(documento is null))
           {
                this.btnAccion.Text = "Modificar";
                this.txtBarcodeDocumento.Enabled = false;
                this.btnAccion.Click += new System.EventHandler(this.btnAccionModificar_Click);
                this.miDoc = documento;

                if (tipoDeFormDocumento.Equals(TipoDeFormDocumento.modificarArticulo))
                {
                    //lo que se tiene que ver para modificar
                    this.lblFuenteDocumento.Visible = false;
                    this.txtFuenteDocumento.Visible = false;
                }
           }
        }
        private void FrmAltaDocumento_Load(object sender, EventArgs e)
        {
           //datos
            this.cmbEncuadernacionDocumento.DataSource = Enum.GetValues(typeof(Encuadernacion));
        }
        private void btnCancelarDocumento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

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
