namespace Siscad
{
    partial class frmSaludoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.saludoLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioLabel = new System.Windows.Forms.Label();
            this.textoIngresoLabel = new System.Windows.Forms.Label();
            this.fechaIngresoLabel = new System.Windows.Forms.Label();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.nombreEmpresaLabel = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.timerIniciaSaludo = new System.Windows.Forms.Timer(this.components);
            this.timerFinSaludo = new System.Windows.Forms.Timer(this.components);
            this.panelInferior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludoLabel
            // 
            this.saludoLabel.AutoSize = true;
            this.saludoLabel.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.saludoLabel.Location = new System.Drawing.Point(160, 231);
            this.saludoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saludoLabel.Name = "saludoLabel";
            this.saludoLabel.Size = new System.Drawing.Size(270, 45);
            this.saludoLabel.TabIndex = 1;
            this.saludoLabel.Text = "SISCAD-PYME";
            // 
            // nombreUsuarioLabel
            // 
            this.nombreUsuarioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreUsuarioLabel.AutoSize = true;
            this.nombreUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nombreUsuarioLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreUsuarioLabel.Location = new System.Drawing.Point(255, 123);
            this.nombreUsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            this.nombreUsuarioLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nombreUsuarioLabel.Size = new System.Drawing.Size(25, 24);
            this.nombreUsuarioLabel.TabIndex = 0;
            this.nombreUsuarioLabel.Text = "...";
            this.nombreUsuarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoIngresoLabel
            // 
            this.textoIngresoLabel.AutoSize = true;
            this.textoIngresoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoIngresoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.textoIngresoLabel.Location = new System.Drawing.Point(256, 157);
            this.textoIngresoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoIngresoLabel.Name = "textoIngresoLabel";
            this.textoIngresoLabel.Size = new System.Drawing.Size(156, 17);
            this.textoIngresoLabel.TabIndex = 3;
            this.textoIngresoLabel.Text = "Su último ingreso fue el";
            // 
            // fechaIngresoLabel
            // 
            this.fechaIngresoLabel.AutoSize = true;
            this.fechaIngresoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIngresoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.fechaIngresoLabel.Location = new System.Drawing.Point(256, 182);
            this.fechaIngresoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaIngresoLabel.Name = "fechaIngresoLabel";
            this.fechaIngresoLabel.Size = new System.Drawing.Size(20, 17);
            this.fechaIngresoLabel.TabIndex = 4;
            this.fechaIngresoLabel.Text = "...";
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBienvenido.Location = new System.Drawing.Point(255, 99);
            this.labelBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(125, 24);
            this.labelBienvenido.TabIndex = 6;
            this.labelBienvenido.Text = "BIENVENIDO";
            // 
            // nombreEmpresaLabel
            // 
            this.nombreEmpresaLabel.AutoSize = true;
            this.nombreEmpresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpresaLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.nombreEmpresaLabel.Location = new System.Drawing.Point(11, 9);
            this.nombreEmpresaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreEmpresaLabel.Name = "nombreEmpresaLabel";
            this.nombreEmpresaLabel.Size = new System.Drawing.Size(30, 25);
            this.nombreEmpresaLabel.TabIndex = 2;
            this.nombreEmpresaLabel.Text = "...";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(178)))), ((int)(((byte)(105)))));
            this.panelTitulo.Controls.Add(this.nombreEmpresaLabel);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(600, 40);
            this.panelTitulo.TabIndex = 3;
            // 
            // timerIniciaSaludo
            // 
            this.timerIniciaSaludo.Interval = 30;
            this.timerIniciaSaludo.Tick += new System.EventHandler(this.timerIniciaSaludo_Tick);
            // 
            // timerFinSaludo
            // 
            this.timerFinSaludo.Interval = 30;
            this.timerFinSaludo.Tick += new System.EventHandler(this.timerFinSaludo_Tick);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(178)))), ((int)(((byte)(105)))));
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.ForeColor = System.Drawing.SystemColors.Control;
            this.panelInferior.Location = new System.Drawing.Point(0, 310);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(600, 40);
            this.panelInferior.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Siscad.Properties.Resources.LogoSiscad;
            this.pictureBox1.Location = new System.Drawing.Point(71, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmSaludoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saludoLabel);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.fechaIngresoLabel);
            this.Controls.Add(this.textoIngresoLabel);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.nombreUsuarioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaludoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaludoUsuario";
            this.Load += new System.EventHandler(this.frmSaludoUsuario_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludoLabel;
        private System.Windows.Forms.Label nombreUsuarioLabel;
        private System.Windows.Forms.Label textoIngresoLabel;
        private System.Windows.Forms.Label fechaIngresoLabel;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Label nombreEmpresaLabel;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerIniciaSaludo;
        private System.Windows.Forms.Timer timerFinSaludo;
        private System.Windows.Forms.Panel panelInferior;
    }
}