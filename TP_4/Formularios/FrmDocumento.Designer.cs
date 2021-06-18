
namespace Formularios
{
    partial class FrmDocumento
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
            this.components = new System.ComponentModel.Container();
            this.btnAccion = new System.Windows.Forms.Button();
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
            this.rtbNotasDocumento = new System.Windows.Forms.RichTextBox();
            this.txtFuenteDocumento = new System.Windows.Forms.TextBox();
            this.cmbEncuadernacionDocumento = new System.Windows.Forms.ComboBox();
            this.tblPrincipalDocumento = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbHistorialDocumento = new System.Windows.Forms.RichTextBox();
            this.lblHistorialDocumento = new System.Windows.Forms.Label();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.tblPrincipalDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(155, 432);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(132, 48);
            this.btnAccion.TabIndex = 0;
            this.btnAccion.Text = "Grabar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnCancelarDocumento
            // 
            this.btnCancelarDocumento.Location = new System.Drawing.Point(310, 432);
            this.btnCancelarDocumento.Name = "btnCancelarDocumento";
            this.btnCancelarDocumento.Size = new System.Drawing.Size(125, 48);
            this.btnCancelarDocumento.TabIndex = 1;
            this.btnCancelarDocumento.Text = "Cancelar";
            this.btnCancelarDocumento.UseVisualStyleBackColor = true;
            this.btnCancelarDocumento.Click += new System.EventHandler(this.btnCancelarDocumento_Click);
            // 
            // lblTituloDocumento
            // 
            this.lblTituloDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTituloDocumento.AutoSize = true;
            this.lblTituloDocumento.Location = new System.Drawing.Point(3, 8);
            this.lblTituloDocumento.Name = "lblTituloDocumento";
            this.lblTituloDocumento.Size = new System.Drawing.Size(41, 13);
            this.lblTituloDocumento.TabIndex = 2;
            this.lblTituloDocumento.Text = "Título: ";
            // 
            // lblAutorDocumento
            // 
            this.lblAutorDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAutorDocumento.AutoSize = true;
            this.lblAutorDocumento.Location = new System.Drawing.Point(3, 37);
            this.lblAutorDocumento.Name = "lblAutorDocumento";
            this.lblAutorDocumento.Size = new System.Drawing.Size(35, 13);
            this.lblAutorDocumento.TabIndex = 3;
            this.lblAutorDocumento.Text = "Autor:";
            // 
            // lblBarcodeDocumento
            // 
            this.lblBarcodeDocumento.AutoSize = true;
            this.lblBarcodeDocumento.Location = new System.Drawing.Point(326, 34);
            this.lblBarcodeDocumento.Name = "lblBarcodeDocumento";
            this.lblBarcodeDocumento.Size = new System.Drawing.Size(90, 13);
            this.lblBarcodeDocumento.TabIndex = 4;
            this.lblBarcodeDocumento.Text = "Código de barras:";
            // 
            // lblIdentificadorDocumento
            // 
            this.lblIdentificadorDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdentificadorDocumento.AutoSize = true;
            this.lblIdentificadorDocumento.Location = new System.Drawing.Point(3, 95);
            this.lblIdentificadorDocumento.Name = "lblIdentificadorDocumento";
            this.lblIdentificadorDocumento.Size = new System.Drawing.Size(19, 13);
            this.lblIdentificadorDocumento.TabIndex = 5;
            this.lblIdentificadorDocumento.Text = "Id:";
            // 
            // lblEncuadernacionDocumento
            // 
            this.lblEncuadernacionDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEncuadernacionDocumento.AutoSize = true;
            this.lblEncuadernacionDocumento.Location = new System.Drawing.Point(3, 154);
            this.lblEncuadernacionDocumento.Name = "lblEncuadernacionDocumento";
            this.lblEncuadernacionDocumento.Size = new System.Drawing.Size(88, 13);
            this.lblEncuadernacionDocumento.TabIndex = 6;
            this.lblEncuadernacionDocumento.Text = "Encuadernación:";
            // 
            // lblNotasDocumento
            // 
            this.lblNotasDocumento.AutoSize = true;
            this.lblNotasDocumento.Location = new System.Drawing.Point(23, 316);
            this.lblNotasDocumento.Name = "lblNotasDocumento";
            this.lblNotasDocumento.Size = new System.Drawing.Size(38, 13);
            this.lblNotasDocumento.TabIndex = 7;
            this.lblNotasDocumento.Text = "Notas:";
            // 
            // lblAnioDocumento
            // 
            this.lblAnioDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioDocumento.AutoSize = true;
            this.lblAnioDocumento.Location = new System.Drawing.Point(3, 66);
            this.lblAnioDocumento.Name = "lblAnioDocumento";
            this.lblAnioDocumento.Size = new System.Drawing.Size(101, 13);
            this.lblAnioDocumento.TabIndex = 8;
            this.lblAnioDocumento.Text = "Año de publicación:";
            // 
            // lblNumeroPaginasDocumento
            // 
            this.lblNumeroPaginasDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumeroPaginasDocumento.AutoSize = true;
            this.lblNumeroPaginasDocumento.Location = new System.Drawing.Point(3, 124);
            this.lblNumeroPaginasDocumento.Name = "lblNumeroPaginasDocumento";
            this.lblNumeroPaginasDocumento.Size = new System.Drawing.Size(77, 13);
            this.lblNumeroPaginasDocumento.TabIndex = 9;
            this.lblNumeroPaginasDocumento.Text = "Nº de páginas:";
            // 
            // lblFuenteDocumento
            // 
            this.lblFuenteDocumento.AutoSize = true;
            this.lblFuenteDocumento.Location = new System.Drawing.Point(26, 289);
            this.lblFuenteDocumento.Name = "lblFuenteDocumento";
            this.lblFuenteDocumento.Size = new System.Drawing.Size(43, 13);
            this.lblFuenteDocumento.TabIndex = 10;
            this.lblFuenteDocumento.Text = "Fuente:";
            // 
            // txtBarcodeDocumento
            // 
            this.txtBarcodeDocumento.Location = new System.Drawing.Point(426, 31);
            this.txtBarcodeDocumento.Name = "txtBarcodeDocumento";
            this.txtBarcodeDocumento.Size = new System.Drawing.Size(154, 20);
            this.txtBarcodeDocumento.TabIndex = 11;
            // 
            // txtTituloDocumento
            // 
            this.txtTituloDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTituloDocumento.Location = new System.Drawing.Point(142, 4);
            this.txtTituloDocumento.Name = "txtTituloDocumento";
            this.txtTituloDocumento.Size = new System.Drawing.Size(412, 20);
            this.txtTituloDocumento.TabIndex = 12;
            // 
            // txtAutorDocumento
            // 
            this.txtAutorDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAutorDocumento.Location = new System.Drawing.Point(142, 33);
            this.txtAutorDocumento.Name = "txtAutorDocumento";
            this.txtAutorDocumento.Size = new System.Drawing.Size(412, 20);
            this.txtAutorDocumento.TabIndex = 13;
            // 
            // txtAnioDocumento
            // 
            this.txtAnioDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnioDocumento.Location = new System.Drawing.Point(142, 62);
            this.txtAnioDocumento.Name = "txtAnioDocumento";
            this.txtAnioDocumento.Size = new System.Drawing.Size(412, 20);
            this.txtAnioDocumento.TabIndex = 14;
            // 
            // txtIdentificadorDocumento
            // 
            this.txtIdentificadorDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdentificadorDocumento.Location = new System.Drawing.Point(142, 91);
            this.txtIdentificadorDocumento.Name = "txtIdentificadorDocumento";
            this.txtIdentificadorDocumento.Size = new System.Drawing.Size(411, 20);
            this.txtIdentificadorDocumento.TabIndex = 15;
            // 
            // txtNumeroPaginasDocumento
            // 
            this.txtNumeroPaginasDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumeroPaginasDocumento.Location = new System.Drawing.Point(142, 120);
            this.txtNumeroPaginasDocumento.Name = "txtNumeroPaginasDocumento";
            this.txtNumeroPaginasDocumento.Size = new System.Drawing.Size(147, 20);
            this.txtNumeroPaginasDocumento.TabIndex = 16;
            // 
            // rtbNotasDocumento
            // 
            this.rtbNotasDocumento.Location = new System.Drawing.Point(26, 332);
            this.rtbNotasDocumento.Name = "rtbNotasDocumento";
            this.rtbNotasDocumento.Size = new System.Drawing.Size(278, 94);
            this.rtbNotasDocumento.TabIndex = 18;
            this.rtbNotasDocumento.Text = "";
            // 
            // txtFuenteDocumento
            // 
            this.txtFuenteDocumento.Location = new System.Drawing.Point(79, 286);
            this.txtFuenteDocumento.Name = "txtFuenteDocumento";
            this.txtFuenteDocumento.Size = new System.Drawing.Size(501, 20);
            this.txtFuenteDocumento.TabIndex = 19;
            // 
            // cmbEncuadernacionDocumento
            // 
            this.cmbEncuadernacionDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbEncuadernacionDocumento.FormattingEnabled = true;
            this.cmbEncuadernacionDocumento.Items.AddRange(new object[] {
            "No",
            "Sí. NO guillotinar",
            "Sí. Guillotinar"});
            this.cmbEncuadernacionDocumento.Location = new System.Drawing.Point(142, 150);
            this.cmbEncuadernacionDocumento.Name = "cmbEncuadernacionDocumento";
            this.cmbEncuadernacionDocumento.Size = new System.Drawing.Size(147, 21);
            this.cmbEncuadernacionDocumento.TabIndex = 20;
            // 
            // tblPrincipalDocumento
            // 
            this.tblPrincipalDocumento.ColumnCount = 2;
            this.tblPrincipalDocumento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tblPrincipalDocumento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tblPrincipalDocumento.Controls.Add(this.txtTituloDocumento, 1, 0);
            this.tblPrincipalDocumento.Controls.Add(this.cmbEncuadernacionDocumento, 1, 5);
            this.tblPrincipalDocumento.Controls.Add(this.lblTituloDocumento, 0, 0);
            this.tblPrincipalDocumento.Controls.Add(this.lblAutorDocumento, 0, 1);
            this.tblPrincipalDocumento.Controls.Add(this.lblAnioDocumento, 0, 2);
            this.tblPrincipalDocumento.Controls.Add(this.txtNumeroPaginasDocumento, 1, 4);
            this.tblPrincipalDocumento.Controls.Add(this.lblIdentificadorDocumento, 0, 3);
            this.tblPrincipalDocumento.Controls.Add(this.txtIdentificadorDocumento, 1, 3);
            this.tblPrincipalDocumento.Controls.Add(this.lblNumeroPaginasDocumento, 0, 4);
            this.tblPrincipalDocumento.Controls.Add(this.txtAnioDocumento, 1, 2);
            this.tblPrincipalDocumento.Controls.Add(this.lblEncuadernacionDocumento, 0, 5);
            this.tblPrincipalDocumento.Controls.Add(this.txtAutorDocumento, 1, 1);
            this.tblPrincipalDocumento.Location = new System.Drawing.Point(23, 105);
            this.tblPrincipalDocumento.Name = "tblPrincipalDocumento";
            this.tblPrincipalDocumento.RowCount = 6;
            this.tblPrincipalDocumento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipalDocumento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipalDocumento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipalDocumento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipalDocumento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipalDocumento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipalDocumento.Size = new System.Drawing.Size(557, 176);
            this.tblPrincipalDocumento.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 27);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // rtbHistorialDocumento
            // 
            this.rtbHistorialDocumento.Enabled = false;
            this.rtbHistorialDocumento.Location = new System.Drawing.Point(310, 332);
            this.rtbHistorialDocumento.Name = "rtbHistorialDocumento";
            this.rtbHistorialDocumento.Size = new System.Drawing.Size(270, 94);
            this.rtbHistorialDocumento.TabIndex = 23;
            this.rtbHistorialDocumento.Text = "";
            // 
            // lblHistorialDocumento
            // 
            this.lblHistorialDocumento.AutoSize = true;
            this.lblHistorialDocumento.Location = new System.Drawing.Point(307, 316);
            this.lblHistorialDocumento.Name = "lblHistorialDocumento";
            this.lblHistorialDocumento.Size = new System.Drawing.Size(47, 13);
            this.lblHistorialDocumento.TabIndex = 24;
            this.lblHistorialDocumento.Text = "Historial:";
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 503);
            this.Controls.Add(this.lblHistorialDocumento);
            this.Controls.Add(this.rtbHistorialDocumento);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tblPrincipalDocumento);
            this.Controls.Add(this.txtFuenteDocumento);
            this.Controls.Add(this.rtbNotasDocumento);
            this.Controls.Add(this.txtBarcodeDocumento);
            this.Controls.Add(this.lblFuenteDocumento);
            this.Controls.Add(this.lblNotasDocumento);
            this.Controls.Add(this.lblBarcodeDocumento);
            this.Controls.Add(this.btnCancelarDocumento);
            this.Controls.Add(this.btnAccion);
            this.Name = "FrmDocumento";
            this.Resizable = false;
            this.Text = "Documento";
            this.Load += new System.EventHandler(this.FrmAltaDocumento_Load);
            this.tblPrincipalDocumento.ResumeLayout(false);
            this.tblPrincipalDocumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccion;
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
        private System.Windows.Forms.RichTextBox rtbNotasDocumento;
        private System.Windows.Forms.TextBox txtFuenteDocumento;
        private System.Windows.Forms.ComboBox cmbEncuadernacionDocumento;
        private System.Windows.Forms.TableLayoutPanel tblPrincipalDocumento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbHistorialDocumento;
        private System.Windows.Forms.Label lblHistorialDocumento;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}