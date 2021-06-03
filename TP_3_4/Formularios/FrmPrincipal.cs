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
        Documento miDoc;



        public FrmPrincipal()
        {
            InitializeComponent();           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            this.procesador = new Procesador("Procesador");
            bool pudo = this.procesador + new Libro("La casa de Bernarda Alba", "Lorca", 1995, 54, "0000", 1234, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Libro("Yerma", "Lorca", 1995, 54, "0001", 1235, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Libro("Bodas de sangre", "Lorca", 1995, 54, "0002", 1236, "uuu", Encuadernacion.Si_Guillotinar);

            /*if (pudo)
            {
                MessageBox.Show("PUDO");
            }
            else
            {
                MessageBox.Show($"NOOOOO PUDO {this.procesador.Documentos}" );
            }*/

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "button";
            button.HeaderText = "Fase";
            foreach(Documento d in procesador.Documentos)
            {
                button.Text = d.FaseProceso.ToString();
            }         
            button.UseColumnTextForButtonValue = true; //dont forget this line
            gridDocumentos.Columns.Add(button);
            FormatoDataGrid(gridDocumentos, procesador.Documentos);
        }

        //el click del boton
        //1 - Busca el documento que tiene el barcode de la currentrow
        //2 - le cambia el estado Fase Proceso


        public void FormatoDataGrid (DataGridView datagrid, List<Documento> lista)
        {

            //borra la lista por las dudas
            datagrid.DataSource = null;
            
            //le pasamos la lista
            datagrid.DataSource = lista;
            //ocultamos la primera columna
            datagrid.RowHeadersVisible = false;
            //autoajustar al contenido
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ocultar columnas
            datagrid.Columns["EstadoEncuadernacion"].Visible = false;
            datagrid.Columns["FaseProceso"].Visible = false;
            datagrid.Columns["NumeroPaginas"].Visible = false;
            datagrid.Columns["Notas"].Visible = false;
            datagrid.Columns["FechaIntroduccion"].Visible = false;
            datagrid.Columns["FechaDistribucion"].Visible = false;
            datagrid.Columns["FechaGuillotinado"].Visible = false;
            datagrid.Columns["FechaEscaneo"].Visible = false;
            datagrid.Columns["FechaRevision"].Visible = false;
            datagrid.Columns["FechaAprobacion"].Visible = false;
            datagrid.Columns["HistorialProceso"].Visible = false;


            //cabeceras
            datagrid.Columns["TipoDeDocumentoString"].HeaderText = "Tipo";
            datagrid.Columns["Anio"].HeaderText = "Año";
            datagrid.Columns["NumeroPaginasString"].HeaderText = "Nº pág.";
            //datagrid.Columns[""].HeaderText = "Encuadernado";


 
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //Listar todos
           FormatoDataGrid(gridDocumentos, procesador.Documentos);
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
            //FormatoDataGrid(gridDocumentos, listaFiltrada);
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            //Listar los que están para escanear
            List<Documento> listaFiltrada = new List<Documento>();
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Escanear);
            //FormatoDataGrid(gridDocumentos, listaFiltrada);
        }

        private void btnTerminados_Click(object sender, EventArgs e)
        {
            //Listar los que ya están terminados
            List<Documento> listaFiltrada = new List<Documento>();
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Aprobado);
            //FormatoDataGrid(gridDocumentos, listaFiltrada);
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
                frmAlta = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.altaLibro);
                if (DialogResult.OK == frmAlta.ShowDialog())
                {
                    libro = (Libro)frmAlta.ObtenerDoc; //obtenemos el libro
                    if (!(libro is null))
                    {
                        if (this.procesador + articulo)
                        {
                            
                            MessageBox.Show("Artículo grabado con éxito.");
                        }
                    }
                }
            }
            else if (cmbAniadirDocumento.Text == "Artículo")
            {
                frmAlta = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.altaArticulo);
                if (DialogResult.OK == frmAlta.ShowDialog())
                {
                    articulo = (Articulo)frmAlta.ObtenerDoc; //obtenemos el libro
                    if(!(articulo is null))
                    {
                        if(this.procesador + articulo)
                        {
                            MessageBox.Show("Artículo grabado con éxito.");
                        }

                    }

                }
            }
            else
            {
                frmAlta = new FrmDocumento();
            }
                
            FormatoDataGrid(gridDocumentos, procesador.Documentos); //HACER QUE SALGA EN EL DATAGRID
        }

        private void picBuscarPorCodebar_Click(object sender, EventArgs e)
        {
            miDoc = Documento.GetByBarcode(procesador.Documentos, txtBuscarPorCodebar.Text);
            if(miDoc is null)
            {
                MessageBox.Show("nononono");
            }
            else
            {
                FrmDocumento frmModificacion;
                if(miDoc is Articulo)
                {
                    frmModificacion = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.modificarArticulo);
                    Articulo miDocAux = (Articulo)miDoc;
                    frmModificacion.Fuente = miDocAux.Fuente;
                }
                else
                {
                    frmModificacion = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.modificarLibro);
                }

                frmModificacion.Titulo = miDoc.Titulo;
                frmModificacion.Autor = miDoc.Autor;
                frmModificacion.Anio = miDoc.Anio.ToString();
                frmModificacion.Id = miDoc.Id;
                frmModificacion.NumeroPaginas = miDoc.NumeroPaginas.ToString();
                frmModificacion.Encuadernacion = miDoc.EstadoEncuadernacion.ToString();
                frmModificacion.Barcode = miDoc.Barcode.ToString();
                frmModificacion.Notas = miDoc.Notas;

                frmModificacion.Historial = miDoc.HistorialProceso;

              
                frmModificacion.ShowDialog();
            }
 
        }

    
        private void txtBuscarPorCodebar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {

                miDoc = Documento.GetByBarcode(procesador.Documentos, txtBuscarPorCodebar.Text);
                if (miDoc is null)
                {
                    MessageBox.Show("nononono");
                }
                else
                {
                    FrmDocumento frmModificacion;

                    frmModificacion = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.modificarArticulo);
                    frmModificacion.ShowDialog();

                }
            }
        }


    }
}
