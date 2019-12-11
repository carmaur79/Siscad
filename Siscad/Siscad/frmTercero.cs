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
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.municipio' Puede moverla o quitarla según sea necesario.
            this.municipioTableAdapter.Fill(this.dSSiscad.municipio);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSSiscad.departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.ocupaciones' Puede moverla o quitarla según sea necesario.
            this.ocupacionesTableAdapter.Fill(this.dSSiscad.ocupaciones);
            this.terceroTableAdapter.Fill(this.dSSiscad.tercero);
        }

        private void buttonPrimerRegistro_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnteriorRegistro_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguienteRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUltimoRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
