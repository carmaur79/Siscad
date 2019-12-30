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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSiscad);

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.secRol' Puede moverla o quitarla según sea necesario.
            this.secRolTableAdapter.Fill(this.dSSiscad.secRol);
            this.usuarioTableAdapter.Fill(this.dSSiscad.usuario);

        }

        private void buttonCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
