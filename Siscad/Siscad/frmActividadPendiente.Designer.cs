namespace Siscad
{
    partial class frmActividadPendiente
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
            // buttonUltimoRegistro
            // 
            this.buttonUltimoRegistro.Location = new System.Drawing.Point(210, 23);
            // 
            // buttonSiguienteRegistro
            // 
            this.buttonSiguienteRegistro.Location = new System.Drawing.Point(144, 23);
            // 
            // buttonAnteriorRegistro
            // 
            this.buttonAnteriorRegistro.Location = new System.Drawing.Point(78, 23);
            // 
            // buttonPrimerRegistro
            // 
            this.buttonPrimerRegistro.Location = new System.Drawing.Point(12, 23);
            // 
            // buttonFormBorrar
            // 
            this.buttonFormBorrar.Location = new System.Drawing.Point(468, 23);
            // 
            // buttonFormEditar
            // 
            this.buttonFormEditar.Location = new System.Drawing.Point(402, 23);
            // 
            // buttonFormNuevo
            // 
            this.buttonFormNuevo.Location = new System.Drawing.Point(336, 23);
            // 
            // buttonFormBuscar
            // 
            this.buttonFormBuscar.Location = new System.Drawing.Point(534, 23);
            // 
            // buttonFormGuardar
            // 
            this.buttonFormGuardar.Location = new System.Drawing.Point(600, 23);
            // 
            // buttonFormCancelar
            // 
            this.buttonFormCancelar.Location = new System.Drawing.Point(666, 23);
            // 
            // buttonFormCerrar
            // 
            this.buttonFormCerrar.Location = new System.Drawing.Point(732, 23);
            // 
            // labelNombreFormulario
            // 
            this.labelNombreFormulario.AutoSize = true;
            this.labelNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFormulario.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNombreFormulario.Location = new System.Drawing.Point(12, 9);
            this.labelNombreFormulario.Name = "labelNombreFormulario";
            this.labelNombreFormulario.Size = new System.Drawing.Size(300, 25);
            this.labelNombreFormulario.TabIndex = 38;
            this.labelNombreFormulario.Text = "ACTIVIDADES PENDIENTES";
            // 
            // frmActividadPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(732, 461);
            this.Controls.Add(this.labelNombreFormulario);
            this.Name = "frmActividadPendiente";
            this.Text = "frmActividadPendiente";
            this.Controls.SetChildIndex(this.labelNombreFormulario, 0);
            this.Controls.SetChildIndex(this.buttonFormCerrar, 0);
            this.Controls.SetChildIndex(this.buttonFormCancelar, 0);
            this.Controls.SetChildIndex(this.buttonFormGuardar, 0);
            this.Controls.SetChildIndex(this.buttonFormBuscar, 0);
            this.Controls.SetChildIndex(this.buttonFormNuevo, 0);
            this.Controls.SetChildIndex(this.buttonFormEditar, 0);
            this.Controls.SetChildIndex(this.buttonFormBorrar, 0);
            this.Controls.SetChildIndex(this.buttonPrimerRegistro, 0);
            this.Controls.SetChildIndex(this.buttonAnteriorRegistro, 0);
            this.Controls.SetChildIndex(this.buttonSiguienteRegistro, 0);
            this.Controls.SetChildIndex(this.buttonUltimoRegistro, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombreFormulario;
    }
}