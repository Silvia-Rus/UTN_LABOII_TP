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


        public FrmPrincipal()
        {
            InitializeComponent();
            this.procesador = new Procesador("Procesador");
            listaFiltrada = new List<Documento>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            ultimoPresionado = "btnTodos";

            bool pudo = this.procesador + new Libro("La casa de Bernarda Alba", "Lorca", 1995, 54, "0000", 1234, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Libro("Yerma", "Lorca", 1995, 54, "0001", 1235, "uuu", Encuadernacion.No);
            pudo = this.procesador + new Articulo("Bodas de sangre", "Lorca", 1995, 54, "0002", 1236, "uuu", Encuadernacion.Si_Guillotinar, "fuente");

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


        public void FormatoDataGrid(DataGridView datagrid, List<Documento> lista)
        {
            //borra la lista por las dudas
            datagrid.DataSource = null;

            datagrid.DataSource = lista;
            //ocultamos la primera columna
            datagrid.RowHeadersVisible = false;
            //autoajustar al contenido
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ocultar columnas
            datagrid.Columns["EstadoEncuadernacion"].Visible = false;
            datagrid.Columns["FaseProceso"].Visible = true;
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

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            FormatoDataGrid(gridDocumentos, procesador.Documentos);
        }

        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            ultimoPresionado = ((Button)sender).Name;
            RefrescarDatagrid(gridDocumentos, PasosProceso.Distribuir);
        }

        private void RefrescarDatagrid(DataGridView grilla, PasosProceso paso)
        {
            listaFiltrada = procesador.ListaFiltrada(procesador.Documentos, paso);
            FormatoDataGrid(grilla, listaFiltrada);
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
                if (aux.FaseProceso == PasosProceso.Escanear)
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
            FormatoDataGrid(gridDocumentos, procesador.Documentos); //HACER QUE SALGA EN EL DATAGRID
            //FormatoDataGrid(gridDocumentos, procesador.Documentos, PasosProceso.Todos); //HACER QUE SALGA EN EL DATAGRID
        }

        private void picBuscarPorCodebar_Click(object sender, EventArgs e)
        {
            miDoc = Documento.GetByBarcode(procesador.Documentos, txtBuscarPorCodebar.Text);
            FrmDocumento frmModificar = LanzarFormModificacion(miDoc);
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
