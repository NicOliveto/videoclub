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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._lblClientePrestamo = new System.Windows.Forms.Label();
            this._lblPlazoPrestamo = new System.Windows.Forms.Label();
            this._lblPeliculaPrestamo = new System.Windows.Forms.Label();
            this._lblCopiaPrestamo = new System.Windows.Forms.Label();
            this._cmbCopias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _btnAltaPrestamo
            // 
            this._btnAltaPrestamo.Location = new System.Drawing.Point(250, 466);
            this._btnAltaPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnAltaPrestamo.Name = "_btnAltaPrestamo";
            this._btnAltaPrestamo.Size = new System.Drawing.Size(187, 81);
            this._btnAltaPrestamo.TabIndex = 17;
            this._btnAltaPrestamo.Text = "Alta Prestamo";
            this._btnAltaPrestamo.UseVisualStyleBackColor = true;
            this._btnAltaPrestamo.Click += new System.EventHandler(this._btnAltaPrestamo_click);
            // 
            // _btnVolverPrestamo
            // 
            this._btnVolverPrestamo.Location = new System.Drawing.Point(14, 466);
            this._btnVolverPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnVolverPrestamo.Name = "_btnVolverPrestamo";
            this._btnVolverPrestamo.Size = new System.Drawing.Size(187, 81);
            this._btnVolverPrestamo.TabIndex = 16;
            this._btnVolverPrestamo.Text = "Volver";
            this._btnVolverPrestamo.UseVisualStyleBackColor = true;
            this._btnVolverPrestamo.Click += new System.EventHandler(this._btnVolverPrestamo_Click);
            // 
            // _cmbClientes
            // 
            this._cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(250, 61);
            this._cmbClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(381, 28);
            this._cmbClientes.TabIndex = 18;
            // 
            // _cmbPeliculas
            // 
            this._cmbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPeliculas.FormattingEnabled = true;
            this._cmbPeliculas.Location = new System.Drawing.Point(250, 116);
            this._cmbPeliculas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cmbPeliculas.Name = "_cmbPeliculas";
            this._cmbPeliculas.Size = new System.Drawing.Size(381, 28);
            this._cmbPeliculas.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 26);
            this.textBox1.TabIndex = 20;
            // 
            // _lblClientePrestamo
            // 
            this._lblClientePrestamo.Location = new System.Drawing.Point(44, 61);
            this._lblClientePrestamo.Name = "_lblClientePrestamo";
            this._lblClientePrestamo.Size = new System.Drawing.Size(172, 29);
            this._lblClientePrestamo.TabIndex = 21;
            this._lblClientePrestamo.Text = "Cliente:";
            // 
            // _lblPlazoPrestamo
            // 
            this._lblPlazoPrestamo.Location = new System.Drawing.Point(44, 226);
            this._lblPlazoPrestamo.Name = "_lblPlazoPrestamo";
            this._lblPlazoPrestamo.Size = new System.Drawing.Size(206, 29);
            this._lblPlazoPrestamo.TabIndex = 22;
            this._lblPlazoPrestamo.Text = "Plazo (días) de prestamo:";
            // 
            // _lblPeliculaPrestamo
            // 
            this._lblPeliculaPrestamo.Location = new System.Drawing.Point(44, 116);
            this._lblPeliculaPrestamo.Name = "_lblPeliculaPrestamo";
            this._lblPeliculaPrestamo.Size = new System.Drawing.Size(172, 29);
            this._lblPeliculaPrestamo.TabIndex = 23;
            this._lblPeliculaPrestamo.Text = "Pelicula: ";
            // 
            // _lblCopiaPrestamo
            // 
            this._lblCopiaPrestamo.Location = new System.Drawing.Point(44, 171);
            this._lblCopiaPrestamo.Name = "_lblCopiaPrestamo";
            this._lblCopiaPrestamo.Size = new System.Drawing.Size(172, 29);
            this._lblCopiaPrestamo.TabIndex = 27;
            this._lblCopiaPrestamo.Text = "Copia: ";
            // 
            // _cmbCopias
            // 
            this._cmbCopias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCopias.FormattingEnabled = true;
            this._cmbCopias.Location = new System.Drawing.Point(250, 171);
            this._cmbCopias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cmbCopias.Name = "_cmbCopias";
            this._cmbCopias.Size = new System.Drawing.Size(381, 28);
            this._cmbCopias.TabIndex = 26;
            // 
            // FrmIngresarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this._lblCopiaPrestamo);
            this.Controls.Add(this._cmbCopias);
            this.Controls.Add(this._lblPeliculaPrestamo);
            this.Controls.Add(this._lblPlazoPrestamo);
            this.Controls.Add(this._lblClientePrestamo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._cmbPeliculas);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this._btnAltaPrestamo);
            this.Controls.Add(this._btnVolverPrestamo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _lblClientePrestamo;
        private System.Windows.Forms.Label _lblPlazoPrestamo;
        private System.Windows.Forms.Label _lblPeliculaPrestamo;
        private System.Windows.Forms.Label _lblCopiaPrestamo;
        private System.Windows.Forms.ComboBox _cmbCopias;
    }
}