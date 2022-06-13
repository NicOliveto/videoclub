namespace VideoClub.IntefazForm
{
    partial class FrmPrestamos
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
            this._btnIngresarPrestamos = new System.Windows.Forms.Button();
            this._btnConsultarPrestamo = new System.Windows.Forms.Button();
            this._cmbPrestamos = new System.Windows.Forms.ComboBox();
            this._btnActualizarListado = new System.Windows.Forms.Button();
            this._btnMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnIngresarPrestamos
            // 
            this._btnIngresarPrestamos.Location = new System.Drawing.Point(21, 29);
            this._btnIngresarPrestamos.Name = "_btnIngresarPrestamos";
            this._btnIngresarPrestamos.Size = new System.Drawing.Size(157, 63);
            this._btnIngresarPrestamos.TabIndex = 1;
            this._btnIngresarPrestamos.Text = "Ingresar Prestamos";
            this._btnIngresarPrestamos.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarPrestamo
            // 
            this._btnConsultarPrestamo.Location = new System.Drawing.Point(21, 133);
            this._btnConsultarPrestamo.Name = "_btnConsultarPrestamo";
            this._btnConsultarPrestamo.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarPrestamo.TabIndex = 2;
            this._btnConsultarPrestamo.Text = "Consultar Prestamo";
            this._btnConsultarPrestamo.UseVisualStyleBackColor = true;
            // 
            // _cmbPrestamos
            // 
            this._cmbPrestamos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPrestamos.FormattingEnabled = true;
            this._cmbPrestamos.Location = new System.Drawing.Point(198, 153);
            this._cmbPrestamos.Name = "_cmbPrestamos";
            this._cmbPrestamos.Size = new System.Drawing.Size(339, 24);
            this._cmbPrestamos.TabIndex = 5;
            // 
            // _btnActualizarListado
            // 
            this._btnActualizarListado.Location = new System.Drawing.Point(579, 153);
            this._btnActualizarListado.Name = "_btnActualizarListado";
            this._btnActualizarListado.Size = new System.Drawing.Size(129, 45);
            this._btnActualizarListado.TabIndex = 8;
            this._btnActualizarListado.Text = "Actualizar listado";
            this._btnActualizarListado.UseVisualStyleBackColor = true;
            // 
            // _btnMenuPrincipal
            // 
            this._btnMenuPrincipal.Location = new System.Drawing.Point(21, 331);
            this._btnMenuPrincipal.Name = "_btnMenuPrincipal";
            this._btnMenuPrincipal.Size = new System.Drawing.Size(157, 63);
            this._btnMenuPrincipal.TabIndex = 9;
            this._btnMenuPrincipal.Text = "Menu Principal";
            this._btnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnActualizarListado);
            this.Controls.Add(this._cmbPrestamos);
            this.Controls.Add(this._btnConsultarPrestamo);
            this.Controls.Add(this._btnIngresarPrestamos);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarPrestamos;
        private System.Windows.Forms.Button _btnConsultarPrestamo;
        private System.Windows.Forms.ComboBox _cmbPrestamos;
        private System.Windows.Forms.Button _btnActualizarListado;
        private System.Windows.Forms.Button _btnMenuPrincipal;
    }
}