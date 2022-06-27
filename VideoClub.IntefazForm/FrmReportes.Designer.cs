namespace VideoClub.IntefazForm
{
    partial class FrmReportes
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
            this._btnPrestamosPorCliente = new System.Windows.Forms.Button();
            this._btnCopiasPorPelicula = new System.Windows.Forms.Button();
            this._btnMenuPrincipal = new System.Windows.Forms.Button();
            this._cmbCopiasPorPelicula = new System.Windows.Forms.ComboBox();
            this._cmbPrestamoPorCliente = new System.Windows.Forms.ComboBox();
            this._lstPrestamos = new System.Windows.Forms.ListBox();
            this._lstCopias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _btnPrestamosPorCliente
            // 
            this._btnPrestamosPorCliente.Location = new System.Drawing.Point(14, 52);
            this._btnPrestamosPorCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnPrestamosPorCliente.Name = "_btnPrestamosPorCliente";
            this._btnPrestamosPorCliente.Size = new System.Drawing.Size(177, 79);
            this._btnPrestamosPorCliente.TabIndex = 1;
            this._btnPrestamosPorCliente.Text = "Prestamos por cliente";
            this._btnPrestamosPorCliente.UseVisualStyleBackColor = true;
            this._btnPrestamosPorCliente.Click += new System.EventHandler(this._btnPrestamosPorCliente_Click);
            // 
            // _btnCopiasPorPelicula
            // 
            this._btnCopiasPorPelicula.Location = new System.Drawing.Point(640, 52);
            this._btnCopiasPorPelicula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnCopiasPorPelicula.Name = "_btnCopiasPorPelicula";
            this._btnCopiasPorPelicula.Size = new System.Drawing.Size(177, 79);
            this._btnCopiasPorPelicula.TabIndex = 2;
            this._btnCopiasPorPelicula.Text = "Copias por pelicula";
            this._btnCopiasPorPelicula.UseVisualStyleBackColor = true;
            this._btnCopiasPorPelicula.Click += new System.EventHandler(this._btnCopiasPorPelicula_Click);
            // 
            // _btnMenuPrincipal
            // 
            this._btnMenuPrincipal.Location = new System.Drawing.Point(553, 704);
            this._btnMenuPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnMenuPrincipal.Name = "_btnMenuPrincipal";
            this._btnMenuPrincipal.Size = new System.Drawing.Size(177, 79);
            this._btnMenuPrincipal.TabIndex = 3;
            this._btnMenuPrincipal.Text = "Menu Principal";
            this._btnMenuPrincipal.UseVisualStyleBackColor = true;
            this._btnMenuPrincipal.Click += new System.EventHandler(this._btnMenuPrincipal_Click);
            // 
            // _cmbCopiasPorPelicula
            // 
            this._cmbCopiasPorPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCopiasPorPelicula.FormattingEnabled = true;
            this._cmbCopiasPorPelicula.Location = new System.Drawing.Point(840, 52);
            this._cmbCopiasPorPelicula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cmbCopiasPorPelicula.Name = "_cmbCopiasPorPelicula";
            this._cmbCopiasPorPelicula.Size = new System.Drawing.Size(381, 28);
            this._cmbCopiasPorPelicula.TabIndex = 6;
            // 
            // _cmbPrestamoPorCliente
            // 
            this._cmbPrestamoPorCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPrestamoPorCliente.FormattingEnabled = true;
            this._cmbPrestamoPorCliente.Location = new System.Drawing.Point(212, 52);
            this._cmbPrestamoPorCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cmbPrestamoPorCliente.Name = "_cmbPrestamoPorCliente";
            this._cmbPrestamoPorCliente.Size = new System.Drawing.Size(381, 28);
            this._cmbPrestamoPorCliente.TabIndex = 7;
            // 
            // _lstPrestamos
            // 
            this._lstPrestamos.FormattingEnabled = true;
            this._lstPrestamos.ItemHeight = 20;
            this._lstPrestamos.Location = new System.Drawing.Point(212, 115);
            this._lstPrestamos.Name = "_lstPrestamos";
            this._lstPrestamos.Size = new System.Drawing.Size(381, 204);
            this._lstPrestamos.TabIndex = 10;
            // 
            // _lstCopias
            // 
            this._lstCopias.FormattingEnabled = true;
            this._lstCopias.ItemHeight = 20;
            this._lstCopias.Location = new System.Drawing.Point(840, 115);
            this._lstCopias.Name = "_lstCopias";
            this._lstCopias.Size = new System.Drawing.Size(381, 204);
            this._lstCopias.TabIndex = 11;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 815);
            this.Controls.Add(this._lstCopias);
            this.Controls.Add(this._lstPrestamos);
            this.Controls.Add(this._cmbPrestamoPorCliente);
            this.Controls.Add(this._cmbCopiasPorPelicula);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnCopiasPorPelicula);
            this.Controls.Add(this._btnPrestamosPorCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnPrestamosPorCliente;
        private System.Windows.Forms.Button _btnCopiasPorPelicula;
        private System.Windows.Forms.Button _btnMenuPrincipal;
        private System.Windows.Forms.ComboBox _cmbCopiasPorPelicula;
        private System.Windows.Forms.ComboBox _cmbPrestamoPorCliente;
        private System.Windows.Forms.ListBox _lstPrestamos;
        private System.Windows.Forms.ListBox _lstCopias;
    }
}