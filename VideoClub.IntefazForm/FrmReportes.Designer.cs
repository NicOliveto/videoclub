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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lblIdCopia = new System.Windows.Forms.Label();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._lblFechaAlta = new System.Windows.Forms.Label();
            this._lblObservaciones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._lblIdCopiaPrestamo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._lblFechaPrestamo = new System.Windows.Forms.Label();
            this._lblFechaDevolucionReal = new System.Windows.Forms.Label();
            this._lblFechaDevolucionTentativa = new System.Windows.Forms.Label();
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
            this._btnMenuPrincipal.Location = new System.Drawing.Point(554, 704);
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
            this._cmbCopiasPorPelicula.SelectedValueChanged += new System.EventHandler(this._cmbCopiasPorPelicula_SelectedValueChange);
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
            this._cmbPrestamoPorCliente.SelectedValueChanged += new System.EventHandler(this._cmbPrestamoPorCliente_SelectedValueChange);
            // 
            // _lstPrestamos
            // 
            this._lstPrestamos.FormattingEnabled = true;
            this._lstPrestamos.ItemHeight = 20;
            this._lstPrestamos.Location = new System.Drawing.Point(212, 115);
            this._lstPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lstPrestamos.Name = "_lstPrestamos";
            this._lstPrestamos.Size = new System.Drawing.Size(381, 204);
            this._lstPrestamos.TabIndex = 10;
            this._lstPrestamos.Click += new System.EventHandler(this._lstPrestamos_Click);
            // 
            // _lstCopias
            // 
            this._lstCopias.FormattingEnabled = true;
            this._lstCopias.ItemHeight = 20;
            this._lstCopias.Location = new System.Drawing.Point(840, 115);
            this._lstCopias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lstCopias.Name = "_lstCopias";
            this._lstCopias.Size = new System.Drawing.Size(381, 204);
            this._lstCopias.TabIndex = 11;
            this._lstCopias.Click += new System.EventHandler(this._lstCopias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Copia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(907, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha Alta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(846, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Observaciones:";
            // 
            // _lblIdCopia
            // 
            this._lblIdCopia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblIdCopia.Location = new System.Drawing.Point(994, 366);
            this._lblIdCopia.Name = "_lblIdCopia";
            this._lblIdCopia.Size = new System.Drawing.Size(227, 20);
            this._lblIdCopia.TabIndex = 16;
            // 
            // _lblPrecio
            // 
            this._lblPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblPrecio.Location = new System.Drawing.Point(994, 408);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(227, 20);
            this._lblPrecio.TabIndex = 17;
            // 
            // _lblFechaAlta
            // 
            this._lblFechaAlta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblFechaAlta.Location = new System.Drawing.Point(994, 452);
            this._lblFechaAlta.Name = "_lblFechaAlta";
            this._lblFechaAlta.Size = new System.Drawing.Size(227, 20);
            this._lblFechaAlta.TabIndex = 18;
            // 
            // _lblObservaciones
            // 
            this._lblObservaciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblObservaciones.Location = new System.Drawing.Point(994, 495);
            this._lblObservaciones.Name = "_lblObservaciones";
            this._lblObservaciones.Size = new System.Drawing.Size(227, 80);
            this._lblObservaciones.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Id Copia:";
            // 
            // _lblIdCopiaPrestamo
            // 
            this._lblIdCopiaPrestamo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblIdCopiaPrestamo.Location = new System.Drawing.Point(366, 366);
            this._lblIdCopiaPrestamo.Name = "_lblIdCopiaPrestamo";
            this._lblIdCopiaPrestamo.Size = new System.Drawing.Size(227, 20);
            this._lblIdCopiaPrestamo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "FechaPrestamo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha Devolucion Real:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha Devolucion Tentativa:";
            // 
            // _lblFechaPrestamo
            // 
            this._lblFechaPrestamo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblFechaPrestamo.Location = new System.Drawing.Point(366, 408);
            this._lblFechaPrestamo.Name = "_lblFechaPrestamo";
            this._lblFechaPrestamo.Size = new System.Drawing.Size(227, 20);
            this._lblFechaPrestamo.TabIndex = 25;
            // 
            // _lblFechaDevolucionReal
            // 
            this._lblFechaDevolucionReal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblFechaDevolucionReal.Location = new System.Drawing.Point(366, 452);
            this._lblFechaDevolucionReal.Name = "_lblFechaDevolucionReal";
            this._lblFechaDevolucionReal.Size = new System.Drawing.Size(227, 20);
            this._lblFechaDevolucionReal.TabIndex = 26;
            // 
            // _lblFechaDevolucionTentativa
            // 
            this._lblFechaDevolucionTentativa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblFechaDevolucionTentativa.Location = new System.Drawing.Point(366, 495);
            this._lblFechaDevolucionTentativa.Name = "_lblFechaDevolucionTentativa";
            this._lblFechaDevolucionTentativa.Size = new System.Drawing.Size(227, 20);
            this._lblFechaDevolucionTentativa.TabIndex = 27;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 815);
            this.Controls.Add(this._lblFechaDevolucionTentativa);
            this.Controls.Add(this._lblFechaDevolucionReal);
            this.Controls.Add(this._lblFechaPrestamo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._lblIdCopiaPrestamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._lblObservaciones);
            this.Controls.Add(this._lblFechaAlta);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._lblIdCopia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Click += new System.EventHandler(this._lstPrestamos_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnPrestamosPorCliente;
        private System.Windows.Forms.Button _btnCopiasPorPelicula;
        private System.Windows.Forms.Button _btnMenuPrincipal;
        private System.Windows.Forms.ComboBox _cmbCopiasPorPelicula;
        private System.Windows.Forms.ComboBox _cmbPrestamoPorCliente;
        private System.Windows.Forms.ListBox _lstPrestamos;
        private System.Windows.Forms.ListBox _lstCopias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblIdCopia;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblFechaAlta;
        private System.Windows.Forms.Label _lblObservaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lblIdCopiaPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label _lblFechaPrestamo;
        private System.Windows.Forms.Label _lblFechaDevolucionReal;
        private System.Windows.Forms.Label _lblFechaDevolucionTentativa;
    }
}