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
    public partial class FrmEstadisticas :  MetroFramework.Forms.MetroForm
    {
        List<Documento> lista;
        public delegate void ManejarDato();
        public event ManejarDato actualizarDato;

        /// <summary>
        /// Iniciliaza el fromulario. Inicializa el Procesador, la listafiltrada auxiliar y el botón del datagrid.
        /// </summary>
        public FrmEstadisticas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor con la lista que llega desde el formulario principal la cual sea asocia a la del presente formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public FrmEstadisticas(List<Documento> lista) : this()
        {
            this.lista = lista;      
        }
        /// <summary>
        /// Carga el evento con los datos a mostrar en él.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEstadísticas_Load(object sender, EventArgs e)
        {
            actualizarDato += ImprimirTotalDocumentos;
            actualizarDato += ImprimirTotalPaginas;
            actualizarDato += ImprimirTotalLibros;
            actualizarDato += ImprimirTotalArticulos;
            actualizarDato.Invoke();
        }
        /// <summary>
        /// Asocia el dato del total de documentos a su correspondiente label.
        /// </summary>
        public void ImprimirTotalDocumentos()
        {
            lblCifraTotalDocumentos.Text = Informes.TotalDocumentos(lista).ToString();
        }
        /// <summary>
        /// Asocia el dato del total de páginas a su correspondiente label.
        /// </summary>
        public void ImprimirTotalPaginas()
        {
            lblCifraTotalPaginas.Text = Informes.TotalPaginas(lista).ToString();
        }
        /// <summary>
        /// Asocia el dato del total de libros a su correspondiente label.
        /// </summary>

        public void ImprimirTotalLibros()
        {
            lblCifraTotalLibros.Text = Informes.TotalLibros(lista).ToString();
        }
        /// <summary>
        /// Asocia el dato del total de artículos a su correspondiente label.
        /// </summary>
        public void ImprimirTotalArticulos()
        {
            lblCifraTotalArticulos.Text = Informes.TotalArticulos(lista).ToString();
        }
        /// <summary>
        /// Desasocia los eventos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void FrmEstadisticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            actualizarDato -= ImprimirTotalDocumentos;
            actualizarDato -= ImprimirTotalPaginas;
            actualizarDato -= ImprimirTotalLibros;
            actualizarDato -= ImprimirTotalArticulos;
        }
    }
}
