namespace VideoClub.IntefazForm
{
    partial class FrmIngresoCliente
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
            this.SuspendLayout();
            // 
            // _btnVolverClientes
            // 
            this._btnVolverClientes.Location = new System.Drawing.Point(78, 231);
            this._btnVolverClientes.Name = "_btnVolverClientes";
            this._btnVolverClientes.Size = new System.Drawing.Size(166, 65);
            this._btnVolverClientes.TabIndex = 0;
            this._btnVolverClientes.Text = "Volver";
            this._btnVolverClientes.UseVisualStyleBackColor = true;
            this._btnVolverClientes.Click += new System.EventHandler(this._btnVolverClientes_Click);
            // 
            // FrmIngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnVolverClientes);
            this.Name = "FrmIngresoCliente";
            this.Text = "FrmIngresoCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnVolverClientes;
    }
}