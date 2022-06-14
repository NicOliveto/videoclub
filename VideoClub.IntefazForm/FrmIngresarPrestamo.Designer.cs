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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._lblClientePrestamo = new System.Windows.Forms.Label();
            this._lblPlazoPrestamo = new System.Windows.Forms.Label();
            this._lblPeliculaPrestamo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnAltaPrestamo
            // 
            this._btnAltaPrestamo.Location = new System.Drawing.Point(56, 350);
            this._btnAltaPrestamo.Name = "_btnAltaPrestamo";
            this._btnAltaPrestamo.Size = new System.Drawing.Size(166, 65);
            this._btnAltaPrestamo.TabIndex = 17;
            this._btnAltaPrestamo.Text = "Alta Prestamo";
            this._btnAltaPrestamo.UseVisualStyleBackColor = true;
            // 
            // _btnVolverPrestamo
            // 
            this._btnVolverPrestamo.Location = new System.Drawing.Point(311, 350);
            this._btnVolverPrestamo.Name = "_btnVolverPrestamo";
            this._btnVolverPrestamo.Size = new System.Drawing.Size(166, 65);
            this._btnVolverPrestamo.TabIndex = 16;
            this._btnVolverPrestamo.Text = "Volver";
            this._btnVolverPrestamo.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 20;
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
            this._lblPlazoPrestamo.Location = new System.Drawing.Point(39, 140);
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
            // FrmIngresarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblPeliculaPrestamo);
            this.Controls.Add(this._lblPlazoPrestamo);
            this.Controls.Add(this._lblClientePrestamo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this._btnAltaPrestamo);
            this.Controls.Add(this._btnVolverPrestamo);
            this.Name = "FrmIngresarPrestamo";
            this.Text = "FrmIngresarPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAltaPrestamo;
        private System.Windows.Forms.Button _btnVolverPrestamo;
        private System.Windows.Forms.ComboBox _cmbClientes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _lblClientePrestamo;
        private System.Windows.Forms.Label _lblPlazoPrestamo;
        private System.Windows.Forms.Label _lblPeliculaPrestamo;
    }
}