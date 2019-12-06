namespace Siscad
{
    partial class frmCompra
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
            this.buttonFormBorrar = new System.Windows.Forms.Button();
            this.buttonFormEditar = new System.Windows.Forms.Button();
            this.buttonFormNuevo = new System.Windows.Forms.Button();
            this.buttonFormBuscar = new System.Windows.Forms.Button();
            this.buttonFormGuardar = new System.Windows.Forms.Button();
            this.buttonFormCancelar = new System.Windows.Forms.Button();
            this.buttonFormCerrar = new System.Windows.Forms.Button();
            this.buttonUltimoRegistro = new System.Windows.Forms.Button();
            this.buttonSiguienteRegistro = new System.Windows.Forms.Button();
            this.buttonAnteriorRegistro = new System.Windows.Forms.Button();
            this.buttonPrimerRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombreFormulario
            // 
            this.labelNombreFormulario.AutoSize = true;
            this.labelNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFormulario.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombreFormulario.Location = new System.Drawing.Point(12, 9);
            this.labelNombreFormulario.Name = "labelNombreFormulario";
            this.labelNombreFormulario.Size = new System.Drawing.Size(121, 25);
            this.labelNombreFormulario.TabIndex = 22;
            this.labelNombreFormulario.Text = "COMPRAS";
            // 
            // buttonFormBorrar
            // 
            this.buttonFormBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormBorrar.Image = global::Siscad.Properties.Resources.borrar;
            this.buttonFormBorrar.Location = new System.Drawing.Point(464, 9);
            this.buttonFormBorrar.Name = "buttonFormBorrar";
            this.buttonFormBorrar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormBorrar.TabIndex = 21;
            this.buttonFormBorrar.Text = "Borrar";
            this.buttonFormBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormBorrar.UseVisualStyleBackColor = true;
            this.buttonFormBorrar.Click += new System.EventHandler(this.buttonFormBorrar_Click);
            // 
            // buttonFormEditar
            // 
            this.buttonFormEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormEditar.Image = global::Siscad.Properties.Resources.editar;
            this.buttonFormEditar.Location = new System.Drawing.Point(398, 9);
            this.buttonFormEditar.Name = "buttonFormEditar";
            this.buttonFormEditar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormEditar.TabIndex = 20;
            this.buttonFormEditar.Text = "Editar";
            this.buttonFormEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormEditar.UseVisualStyleBackColor = true;
            this.buttonFormEditar.Click += new System.EventHandler(this.buttonFormEditar_Click);
            // 
            // buttonFormNuevo
            // 
            this.buttonFormNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormNuevo.Image = global::Siscad.Properties.Resources.nuevo;
            this.buttonFormNuevo.Location = new System.Drawing.Point(332, 9);
            this.buttonFormNuevo.Name = "buttonFormNuevo";
            this.buttonFormNuevo.Size = new System.Drawing.Size(60, 60);
            this.buttonFormNuevo.TabIndex = 19;
            this.buttonFormNuevo.Text = "Nuevo";
            this.buttonFormNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormNuevo.UseVisualStyleBackColor = true;
            this.buttonFormNuevo.Click += new System.EventHandler(this.buttonFormNuevo_Click);
            // 
            // buttonFormBuscar
            // 
            this.buttonFormBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormBuscar.Image = global::Siscad.Properties.Resources.buscar;
            this.buttonFormBuscar.Location = new System.Drawing.Point(530, 9);
            this.buttonFormBuscar.Name = "buttonFormBuscar";
            this.buttonFormBuscar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormBuscar.TabIndex = 18;
            this.buttonFormBuscar.Text = "Buscar";
            this.buttonFormBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormBuscar.UseVisualStyleBackColor = true;
            this.buttonFormBuscar.Click += new System.EventHandler(this.buttonFormBuscar_Click);
            // 
            // buttonFormGuardar
            // 
            this.buttonFormGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormGuardar.Image = global::Siscad.Properties.Resources.guardar;
            this.buttonFormGuardar.Location = new System.Drawing.Point(596, 9);
            this.buttonFormGuardar.Name = "buttonFormGuardar";
            this.buttonFormGuardar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormGuardar.TabIndex = 17;
            this.buttonFormGuardar.Text = "Guardar";
            this.buttonFormGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormGuardar.UseVisualStyleBackColor = true;
            this.buttonFormGuardar.Click += new System.EventHandler(this.buttonFormGuardar_Click);
            // 
            // buttonFormCancelar
            // 
            this.buttonFormCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormCancelar.Image = global::Siscad.Properties.Resources.cancelar;
            this.buttonFormCancelar.Location = new System.Drawing.Point(662, 9);
            this.buttonFormCancelar.Name = "buttonFormCancelar";
            this.buttonFormCancelar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormCancelar.TabIndex = 16;
            this.buttonFormCancelar.Text = "Cancelar";
            this.buttonFormCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormCancelar.UseVisualStyleBackColor = true;
            this.buttonFormCancelar.Click += new System.EventHandler(this.buttonFormCancelar_Click);
            // 
            // buttonFormCerrar
            // 
            this.buttonFormCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormCerrar.Image = global::Siscad.Properties.Resources.salir;
            this.buttonFormCerrar.Location = new System.Drawing.Point(728, 9);
            this.buttonFormCerrar.Name = "buttonFormCerrar";
            this.buttonFormCerrar.Size = new System.Drawing.Size(60, 60);
            this.buttonFormCerrar.TabIndex = 15;
            this.buttonFormCerrar.Text = "Cerrar";
            this.buttonFormCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFormCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFormCerrar.UseVisualStyleBackColor = true;
            this.buttonFormCerrar.Click += new System.EventHandler(this.buttonFormCerrar_Click);
            // 
            // buttonUltimoRegistro
            // 
            this.buttonUltimoRegistro.Image = global::Siscad.Properties.Resources.ultimoRegistro;
            this.buttonUltimoRegistro.Location = new System.Drawing.Point(140, 34);
            this.buttonUltimoRegistro.Name = "buttonUltimoRegistro";
            this.buttonUltimoRegistro.Size = new System.Drawing.Size(35, 35);
            this.buttonUltimoRegistro.TabIndex = 26;
            this.buttonUltimoRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUltimoRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUltimoRegistro.UseVisualStyleBackColor = true;
            this.buttonUltimoRegistro.Click += new System.EventHandler(this.buttonUltimoRegistro_Click);
            // 
            // buttonSiguienteRegistro
            // 
            this.buttonSiguienteRegistro.Image = global::Siscad.Properties.Resources.siguienteRegistro;
            this.buttonSiguienteRegistro.Location = new System.Drawing.Point(99, 34);
            this.buttonSiguienteRegistro.Name = "buttonSiguienteRegistro";
            this.buttonSiguienteRegistro.Size = new System.Drawing.Size(35, 35);
            this.buttonSiguienteRegistro.TabIndex = 25;
            this.buttonSiguienteRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSiguienteRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSiguienteRegistro.UseVisualStyleBackColor = true;
            this.buttonSiguienteRegistro.Click += new System.EventHandler(this.buttonSiguienteRegistro_Click);
            // 
            // buttonAnteriorRegistro
            // 
            this.buttonAnteriorRegistro.Image = global::Siscad.Properties.Resources.anteriorRegistro;
            this.buttonAnteriorRegistro.Location = new System.Drawing.Point(58, 34);
            this.buttonAnteriorRegistro.Name = "buttonAnteriorRegistro";
            this.buttonAnteriorRegistro.Size = new System.Drawing.Size(35, 35);
            this.buttonAnteriorRegistro.TabIndex = 24;
            this.buttonAnteriorRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAnteriorRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAnteriorRegistro.UseVisualStyleBackColor = true;
            this.buttonAnteriorRegistro.Click += new System.EventHandler(this.buttonAnteriorRegistro_Click);
            // 
            // buttonPrimerRegistro
            // 
            this.buttonPrimerRegistro.Image = global::Siscad.Properties.Resources.primerRegistro;
            this.buttonPrimerRegistro.Location = new System.Drawing.Point(17, 34);
            this.buttonPrimerRegistro.Name = "buttonPrimerRegistro";
            this.buttonPrimerRegistro.Size = new System.Drawing.Size(35, 35);
            this.buttonPrimerRegistro.TabIndex = 23;
            this.buttonPrimerRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrimerRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPrimerRegistro.UseVisualStyleBackColor = true;
            this.buttonPrimerRegistro.Click += new System.EventHandler(this.buttonPrimerRegistro_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUltimoRegistro);
            this.Controls.Add(this.buttonSiguienteRegistro);
            this.Controls.Add(this.buttonAnteriorRegistro);
            this.Controls.Add(this.buttonPrimerRegistro);
            this.Controls.Add(this.labelNombreFormulario);
            this.Controls.Add(this.buttonFormBorrar);
            this.Controls.Add(this.buttonFormEditar);
            this.Controls.Add(this.buttonFormNuevo);
            this.Controls.Add(this.buttonFormBuscar);
            this.Controls.Add(this.buttonFormGuardar);
            this.Controls.Add(this.buttonFormCancelar);
            this.Controls.Add(this.buttonFormCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreFormulario;
        private System.Windows.Forms.Button buttonFormBorrar;
        private System.Windows.Forms.Button buttonFormEditar;
        private System.Windows.Forms.Button buttonFormNuevo;
        private System.Windows.Forms.Button buttonFormBuscar;
        private System.Windows.Forms.Button buttonFormGuardar;
        private System.Windows.Forms.Button buttonFormCancelar;
        private System.Windows.Forms.Button buttonFormCerrar;
        private System.Windows.Forms.Button buttonUltimoRegistro;
        private System.Windows.Forms.Button buttonSiguienteRegistro;
        private System.Windows.Forms.Button buttonAnteriorRegistro;
        private System.Windows.Forms.Button buttonPrimerRegistro;
    }
}