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
            this._btnActualizarListado = new System.Windows.Forms.Button();
            this._btnConsultarCopias = new System.Windows.Forms.Button();
            this._lblCopiasParaMostrar = new System.Windows.Forms.Label();
            this._cmbCopias = new System.Windows.Forms.ComboBox();
            this._btnMenuPrincipal = new System.Windows.Forms.Button();
            this._btnIngresarCopias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnActualizarListado
            // 
            this._btnActualizarListado.Location = new System.Drawing.Point(617, 156);
            this._btnActualizarListado.Name = "_btnActualizarListado";
            this._btnActualizarListado.Size = new System.Drawing.Size(129, 45);
            this._btnActualizarListado.TabIndex = 13;
            this._btnActualizarListado.Text = "Actualizar listado";
            this._btnActualizarListado.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarCopias
            // 
            this._btnConsultarCopias.Location = new System.Drawing.Point(54, 136);
            this._btnConsultarCopias.Name = "_btnConsultarCopias";
            this._btnConsultarCopias.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarCopias.TabIndex = 12;
            this._btnConsultarCopias.Text = "Consultar Copias";
            this._btnConsultarCopias.UseVisualStyleBackColor = true;
            // 
            // _lblCopiasParaMostrar
            // 
            this._lblCopiasParaMostrar.Location = new System.Drawing.Point(279, 204);
            this._lblCopiasParaMostrar.Name = "_lblCopiasParaMostrar";
            this._lblCopiasParaMostrar.Size = new System.Drawing.Size(339, 195);
            this._lblCopiasParaMostrar.TabIndex = 11;
            // 
            // _cmbCopias
            // 
            this._cmbCopias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCopias.FormattingEnabled = true;
            this._cmbCopias.Location = new System.Drawing.Point(217, 156);
            this._cmbCopias.Name = "_cmbCopias";
            this._cmbCopias.Size = new System.Drawing.Size(339, 24);
            this._cmbCopias.TabIndex = 10;
            // 
            // _btnMenuPrincipal
            // 
            this._btnMenuPrincipal.Location = new System.Drawing.Point(54, 296);
            this._btnMenuPrincipal.Name = "_btnMenuPrincipal";
            this._btnMenuPrincipal.Size = new System.Drawing.Size(157, 63);
            this._btnMenuPrincipal.TabIndex = 9;
            this._btnMenuPrincipal.Text = "Menu Principal";
            this._btnMenuPrincipal.UseVisualStyleBackColor = true;
            this._btnMenuPrincipal.Click += new System.EventHandler(this._btnMenuPrincipal_Click);
            // 
            // _btnIngresarCopias
            // 
            this._btnIngresarCopias.Location = new System.Drawing.Point(54, 51);
            this._btnIngresarCopias.Name = "_btnIngresarCopias";
            this._btnIngresarCopias.Size = new System.Drawing.Size(157, 63);
            this._btnIngresarCopias.TabIndex = 8;
            this._btnIngresarCopias.Text = "Ingresar Copias";
            this._btnIngresarCopias.UseVisualStyleBackColor = true;
            // 
            // FrmCopias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnActualizarListado);
            this.Controls.Add(this._btnConsultarCopias);
            this.Controls.Add(this._lblCopiasParaMostrar);
            this.Controls.Add(this._cmbCopias);
            this.Controls.Add(this._btnMenuPrincipal);
            this.Controls.Add(this._btnIngresarCopias);
            this.Name = "FrmCopias";
            this.Text = "FrmCopias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnActualizarListado;
        private System.Windows.Forms.Button _btnConsultarCopias;
        private System.Windows.Forms.Label _lblCopiasParaMostrar;
        private System.Windows.Forms.ComboBox _cmbCopias;
        private System.Windows.Forms.Button _btnMenuPrincipal;
        private System.Windows.Forms.Button _btnIngresarCopias;
    }
}