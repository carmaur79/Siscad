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
    public partial class pruebaDeCodigo : BaseCrud
    {
        public pruebaDeCodigo()
        {
            InitializeComponent();
        }

        private void terceroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terceroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSiscad);

        }

        private void pruebaDeCodigo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tipoPersona' Puede moverla o quitarla según sea necesario.
            this.tipoPersonaTableAdapter.Fill(this.dSSiscad.tipoPersona);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSSiscad.tipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.tercero' Puede moverla o quitarla según sea necesario.
            this.terceroTableAdapter.Fill(this.dSSiscad.tercero);

        }
    }
}
