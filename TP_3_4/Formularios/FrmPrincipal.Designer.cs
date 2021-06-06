
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnDistribuir = new MetroFramework.Controls.MetroTile();
            this.btnGuillotinar = new MetroFramework.Controls.MetroTile();
            this.btnEscanear = new MetroFramework.Controls.MetroTile();
            this.btnTerminados = new MetroFramework.Controls.MetroTile();
            this.btnTodos = new MetroFramework.Controls.MetroTile();
            this.tblCuerpo = new System.Windows.Forms.TableLayoutPanel();
            this.gridDocumentos = new MetroFramework.Controls.MetroGrid();
            this.btnInformes = new MetroFramework.Controls.MetroButton();
            this.txtBuscarPorCodebar = new System.Windows.Forms.TextBox();
            this.cmbAniadirDocumento = new System.Windows.Forms.ComboBox();
            this.picBuscarPorCodebar = new System.Windows.Forms.PictureBox();
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
            this.tblMenu.Controls.Add(this.btnTerminados, 0, 4);
            this.tblMenu.Controls.Add(this.btnTodos, 0, 0);
            this.tblMenu.Location = new System.Drawing.Point(37, 124);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 5;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMenu.Size = new System.Drawing.Size(177, 243);
            this.tblMenu.TabIndex = 0;
            // 
            // btnDistribuir
            // 
            this.btnDistribuir.ActiveControl = null;
            this.btnDistribuir.Location = new System.Drawing.Point(3, 51);
            this.btnDistribuir.Name = "btnDistribuir";
            this.btnDistribuir.Size = new System.Drawing.Size(171, 42);
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
            this.btnGuillotinar.Location = new System.Drawing.Point(3, 99);
            this.btnGuillotinar.Name = "btnGuillotinar";
            this.btnGuillotinar.Size = new System.Drawing.Size(171, 42);
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
            this.btnEscanear.Location = new System.Drawing.Point(3, 147);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(171, 42);
            this.btnEscanear.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnEscanear.TabIndex = 3;
            this.btnEscanear.Text = "3 - Escanear";
            this.btnEscanear.UseSelectable = true;
            this.btnEscanear.UseStyleColors = true;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // btnTerminados
            // 
            this.btnTerminados.ActiveControl = null;
            this.btnTerminados.Location = new System.Drawing.Point(3, 195);
            this.btnTerminados.Name = "btnTerminados";
            this.btnTerminados.Size = new System.Drawing.Size(171, 45);
            this.btnTerminados.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnTerminados.TabIndex = 4;
            this.btnTerminados.Text = "Terminados";
            this.btnTerminados.UseSelectable = true;
            this.btnTerminados.UseStyleColors = true;
            this.btnTerminados.Click += new System.EventHandler(this.btnTerminados_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.ActiveControl = null;
            this.btnTodos.BackColor = System.Drawing.Color.White;
            this.btnTodos.Location = new System.Drawing.Point(3, 3);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(171, 42);
            this.btnTodos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnTodos.TabIndex = 0;
            this.btnTodos.Text = "TODOS";
            this.btnTodos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTodos.UseSelectable = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
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
            this.tblCuerpo.Size = new System.Drawing.Size(691, 237);
            this.tblCuerpo.TabIndex = 1;
            this.tblCuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.tblCuerpo_Paint);
            // 
            // gridDocumentos
            // 
            this.gridDocumentos.AllowUserToResizeRows = false;
            this.gridDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDocumentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDocumentos.EnableHeadersVisualStyles = false;
            this.gridDocumentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDocumentos.Location = new System.Drawing.Point(3, 3);
            this.gridDocumentos.Name = "gridDocumentos";
            this.gridDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDocumentos.Size = new System.Drawing.Size(685, 231);
            this.gridDocumentos.TabIndex = 0;
            this.gridDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDocumentos_CellClick);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.Black;
            this.btnInformes.Location = new System.Drawing.Point(797, 378);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(138, 29);
            this.btnInformes.Style = MetroFramework.MetroColorStyle.Black;
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "Informes ";
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
            // FrmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 481);
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
        //private System.Windows.Forms.BindingSource documentoBindingSource;
    }
}