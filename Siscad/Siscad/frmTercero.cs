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
    public partial class frmTercero : FormBase
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

        private void frmTercero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.estadoCivil' Puede moverla o quitarla según sea necesario.
            this.estadoCivilTableAdapter.Fill(this.dSSiscad.estadoCivil);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.municipio' Puede moverla o quitarla según sea necesario.
            this.municipioTableAdapter.Fill(this.dSSiscad.municipio);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSSiscad.departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tipoSangre' Puede moverla o quitarla según sea necesario.
            this.tipoSangreTableAdapter.Fill(this.dSSiscad.tipoSangre);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.dSSiscad.sexo);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tipoPersona' Puede moverla o quitarla según sea necesario.
            this.tipoPersonaTableAdapter.Fill(this.dSSiscad.tipoPersona);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSSiscad.tipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tercero' Puede moverla o quitarla según sea necesario.
            this.terceroTableAdapter.Fill(this.dSSiscad.tercero);

        }
    }
}
