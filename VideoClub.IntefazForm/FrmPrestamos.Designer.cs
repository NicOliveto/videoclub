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
            this._btnConsultarPrestamoAbierto = new System.Windows.Forms.Button();
            this._cmbPrestamosAbiertos = new System.Windows.Forms.ComboBox();
            this._btnActualizarListado = new System.Windows.Forms.Button();
            this._btnMenuPrincipal = new System.Windows.Forms.Button();
            this._cmbPrestamosCerrados = new System.Windows.Forms.ComboBox();
            this._btnConsultarPrestamoCerrado = new System.Windows.Forms.Button();
            this._lblPrestamoAbierto = new System.Windows.Forms.Label();
            this._lblPrestamoCerrado = new System.Windows.Forms.Label();
            this._cmbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._lblVerCliente = new System.Windows.Forms.Label();
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
            // _btnConsultarPrestamoAbierto
            // 
            this._btnConsultarPrestamoAbierto.Location = new System.Drawing.Point(21, 133);
            this._btnConsultarPrestamoAbierto.Name = "_btnConsultarPrestamoAbierto";
            this._btnConsultarPrestamoAbierto.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarPrestamoAbierto.TabIndex = 2;
            this._btnConsultarPrestamoAbierto.Text = "Consultar Prestamo Abierto";
            this._btnConsultarPrestamoAbierto.UseVisualStyleBackColor = true;
            this._btnConsultarPrestamoAbierto.Click += new System.EventHandler(this._btnConsultarPrestamoAbierto_Click);
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
            this._btnActualizarListado.Click += new System.EventHandler(this._btnActualizarListado_Click);
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
            // _cmbPrestamosCerrados
            // 
            this._cmbPrestamosCerrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPrestamosCerrados.FormattingEnabled = true;
            this._cmbPrestamosCerrados.Location = new System.Drawing.Point(922, 153);
            this._cmbPrestamosCerrados.Name = "_cmbPrestamosCerrados";
            this._cmbPrestamosCerrados.Size = new System.Drawing.Size(339, 24);
            this._cmbPrestamosCerrados.TabIndex = 11;
            // 
            // _btnConsultarPrestamoCerrado
            // 
            this._btnConsultarPrestamoCerrado.Location = new System.Drawing.Point(745, 133);
            this._btnConsultarPrestamoCerrado.Name = "_btnConsultarPrestamoCerrado";
            this._btnConsultarPrestamoCerrado.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarPrestamoCerrado.TabIndex = 10;
            this._btnConsultarPrestamoCerrado.Text = "Consultar Prestamo Cerrado";
            this._btnConsultarPrestamoCerrado.UseVisualStyleBackColor = true;
            this._btnConsultarPrestamoCerrado.Click += new System.EventHandler(this._btnConsultarPrestamoCerrado_Click);
            // 
            // _lblPrestamoAbierto
            // 
            this._lblPrestamoAbierto.Location = new System.Drawing.Point(198, 220);
            this._lblPrestamoAbierto.Name = "_lblPrestamoAbierto";
            this._lblPrestamoAbierto.Size = new System.Drawing.Size(339, 174);
            this._lblPrestamoAbierto.TabIndex = 12;
            // 
            // _lblPrestamoCerrado
            // 
            this._lblPrestamoCerrado.Location = new System.Drawing.Point(919, 220);
            this._lblPrestamoCerrado.Name = "_lblPrestamoCerrado";
            this._lblPrestamoCerrado.Size = new System.Drawing.Size(339, 174);
            this._lblPrestamoCerrado.TabIndex = 13;
            // 
            // _cmbClientes
            // 
            this._cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(919, 29);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(339, 24);
            this._cmbClientes.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // _lblVerCliente
            // 
            this._lblVerCliente.Location = new System.Drawing.Point(755, 29);
            this._lblVerCliente.Name = "_lblVerCliente";
            this._lblVerCliente.Size = new System.Drawing.Size(147, 24);
            this._lblVerCliente.TabIndex = 16;
            this._lblVerCliente.Text = "Ver cliente y su ID:";
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoClub.IntefazForm.Properties.Resources.frmfondoConsulas;
            this.ClientSize = new System.Drawing.Size(1294, 432);
            this.Controls.Add(this._lblVerCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this._lblPrestamoCerrado);
            this.Controls.Add(this._lblPrestamoAbierto);
            this.Controls.Add(this._cmbPrestamosCerrados);
            this.Controls.Add(this._btnConsultarPrestamoCerrado);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnActualizarListado);
            this.Controls.Add(this._cmbPrestamosAbiertos);
            this.Controls.Add(this._btnConsultarPrestamoAbierto);
            this.Controls.Add(this._btnIngresarPrestamos);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarPrestamos;
        private System.Windows.Forms.Button _btnConsultarPrestamoAbierto;
        private System.Windows.Forms.ComboBox _cmbPrestamosAbiertos;
        private System.Windows.Forms.Button _btnActualizarListado;
        private System.Windows.Forms.Button _btnMenuPrincipal;
        private System.Windows.Forms.ComboBox _cmbPrestamosCerrados;
        private System.Windows.Forms.Button _btnConsultarPrestamoCerrado;
        private System.Windows.Forms.Label _lblPrestamoAbierto;
        private System.Windows.Forms.Label _lblPrestamoCerrado;
        private System.Windows.Forms.ComboBox _cmbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblVerCliente;
    }
}