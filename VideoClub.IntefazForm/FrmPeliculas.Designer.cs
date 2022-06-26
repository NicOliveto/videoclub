namespace VideoClub.IntefazForm
{
    partial class FrmPeliculas
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
            this._btnIngresarPeliculas = new System.Windows.Forms.Button();
            this._btnConsultarPeliculas = new System.Windows.Forms.Button();
            this._btnMenuPrincipal2 = new System.Windows.Forms.Button();
            this._btnActualizarListado = new System.Windows.Forms.Button();
            this._cmbPeliculas = new System.Windows.Forms.ComboBox();
            this._lblPeliculaParaMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnIngresarPeliculas
            // 
            this._btnIngresarPeliculas.Location = new System.Drawing.Point(27, 21);
            this._btnIngresarPeliculas.Name = "_btnIngresarPeliculas";
            this._btnIngresarPeliculas.Size = new System.Drawing.Size(157, 63);
            this._btnIngresarPeliculas.TabIndex = 1;
            this._btnIngresarPeliculas.Text = "Ingresar Peliculas";
            this._btnIngresarPeliculas.UseVisualStyleBackColor = true;
            this._btnIngresarPeliculas.Click += new System.EventHandler(this._btnIngresarPeliculas_Click);
            // 
            // _btnConsultarPeliculas
            // 
            this._btnConsultarPeliculas.Location = new System.Drawing.Point(27, 168);
            this._btnConsultarPeliculas.Name = "_btnConsultarPeliculas";
            this._btnConsultarPeliculas.Size = new System.Drawing.Size(157, 63);
            this._btnConsultarPeliculas.TabIndex = 3;
            this._btnConsultarPeliculas.Text = "Consultar Peliculas";
            this._btnConsultarPeliculas.UseVisualStyleBackColor = true;
            this._btnConsultarPeliculas.Click += new System.EventHandler(this._btnConsultarPeliculas_Click);
            // 
            // _btnMenuPrincipal2
            // 
            this._btnMenuPrincipal2.Location = new System.Drawing.Point(27, 375);
            this._btnMenuPrincipal2.Name = "_btnMenuPrincipal2";
            this._btnMenuPrincipal2.Size = new System.Drawing.Size(157, 63);
            this._btnMenuPrincipal2.TabIndex = 4;
            this._btnMenuPrincipal2.Text = "Menu Principal";
            this._btnMenuPrincipal2.UseVisualStyleBackColor = true;
            this._btnMenuPrincipal2.Click += new System.EventHandler(this._btnMenuPrincipal2_Click);
            // 
            // _btnActualizarListado
            // 
            this._btnActualizarListado.Location = new System.Drawing.Point(594, 177);
            this._btnActualizarListado.Name = "_btnActualizarListado";
            this._btnActualizarListado.Size = new System.Drawing.Size(129, 45);
            this._btnActualizarListado.TabIndex = 10;
            this._btnActualizarListado.Text = "Actualizar listado";
            this._btnActualizarListado.UseVisualStyleBackColor = true;
            this._btnActualizarListado.Click += new System.EventHandler(this._btnActualizarListado_Click);
            // 
            // _cmbPeliculas
            // 
            this._cmbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPeliculas.FormattingEnabled = true;
            this._cmbPeliculas.Location = new System.Drawing.Point(208, 188);
            this._cmbPeliculas.Name = "_cmbPeliculas";
            this._cmbPeliculas.Size = new System.Drawing.Size(339, 24);
            this._cmbPeliculas.TabIndex = 9;
            // 
            // _lblPeliculaParaMostrar
            // 
            this._lblPeliculaParaMostrar.Location = new System.Drawing.Point(205, 251);
            this._lblPeliculaParaMostrar.Name = "_lblPeliculaParaMostrar";
            this._lblPeliculaParaMostrar.Size = new System.Drawing.Size(342, 187);
            this._lblPeliculaParaMostrar.TabIndex = 11;
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblPeliculaParaMostrar);
            this.Controls.Add(this._btnActualizarListado);
            this.Controls.Add(this._cmbPeliculas);
            this.Controls.Add(this._btnMenuPrincipal2);
            this.Controls.Add(this._btnConsultarPeliculas);
            this.Controls.Add(this._btnIngresarPeliculas);
            this.Name = "FrmPeliculas";
            this.Text = "FrmPeliculas";
            this.Load += new System.EventHandler(this.FrmPeliculas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarPeliculas;
        private System.Windows.Forms.Button _btnConsultarPeliculas;
        private System.Windows.Forms.Button _btnMenuPrincipal2;
        private System.Windows.Forms.Button _btnActualizarListado;
        private System.Windows.Forms.ComboBox _cmbPeliculas;
        private System.Windows.Forms.Label _lblPeliculaParaMostrar;
    }
}