namespace VideoClub.IntefazForm
{
    partial class FrmPrincipal
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
            this._lblVideoClub = new System.Windows.Forms.Label();
            this._btnClientes = new System.Windows.Forms.Button();
            this._btnPrestamos = new System.Windows.Forms.Button();
            this._btnpeliculas = new System.Windows.Forms.Button();
            this._btnCopias = new System.Windows.Forms.Button();
            this._btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblVideoClub
            // 
            this._lblVideoClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblVideoClub.Location = new System.Drawing.Point(31, 9);
            this._lblVideoClub.Name = "_lblVideoClub";
            this._lblVideoClub.Size = new System.Drawing.Size(253, 64);
            this._lblVideoClub.TabIndex = 0;
            this._lblVideoClub.Text = "Video Club";
            // 
            // _btnClientes
            // 
            this._btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClientes.Location = new System.Drawing.Point(66, 96);
            this._btnClientes.Name = "_btnClientes";
            this._btnClientes.Size = new System.Drawing.Size(159, 62);
            this._btnClientes.TabIndex = 1;
            this._btnClientes.Text = "Clientes";
            this._btnClientes.UseVisualStyleBackColor = true;
            // 
            // _btnPrestamos
            // 
            this._btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnPrestamos.Location = new System.Drawing.Point(66, 164);
            this._btnPrestamos.Name = "_btnPrestamos";
            this._btnPrestamos.Size = new System.Drawing.Size(159, 62);
            this._btnPrestamos.TabIndex = 2;
            this._btnPrestamos.Text = "Préstamos";
            this._btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // _btnpeliculas
            // 
            this._btnpeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnpeliculas.Location = new System.Drawing.Point(66, 232);
            this._btnpeliculas.Name = "_btnpeliculas";
            this._btnpeliculas.Size = new System.Drawing.Size(159, 62);
            this._btnpeliculas.TabIndex = 3;
            this._btnpeliculas.Text = "Películas";
            this._btnpeliculas.UseVisualStyleBackColor = true;
            // 
            // _btnCopias
            // 
            this._btnCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCopias.Location = new System.Drawing.Point(66, 300);
            this._btnCopias.Name = "_btnCopias";
            this._btnCopias.Size = new System.Drawing.Size(159, 62);
            this._btnCopias.TabIndex = 4;
            this._btnCopias.Text = "Copias";
            this._btnCopias.UseVisualStyleBackColor = true;
            // 
            // _btnReportes
            // 
            this._btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReportes.Location = new System.Drawing.Point(66, 368);
            this._btnReportes.Name = "_btnReportes";
            this._btnReportes.Size = new System.Drawing.Size(159, 62);
            this._btnReportes.TabIndex = 5;
            this._btnReportes.Text = "Reportes";
            this._btnReportes.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 484);
            this.Controls.Add(this._btnReportes);
            this.Controls.Add(this._btnCopias);
            this.Controls.Add(this._btnpeliculas);
            this.Controls.Add(this._btnPrestamos);
            this.Controls.Add(this._btnClientes);
            this.Controls.Add(this._lblVideoClub);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblVideoClub;
        private System.Windows.Forms.Button _btnClientes;
        private System.Windows.Forms.Button _btnPrestamos;
        private System.Windows.Forms.Button _btnpeliculas;
        private System.Windows.Forms.Button _btnCopias;
        private System.Windows.Forms.Button _btnReportes;
    }
}