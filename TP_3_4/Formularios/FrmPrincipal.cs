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
        Libro libro; //quitarlo cuando se solucione el obtener nosequé
        Articulo articulo; //quitarlo cuando se solucione el obtener nosequé
        Documento miDoc;
        List<Documento> listaFiltrada;
        string ultimoPresionado;
        DataGridViewButtonColumn button;


        public FrmPrincipal()
        {
            InitializeComponent();
            this.procesador = new Procesador("Procesador");
            listaFiltrada = new List<Documento>();
            button =  new DataGridViewButtonColumn();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            FormatoButton(gridDocumentos, button);

            bool pudo = this.procesador + new Libro("La casa de Bernarda Alba", "Lorca", 1995, 54, "0000", 1234, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Libro("Yerma", "Lorca", 1995, 54, "0001", 1235, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Articulo("Bodas de sangre", "Lorca", 1995, 54, "0002", 1236, "uuu", Encuadernacion.Si_Guillotinar, "fuente");

            //FormatoDataGrid(gridDocumentos, procesador.Documentos, button);
            ultimoPresionado = "btnTodos";
            RefrescarDatagrid(gridDocumentos, PasosProceso.Todos);

        }

        private void FormatoButton(DataGridView datagrid, DataGridViewButtonColumn button)
        {
            button.Name = "button";
            button.HeaderText = "";

            button.UseColumnTextForButtonValue = true; //dont forget this line


            datagrid.Columns.Add(button);
        }
        private void FormatoDataGrid(DataGridView datagrid, List<Documento> lista, DataGridViewButtonColumn button)
        {
            //borra la lista por las dudas
            datagrid.DataSource = null;
            datagrid.DataSource = lista;

            button.Text = "-->";
            //ocultamos la primera columna
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
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //FormatoDataGrid(gridDocumentos, procesador.Documentos, button);
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Todos);
        }

        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Distribuir);
        }

        private void RefrescarDatagrid(DataGridView datagrid, PasosProceso paso)
        {
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, paso);
            if(listaFiltrada.Count < 1)
            {
                datagrid.Visible = false;
                txtAvisoSuperior.Visible = true;
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
                datagrid.Visible = true;
                txtAvisoSuperior.Visible = false;
                FormatoDataGrid(datagrid, listaFiltrada, button);

            }
            
            
        }


        private void btnGuillotinar_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Guillotinar);

        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Escanear);
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Revisar);
        }

        private void btnTerminados_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Aprobado);
        }

        private void gridDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Documento aux = (Documento)gridDocumentos.CurrentRow.DataBoundItem;

            if (gridDocumentos.CurrentCell.ColumnIndex == 0)
            {
                if (aux.FaseProceso == PasosProceso.Revisar)
                {
                    Procesador.Revisar(aux, true);

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

            RecargarDatagridSegunBoton();

        }

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
        private void btnInformes_Click(object sender, EventArgs e)
        {
            try
            {
                Xml<List<Documento>> miVariable = new Xml<List<Documento>>();

                if (miVariable.Exportar(procesador.Documentos))
                {
                    MessageBox.Show("PUDO");
                }
                else
                {
                    MessageBox.Show("NO PUDO");
                }
            }
            catch (Exception exc)
            {


            }


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
            FormatoDataGrid(gridDocumentos, procesador.Documentos, button); //HACER QUE SALGA EN EL DATAGRID
            //FormatoDataGrid(gridDocumentos, procesador.Documentos, PasosProceso.Todos); //HACER QUE SALGA EN EL DATAGRID
        }

        private void picBuscarPorCodebar_Click(object sender, EventArgs e)
        {
            miDoc = Documento.GetByBarcode(procesador.Documentos, txtBuscarPorCodebar.Text);
            if(!(miDoc is null))
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

        private void txtBuscarPorCodebar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                miDoc = Documento.GetByBarcode(procesador.Documentos, txtBuscarPorCodebar.Text);

                if(!(miDoc is null))
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
