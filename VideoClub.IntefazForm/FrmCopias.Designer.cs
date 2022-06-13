namespace VideoClub.IntefazForm
{
    partial class FrmCopias
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
            this.SuspendLayout();
            // 
            // _btnIngresarClientes
            // 
            this._btnIngresarClientes.Location = new System.Drawing.Point(72, 53);
            this._btnIngresarClientes.Name = "_btnIngresarClientes";
            this._btnIngresarClientes.Size = new System.Drawing.Size(157, 63);
            this._btnIngresarClientes.TabIndex = 1;
            this._btnIngresarClientes.Text = "Ingresar Clientes";
            this._btnIngresarClientes.UseVisualStyleBackColor = true;
            // 
            // FrmCopias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnIngresarClientes);
            this.Name = "FrmCopias";
            this.Text = "FrmCopias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarClientes;
    }
}