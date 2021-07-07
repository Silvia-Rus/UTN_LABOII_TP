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
        //public delegate void EventHandler(object sender, EventArgs e);
        //public event EventHandler Click;
        //this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
        //private void btnAccionModificar_Click(object sender, EventArgs e)
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

        }

       

    }
}
