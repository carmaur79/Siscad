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
            this.saludoLabel = new System.Windows.Forms.Label();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.nombreUsuarioLabel = new System.Windows.Forms.Label();
            this.textoIngresoLabel = new System.Windows.Forms.Label();
            this.fechaIngresoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreEmpresaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saludoLabel
            // 
            this.saludoLabel.AutoSize = true;
            this.saludoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludoLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.saludoLabel.Location = new System.Drawing.Point(15, 252);
            this.saludoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saludoLabel.Name = "saludoLabel";
            this.saludoLabel.Size = new System.Drawing.Size(449, 18);
            this.saludoLabel.TabIndex = 1;
            this.saludoLabel.Text = "Sistema Integral de Seguridad social, Comercial y Administrativo de";
            // 
            // aceptarButton
            // 
            this.aceptarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarButton.ForeColor = System.Drawing.Color.White;
            this.aceptarButton.Location = new System.Drawing.Point(624, 368);
            this.aceptarButton.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(77, 30);
            this.aceptarButton.TabIndex = 5;
            this.aceptarButton.Text = "&Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // nombreUsuarioLabel
            // 
            this.nombreUsuarioLabel.AutoSize = true;
            this.nombreUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.nombreUsuarioLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.nombreUsuarioLabel.Location = new System.Drawing.Point(15, 196);
            this.nombreUsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            this.nombreUsuarioLabel.Size = new System.Drawing.Size(23, 18);
            this.nombreUsuarioLabel.TabIndex = 0;
            this.nombreUsuarioLabel.Text = "...";
            // 
            // textoIngresoLabel
            // 
            this.textoIngresoLabel.AutoSize = true;
            this.textoIngresoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoIngresoLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.textoIngresoLabel.Location = new System.Drawing.Point(15, 302);
            this.textoIngresoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoIngresoLabel.Name = "textoIngresoLabel";
            this.textoIngresoLabel.Size = new System.Drawing.Size(256, 18);
            this.textoIngresoLabel.TabIndex = 3;
            this.textoIngresoLabel.Text = "Su último ingreso al sistema fue el día";
            // 
            // fechaIngresoLabel
            // 
            this.fechaIngresoLabel.AutoSize = true;
            this.fechaIngresoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIngresoLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.fechaIngresoLabel.Location = new System.Drawing.Point(15, 327);
            this.fechaIngresoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaIngresoLabel.Name = "fechaIngresoLabel";
            this.fechaIngresoLabel.Size = new System.Drawing.Size(20, 18);
            this.fechaIngresoLabel.TabIndex = 4;
            this.fechaIngresoLabel.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombreEmpresaLabel);
            this.groupBox1.Controls.Add(this.saludoLabel);
            this.groupBox1.Controls.Add(this.aceptarButton);
            this.groupBox1.Controls.Add(this.nombreUsuarioLabel);
            this.groupBox1.Controls.Add(this.textoIngresoLabel);
            this.groupBox1.Controls.Add(this.fechaIngresoLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(39, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(722, 423);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Algerian", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(119, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 75);
            this.label5.TabIndex = 18;
            this.label5.Text = "SISCAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(15, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido(a)";
            // 
            // nombreEmpresaLabel
            // 
            this.nombreEmpresaLabel.AutoSize = true;
            this.nombreEmpresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpresaLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.nombreEmpresaLabel.Location = new System.Drawing.Point(15, 277);
            this.nombreEmpresaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreEmpresaLabel.Name = "nombreEmpresaLabel";
            this.nombreEmpresaLabel.Size = new System.Drawing.Size(23, 18);
            this.nombreEmpresaLabel.TabIndex = 2;
            this.nombreEmpresaLabel.Text = "...";
            // 
            // frmSaludoUsuario
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Siscad.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaludoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaludoUsuario";
            this.Load += new System.EventHandler(this.frmSaludoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label saludoLabel;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label nombreUsuarioLabel;
        private System.Windows.Forms.Label textoIngresoLabel;
        private System.Windows.Forms.Label fechaIngresoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreEmpresaLabel;
    }
}