namespace VideoClub.IntefazForm
{
    partial class FrmIngresarPrestamo
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
            this._btnAltaPrestamo = new System.Windows.Forms.Button();
            this._btnVolverPrestamo = new System.Windows.Forms.Button();
            this._cmbClientes = new System.Windows.Forms.ComboBox();
            this._cmbPeliculas = new System.Windows.Forms.ComboBox();
            this._tbPlazo = new System.Windows.Forms.TextBox();
            this._lblClientePrestamo = new System.Windows.Forms.Label();
            this._lblPlazoPrestamo = new System.Windows.Forms.Label();
            this._lblPeliculaPrestamo = new System.Windows.Forms.Label();
            this._lblCopiaPrestamo = new System.Windows.Forms.Label();
            this._cmbCopias = new System.Windows.Forms.ComboBox();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._lblPrecioCopia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnAltaPrestamo
            // 
            this._btnAltaPrestamo.Location = new System.Drawing.Point(222, 373);
            this._btnAltaPrestamo.Name = "_btnAltaPrestamo";
            this._btnAltaPrestamo.Size = new System.Drawing.Size(166, 65);
            this._btnAltaPrestamo.TabIndex = 17;
            this._btnAltaPrestamo.Text = "Alta Prestamo";
            this._btnAltaPrestamo.UseVisualStyleBackColor = true;
            this._btnAltaPrestamo.Click += new System.EventHandler(this._btnAltaPrestamo_click);
            // 
            // _btnVolverPrestamo
            // 
            this._btnVolverPrestamo.Location = new System.Drawing.Point(12, 373);
            this._btnVolverPrestamo.Name = "_btnVolverPrestamo";
            this._btnVolverPrestamo.Size = new System.Drawing.Size(166, 65);
            this._btnVolverPrestamo.TabIndex = 16;
            this._btnVolverPrestamo.Text = "Volver";
            this._btnVolverPrestamo.UseVisualStyleBackColor = true;
            this._btnVolverPrestamo.Click += new System.EventHandler(this._btnVolverPrestamo_Click);
            // 
            // _cmbClientes
            // 
            this._cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(222, 49);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(339, 24);
            this._cmbClientes.TabIndex = 18;
            // 
            // _cmbPeliculas
            // 
            this._cmbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPeliculas.FormattingEnabled = true;
            this._cmbPeliculas.Location = new System.Drawing.Point(222, 93);
            this._cmbPeliculas.Name = "_cmbPeliculas";
            this._cmbPeliculas.Size = new System.Drawing.Size(339, 24);
            this._cmbPeliculas.TabIndex = 19;
            this._cmbPeliculas.SelectedValueChanged += new System.EventHandler(this._cmbPeliculas_SelectedValueChanged);
            // 
            // _tbPlazo
            // 
            this._tbPlazo.BackColor = System.Drawing.SystemColors.Window;
            this._tbPlazo.Location = new System.Drawing.Point(222, 181);
            this._tbPlazo.Name = "_tbPlazo";
            this._tbPlazo.Size = new System.Drawing.Size(339, 22);
            this._tbPlazo.TabIndex = 20;
            this._tbPlazo.TextChanged += new System.EventHandler(this._tbPlazo_TextChanged);
            // 
            // _lblClientePrestamo
            // 
            this._lblClientePrestamo.Location = new System.Drawing.Point(39, 49);
            this._lblClientePrestamo.Name = "_lblClientePrestamo";
            this._lblClientePrestamo.Size = new System.Drawing.Size(153, 23);
            this._lblClientePrestamo.TabIndex = 21;
            this._lblClientePrestamo.Text = "Cliente:";
            // 
            // _lblPlazoPrestamo
            // 
            this._lblPlazoPrestamo.Location = new System.Drawing.Point(39, 181);
            this._lblPlazoPrestamo.Name = "_lblPlazoPrestamo";
            this._lblPlazoPrestamo.Size = new System.Drawing.Size(183, 23);
            this._lblPlazoPrestamo.TabIndex = 22;
            this._lblPlazoPrestamo.Text = "Plazo (días) de prestamo:";
            // 
            // _lblPeliculaPrestamo
            // 
            this._lblPeliculaPrestamo.Location = new System.Drawing.Point(39, 93);
            this._lblPeliculaPrestamo.Name = "_lblPeliculaPrestamo";
            this._lblPeliculaPrestamo.Size = new System.Drawing.Size(153, 23);
            this._lblPeliculaPrestamo.TabIndex = 23;
            this._lblPeliculaPrestamo.Text = "Pelicula: ";
            // 
            // _lblCopiaPrestamo
            // 
            this._lblCopiaPrestamo.Location = new System.Drawing.Point(39, 137);
            this._lblCopiaPrestamo.Name = "_lblCopiaPrestamo";
            this._lblCopiaPrestamo.Size = new System.Drawing.Size(153, 23);
            this._lblCopiaPrestamo.TabIndex = 27;
            this._lblCopiaPrestamo.Text = "Copia: ";
            // 
            // _cmbCopias
            // 
            this._cmbCopias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCopias.FormattingEnabled = true;
            this._cmbCopias.Location = new System.Drawing.Point(222, 137);
            this._cmbCopias.Name = "_cmbCopias";
            this._cmbCopias.Size = new System.Drawing.Size(339, 24);
            this._cmbCopias.TabIndex = 26;
            this._cmbCopias.SelectedValueChanged += new System.EventHandler(this._cmbCopias_SelectedValueChanged);
            // 
            // _lblPrecio
            // 
            this._lblPrecio.Location = new System.Drawing.Point(591, 140);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(67, 23);
            this._lblPrecio.TabIndex = 28;
            this._lblPrecio.Text = "Precio: $";
            // 
            // _lblPrecioCopia
            // 
            this._lblPrecioCopia.Location = new System.Drawing.Point(654, 140);
            this._lblPrecioCopia.Name = "_lblPrecioCopia";
            this._lblPrecioCopia.Size = new System.Drawing.Size(53, 23);
            this._lblPrecioCopia.TabIndex = 29;
            // 
            // FrmIngresarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblPrecioCopia);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._lblCopiaPrestamo);
            this.Controls.Add(this._cmbCopias);
            this.Controls.Add(this._lblPeliculaPrestamo);
            this.Controls.Add(this._lblPlazoPrestamo);
            this.Controls.Add(this._lblClientePrestamo);
            this.Controls.Add(this._tbPlazo);
            this.Controls.Add(this._cmbPeliculas);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this._btnAltaPrestamo);
            this.Controls.Add(this._btnVolverPrestamo);
            this.Name = "FrmIngresarPrestamo";
            this.Text = "FrmIngresarPrestamo";
            this.Load += new System.EventHandler(this.FrmIngresarPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAltaPrestamo;
        private System.Windows.Forms.Button _btnVolverPrestamo;
        private System.Windows.Forms.ComboBox _cmbClientes;
        private System.Windows.Forms.ComboBox _cmbPeliculas;
        private System.Windows.Forms.TextBox _tbPlazo;
        private System.Windows.Forms.Label _lblClientePrestamo;
        private System.Windows.Forms.Label _lblPlazoPrestamo;
        private System.Windows.Forms.Label _lblPeliculaPrestamo;
        private System.Windows.Forms.Label _lblCopiaPrestamo;
        private System.Windows.Forms.ComboBox _cmbCopias;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblPrecioCopia;
    }
}