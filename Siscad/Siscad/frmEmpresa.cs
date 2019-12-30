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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void datosEmpresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datosEmpresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSiscad);

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            this.terceroTableAdapter.Fill(this.dSSiscad.tercero);
            this.secMunicipioTableAdapter.Fill(this.dSSiscad.secMunicipio);
            this.secDepartamentoTableAdapter.Fill(this.dSSiscad.secDepartamento);
            this.terceroTableAdapter.Fill(this.dSSiscad.tercero);
            this.secMunicipioTableAdapter.Fill(this.dSSiscad.secMunicipio);
            this.secDepartamentoTableAdapter.Fill(this.dSSiscad.secDepartamento);
            this.datosEmpresaTableAdapter.Fill(this.dSSiscad.datosEmpresa);

        }

        private void buttonCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCerrarVentana_MouseMove(object sender, MouseEventArgs e)
        {
            labelCerrarVentana.Visible = true;
        }

        private void buttonCerrarVentana_MouseLeave(object sender, EventArgs e)
        {
            labelCerrarVentana.Visible = false;
        }
    }
}
