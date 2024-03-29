﻿namespace VideoClub.IntefazForm
{
    partial class FrmIngresarPelicula
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
            this._btnAltaPelicula = new System.Windows.Forms.Button();
            this._lblGenero = new System.Windows.Forms.Label();
            this._lblProductora = new System.Windows.Forms.Label();
            this._lblDuracion = new System.Windows.Forms.Label();
            this._lblAnio = new System.Windows.Forms.Label();
            this._lblDirector = new System.Windows.Forms.Label();
            this._lblTitulo = new System.Windows.Forms.Label();
            this._txtGenero = new System.Windows.Forms.TextBox();
            this._txtProductora = new System.Windows.Forms.TextBox();
            this._txtDuracion = new System.Windows.Forms.TextBox();
            this._txtAnio = new System.Windows.Forms.TextBox();
            this._txtDirector = new System.Windows.Forms.TextBox();
            this._txtTitulo = new System.Windows.Forms.TextBox();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnAltaPelicula
            // 
            this._btnAltaPelicula.Location = new System.Drawing.Point(291, 373);
            this._btnAltaPelicula.Name = "_btnAltaPelicula";
            this._btnAltaPelicula.Size = new System.Drawing.Size(166, 65);
            this._btnAltaPelicula.TabIndex = 39;
            this._btnAltaPelicula.Text = "Alta Pelicula";
            this._btnAltaPelicula.UseVisualStyleBackColor = true;
            this._btnAltaPelicula.Click += new System.EventHandler(this._btnAltaPelicula_Click);
            // 
            // _lblGenero
            // 
            this._lblGenero.Location = new System.Drawing.Point(60, 186);
            this._lblGenero.Name = "_lblGenero";
            this._lblGenero.Size = new System.Drawing.Size(171, 22);
            this._lblGenero.TabIndex = 37;
            this._lblGenero.Text = "Género:";
            // 
            // _lblProductora
            // 
            this._lblProductora.Location = new System.Drawing.Point(60, 158);
            this._lblProductora.Name = "_lblProductora";
            this._lblProductora.Size = new System.Drawing.Size(171, 22);
            this._lblProductora.TabIndex = 36;
            this._lblProductora.Text = "Productora";
            // 
            // _lblDuracion
            // 
            this._lblDuracion.Location = new System.Drawing.Point(60, 130);
            this._lblDuracion.Name = "_lblDuracion";
            this._lblDuracion.Size = new System.Drawing.Size(171, 22);
            this._lblDuracion.TabIndex = 35;
            this._lblDuracion.Text = "Duracion (en minutos):";
            // 
            // _lblAnio
            // 
            this._lblAnio.Location = new System.Drawing.Point(60, 102);
            this._lblAnio.Name = "_lblAnio";
            this._lblAnio.Size = new System.Drawing.Size(171, 22);
            this._lblAnio.TabIndex = 34;
            this._lblAnio.Text = "Año:";
            // 
            // _lblDirector
            // 
            this._lblDirector.Location = new System.Drawing.Point(60, 74);
            this._lblDirector.Name = "_lblDirector";
            this._lblDirector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblDirector.Size = new System.Drawing.Size(171, 22);
            this._lblDirector.TabIndex = 33;
            this._lblDirector.Text = "Director:";
            // 
            // _lblTitulo
            // 
            this._lblTitulo.Location = new System.Drawing.Point(60, 43);
            this._lblTitulo.Name = "_lblTitulo";
            this._lblTitulo.Size = new System.Drawing.Size(171, 22);
            this._lblTitulo.TabIndex = 32;
            this._lblTitulo.Text = "Título:";
            // 
            // _txtGenero
            // 
            this._txtGenero.Location = new System.Drawing.Point(291, 186);
            this._txtGenero.Name = "_txtGenero";
            this._txtGenero.Size = new System.Drawing.Size(273, 22);
            this._txtGenero.TabIndex = 30;
            this._txtGenero.TextChanged += new System.EventHandler(this._txtGenero_TextChanged);
            // 
            // _txtProductora
            // 
            this._txtProductora.Location = new System.Drawing.Point(291, 155);
            this._txtProductora.Name = "_txtProductora";
            this._txtProductora.Size = new System.Drawing.Size(273, 22);
            this._txtProductora.TabIndex = 29;
            this._txtProductora.TextChanged += new System.EventHandler(this._txtProductora_TextChanged);
            // 
            // _txtDuracion
            // 
            this._txtDuracion.Location = new System.Drawing.Point(291, 127);
            this._txtDuracion.Name = "_txtDuracion";
            this._txtDuracion.Size = new System.Drawing.Size(273, 22);
            this._txtDuracion.TabIndex = 28;
            this._txtDuracion.TextChanged += new System.EventHandler(this._txtDuracion_TextChanged);
            // 
            // _txtAnio
            // 
            this._txtAnio.Location = new System.Drawing.Point(291, 99);
            this._txtAnio.Name = "_txtAnio";
            this._txtAnio.Size = new System.Drawing.Size(273, 22);
            this._txtAnio.TabIndex = 27;
            this._txtAnio.TextChanged += new System.EventHandler(this._txtAnio_TextChanged);
            // 
            // _txtDirector
            // 
            this._txtDirector.Location = new System.Drawing.Point(291, 71);
            this._txtDirector.Name = "_txtDirector";
            this._txtDirector.Size = new System.Drawing.Size(273, 22);
            this._txtDirector.TabIndex = 26;
            this._txtDirector.TextChanged += new System.EventHandler(this._txtDirector_TextChanged);
            // 
            // _txtTitulo
            // 
            this._txtTitulo.Location = new System.Drawing.Point(291, 43);
            this._txtTitulo.Name = "_txtTitulo";
            this._txtTitulo.Size = new System.Drawing.Size(273, 22);
            this._txtTitulo.TabIndex = 25;
            this._txtTitulo.TextChanged += new System.EventHandler(this._txtTitulo_TextChanged);
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(12, 373);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(166, 65);
            this._btnVolver.TabIndex = 24;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // FrmIngresarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnAltaPelicula);
            this.Controls.Add(this._lblGenero);
            this.Controls.Add(this._lblProductora);
            this.Controls.Add(this._lblDuracion);
            this.Controls.Add(this._lblAnio);
            this.Controls.Add(this._lblDirector);
            this.Controls.Add(this._lblTitulo);
            this.Controls.Add(this._txtGenero);
            this.Controls.Add(this._txtProductora);
            this.Controls.Add(this._txtDuracion);
            this.Controls.Add(this._txtAnio);
            this.Controls.Add(this._txtDirector);
            this.Controls.Add(this._txtTitulo);
            this.Controls.Add(this._btnVolver);
            this.Name = "FrmIngresarPelicula";
            this.Text = "FrmIngresarPelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btnAltaPelicula;
        private System.Windows.Forms.Label _lblGenero;
        private System.Windows.Forms.Label _lblProductora;
        private System.Windows.Forms.Label _lblDuracion;
        private System.Windows.Forms.Label _lblAnio;
        private System.Windows.Forms.Label _lblDirector;
        private System.Windows.Forms.Label _lblTitulo;
        private System.Windows.Forms.TextBox _txtGenero;
        private System.Windows.Forms.TextBox _txtProductora;
        private System.Windows.Forms.TextBox _txtDuracion;
        private System.Windows.Forms.TextBox _txtAnio;
        private System.Windows.Forms.TextBox _txtDirector;
        private System.Windows.Forms.TextBox _txtTitulo;
        private System.Windows.Forms.Button _btnVolver;
    }
}