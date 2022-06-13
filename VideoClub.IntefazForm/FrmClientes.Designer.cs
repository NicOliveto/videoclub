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
            this._btnConsultarCliente = new System.Windows.Forms.Button();
            this._btnMenuPrincipal = new System.Windows.Forms.Button();
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
            // 
            // _btnConsultarCliente
            // 
            this._btnConsultarCliente.Location = new System.Drawing.Point(65, 151);
            this._btnConsultarCliente.Name = "_btnConsultarCliente";
            this._btnConsultarCliente.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarCliente.TabIndex = 1;
            this._btnConsultarCliente.Text = "Consultar Cliente";
            this._btnConsultarCliente.UseVisualStyleBackColor = true;
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
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnConsultarCliente);
            this.Controls.Add(this._btnIngresarClientes);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarClientes;
        private System.Windows.Forms.Button _btnConsultarCliente;
        private System.Windows.Forms.Button _btnMenuPrincipal;
    }
}