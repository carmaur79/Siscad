namespace Siscad
{
    partial class frmCambioClave
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
            this.buttonFormCancelar = new System.Windows.Forms.Button();
            this.buttonFormCerrar = new System.Windows.Forms.Button();
            this.labelNombreFormulario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFormCancelar
            // 
            this.buttonFormCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormCancelar.Image = global::Siscad.Properties.Resources.cancelar;
            this.buttonFormCancelar.Location = new System.Drawing.Point(662, 9);
            this.buttonFormCancelar.Name = "buttonFormCancelar";
            this.buttonFormCancelar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormCancelar.TabIndex = 1;
            this.buttonFormCancelar.Text = "Cancelar";
            this.buttonFormCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonFormCerrar
            // 
            this.buttonFormCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormCerrar.Image = global::Siscad.Properties.Resources.salir;
            this.buttonFormCerrar.Location = new System.Drawing.Point(728, 9);
            this.buttonFormCerrar.Name = "buttonFormCerrar";
            this.buttonFormCerrar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormCerrar.TabIndex = 0;
            this.buttonFormCerrar.Text = "Cerrar";
            this.buttonFormCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormCerrar.UseVisualStyleBackColor = true;
            // 
            // labelNombreFormulario
            // 
            this.labelNombreFormulario.AutoSize = true;
            this.labelNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFormulario.Location = new System.Drawing.Point(12, 9);
            this.labelNombreFormulario.Name = "labelNombreFormulario";
            this.labelNombreFormulario.Size = new System.Drawing.Size(211, 25);
            this.labelNombreFormulario.TabIndex = 16;
            this.labelNombreFormulario.Text = "CAMBIO DE CLAVE";
            // 
            // frmCambioClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNombreFormulario);
            this.Controls.Add(this.buttonFormCancelar);
            this.Controls.Add(this.buttonFormCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambioClave";
            this.Text = "frmCambioClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFormCerrar;
        private System.Windows.Forms.Button buttonFormCancelar;
        private System.Windows.Forms.Label labelNombreFormulario;
    }
}