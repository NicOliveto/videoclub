﻿namespace VideoClub.IntefazForm
{
    partial class FrmReportes
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnIngresarClientes
            // 
            this._btnIngresarClientes.Location = new System.Drawing.Point(22, 33);
            this._btnIngresarClientes.Name = "_btnIngresarClientes";
            this._btnIngresarClientes.Size = new System.Drawing.Size(157, 63);
            this._btnIngresarClientes.TabIndex = 1;
            this._btnIngresarClientes.Text = "Ingresar Clientes";
            this._btnIngresarClientes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ingresar Clientes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._btnIngresarClientes);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}