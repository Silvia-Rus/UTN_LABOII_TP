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

        public Libro ObtenerLibro { get { return libro; } }

        public Articulo ObtenerArticulo { get { return articulo; } }

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
            else if (tipoDeFormDocumento.Equals(TipoDeFormDocumento.modificarArticulo))
            {
                //lo que se tiene que ver para modificar
                this.btnAccion.Text = "Modificar";
                this.txtBarcodeDocumento.Enabled = false;
                this.btnAccion.Click += new System.EventHandler(this.btnAccionModificar_Click);
                
            }
            else if (tipoDeFormDocumento.Equals(TipoDeFormDocumento.modificarLibro))
            {
                //lo que se tiene que ver para modificar
                this.btnAccion.Text = "Modificar";
                this.txtBarcodeDocumento.Enabled = false;
                this.lblFuenteDocumento.Visible = false;
                this.txtFuenteDocumento.Visible = false;
                this.btnAccion.Click += new System.EventHandler(this.btnAccionModificar_Click);

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
            //acción por defecto del botón Acción

            //si los campos están ok
            this.DialogResult = DialogResult.OK;

            //si no 

            //MessageBox.Show("Revise los campos");

        }



        private void btnAccionAnadirArticulo_Click(object sender, EventArgs e)
        {

            Encuadernacion encuadernado = Entidades.Encuadernacion.No;
            if (cmbEncuadernacionDocumento.SelectedIndex != -1)
            {

                foreach (Encuadernacion item in Enum.GetValues(typeof(Encuadernacion)))
                {
                    if (cmbEncuadernacionDocumento.SelectedIndex == (int)item)
                    {
                        encuadernado = item;
                    }
                }

                this.DialogResult = DialogResult.None;
                miDoc = Articulo.GenerarArticulo(txtTituloDocumento.Text, txtAutorDocumento.Text, txtAnioDocumento.Text, txtNumeroPaginasDocumento.Text, txtIdentificadorDocumento.Text, txtBarcodeDocumento.Text, rtbNotasDocumento.Text, encuadernado, txtFuenteDocumento.Text);

                if (miDoc != null)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Revise los campos");
                }
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

        private void btnAccionModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ANDA EL BOTÓN DE MODIFICAR LIBRO");
        }
    }
}
