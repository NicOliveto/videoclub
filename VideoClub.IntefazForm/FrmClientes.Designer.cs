namespace VideoClub.IntefazForm
{
    partial class FrmClientes
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
            this._btnIngresarClientes = new System.Windows.Forms.Button();
            this._btnMenuPrincipal = new System.Windows.Forms.Button();
            this._cmbClientes = new System.Windows.Forms.ComboBox();
            this._lblClienteParaMostrar = new System.Windows.Forms.Label();
            this._btnConsultarCliente = new System.Windows.Forms.Button();
            this._btnActualizarListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnIngresarClientes
            // 
            this._btnIngresarClientes.Location = new System.Drawing.Point(65, 42);
            this._btnIngresarClientes.Name = "_btnIngresarClientes";
            this._btnIngresarClientes.Size = new System.Drawing.Size(157, 63);
            this._btnIngresarClientes.TabIndex = 0;
            this._btnIngresarClientes.Text = "Ingresar Clientes";
            this._btnIngresarClientes.UseVisualStyleBackColor = true;
            this._btnIngresarClientes.Click += new System.EventHandler(this._btnIngresarClientes_Click);
            // 
            // _btnMenuPrincipal
            // 
            this._btnMenuPrincipal.Location = new System.Drawing.Point(65, 287);
            this._btnMenuPrincipal.Name = "_btnMenuPrincipal";
            this._btnMenuPrincipal.Size = new System.Drawing.Size(157, 63);
            this._btnMenuPrincipal.TabIndex = 2;
            this._btnMenuPrincipal.Text = "Menu Principal";
            this._btnMenuPrincipal.UseVisualStyleBackColor = true;
            this._btnMenuPrincipal.Click += new System.EventHandler(this._btnMenuPrincipal_Click);
            // 
            // _cmbClientes
            // 
            this._cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(228, 147);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(339, 24);
            this._cmbClientes.TabIndex = 4;
            this._cmbClientes.SelectedIndexChanged += new System.EventHandler(this._cmbClientes_SelectedIndexChanged);
            // 
            // _lblClienteParaMostrar
            // 
            this._lblClienteParaMostrar.Location = new System.Drawing.Point(290, 195);
            this._lblClienteParaMostrar.Name = "_lblClienteParaMostrar";
            this._lblClienteParaMostrar.Size = new System.Drawing.Size(339, 195);
            this._lblClienteParaMostrar.TabIndex = 5;
            // 
            // _btnConsultarCliente
            // 
            this._btnConsultarCliente.Location = new System.Drawing.Point(65, 127);
            this._btnConsultarCliente.Name = "_btnConsultarCliente";
            this._btnConsultarCliente.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarCliente.TabIndex = 6;
            this._btnConsultarCliente.Text = "Consultar Cliente";
            this._btnConsultarCliente.UseVisualStyleBackColor = true;
            this._btnConsultarCliente.Click += new System.EventHandler(this._btnConsultarCliente_Click);
            // 
            // _btnActualizarListado
            // 
            this._btnActualizarListado.Location = new System.Drawing.Point(628, 147);
            this._btnActualizarListado.Name = "_btnActualizarListado";
            this._btnActualizarListado.Size = new System.Drawing.Size(129, 45);
            this._btnActualizarListado.TabIndex = 7;
            this._btnActualizarListado.Text = "Actualizar listado";
            this._btnActualizarListado.UseVisualStyleBackColor = true;
            this._btnActualizarListado.Click += new System.EventHandler(this._btnActualizarListado_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this._btnActualizarListado);
            this.Controls.Add(this._btnConsultarCliente);
            this.Controls.Add(this._lblClienteParaMostrar);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnIngresarClientes);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarClientes;
        private System.Windows.Forms.Button _btnMenuPrincipal;
        private System.Windows.Forms.ComboBox _cmbClientes;
        private System.Windows.Forms.Label _lblClienteParaMostrar;
        private System.Windows.Forms.Button _btnConsultarCliente;
        private System.Windows.Forms.Button _btnActualizarListado;
    }
}