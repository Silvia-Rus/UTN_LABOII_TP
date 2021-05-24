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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnDistribuirDocumentos_Click(object sender, EventArgs e)
        {

        }

        private void btnGuillotinarDocumentos_Click(object sender, EventArgs e)
        {

        }

        private void btnEscanearDocumento_Click(object sender, EventArgs e)
        {

        }

        private void btnRevisarDocumento_Click(object sender, EventArgs e)
        {

        }

        private void btnVerInformes_Click(object sender, EventArgs e)
        {

        }

        private void cmbAniadirDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

            FrmAltaDocumento frmAlta;

            if(cmbAniadirDocumento.Text == "Libro")
            {
                //MessageBox.Show("elegiste libro");

                frmAlta = new FrmAltaDocumento(FrmAltaDocumento.TipoDeFormAlta.libro);
                //FrmAltaDocumento frmAlta = new FrmAltaDocumento(FrmAltaDocumento.TipoDeFormAlta.libro);
                //frmAlta.ShowDialog();
            }
            else if (cmbAniadirDocumento.Text == "Artículo")
            {
                //MessageBox.Show("elegiste artículo");

                frmAlta = new FrmAltaDocumento(FrmAltaDocumento.TipoDeFormAlta.articulo);
                //FrmAltaDocumento frmAlta = new FrmAltaDocumento(FrmAltaDocumento.TipoDeFormAlta.articulo);
                //frmAlta.ShowDialog();
            }
            else
            {
                frmAlta = new FrmAltaDocumento();
                //FrmAltaDocumento frmAlta = new FrmAltaDocumento();
                //frmAlta.ShowDialog();
            }

            //frmAlta.ShowDialog();

            if(DialogResult.OK == frmAlta.ShowDialog())
            {
                MessageBox.Show("Documento grabado con éxito");
            }
            /*else
            {
                MessageBox.Show("Vuelta al formulario de Inicio.");
            }*/


        }
    }
}
