namespace VideoClub.IntefazForm
{
    partial class FrmIngrearCliente
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
            this._btnVolverClientes = new System.Windows.Forms.Button();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._txtDNI = new System.Windows.Forms.TextBox();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this._txtMail = new System.Windows.Forms.TextBox();
            this._txtFechaNac = new System.Windows.Forms.TextBox();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblApellido = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this._lblDni = new System.Windows.Forms.Label();
            this._lblTelefono = new System.Windows.Forms.Label();
            this._lblMail = new System.Windows.Forms.Label();
            this._lblFechaNac = new System.Windows.Forms.Label();
            this._btnAltaCliente = new System.Windows.Forms.Button();
            this._lblError = new System.Windows.Forms.Label();
            this._lblNombreError = new System.Windows.Forms.Label();
            this._lblApellidoError = new System.Windows.Forms.Label();
            this._lblDireccionError = new System.Windows.Forms.Label();
            this._lblDniError = new System.Windows.Forms.Label();
            this._lblTelefonoError = new System.Windows.Forms.Label();
            this._lblMailError = new System.Windows.Forms.Label();
            this._lblFechaNacError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnVolverClientes
            // 
            this._btnVolverClientes.Location = new System.Drawing.Point(305, 341);
            this._btnVolverClientes.Name = "_btnVolverClientes";
            this._btnVolverClientes.Size = new System.Drawing.Size(166, 65);
            this._btnVolverClientes.TabIndex = 0;
            this._btnVolverClientes.Text = "Volver";
            this._btnVolverClientes.UseVisualStyleBackColor = true;
            this._btnVolverClientes.Click += new System.EventHandler(this._btnVolverClientes_Click);
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(243, 41);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(273, 22);
            this._txtNombre.TabIndex = 1;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(243, 69);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(273, 22);
            this._txtApellido.TabIndex = 2;
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(243, 97);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(273, 22);
            this._txtDireccion.TabIndex = 3;
            // 
            // _txtDNI
            // 
            this._txtDNI.Location = new System.Drawing.Point(243, 125);
            this._txtDNI.Name = "_txtDNI";
            this._txtDNI.Size = new System.Drawing.Size(273, 22);
            this._txtDNI.TabIndex = 4;
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(243, 153);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(273, 22);
            this._txtTelefono.TabIndex = 5;
            // 
            // _txtMail
            // 
            this._txtMail.Location = new System.Drawing.Point(243, 184);
            this._txtMail.Name = "_txtMail";
            this._txtMail.Size = new System.Drawing.Size(273, 22);
            this._txtMail.TabIndex = 6;
            // 
            // _txtFechaNac
            // 
            this._txtFechaNac.Location = new System.Drawing.Point(243, 212);
            this._txtFechaNac.Name = "_txtFechaNac";
            this._txtFechaNac.Size = new System.Drawing.Size(273, 22);
            this._txtFechaNac.TabIndex = 7;
            // 
            // _lblNombre
            // 
            this._lblNombre.Location = new System.Drawing.Point(12, 41);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(171, 22);
            this._lblNombre.TabIndex = 8;
            this._lblNombre.Text = "Nombre:";
            // 
            // _lblApellido
            // 
            this._lblApellido.Location = new System.Drawing.Point(12, 72);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblApellido.Size = new System.Drawing.Size(171, 22);
            this._lblApellido.TabIndex = 9;
            this._lblApellido.Text = "Apeliido:";
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(12, 100);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(171, 22);
            this.v.TabIndex = 10;
            this.v.Text = "Direccion:";
            // 
            // _lblDni
            // 
            this._lblDni.Location = new System.Drawing.Point(12, 128);
            this._lblDni.Name = "_lblDni";
            this._lblDni.Size = new System.Drawing.Size(171, 22);
            this._lblDni.TabIndex = 11;
            this._lblDni.Text = "DNI:";
            // 
            // _lblTelefono
            // 
            this._lblTelefono.Location = new System.Drawing.Point(12, 156);
            this._lblTelefono.Name = "_lblTelefono";
            this._lblTelefono.Size = new System.Drawing.Size(171, 22);
            this._lblTelefono.TabIndex = 12;
            this._lblTelefono.Text = "Teléfono: (solo numeros)";
            // 
            // _lblMail
            // 
            this._lblMail.Location = new System.Drawing.Point(12, 184);
            this._lblMail.Name = "_lblMail";
            this._lblMail.Size = new System.Drawing.Size(171, 22);
            this._lblMail.TabIndex = 13;
            this._lblMail.Text = "Mail:";
            // 
            // _lblFechaNac
            // 
            this._lblFechaNac.Location = new System.Drawing.Point(12, 212);
            this._lblFechaNac.Name = "_lblFechaNac";
            this._lblFechaNac.Size = new System.Drawing.Size(225, 22);
            this._lblFechaNac.TabIndex = 14;
            this._lblFechaNac.Text = "Fecha de nacimiento: AAAA-MM-DD";
            // 
            // _btnAltaCliente
            // 
            this._btnAltaCliente.Location = new System.Drawing.Point(50, 341);
            this._btnAltaCliente.Name = "_btnAltaCliente";
            this._btnAltaCliente.Size = new System.Drawing.Size(166, 65);
            this._btnAltaCliente.TabIndex = 15;
            this._btnAltaCliente.Text = "Alta Cliente";
            this._btnAltaCliente.UseVisualStyleBackColor = true;
            this._btnAltaCliente.Click += new System.EventHandler(this._btnAltaCliente_Click);
            // 
            // _lblError
            // 
            this._lblError.Location = new System.Drawing.Point(549, 9);
            this._lblError.Name = "_lblError";
            this._lblError.Size = new System.Drawing.Size(224, 22);
            this._lblError.TabIndex = 16;
            // 
            // _lblNombreError
            // 
            this._lblNombreError.ForeColor = System.Drawing.Color.Brown;
            this._lblNombreError.Location = new System.Drawing.Point(522, 41);
            this._lblNombreError.Name = "_lblNombreError";
            this._lblNombreError.Size = new System.Drawing.Size(171, 22);
            this._lblNombreError.TabIndex = 17;
            // 
            // _lblApellidoError
            // 
            this._lblApellidoError.ForeColor = System.Drawing.Color.Brown;
            this._lblApellidoError.Location = new System.Drawing.Point(522, 69);
            this._lblApellidoError.Name = "_lblApellidoError";
            this._lblApellidoError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblApellidoError.Size = new System.Drawing.Size(171, 22);
            this._lblApellidoError.TabIndex = 18;
            // 
            // _lblDireccionError
            // 
            this._lblDireccionError.ForeColor = System.Drawing.Color.Brown;
            this._lblDireccionError.Location = new System.Drawing.Point(522, 97);
            this._lblDireccionError.Name = "_lblDireccionError";
            this._lblDireccionError.Size = new System.Drawing.Size(171, 22);
            this._lblDireccionError.TabIndex = 19;
            // 
            // _lblDniError
            // 
            this._lblDniError.ForeColor = System.Drawing.Color.Brown;
            this._lblDniError.Location = new System.Drawing.Point(522, 125);
            this._lblDniError.Name = "_lblDniError";
            this._lblDniError.Size = new System.Drawing.Size(171, 22);
            this._lblDniError.TabIndex = 20;
            // 
            // _lblTelefonoError
            // 
            this._lblTelefonoError.ForeColor = System.Drawing.Color.Brown;
            this._lblTelefonoError.Location = new System.Drawing.Point(522, 156);
            this._lblTelefonoError.Name = "_lblTelefonoError";
            this._lblTelefonoError.Size = new System.Drawing.Size(171, 22);
            this._lblTelefonoError.TabIndex = 21;
            // 
            // _lblMailError
            // 
            this._lblMailError.ForeColor = System.Drawing.Color.Brown;
            this._lblMailError.Location = new System.Drawing.Point(522, 184);
            this._lblMailError.Name = "_lblMailError";
            this._lblMailError.Size = new System.Drawing.Size(171, 22);
            this._lblMailError.TabIndex = 22;
            // 
            // _lblFechaNacError
            // 
            this._lblFechaNacError.ForeColor = System.Drawing.Color.Brown;
            this._lblFechaNacError.Location = new System.Drawing.Point(522, 212);
            this._lblFechaNacError.Name = "_lblFechaNacError";
            this._lblFechaNacError.Size = new System.Drawing.Size(171, 22);
            this._lblFechaNacError.TabIndex = 23;
            // 
            // FrmIngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 483);
            this.Controls.Add(this._lblFechaNacError);
            this.Controls.Add(this._lblMailError);
            this.Controls.Add(this._lblTelefonoError);
            this.Controls.Add(this._lblDniError);
            this.Controls.Add(this._lblDireccionError);
            this.Controls.Add(this._lblApellidoError);
            this.Controls.Add(this._lblNombreError);
            this.Controls.Add(this._lblError);
            this.Controls.Add(this._btnAltaCliente);
            this.Controls.Add(this._lblFechaNac);
            this.Controls.Add(this._lblMail);
            this.Controls.Add(this._lblTelefono);
            this.Controls.Add(this._lblDni);
            this.Controls.Add(this.v);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._txtFechaNac);
            this.Controls.Add(this._txtMail);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this._txtDNI);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._btnVolverClientes);
            this.Name = "FrmIngresoCliente";
            this.Text = "FrmIngresoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnVolverClientes;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtDNI;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.TextBox _txtMail;
        private System.Windows.Forms.TextBox _txtFechaNac;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label _lblDni;
        private System.Windows.Forms.Label _lblTelefono;
        private System.Windows.Forms.Label _lblMail;
        private System.Windows.Forms.Label _lblFechaNac;
        private System.Windows.Forms.Button _btnAltaCliente;
        private System.Windows.Forms.Label _lblError;
        private System.Windows.Forms.Label _lblNombreError;
        private System.Windows.Forms.Label _lblApellidoError;
        private System.Windows.Forms.Label _lblDireccionError;
        private System.Windows.Forms.Label _lblDniError;
        private System.Windows.Forms.Label _lblTelefonoError;
        private System.Windows.Forms.Label _lblMailError;
        private System.Windows.Forms.Label _lblFechaNacError;
    }
}