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
        Libro libro; //quitarlo cuando se solucione el obtener nosequé
        Articulo articulo; //quitarlo cuando se solucione el obtener nosequé
        Documento miDoc;
        List<Documento> listaFiltrada = new List<Documento>();





        public FrmPrincipal()
        {
            InitializeComponent();           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            this.procesador = new Procesador("Procesador");
            bool pudo = this.procesador + new Libro("La casa de Bernarda Alba", "Lorca", 1995, 54, "0000", 1234, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Libro("Yerma", "Lorca", 1995, 54, "0001", 1235, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Articulo("Bodas de sangre", "Lorca", 1995, 54, "0002", 1236, "uuu", Encuadernacion.Si_Guillotinar, "fuente");

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
            button.HeaderText = "";
            foreach (Documento d in procesador.Documentos)
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

            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Distribuir);
            FormatoDataGrid(gridDocumentos, listaFiltrada);
        }

        private void btnGuillotinar_Click(object sender, EventArgs e)
        {
            //Listar los que están para guillotinar

            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Guillotinar);
            FormatoDataGrid(gridDocumentos, listaFiltrada);
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            //Listar los que están para escanear
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Escanear);
            FormatoDataGrid(gridDocumentos, listaFiltrada);
        }

        private void btnTerminados_Click(object sender, EventArgs e)
        {
            //Listar los que ya están terminados
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
                frmAlta = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.altaLibro);
                if (DialogResult.OK == frmAlta.ShowDialog())
                {
                    libro = (Libro)frmAlta.ObtenerDoc; //obtenemos el libro
                    if (!(libro is null) && this.procesador + libro)
                    {                         
                         MessageBox.Show("Libro grabado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema grabando el libro.");
                    }
                }          
            }
            else if (cmbAniadirDocumento.Text == "Artículo")
            {
                frmAlta = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.altaArticulo);
                if (DialogResult.OK == frmAlta.ShowDialog())
                {
                    articulo = (Articulo)frmAlta.ObtenerDoc; //obtenemos el libro
                    if (!(articulo is null) && this.procesador + articulo)
                    {
                        MessageBox.Show("Artículo grabado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema grabando el artículo.");
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
            FrmDocumento frmModificar =LanzarFormModificacion(miDoc);
            if (DialogResult.OK == frmModificar.ShowDialog())                                                                                                    
            {

                MessageBox.Show("Documento modificado con éxito.");
                FormatoDataGrid(gridDocumentos, procesador.Documentos);

            }
            //else { MessageBox.Show("SALIÓ"); }
        }

        private void txtBuscarPorCodebar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                miDoc = Documento.GetByBarcode(procesador.Documentos, txtBuscarPorCodebar.Text);
                FrmDocumento frmModificar = LanzarFormModificacion(miDoc);
                if (DialogResult.OK == frmModificar.ShowDialog())
                {
                    MessageBox.Show("Documento modificado con éxito.");
                    FormatoDataGrid(gridDocumentos, procesador.Documentos);
                }
            }
        }

        public FrmDocumento LanzarFormModificacion(Documento documento)
        {
            FrmDocumento frmModificacion = null;
            if (documento is null)
            {
                MessageBox.Show("El documento no existe.");
            }
            else
            {             
                if (documento is Articulo)
                {
                    frmModificacion = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.modificarArticulo, documento);                  
                }
                else
                {
                    frmModificacion = new FrmDocumento(FrmDocumento.TipoDeFormDocumento.modificarLibro, documento);
                }
                ImprimirDatosDocumento(frmModificacion, documento);
            }
            return frmModificacion;
        }

        public void  ImprimirDatosDocumento(FrmDocumento form, Documento documento)
        {
            form.Titulo = documento.Titulo;
            form.Autor = documento.Autor;
            form.Anio = documento.Anio.ToString();
            form.Id = documento.Id;
            form.NumeroPaginas = documento.NumeroPaginas.ToString();
            form.Encuadernacion = documento.EstadoEncuadernacion.ToString();
            form.Barcode = documento.Barcode.ToString();
            form.Notas = documento.Notas;
            form.Historial = documento.HistorialProceso;
            if(documento is Articulo)
            {
                Articulo docAux = (Articulo)documento;
                form.Fuente = docAux.Fuente;
            }
        }

        private void gridDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Documento aux = procesador.Documentos[gridDocumentos.CurrentRow.Index];
            if (gridDocumentos.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("TOCO LOS BOTONES OMG");
                Procesador.Proceso(aux);
            }
            else
            {
                FrmDocumento frmModificar = LanzarFormModificacion(aux);
                if (DialogResult.OK == frmModificar.ShowDialog())
                {
                    MessageBox.Show("Documento modificado con éxito.");
                    FormatoDataGrid(gridDocumentos, procesador.Documentos);
                }
            }


        }
    }
}
