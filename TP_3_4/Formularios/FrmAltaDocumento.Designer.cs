
namespace Formularios
{
    partial class FrmAltaDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGrabarDocumento = new System.Windows.Forms.Button();
            this.btnCancelarDocumento = new System.Windows.Forms.Button();
            this.lblTituloDocumento = new System.Windows.Forms.Label();
            this.lblAutorDocumento = new System.Windows.Forms.Label();
            this.lblBarcodeDocumento = new System.Windows.Forms.Label();
            this.lblIdentificadorDocumento = new System.Windows.Forms.Label();
            this.lblEncuadernacionDocumento = new System.Windows.Forms.Label();
            this.lblNotasDocumento = new System.Windows.Forms.Label();
            this.lblAnioDocumento = new System.Windows.Forms.Label();
            this.lblNumeroPaginasDocumento = new System.Windows.Forms.Label();
            this.lblFuenteDocumento = new System.Windows.Forms.Label();
            this.txtBarcodeDocumento = new System.Windows.Forms.TextBox();
            this.txtTituloDocumento = new System.Windows.Forms.TextBox();
            this.txtAutorDocumento = new System.Windows.Forms.TextBox();
            this.txtAnioDocumento = new System.Windows.Forms.TextBox();
            this.txtIdentificadorDocumento = new System.Windows.Forms.TextBox();
            this.txtNumeroPaginasDocumento = new System.Windows.Forms.TextBox();
            this.txtNotasDocumento = new System.Windows.Forms.RichTextBox();
            this.txtFuenteDocumento = new System.Windows.Forms.TextBox();
            this.cmbEncuadernacionDocumento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGrabarDocumento
            // 
            this.btnGrabarDocumento.Location = new System.Drawing.Point(153, 361);
            this.btnGrabarDocumento.Name = "btnGrabarDocumento";
            this.btnGrabarDocumento.Size = new System.Drawing.Size(132, 48);
            this.btnGrabarDocumento.TabIndex = 0;
            this.btnGrabarDocumento.Text = "Grabar";
            this.btnGrabarDocumento.UseVisualStyleBackColor = true;
            this.btnGrabarDocumento.Click += new System.EventHandler(this.btnGrabarDocumento_Click);
            // 
            // btnCancelarDocumento
            // 
            this.btnCancelarDocumento.Location = new System.Drawing.Point(307, 361);
            this.btnCancelarDocumento.Name = "btnCancelarDocumento";
            this.btnCancelarDocumento.Size = new System.Drawing.Size(125, 48);
            this.btnCancelarDocumento.TabIndex = 1;
            this.btnCancelarDocumento.Text = "Cancelar";
            this.btnCancelarDocumento.UseVisualStyleBackColor = true;
            this.btnCancelarDocumento.Click += new System.EventHandler(this.btnCancelarDocumento_Click);
            // 
            // lblTituloDocumento
            // 
            this.lblTituloDocumento.AutoSize = true;
            this.lblTituloDocumento.Location = new System.Drawing.Point(37, 64);
            this.lblTituloDocumento.Name = "lblTituloDocumento";
            this.lblTituloDocumento.Size = new System.Drawing.Size(41, 13);
            this.lblTituloDocumento.TabIndex = 2;
            this.lblTituloDocumento.Text = "Título: ";
            // 
            // lblAutorDocumento
            // 
            this.lblAutorDocumento.AutoSize = true;
            this.lblAutorDocumento.Location = new System.Drawing.Point(40, 100);
            this.lblAutorDocumento.Name = "lblAutorDocumento";
            this.lblAutorDocumento.Size = new System.Drawing.Size(35, 13);
            this.lblAutorDocumento.TabIndex = 3;
            this.lblAutorDocumento.Text = "Autor:";
            // 
            // lblBarcodeDocumento
            // 
            this.lblBarcodeDocumento.AutoSize = true;
            this.lblBarcodeDocumento.Location = new System.Drawing.Point(324, 18);
            this.lblBarcodeDocumento.Name = "lblBarcodeDocumento";
            this.lblBarcodeDocumento.Size = new System.Drawing.Size(90, 13);
            this.lblBarcodeDocumento.TabIndex = 4;
            this.lblBarcodeDocumento.Text = "Código de barras:";
            // 
            // lblIdentificadorDocumento
            // 
            this.lblIdentificadorDocumento.AutoSize = true;
            this.lblIdentificadorDocumento.Location = new System.Drawing.Point(40, 154);
            this.lblIdentificadorDocumento.Name = "lblIdentificadorDocumento";
            this.lblIdentificadorDocumento.Size = new System.Drawing.Size(19, 13);
            this.lblIdentificadorDocumento.TabIndex = 5;
            this.lblIdentificadorDocumento.Text = "Id:";
            // 
            // lblEncuadernacionDocumento
            // 
            this.lblEncuadernacionDocumento.AutoSize = true;
            this.lblEncuadernacionDocumento.Location = new System.Drawing.Point(37, 202);
            this.lblEncuadernacionDocumento.Name = "lblEncuadernacionDocumento";
            this.lblEncuadernacionDocumento.Size = new System.Drawing.Size(88, 13);
            this.lblEncuadernacionDocumento.TabIndex = 6;
            this.lblEncuadernacionDocumento.Text = "Encuadernación:";
            // 
            // lblNotasDocumento
            // 
            this.lblNotasDocumento.AutoSize = true;
            this.lblNotasDocumento.Location = new System.Drawing.Point(37, 231);
            this.lblNotasDocumento.Name = "lblNotasDocumento";
            this.lblNotasDocumento.Size = new System.Drawing.Size(38, 13);
            this.lblNotasDocumento.TabIndex = 7;
            this.lblNotasDocumento.Text = "Notas:";
            // 
            // lblAnioDocumento
            // 
            this.lblAnioDocumento.AutoSize = true;
            this.lblAnioDocumento.Location = new System.Drawing.Point(37, 127);
            this.lblAnioDocumento.Name = "lblAnioDocumento";
            this.lblAnioDocumento.Size = new System.Drawing.Size(101, 13);
            this.lblAnioDocumento.TabIndex = 8;
            this.lblAnioDocumento.Text = "Año de publicación:";
            // 
            // lblNumeroPaginasDocumento
            // 
            this.lblNumeroPaginasDocumento.AutoSize = true;
            this.lblNumeroPaginasDocumento.Location = new System.Drawing.Point(40, 178);
            this.lblNumeroPaginasDocumento.Name = "lblNumeroPaginasDocumento";
            this.lblNumeroPaginasDocumento.Size = new System.Drawing.Size(77, 13);
            this.lblNumeroPaginasDocumento.TabIndex = 9;
            this.lblNumeroPaginasDocumento.Text = "Nº de páginas:";
            // 
            // lblFuenteDocumento
            // 
            this.lblFuenteDocumento.AutoSize = true;
            this.lblFuenteDocumento.Location = new System.Drawing.Point(40, 316);
            this.lblFuenteDocumento.Name = "lblFuenteDocumento";
            this.lblFuenteDocumento.Size = new System.Drawing.Size(43, 13);
            this.lblFuenteDocumento.TabIndex = 10;
            this.lblFuenteDocumento.Text = "Fuente:";
            // 
            // txtBarcodeDocumento
            // 
            this.txtBarcodeDocumento.Location = new System.Drawing.Point(421, 18);
            this.txtBarcodeDocumento.Name = "txtBarcodeDocumento";
            this.txtBarcodeDocumento.Size = new System.Drawing.Size(154, 20);
            this.txtBarcodeDocumento.TabIndex = 11;
            // 
            // txtTituloDocumento
            // 
            this.txtTituloDocumento.Location = new System.Drawing.Point(179, 64);
            this.txtTituloDocumento.Name = "txtTituloDocumento";
            this.txtTituloDocumento.Size = new System.Drawing.Size(396, 20);
            this.txtTituloDocumento.TabIndex = 12;
            // 
            // txtAutorDocumento
            // 
            this.txtAutorDocumento.Location = new System.Drawing.Point(179, 97);
            this.txtAutorDocumento.Name = "txtAutorDocumento";
            this.txtAutorDocumento.Size = new System.Drawing.Size(396, 20);
            this.txtAutorDocumento.TabIndex = 13;
            // 
            // txtAnioDocumento
            // 
            this.txtAnioDocumento.Location = new System.Drawing.Point(179, 123);
            this.txtAnioDocumento.Name = "txtAnioDocumento";
            this.txtAnioDocumento.Size = new System.Drawing.Size(396, 20);
            this.txtAnioDocumento.TabIndex = 14;
            // 
            // txtIdentificadorDocumento
            // 
            this.txtIdentificadorDocumento.Location = new System.Drawing.Point(179, 149);
            this.txtIdentificadorDocumento.Name = "txtIdentificadorDocumento";
            this.txtIdentificadorDocumento.Size = new System.Drawing.Size(396, 20);
            this.txtIdentificadorDocumento.TabIndex = 15;
            // 
            // txtNumeroPaginasDocumento
            // 
            this.txtNumeroPaginasDocumento.Location = new System.Drawing.Point(179, 175);
            this.txtNumeroPaginasDocumento.Name = "txtNumeroPaginasDocumento";
            this.txtNumeroPaginasDocumento.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroPaginasDocumento.TabIndex = 16;
            // 
            // txtNotasDocumento
            // 
            this.txtNotasDocumento.Location = new System.Drawing.Point(40, 247);
            this.txtNotasDocumento.Name = "txtNotasDocumento";
            this.txtNotasDocumento.Size = new System.Drawing.Size(535, 55);
            this.txtNotasDocumento.TabIndex = 18;
            this.txtNotasDocumento.Text = "";
            // 
            // txtFuenteDocumento
            // 
            this.txtFuenteDocumento.Location = new System.Drawing.Point(89, 313);
            this.txtFuenteDocumento.Name = "txtFuenteDocumento";
            this.txtFuenteDocumento.Size = new System.Drawing.Size(486, 20);
            this.txtFuenteDocumento.TabIndex = 19;
            // 
            // cmbEncuadernacionDocumento
            // 
            this.cmbEncuadernacionDocumento.FormattingEnabled = true;
            this.cmbEncuadernacionDocumento.Location = new System.Drawing.Point(179, 202);
            this.cmbEncuadernacionDocumento.Name = "cmbEncuadernacionDocumento";
            this.cmbEncuadernacionDocumento.Size = new System.Drawing.Size(147, 21);
            this.cmbEncuadernacionDocumento.TabIndex = 20;
            // 
            // FrmAltaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.cmbEncuadernacionDocumento);
            this.Controls.Add(this.txtFuenteDocumento);
            this.Controls.Add(this.txtNotasDocumento);
            this.Controls.Add(this.txtNumeroPaginasDocumento);
            this.Controls.Add(this.txtIdentificadorDocumento);
            this.Controls.Add(this.txtAnioDocumento);
            this.Controls.Add(this.txtAutorDocumento);
            this.Controls.Add(this.txtTituloDocumento);
            this.Controls.Add(this.txtBarcodeDocumento);
            this.Controls.Add(this.lblFuenteDocumento);
            this.Controls.Add(this.lblNumeroPaginasDocumento);
            this.Controls.Add(this.lblAnioDocumento);
            this.Controls.Add(this.lblNotasDocumento);
            this.Controls.Add(this.lblEncuadernacionDocumento);
            this.Controls.Add(this.lblIdentificadorDocumento);
            this.Controls.Add(this.lblBarcodeDocumento);
            this.Controls.Add(this.lblAutorDocumento);
            this.Controls.Add(this.lblTituloDocumento);
            this.Controls.Add(this.btnCancelarDocumento);
            this.Controls.Add(this.btnGrabarDocumento);
            this.Name = "FrmAltaDocumento";
            this.Text = "Alta de Documento";
            this.Load += new System.EventHandler(this.FrmAltaDocumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabarDocumento;
        private System.Windows.Forms.Button btnCancelarDocumento;
        private System.Windows.Forms.Label lblTituloDocumento;
        private System.Windows.Forms.Label lblAutorDocumento;
        private System.Windows.Forms.Label lblBarcodeDocumento;
        private System.Windows.Forms.Label lblIdentificadorDocumento;
        private System.Windows.Forms.Label lblEncuadernacionDocumento;
        private System.Windows.Forms.Label lblNotasDocumento;
        private System.Windows.Forms.Label lblAnioDocumento;
        private System.Windows.Forms.Label lblNumeroPaginasDocumento;
        private System.Windows.Forms.Label lblFuenteDocumento;
        private System.Windows.Forms.TextBox txtBarcodeDocumento;
        private System.Windows.Forms.TextBox txtTituloDocumento;
        private System.Windows.Forms.TextBox txtAutorDocumento;
        private System.Windows.Forms.TextBox txtAnioDocumento;
        private System.Windows.Forms.TextBox txtIdentificadorDocumento;
        private System.Windows.Forms.TextBox txtNumeroPaginasDocumento;
        private System.Windows.Forms.RichTextBox txtNotasDocumento;
        private System.Windows.Forms.TextBox txtFuenteDocumento;
        private System.Windows.Forms.ComboBox cmbEncuadernacionDocumento;
    }
}