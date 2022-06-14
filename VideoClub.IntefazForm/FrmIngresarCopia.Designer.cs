namespace VideoClub.IntefazForm
{
    partial class FrmIngresarCopia
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
            this._btnConsultarCopias = new System.Windows.Forms.Button();
            this._cmbCopias = new System.Windows.Forms.ComboBox();
            this._lblSelecPeli = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._lblObservaciones = new System.Windows.Forms.Label();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._lblCantidadCopias = new System.Windows.Forms.Label();
            this._txtObservaciones = new System.Windows.Forms.TextBox();
            this._txtCantidadCopias = new System.Windows.Forms.TextBox();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnConsultarCopias
            // 
            this._btnConsultarCopias.Location = new System.Drawing.Point(330, 251);
            this._btnConsultarCopias.Name = "_btnConsultarCopias";
            this._btnConsultarCopias.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarCopias.TabIndex = 14;
            this._btnConsultarCopias.Text = "Crear Copias";
            this._btnConsultarCopias.UseVisualStyleBackColor = true;
            // 
            // _cmbCopias
            // 
            this._cmbCopias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCopias.FormattingEnabled = true;
            this._cmbCopias.Location = new System.Drawing.Point(231, 62);
            this._cmbCopias.Name = "_cmbCopias";
            this._cmbCopias.Size = new System.Drawing.Size(339, 24);
            this._cmbCopias.TabIndex = 13;
            // 
            // _lblSelecPeli
            // 
            this._lblSelecPeli.Location = new System.Drawing.Point(28, 62);
            this._lblSelecPeli.Name = "_lblSelecPeli";
            this._lblSelecPeli.Size = new System.Drawing.Size(169, 24);
            this._lblSelecPeli.TabIndex = 15;
            this._lblSelecPeli.Text = "Seleccione la pelicula ";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(40, 375);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(157, 63);
            this._btnVolver.TabIndex = 16;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            // 
            // _lblObservaciones
            // 
            this._lblObservaciones.Location = new System.Drawing.Point(28, 108);
            this._lblObservaciones.Name = "_lblObservaciones";
            this._lblObservaciones.Size = new System.Drawing.Size(169, 24);
            this._lblObservaciones.TabIndex = 17;
            this._lblObservaciones.Text = "Observaciones:";
            // 
            // _lblPrecio
            // 
            this._lblPrecio.Location = new System.Drawing.Point(28, 148);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(169, 24);
            this._lblPrecio.TabIndex = 18;
            this._lblPrecio.Text = "Precio:";
            // 
            // _lblCantidadCopias
            // 
            this._lblCantidadCopias.Location = new System.Drawing.Point(28, 188);
            this._lblCantidadCopias.Name = "_lblCantidadCopias";
            this._lblCantidadCopias.Size = new System.Drawing.Size(169, 24);
            this._lblCantidadCopias.TabIndex = 19;
            this._lblCantidadCopias.Text = "Cantidad de copias";
            // 
            // _txtObservaciones
            // 
            this._txtObservaciones.Location = new System.Drawing.Point(231, 105);
            this._txtObservaciones.Name = "_txtObservaciones";
            this._txtObservaciones.Size = new System.Drawing.Size(339, 22);
            this._txtObservaciones.TabIndex = 20;
            // 
            // _txtCantidadCopias
            // 
            this._txtCantidadCopias.Location = new System.Drawing.Point(231, 190);
            this._txtCantidadCopias.Name = "_txtCantidadCopias";
            this._txtCantidadCopias.Size = new System.Drawing.Size(339, 22);
            this._txtCantidadCopias.TabIndex = 21;
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(231, 148);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(339, 22);
            this._txtPrecio.TabIndex = 22;
            // 
            // FrmIngresarCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtPrecio);
            this.Controls.Add(this._txtCantidadCopias);
            this.Controls.Add(this._txtObservaciones);
            this.Controls.Add(this._lblCantidadCopias);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._lblObservaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblSelecPeli);
            this.Controls.Add(this._btnConsultarCopias);
            this.Controls.Add(this._cmbCopias);
            this.Name = "FrmIngresarCopia";
            this.Text = "FrmIngresarCopia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnConsultarCopias;
        private System.Windows.Forms.ComboBox _cmbCopias;
        private System.Windows.Forms.Label _lblSelecPeli;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblObservaciones;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblCantidadCopias;
        private System.Windows.Forms.TextBox _txtObservaciones;
        private System.Windows.Forms.TextBox _txtCantidadCopias;
        private System.Windows.Forms.TextBox _txtPrecio;
    }
}