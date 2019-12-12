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
    public partial class frmTerceroParaBorrar : BaseCrud
    {
        public frmTerceroParaBorrar()
        {
            InitializeComponent();
        }

        private int i = 0;

        private void buttonFormEditar_Click(object sender, EventArgs e)
        {
            frmTercero miTercero = new frmTercero();
            miTercero.ShowDialog();
        }

        private void frmTercero_Load(object sender, EventArgs e)
        {
            this.municipioTableAdapter.Fill(this.dSSiscad.municipio);
            this.departamentoTableAdapter.Fill(this.dSSiscad.departamento);
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
            if (i >= dataGridViewPrincipal.Rows.Count) return;
            i++;

        }

        private void buttonUltimoRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
