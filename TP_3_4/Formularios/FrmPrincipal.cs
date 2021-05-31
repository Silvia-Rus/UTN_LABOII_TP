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
using Consola;

namespace Formularios
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        Procesador procesador;
        Libro libro;
        Articulo articulo;
        
        public FrmPrincipal()
        {
            InitializeComponent();           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            this.procesador = new Procesador("Procesador");
            bool pudo = this.procesador + new Libro("La casa de Bernarda Alba", "Lorca", 1995, 54, "0000", 1234, "uuu", Encuadernacion.encuadernado);
            pudo = this.procesador + new Libro("Yerma", "Lorca", 1995, 54, "0001", 1235, "uuu", Encuadernacion.encuadernado);
            pudo = this.procesador + new Libro("Bodas de sangre", "Lorca", 1995, 54, "0002", 1236, "uuu", Encuadernacion.encuadernado);
            
            /*if (pudo)
            {
                MessageBox.Show("PUDO");
            }
            else
            {
                MessageBox.Show($"NOOOOO PUDO {this.procesador.Documentos}" );
            }*/

            FormatoDataGrid(gridDocumentos, procesador.Documentos);

        }

        public void FormatoDataGrid (DataGridView datagrid, List<Documento> lista)
        {
            //le pasamos la lista
            datagrid.DataSource = lista;
            //autoajustar al contenido
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ocultar columnas
            datagrid.Columns["EstadoEncuadernacion"].Visible = false;
            datagrid.Columns["NumeroPaginas"].Visible = false;
            //cabeceras
            datagrid.Columns["TipoDeDocumentoString"].HeaderText = "Tipo";
            datagrid.Columns["Anio"].HeaderText = "Año";
            datagrid.Columns["NumeroPaginasString"].HeaderText = "Nº pág.";
            datagrid.Columns["EstadoEncuadernacionString"].HeaderText = "Encuadernado";
            datagrid.Columns["FaseProceso"].HeaderText = "Fase";

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "button";
                button.HeaderText = "Button";
                button.Text = "Button";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                datagrid.Columns.Add(button);
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //Listar todos
            gridDocumentos.DataSource = procesador.Documentos;


        }

        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            //Listar los que están para distribuir
            List<Documento> listaFiltrada = new List<Documento>();
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Distribuir);
            FormatoDataGrid(gridDocumentos, listaFiltrada);


        }

        private void btnGuillotinar_Click(object sender, EventArgs e)
        {
            //Listar los que están para guillotinar
            List<Documento> listaFiltrada = new List<Documento>();
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Guillotinar);
            FormatoDataGrid(gridDocumentos, listaFiltrada);
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            //Listar los que están para escanear
            List<Documento> listaFiltrada = new List<Documento>();
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Escanear);
            FormatoDataGrid(gridDocumentos, listaFiltrada);
        }

        private void btnTerminados_Click(object sender, EventArgs e)
        {
            //Listar los que ya están terminados
            List<Documento> listaFiltrada = new List<Documento>();
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Aprobado);
            FormatoDataGrid(gridDocumentos, listaFiltrada);

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            //Ir a pantalla de informes
        }

        private void tblCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbAniadirDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmDocumento frmAlta;

            if (cmbAniadirDocumento.Text == "Libro")
            {
                //MessageBox.Show("elegiste libro");

                frmAlta = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.libro);
                //FrmAltaDocumento frmAlta = new FrmAltaDocumento(FrmAltaDocumento.TipoDeFormAlta.libro);
                //frmAlta.ShowDialog();
            }
            else if (cmbAniadirDocumento.Text == "Artículo")
            {
                //MessageBox.Show("elegiste artículo");

                frmAlta = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.articulo);
                //FrmAltaDocumento frmAlta = new FrmAltaDocumento(FrmAltaDocumento.TipoDeFormAlta.articulo);
                //frmAlta.ShowDialog();
            }
            else
            {
                frmAlta = new FrmDocumento();
                //FrmAltaDocumento frmAlta = new FrmAltaDocumento();
                //frmAlta.ShowDialog();
            }

            //frmAlta.ShowDialog();

            if (DialogResult.OK == frmAlta.ShowDialog())
            {
                MessageBox.Show("Documento grabado con éxito");

                articulo = frmAlta.ObtenerArticulo; //obtenemos el libro
                bool pudo = this.procesador + articulo;//lo sumamos a la lista
                //HACER QUE SALGA EN EL DATAGRID
            }
            /*else
            {
                MessageBox.Show("Vuelta al formulario de Inicio.");
            }*/

        }

        private void txtBuscarPorCodebar_TextChanged(object sender, EventArgs e)
        {
            bool existe = false;
            
            foreach (var item in procesador.Documentos)
            {
                if(item.Barcode == int.Parse(txtBuscarPorCodebar.Text))
                {
                    existe = true;
                    break;
                }
            }

            if(existe)
            {
                MessageBox.Show("AHHHH");
            }

        }
    }
}
