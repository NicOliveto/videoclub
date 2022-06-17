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
            this._btnConsultarPrestamoActual = new System.Windows.Forms.Button();
            this._cmbPrestamosAbiertos = new System.Windows.Forms.ComboBox();
            this._btnActualizarListado = new System.Windows.Forms.Button();
            this._btnMenuPrincipal = new System.Windows.Forms.Button();
            this._cbmPrestamosCerrados = new System.Windows.Forms.ComboBox();
            this._btnConsultarPrestamoCerrado = new System.Windows.Forms.Button();
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
            this._btnIngresarPrestamos.Click += new System.EventHandler(this._btnIngresarPrestamos_Click);
            // 
            // _btnConsultarPrestamoActual
            // 
            this._btnConsultarPrestamoActual.Location = new System.Drawing.Point(21, 133);
            this._btnConsultarPrestamoActual.Name = "_btnConsultarPrestamoActual";
            this._btnConsultarPrestamoActual.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarPrestamoActual.TabIndex = 2;
            this._btnConsultarPrestamoActual.Text = "Consultar Prestamo Abierto";
            this._btnConsultarPrestamoActual.UseVisualStyleBackColor = true;
            // 
            // _cmbPrestamosAbiertos
            // 
            this._cmbPrestamosAbiertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPrestamosAbiertos.FormattingEnabled = true;
            this._cmbPrestamosAbiertos.Location = new System.Drawing.Point(198, 153);
            this._cmbPrestamosAbiertos.Name = "_cmbPrestamosAbiertos";
            this._cmbPrestamosAbiertos.Size = new System.Drawing.Size(339, 24);
            this._cmbPrestamosAbiertos.TabIndex = 5;
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
            this._btnMenuPrincipal.Click += new System.EventHandler(this._btnMenuPrincipal_Click);
            // 
            // _cbmPrestamosCerrados
            // 
            this._cbmPrestamosCerrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbmPrestamosCerrados.FormattingEnabled = true;
            this._cbmPrestamosCerrados.Location = new System.Drawing.Point(922, 153);
            this._cbmPrestamosCerrados.Name = "_cbmPrestamosCerrados";
            this._cbmPrestamosCerrados.Size = new System.Drawing.Size(339, 24);
            this._cbmPrestamosCerrados.TabIndex = 11;
            // 
            // _btnConsultarPrestamoCerrado
            // 
            this._btnConsultarPrestamoCerrado.Location = new System.Drawing.Point(745, 133);
            this._btnConsultarPrestamoCerrado.Name = "_btnConsultarPrestamoCerrado";
            this._btnConsultarPrestamoCerrado.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarPrestamoCerrado.TabIndex = 10;
            this._btnConsultarPrestamoCerrado.Text = "Consultar Prestamo Cerrado";
            this._btnConsultarPrestamoCerrado.UseVisualStyleBackColor = true;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 432);
            this.Controls.Add(this._cbmPrestamosCerrados);
            this.Controls.Add(this._btnConsultarPrestamoCerrado);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnActualizarListado);
            this.Controls.Add(this._cmbPrestamosAbiertos);
            this.Controls.Add(this._btnConsultarPrestamoActual);
            this.Controls.Add(this._btnIngresarPrestamos);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarPrestamos;
        private System.Windows.Forms.Button _btnConsultarPrestamoActual;
        private System.Windows.Forms.ComboBox _cmbPrestamosAbiertos;
        private System.Windows.Forms.Button _btnActualizarListado;
        private System.Windows.Forms.Button _btnMenuPrincipal;
        private System.Windows.Forms.ComboBox _cbmPrestamosCerrados;
        private System.Windows.Forms.Button _btnConsultarPrestamoCerrado;
    }
}