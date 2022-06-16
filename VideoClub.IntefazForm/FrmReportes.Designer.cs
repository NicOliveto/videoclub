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
            this._lblPrestamosPorCliente = new System.Windows.Forms.Label();
            this._lblCopiasPorPelicula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnPrestamosPorCliente
            // 
            this._btnPrestamosPorCliente.Location = new System.Drawing.Point(12, 42);
            this._btnPrestamosPorCliente.Name = "_btnPrestamosPorCliente";
            this._btnPrestamosPorCliente.Size = new System.Drawing.Size(157, 63);
            this._btnPrestamosPorCliente.TabIndex = 1;
            this._btnPrestamosPorCliente.Text = "Prestamos por cliente";
            this._btnPrestamosPorCliente.UseVisualStyleBackColor = true;
            // 
            // _btnCopiasPorPelicula
            // 
            this._btnCopiasPorPelicula.Location = new System.Drawing.Point(12, 244);
            this._btnCopiasPorPelicula.Name = "_btnCopiasPorPelicula";
            this._btnCopiasPorPelicula.Size = new System.Drawing.Size(157, 63);
            this._btnCopiasPorPelicula.TabIndex = 2;
            this._btnCopiasPorPelicula.Text = "Copias por pelicula";
            this._btnCopiasPorPelicula.UseVisualStyleBackColor = true;
            // 
            // _btnMenuPrincipal
            // 
            this._btnMenuPrincipal.Location = new System.Drawing.Point(12, 375);
            this._btnMenuPrincipal.Name = "_btnMenuPrincipal";
            this._btnMenuPrincipal.Size = new System.Drawing.Size(157, 63);
            this._btnMenuPrincipal.TabIndex = 3;
            this._btnMenuPrincipal.Text = "Menu Principal";
            this._btnMenuPrincipal.UseVisualStyleBackColor = true;
            this._btnMenuPrincipal.Click += new System.EventHandler(this._btnMenuPrincipal_Click);
            // 
            // _cmbCopiasPorPelicula
            // 
            this._cmbCopiasPorPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCopiasPorPelicula.FormattingEnabled = true;
            this._cmbCopiasPorPelicula.Location = new System.Drawing.Point(188, 244);
            this._cmbCopiasPorPelicula.Name = "_cmbCopiasPorPelicula";
            this._cmbCopiasPorPelicula.Size = new System.Drawing.Size(339, 24);
            this._cmbCopiasPorPelicula.TabIndex = 6;
            // 
            // _cmbPrestamoPorCliente
            // 
            this._cmbPrestamoPorCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPrestamoPorCliente.FormattingEnabled = true;
            this._cmbPrestamoPorCliente.Location = new System.Drawing.Point(188, 42);
            this._cmbPrestamoPorCliente.Name = "_cmbPrestamoPorCliente";
            this._cmbPrestamoPorCliente.Size = new System.Drawing.Size(339, 24);
            this._cmbPrestamoPorCliente.TabIndex = 7;
            // 
            // _lblPrestamosPorCliente
            // 
            this._lblPrestamosPorCliente.Location = new System.Drawing.Point(188, 82);
            this._lblPrestamosPorCliente.Name = "_lblPrestamosPorCliente";
            this._lblPrestamosPorCliente.Size = new System.Drawing.Size(339, 159);
            this._lblPrestamosPorCliente.TabIndex = 8;
            this._lblPrestamosPorCliente.Text = "Pretamos por cliente:";
            // 
            // _lblCopiasPorPelicula
            // 
            this._lblCopiasPorPelicula.Location = new System.Drawing.Point(188, 297);
            this._lblCopiasPorPelicula.Name = "_lblCopiasPorPelicula";
            this._lblCopiasPorPelicula.Size = new System.Drawing.Size(339, 141);
            this._lblCopiasPorPelicula.TabIndex = 9;
            this._lblCopiasPorPelicula.Text = "Copias por pelicula:";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 495);
            this.Controls.Add(this._lblCopiasPorPelicula);
            this.Controls.Add(this._lblPrestamosPorCliente);
            this.Controls.Add(this._cmbPrestamoPorCliente);
            this.Controls.Add(this._cmbCopiasPorPelicula);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnCopiasPorPelicula);
            this.Controls.Add(this._btnPrestamosPorCliente);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnPrestamosPorCliente;
        private System.Windows.Forms.Button _btnCopiasPorPelicula;
        private System.Windows.Forms.Button _btnMenuPrincipal;
        private System.Windows.Forms.ComboBox _cmbCopiasPorPelicula;
        private System.Windows.Forms.ComboBox _cmbPrestamoPorCliente;
        private System.Windows.Forms.Label _lblPrestamosPorCliente;
        private System.Windows.Forms.Label _lblCopiasPorPelicula;
    }
}