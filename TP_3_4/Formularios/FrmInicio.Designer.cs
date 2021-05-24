
namespace Formularios
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDistribuirDocumentos = new System.Windows.Forms.Button();
            this.btnGuillotinarDocumentos = new System.Windows.Forms.Button();
            this.btnEscanearDocumento = new System.Windows.Forms.Button();
            this.btnRevisarDocumento = new System.Windows.Forms.Button();
            this.btnVerInformes = new System.Windows.Forms.Button();
            this.cmbAniadirDocumento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDistribuirDocumentos
            // 
            this.btnDistribuirDocumentos.BackColor = System.Drawing.Color.Orange;
            this.btnDistribuirDocumentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuirDocumentos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDistribuirDocumentos.Location = new System.Drawing.Point(9, 144);
            this.btnDistribuirDocumentos.Name = "btnDistribuirDocumentos";
            this.btnDistribuirDocumentos.Size = new System.Drawing.Size(285, 47);
            this.btnDistribuirDocumentos.TabIndex = 1;
            this.btnDistribuirDocumentos.Text = "Distribuir";
            this.btnDistribuirDocumentos.UseVisualStyleBackColor = false;
            this.btnDistribuirDocumentos.Click += new System.EventHandler(this.btnDistribuirDocumentos_Click);
            // 
            // btnGuillotinarDocumentos
            // 
            this.btnGuillotinarDocumentos.BackColor = System.Drawing.Color.Orange;
            this.btnGuillotinarDocumentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuillotinarDocumentos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGuillotinarDocumentos.Location = new System.Drawing.Point(9, 197);
            this.btnGuillotinarDocumentos.Name = "btnGuillotinarDocumentos";
            this.btnGuillotinarDocumentos.Size = new System.Drawing.Size(285, 47);
            this.btnGuillotinarDocumentos.TabIndex = 2;
            this.btnGuillotinarDocumentos.Text = "Guillotinar";
            this.btnGuillotinarDocumentos.UseVisualStyleBackColor = false;
            this.btnGuillotinarDocumentos.Click += new System.EventHandler(this.btnGuillotinarDocumentos_Click);
            // 
            // btnEscanearDocumento
            // 
            this.btnEscanearDocumento.BackColor = System.Drawing.Color.Orange;
            this.btnEscanearDocumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanearDocumento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEscanearDocumento.Location = new System.Drawing.Point(9, 250);
            this.btnEscanearDocumento.Name = "btnEscanearDocumento";
            this.btnEscanearDocumento.Size = new System.Drawing.Size(285, 47);
            this.btnEscanearDocumento.TabIndex = 3;
            this.btnEscanearDocumento.Text = "Escanear";
            this.btnEscanearDocumento.UseVisualStyleBackColor = false;
            this.btnEscanearDocumento.Click += new System.EventHandler(this.btnEscanearDocumento_Click);
            // 
            // btnRevisarDocumento
            // 
            this.btnRevisarDocumento.BackColor = System.Drawing.Color.Orange;
            this.btnRevisarDocumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisarDocumento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRevisarDocumento.Location = new System.Drawing.Point(9, 303);
            this.btnRevisarDocumento.Name = "btnRevisarDocumento";
            this.btnRevisarDocumento.Size = new System.Drawing.Size(285, 47);
            this.btnRevisarDocumento.TabIndex = 4;
            this.btnRevisarDocumento.Text = "Revisar";
            this.btnRevisarDocumento.UseVisualStyleBackColor = false;
            this.btnRevisarDocumento.Click += new System.EventHandler(this.btnRevisarDocumento_Click);
            // 
            // btnVerInformes
            // 
            this.btnVerInformes.BackColor = System.Drawing.Color.Sienna;
            this.btnVerInformes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInformes.ForeColor = System.Drawing.Color.Bisque;
            this.btnVerInformes.Location = new System.Drawing.Point(9, 371);
            this.btnVerInformes.Name = "btnVerInformes";
            this.btnVerInformes.Size = new System.Drawing.Size(285, 47);
            this.btnVerInformes.TabIndex = 6;
            this.btnVerInformes.Text = "Ver Informes";
            this.btnVerInformes.UseVisualStyleBackColor = false;
            this.btnVerInformes.Visible = false;
            this.btnVerInformes.Click += new System.EventHandler(this.btnVerInformes_Click);
            // 
            // cmbAniadirDocumento
            // 
            this.cmbAniadirDocumento.AutoCompleteCustomSource.AddRange(new string[] {
            "Artículo",
            "Libro"});
            this.cmbAniadirDocumento.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbAniadirDocumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAniadirDocumento.ForeColor = System.Drawing.Color.Chocolate;
            this.cmbAniadirDocumento.FormattingEnabled = true;
            this.cmbAniadirDocumento.Items.AddRange(new object[] {
            "Artículo",
            "Libro"});
            this.cmbAniadirDocumento.Location = new System.Drawing.Point(12, 66);
            this.cmbAniadirDocumento.Name = "cmbAniadirDocumento";
            this.cmbAniadirDocumento.Size = new System.Drawing.Size(285, 26);
            this.cmbAniadirDocumento.TabIndex = 7;
            this.cmbAniadirDocumento.Text = "Añadir Documento";
            this.cmbAniadirDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbAniadirDocumento_SelectedIndexChanged);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(306, 439);
            this.Controls.Add(this.cmbAniadirDocumento);
            this.Controls.Add(this.btnVerInformes);
            this.Controls.Add(this.btnRevisarDocumento);
            this.Controls.Add(this.btnEscanearDocumento);
            this.Controls.Add(this.btnGuillotinarDocumentos);
            this.Controls.Add(this.btnDistribuirDocumentos);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDistribuirDocumentos;
        private System.Windows.Forms.Button btnGuillotinarDocumentos;
        private System.Windows.Forms.Button btnEscanearDocumento;
        private System.Windows.Forms.Button btnRevisarDocumento;
        private System.Windows.Forms.Button btnVerInformes;
        private System.Windows.Forms.ComboBox cmbAniadirDocumento;
    }
}

