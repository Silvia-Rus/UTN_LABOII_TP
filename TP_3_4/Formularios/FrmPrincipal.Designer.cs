
namespace Formularios
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnDistribuir = new MetroFramework.Controls.MetroTile();
            this.btnGuillotinar = new MetroFramework.Controls.MetroTile();
            this.btnEscanear = new MetroFramework.Controls.MetroTile();
            this.btnTodos = new MetroFramework.Controls.MetroTile();
            this.btnTerminados = new MetroFramework.Controls.MetroTile();
            this.btnRevisar = new MetroFramework.Controls.MetroTile();
            this.tblCuerpo = new System.Windows.Forms.TableLayoutPanel();
            this.gridDocumentos = new MetroFramework.Controls.MetroGrid();
            this.btnInformes = new MetroFramework.Controls.MetroButton();
            this.txtBuscarPorCodebar = new System.Windows.Forms.TextBox();
            this.cmbAniadirDocumento = new System.Windows.Forms.ComboBox();
            this.picBuscarPorCodebar = new System.Windows.Forms.PictureBox();
            this.txtAvisoSuperior = new MetroFramework.Controls.MetroTextBox();
            this.tblMenu.SuspendLayout();
            this.tblCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarPorCodebar)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMenu
            // 
            this.tblMenu.ColumnCount = 1;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tblMenu.Controls.Add(this.btnDistribuir, 0, 1);
            this.tblMenu.Controls.Add(this.btnGuillotinar, 0, 2);
            this.tblMenu.Controls.Add(this.btnEscanear, 0, 3);
            this.tblMenu.Controls.Add(this.btnTodos, 0, 0);
            this.tblMenu.Controls.Add(this.btnTerminados, 0, 5);
            this.tblMenu.Controls.Add(this.btnRevisar, 0, 4);
            this.tblMenu.Location = new System.Drawing.Point(37, 124);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 6;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMenu.Size = new System.Drawing.Size(177, 273);
            this.tblMenu.TabIndex = 0;
            // 
            // btnDistribuir
            // 
            this.btnDistribuir.ActiveControl = null;
            this.btnDistribuir.Location = new System.Drawing.Point(3, 48);
            this.btnDistribuir.Name = "btnDistribuir";
            this.btnDistribuir.Size = new System.Drawing.Size(171, 39);
            this.btnDistribuir.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnDistribuir.TabIndex = 1;
            this.btnDistribuir.Text = "1 - Distribuir";
            this.btnDistribuir.UseSelectable = true;
            this.btnDistribuir.UseStyleColors = true;
            this.btnDistribuir.Click += new System.EventHandler(this.btnDistribuir_Click);
            // 
            // btnGuillotinar
            // 
            this.btnGuillotinar.ActiveControl = null;
            this.btnGuillotinar.Location = new System.Drawing.Point(3, 93);
            this.btnGuillotinar.Name = "btnGuillotinar";
            this.btnGuillotinar.Size = new System.Drawing.Size(171, 39);
            this.btnGuillotinar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnGuillotinar.TabIndex = 2;
            this.btnGuillotinar.Text = "2 - Guillotinar";
            this.btnGuillotinar.UseSelectable = true;
            this.btnGuillotinar.UseStyleColors = true;
            this.btnGuillotinar.UseTileImage = true;
            this.btnGuillotinar.Click += new System.EventHandler(this.btnGuillotinar_Click);
            // 
            // btnEscanear
            // 
            this.btnEscanear.ActiveControl = null;
            this.btnEscanear.Location = new System.Drawing.Point(3, 138);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(171, 39);
            this.btnEscanear.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnEscanear.TabIndex = 3;
            this.btnEscanear.Text = "3 - Escanear";
            this.btnEscanear.UseSelectable = true;
            this.btnEscanear.UseStyleColors = true;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.ActiveControl = null;
            this.btnTodos.BackColor = System.Drawing.Color.White;
            this.btnTodos.Location = new System.Drawing.Point(3, 3);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(171, 39);
            this.btnTodos.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnTodos.TabIndex = 0;
            this.btnTodos.Text = "Lista completa";
            this.btnTodos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTodos.UseSelectable = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnTerminados
            // 
            this.btnTerminados.ActiveControl = null;
            this.btnTerminados.Location = new System.Drawing.Point(3, 228);
            this.btnTerminados.Name = "btnTerminados";
            this.btnTerminados.Size = new System.Drawing.Size(171, 42);
            this.btnTerminados.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnTerminados.TabIndex = 4;
            this.btnTerminados.Text = "Aprobados";
            this.btnTerminados.UseSelectable = true;
            this.btnTerminados.UseStyleColors = true;
            this.btnTerminados.Click += new System.EventHandler(this.btnTerminados_Click);
            // 
            // btnRevisar
            // 
            this.btnRevisar.ActiveControl = null;
            this.btnRevisar.Location = new System.Drawing.Point(3, 183);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(171, 39);
            this.btnRevisar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRevisar.TabIndex = 5;
            this.btnRevisar.Text = "4 - Revisar";
            this.btnRevisar.UseSelectable = true;
            this.btnRevisar.UseStyleColors = true;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // tblCuerpo
            // 
            this.tblCuerpo.ColumnCount = 1;
            this.tblCuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCuerpo.Controls.Add(this.gridDocumentos, 0, 0);
            this.tblCuerpo.Location = new System.Drawing.Point(244, 127);
            this.tblCuerpo.Name = "tblCuerpo";
            this.tblCuerpo.RowCount = 1;
            this.tblCuerpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCuerpo.Size = new System.Drawing.Size(691, 270);
            this.tblCuerpo.TabIndex = 1;
            // 
            // gridDocumentos
            // 
            this.gridDocumentos.AllowUserToResizeRows = false;
            this.gridDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDocumentos.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDocumentos.EnableHeadersVisualStyles = false;
            this.gridDocumentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDocumentos.Location = new System.Drawing.Point(3, 3);
            this.gridDocumentos.Name = "gridDocumentos";
            this.gridDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDocumentos.Size = new System.Drawing.Size(685, 264);
            this.gridDocumentos.TabIndex = 0;
            this.gridDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDocumentos_CellClick);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.Black;
            this.btnInformes.Location = new System.Drawing.Point(797, 429);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(138, 29);
            this.btnInformes.Style = MetroFramework.MetroColorStyle.Black;
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "Exportar ";
            this.btnInformes.UseSelectable = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // txtBuscarPorCodebar
            // 
            this.txtBuscarPorCodebar.Location = new System.Drawing.Point(754, 34);
            this.txtBuscarPorCodebar.Name = "txtBuscarPorCodebar";
            this.txtBuscarPorCodebar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscarPorCodebar.TabIndex = 4;
            this.txtBuscarPorCodebar.Text = "Código de barras";
            this.txtBuscarPorCodebar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPorCodebar_KeyPress);
            // 
            // cmbAniadirDocumento
            // 
            this.cmbAniadirDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAniadirDocumento.FormattingEnabled = true;
            this.cmbAniadirDocumento.Items.AddRange(new object[] {
            "Libro",
            "Artículo"});
            this.cmbAniadirDocumento.Location = new System.Drawing.Point(723, 63);
            this.cmbAniadirDocumento.Name = "cmbAniadirDocumento";
            this.cmbAniadirDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAniadirDocumento.Size = new System.Drawing.Size(212, 21);
            this.cmbAniadirDocumento.TabIndex = 5;
            this.cmbAniadirDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbAniadirDocumento_SelectedIndexChanged);
            // 
            // picBuscarPorCodebar
            // 
            this.picBuscarPorCodebar.Image = global::Formularios.Properties.Resources.lupa;
            this.picBuscarPorCodebar.InitialImage = global::Formularios.Properties.Resources.lupa;
            this.picBuscarPorCodebar.Location = new System.Drawing.Point(728, 34);
            this.picBuscarPorCodebar.Name = "picBuscarPorCodebar";
            this.picBuscarPorCodebar.Size = new System.Drawing.Size(20, 20);
            this.picBuscarPorCodebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscarPorCodebar.TabIndex = 6;
            this.picBuscarPorCodebar.TabStop = false;
            this.picBuscarPorCodebar.Click += new System.EventHandler(this.picBuscarPorCodebar_Click);
            // 
            // txtAvisoSuperior
            // 
            // 
            // 
            // 
            this.txtAvisoSuperior.CustomButton.Image = null;
            this.txtAvisoSuperior.CustomButton.Location = new System.Drawing.Point(428, 1);
            this.txtAvisoSuperior.CustomButton.Name = "";
            this.txtAvisoSuperior.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAvisoSuperior.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAvisoSuperior.CustomButton.TabIndex = 1;
            this.txtAvisoSuperior.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAvisoSuperior.CustomButton.UseSelectable = true;
            this.txtAvisoSuperior.CustomButton.Visible = false;
            this.txtAvisoSuperior.Enabled = false;
            this.txtAvisoSuperior.Lines = new string[0];
            this.txtAvisoSuperior.Location = new System.Drawing.Point(313, 90);
            this.txtAvisoSuperior.MaxLength = 32767;
            this.txtAvisoSuperior.Name = "txtAvisoSuperior";
            this.txtAvisoSuperior.PasswordChar = '\0';
            this.txtAvisoSuperior.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAvisoSuperior.SelectedText = "";
            this.txtAvisoSuperior.SelectionLength = 0;
            this.txtAvisoSuperior.SelectionStart = 0;
            this.txtAvisoSuperior.ShortcutsEnabled = true;
            this.txtAvisoSuperior.Size = new System.Drawing.Size(450, 23);
            this.txtAvisoSuperior.Style = MetroFramework.MetroColorStyle.Red;
            this.txtAvisoSuperior.TabIndex = 7;
            this.txtAvisoSuperior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAvisoSuperior.UseSelectable = true;
            this.txtAvisoSuperior.UseStyleColors = true;
            this.txtAvisoSuperior.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAvisoSuperior.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 481);
            this.Controls.Add(this.txtAvisoSuperior);
            this.Controls.Add(this.picBuscarPorCodebar);
            this.Controls.Add(this.cmbAniadirDocumento);
            this.Controls.Add(this.txtBuscarPorCodebar);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.tblCuerpo);
            this.Controls.Add(this.tblMenu);
            this.Name = "FrmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "BlaBlaBla";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tblMenu.ResumeLayout(false);
            this.tblCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarPorCodebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private MetroFramework.Controls.MetroTile btnTodos;
        private MetroFramework.Controls.MetroTile btnDistribuir;
        private MetroFramework.Controls.MetroTile btnGuillotinar;
        private MetroFramework.Controls.MetroTile btnEscanear;
        private MetroFramework.Controls.MetroTile btnTerminados;
        private System.Windows.Forms.TableLayoutPanel tblCuerpo;
        private MetroFramework.Controls.MetroButton btnInformes;
        private System.Windows.Forms.TextBox txtBuscarPorCodebar;
        private System.Windows.Forms.ComboBox cmbAniadirDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEncuadernacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faseProcesoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid gridDocumentos;
        private System.Windows.Forms.PictureBox picBuscarPorCodebar;
        private MetroFramework.Controls.MetroTile btnRevisar;
        private MetroFramework.Controls.MetroTextBox txtAvisoSuperior;
        //private System.Windows.Forms.BindingSource documentoBindingSource;
    }
}