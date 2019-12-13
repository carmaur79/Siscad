﻿using System;
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
    public partial class frmSucursal : FormBase
    {
        public frmSucursal()
        {
            InitializeComponent();
        }

        private void sucursalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sucursalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSiscad);

        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSiscad.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.dSSiscad.sucursal);

        }
    }
}
