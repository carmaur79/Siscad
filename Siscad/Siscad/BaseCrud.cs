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
    public partial class BaseCrud : Form
    {
        public BaseCrud()
        {
            InitializeComponent();
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

        private void buttonFormNuevo_Click(object sender, EventArgs e)
        {

        }

        private void buttonFormEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFormBorrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFormBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFormGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFormCancelar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFormCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void hideSubmenu()
        {
            //if (panelSubMenuArchivo.Visible == true)
            //    panelSubMenuArchivo.Visible = false;
            //if (panelSubMenuComercio.Visible == true)
            //    panelSubMenuComercio.Visible = false;
            //if (panelSubMenuRrHh.Visible == true)
            //    panelSubMenuRrHh.Visible = false;
            //if (panelSubMenuSiso.Visible == true)
            //    panelSubMenuSiso.Visible = false;
            //if (panelSubMenuHerramientaAnexo.Visible == true)
            //    panelSubMenuHerramientaAnexo.Visible = false;
            //if (panelSubMenuInformeReporte.Visible == true)
            //    panelSubMenuInformeReporte.Visible = false;
        }

        public virtual void minimizarMenuLateral()
        {
            //buttonArchivo.Text = string.Empty;
            //buttonComercio.Text = string.Empty;
            //buttonRrHh.Text = string.Empty;
            //buttonSiso.Text = string.Empty;
            //buttonHerramientaAnexo.Text = string.Empty;
            //buttonConsultaInformacion.Text = string.Empty;
            //buttonSalir.Text = string.Empty;
            //panelMenuLateral.Width = 43;
        }

        public virtual void Nuevo()
        {

        }

        public virtual void Editar()
        {

        }

        public virtual void Borrar()
        {

        }

        public virtual void Buscar()
        {

        }

        public virtual bool Guardar()
        {
            return false;
        }

        public virtual void Cancelar()
        {

        }

        public virtual void Cerrar()
        {

        }
    }
}
