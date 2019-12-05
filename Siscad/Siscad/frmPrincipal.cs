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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubMenuArchivo.Visible = false;
            panelSubMenuComercio.Visible = false;
            panelSubMenuRrHh.Visible = false;
            panelSubMenuSiso.Visible = false;
            panelSubMenuHerramientaAnexo.Visible = false;
            panelSubMenuInformeReporte.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubMenuArchivo.Visible == true)
                panelSubMenuArchivo.Visible = false;
            if (panelSubMenuComercio.Visible == true)
                panelSubMenuComercio.Visible = false;
            if (panelSubMenuRrHh.Visible == true)
                panelSubMenuRrHh.Visible = false;
            if (panelSubMenuSiso.Visible == true)
                panelSubMenuSiso.Visible = false;
            if (panelSubMenuHerramientaAnexo.Visible == true)
                panelSubMenuHerramientaAnexo.Visible = false;
            if (panelSubMenuInformeReporte.Visible == true)
                panelSubMenuInformeReporte.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonArchivo_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuArchivo);
        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonSucursal_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonTercero_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonCambioClave_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonCambioUsuario_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonComercio_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuComercio);
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonTraslado_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonDevolucion_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonRrHh_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuRrHh);
        }

        private void buttonAfiliacion_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonContrato_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonNomina_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonSiso_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuSiso);
        }

        private void buttonIncidenteAccidente_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonHistorialMedico_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonVigilanciaControl_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonHerramientaAnexo_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuHerramientaAnexo);
        }

        private void buttonEmpresa_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonActividadPendiente_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonAnexoProducto_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonAnexoTercero_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonAnexoRrHh_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonAnexoSiso_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonConsultaInformacion_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuInformeReporte);
        }

        private void buttonInfoEmpresa_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonInfoLaboral_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonInfoComercial_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonInfoSiso_Click(object sender, EventArgs e)
        {
            //mi código
            hideSubmenu();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
