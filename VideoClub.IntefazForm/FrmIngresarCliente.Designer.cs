﻿namespace VideoClub.IntefazForm
{
    partial class FrmIngresarCliente
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
            this.SuspendLayout();
            // 
            // _btnVolverClientes
            // 
            this._btnVolverClientes.Location = new System.Drawing.Point(12, 406);
            this._btnVolverClientes.Name = "_btnVolverClientes";
            this._btnVolverClientes.Size = new System.Drawing.Size(166, 65);
            this._btnVolverClientes.TabIndex = 0;
            this._btnVolverClientes.Text = "Volver";
            this._btnVolverClientes.UseVisualStyleBackColor = true;
            this._btnVolverClientes.Click += new System.EventHandler(this._btnVolverClientes_Click);
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(288, 41);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(273, 22);
            this._txtNombre.TabIndex = 1;
            this._txtNombre.TextChanged += new System.EventHandler(this._txtNombre_TextChanged);
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(288, 69);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(273, 22);
            this._txtApellido.TabIndex = 2;
            this._txtApellido.TextChanged += new System.EventHandler(this._txtApellido_TextChanged);
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(288, 97);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(273, 22);
            this._txtDireccion.TabIndex = 3;
            this._txtDireccion.TextChanged += new System.EventHandler(this._txtDireccion_TextChanged);
            // 
            // _txtDNI
            // 
            this._txtDNI.Location = new System.Drawing.Point(288, 125);
            this._txtDNI.Name = "_txtDNI";
            this._txtDNI.Size = new System.Drawing.Size(273, 22);
            this._txtDNI.TabIndex = 4;
            this._txtDNI.TextChanged += new System.EventHandler(this._txtDNI_TextChanged);
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(288, 153);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(273, 22);
            this._txtTelefono.TabIndex = 5;
            this._txtTelefono.TextChanged += new System.EventHandler(this._txtTelefono_TextChanged);
            // 
            // _txtMail
            // 
            this._txtMail.Location = new System.Drawing.Point(288, 184);
            this._txtMail.Name = "_txtMail";
            this._txtMail.Size = new System.Drawing.Size(273, 22);
            this._txtMail.TabIndex = 6;
            this._txtMail.TextChanged += new System.EventHandler(this._txtMail_TextChanged);
            // 
            // _txtFechaNac
            // 
            this._txtFechaNac.Location = new System.Drawing.Point(288, 212);
            this._txtFechaNac.Name = "_txtFechaNac";
            this._txtFechaNac.Size = new System.Drawing.Size(273, 22);
            this._txtFechaNac.TabIndex = 7;
            this._txtFechaNac.TextChanged += new System.EventHandler(this._txtFechaNac_TextChanged);
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
            this._lblFechaNac.Size = new System.Drawing.Size(252, 22);
            this._lblFechaNac.TabIndex = 14;
            this._lblFechaNac.Text = "Fecha de nacimiento: AAAA-MM-DD";
            // 
            // _btnAltaCliente
            // 
            this._btnAltaCliente.Location = new System.Drawing.Point(243, 406);
            this._btnAltaCliente.Name = "_btnAltaCliente";
            this._btnAltaCliente.Size = new System.Drawing.Size(166, 65);
            this._btnAltaCliente.TabIndex = 15;
            this._btnAltaCliente.Text = "Alta Cliente";
            this._btnAltaCliente.UseVisualStyleBackColor = true;
            this._btnAltaCliente.Click += new System.EventHandler(this._btnAltaCliente_Click);
            // 
            // FrmIngresarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 483);
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
            this.Name = "FrmIngresarCliente";
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
    }
}