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
    public partial class frmTercero : BaseCrud
    {
        public frmTercero()
        {
            InitializeComponent();
        }

        private void buttonFormEditar_Click(object sender, EventArgs e)
        {
            frmMantenimientoTercero miTercero = new frmMantenimientoTercero();
            miTercero.ShowDialog();
        }

        private void frmTercero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tercero' Puede moverla o quitarla según sea necesario.
            this.terceroTableAdapter.Fill(this.dSSiscad.tercero);

        }
    }
}
