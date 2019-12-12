using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siscad
{
    public partial class frmTercero : Form
    {
        public frmTercero()
        {
            InitializeComponent();
        }

        private void terceroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terceroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSiscad);

        }

        private void terceroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.terceroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSiscad);

        }

        private void frmMantenimientoTercero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tercero' Puede moverla o quitarla según sea necesario.
            this.terceroTableAdapter.Fill(this.dSSiscad.tercero);

        }

        private void buttonCargarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Imágenes soportadas|*.jpeg; *.jpg; *.jpe; *.png; *.bmp; *.ico; *.gif; *.tif; *.tiff; *.jfif; *.dib; *.psd; *.raw";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) pictureBoxImagen.Load(openFileDialog1.FileName);

        }
    }
}
