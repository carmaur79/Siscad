﻿namespace Siscad
{
    partial class frmInfoEmpresa
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
            this.labelNombreFormulario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombreFormulario
            // 
            this.labelNombreFormulario.AutoSize = true;
            this.labelNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFormulario.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNombreFormulario.Location = new System.Drawing.Point(12, 11);
            this.labelNombreFormulario.Name = "labelNombreFormulario";
            this.labelNombreFormulario.Size = new System.Drawing.Size(448, 25);
            this.labelNombreFormulario.TabIndex = 46;
            this.labelNombreFormulario.Text = "INFORMACIÓN GENERAL DE LA EMPRESA";
            // 
            // frmInfoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.labelNombreFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoEmpresa";
            this.Text = "frmInfoEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreFormulario;
    }
}