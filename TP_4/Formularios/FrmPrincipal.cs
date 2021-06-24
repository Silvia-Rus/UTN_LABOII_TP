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
using Serializador;

namespace Formularios
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        Procesador procesador;
        Libro libro; 
        Articulo articulo; 
        Documento miDoc;
        List<Documento> listaFiltrada;
        string ultimoPresionado;
        DataGridViewButtonColumn button;
        FrmDocumento frmAlta;

        #region Controles
        /// <summary>
        /// Iniciliaza el fromulario. Inicializa el Procesador, la listafiltrada auxiliar y el botón del datagrid.
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            this.procesador = new Procesador("Procesador");
            listaFiltrada = new List<Documento>();
            button =  new DataGridViewButtonColumn();
        }
        /// <summary>
        /// Carga el formato del botón y desserializa los registros de prueba.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FormatoButton(gridDocumentos, button);
            List<Documento> listaDeserializadora = new List<Documento>();
            Xml<List<Documento>> miVariable = new Xml<List<Documento>>();
            
            try
            {
                miVariable.Importar(Environment.CurrentDirectory + @"\ImportXml\Inicio.xml", out listaDeserializadora);
            }
            catch (Exception exc)
            {
               MessageBox.Show(exc.Message);
            }

            this.procesador.Documentos = listaDeserializadora;
            ultimoPresionado = "btnTodos";
            RefrescarDatagrid(gridDocumentos, PasosProceso.Todos);
        }
        /// <summary>
        /// Muestra la grilla con todos los documentos en el sistema. Cambia el último botón presionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void btnTodos_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Todos);
        }
        /// <summary>
        /// Muestra la grilla con los documentoss a distribuir. Cambia el último botón presionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Distribuir);
        }
        /// <summary>
        /// Muestra la grilla con los documentos a guillotinar. Cambia el último botón presionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void btnGuillotinar_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Guillotinar);
        }
        /// <summary>
        /// Muestra la grilla con todos los documentos a escanear. Cambia el último botón presionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void btnEscanear_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Escanear);
        }
        /// <summary>
        /// Muestra la grilla con todos los registros en el sistema. Cambia el último botón presionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void btnRevisar_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Revisar);
        }
        /// <summary>
        /// Muestra la grilla con todos los registros aprobados. Cambia el último botón presionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void btnTerminados_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Aprobado);
        }
        /// <summary>
        /// Agrega un artículo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
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
            FormatoDataGrid(gridDocumentos, procesador.Documentos, button);

        }

        /// <summary>
        /// Agrega un libro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarLibro_Click(object sender, EventArgs e)
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
            FormatoDataGrid(gridDocumentos, procesador.Documentos, button);
        }
        /// <summary>
        /// Modifica el registro seleccionado en la tabla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Documento aux = (Documento)gridDocumentos.CurrentRow.DataBoundItem;

            if(aux.FaseProceso == PasosProceso.Aprobado)
            {
                MessageBox.Show("El documento ya está aprobado y no se puede modificar.");
            }
            else
            {
                if (gridDocumentos.CurrentCell.ColumnIndex == 0)
                {
                    if (aux.FaseProceso == PasosProceso.Revisar)
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Está correcto el PDF?", "Revisión", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Procesador.Revisar(aux, true);
                        }
                        else
                        {
                            Procesador.Revisar(aux, false);
                            MessageBox.Show("El documento vuelve al escaner.");
                        }
                    }
                    else
                    {
                        Procesador.Proceso(aux);
                    }
                }
                else
                {
                    FrmDocumento frmModificar = LanzarFormModificacion(aux);
                    if (DialogResult.OK == frmModificar.ShowDialog())
                    {
                        MessageBox.Show("Documento modificado con éxito.");
                    }
                }
            }
                               
            RecargarDatagridSegunBoton();
        }


        /// <summary>
        /// Descarga un listado en formato xml todos los registros de los documentos aprobados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformes_Click(object sender, EventArgs e)
        {
            try
            {
                listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, PasosProceso.Aprobado);
                
                if(Documento.ExportarDocumentos(listaFiltrada))
                {
                    MessageBox.Show("Exportado con éxito. Disponible en MisDocumentos/RusApp.");
                }
                else
                {
                    MessageBox.Show("Problemas al exportar.\n\n Aségurese de que hay documentos Aprobados.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }         
        }
        /// Busca en la lista de documentos el barcode introducido en el label de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBuscarPorCodebar_Click(object sender, EventArgs e)
        {
            BuscarPorCodebar(txtBuscarPorCodebar.Text);
        }
        /// <summary>
        /// Busca en la lista de documentos el barcode introducido en el label de texto cuando das enter.        
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarPorCodebar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarPorCodebar(txtBuscarPorCodebar.Text);
            }
        }
        #endregion

        #region Formato DataGrid
        /// <summary>
        /// Añade un botón al datagrid y le da formato.
        /// </summary>
        /// <param name="datagrid">datagrid al que añadir el botón.</param>
        /// <param name="button">Botón a añadir.</param>
        private void FormatoButton(DataGridView datagrid, DataGridViewButtonColumn button)
        {
            button.Name = "button";
            button.HeaderText = "";
            button.Text = "-->";
            button.UseColumnTextForButtonValue = true;
            datagrid.Columns.Add(button);
        }
        /// <summary>
        /// Le da formato al datagrid. 
        /// </summary>
        /// <param name="datagrid">Datagrid que formatear.</param>
        /// <param name="lista">Lista que se añade al datagrid.</param>
        /// <param name="button">Botón del datagrid.</param>
        private void FormatoDataGrid(DataGridView datagrid, List<Documento> lista, DataGridViewButtonColumn button)
        {
            //borra la lista por las dudas
            datagrid.DataSource = null;
            datagrid.DataSource = lista;          
            //oculta la primera columna
            datagrid.RowHeadersVisible = false;
            //autoajustar al contenido
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ocultar columnas
            datagrid.Columns["EstadoEncuadernacion"].Visible = false;
            datagrid.Columns["FaseProceso"].Visible = true;
            //int index = datagrid.Columns["FaseProceso"].Index;
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
            datagrid.Columns["FaseProceso"].HeaderText = "Acción";
            datagrid.Columns["Barcode"].HeaderText = "BCode";
        }
        /// <summary>
        /// Refresca el datagrid según el paso de los documentos contenidos en la lista. 
        /// </summary>
        /// <param name="datagrid"></param>
        /// <param name="paso"></param>
        private void RefrescarDatagrid(DataGridView datagrid, PasosProceso paso)
        {
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, paso);
            if (listaFiltrada.Count < 1)
            {
                datagrid.Visible = false;
                txtAvisoSuperior.Visible = true;
                lblSuperior.Visible = false;
                if (paso == PasosProceso.Aprobado)
                {
                   
                    txtAvisoSuperior.Text = "No hay nada aprobado todavía.";
                }
                else
                {
                    txtAvisoSuperior.Text = $"No hay nada en la pila para {paso.ToString().ToLower()}.";
                }
            }
            else
            {
                lblSuperior.Visible = true;
                datagrid.Visible = true;
                txtAvisoSuperior.Visible = false;
                FormatoDataGrid(datagrid, listaFiltrada, button);
            }
        }
        /// <summary>
        /// Recarga el datagrid según el botón pulsado.
        /// </summary>
        void RecargarDatagridSegunBoton()
        {
            switch (ultimoPresionado)
            {
                case "btnDistribuir":
                    RefrescarDatagrid(gridDocumentos, PasosProceso.Distribuir);
                    break;

                case "btnEscanear":
                    RefrescarDatagrid(gridDocumentos, PasosProceso.Escanear);
                    break;

                case "btnGuillotinar":
                    RefrescarDatagrid(gridDocumentos, PasosProceso.Guillotinar);
                    break;

                case "btnTodos":
                    RefrescarDatagrid(gridDocumentos, PasosProceso.Todos);
                    break;

                case "btnRevisar":
                    RefrescarDatagrid(gridDocumentos, PasosProceso.Revisar);
                    break;

                case "btnTerminados":
                    RefrescarDatagrid(gridDocumentos, PasosProceso.Aprobado);
                    break;
            }
        }

        #endregion

        /// <summary>
        /// Busca un documento del cual el código de barras entra por parámetro y lanza el form para que lo modifiquemos.
        /// </summary>
        /// <param name="codebar"></param>
        private void BuscarPorCodebar(string codebar)
        {
            miDoc = Documento.GetByBarcode(procesador.Documentos, codebar);
            if (!(miDoc is null))
            {
                FrmDocumento frmModificar = LanzarFormModificacion(miDoc);
                if (DialogResult.OK == frmModificar.ShowDialog())
                {

                    MessageBox.Show("Documento modificado con éxito.");
                    FormatoDataGrid(gridDocumentos, procesador.Documentos, button);
                }
            }
            else { MessageBox.Show("El Documento no existe."); }
        }
        /// <summary>
        /// Lanza el form de modificación de un documento que entra por parámetro.
        /// </summary>
        /// <param name="documento">Documento que queremos modificar.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Imprime los datos de un documento que entra por parámetro en un form.
        /// </summary>
        /// <param name="form">Al que queremos mandar los datos del documento.</param>
        /// <param name="documento">Documento del que queremos imprimir los datos.</param>
        public void ImprimirDatosDocumento(FrmDocumento form, Documento documento)
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
            if (documento is Articulo)
            {
                Articulo docAux = (Articulo)documento;
                form.Fuente = docAux.Fuente;
            }
        }

      
    }
}
