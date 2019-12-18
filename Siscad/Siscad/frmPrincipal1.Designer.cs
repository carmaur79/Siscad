namespace Siscad
{
    partial class frmPrincipal1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal1));
            this.panelMenuLateral = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenuLateral.BackgroundImage")));
            this.panelMenuLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenuLateral.GradientBottomLeft = System.Drawing.Color.White;
            this.panelMenuLateral.GradientBottomRight = System.Drawing.Color.White;
            this.panelMenuLateral.GradientTopLeft = System.Drawing.Color.White;
            this.panelMenuLateral.GradientTopRight = System.Drawing.Color.White;
            this.panelMenuLateral.Location = new System.Drawing.Point(145, 167);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Quality = 10;
            this.panelMenuLateral.Size = new System.Drawing.Size(200, 100);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // frmPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal1";
            this.Text = "frmPrincipal1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelMenuLateral;
    }
}