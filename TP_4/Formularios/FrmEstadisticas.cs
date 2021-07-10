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

        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        public FrmEstadisticas(List<Documento> lista) : this()
        {
            this.lista = lista;      
        }

        private void FrmEstadísticas_Load(object sender, EventArgs e)
        {
            actualizarDato += ImprimirTotalDocumentos;
            actualizarDato += ImprimirTotalPaginas;
            actualizarDato += ImprimirTotalLibros;
            actualizarDato += ImprimirTotalArticulos;
            actualizarDato.Invoke();
        }

        public void ImprimirTotalDocumentos()
        {
            lblCifraTotalDocumentos.Text = Informes.TotalDocumentos(lista).ToString();
        }

        public void ImprimirTotalPaginas()
        {
            lblCifraTotalPaginas.Text = Informes.TotalPaginas(lista).ToString();
        }
        
        public void ImprimirTotalLibros()
        {
            lblCifraTotalLibros.Text = Informes.TotalLibros(lista).ToString();
        }

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
