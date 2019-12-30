using CADSiscad;
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
            personalizarDiseño();
        }

        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        private CADEmpresa empresaLogueada;

        public CADEmpresa EmpresaLogueada
        {
            get { return empresaLogueada; }
            set { empresaLogueada = value; }
        }

        private void personalizarDiseño()
        {
            panelSubMenuAdministracion.Visible = false;
            panelSubMenuRecursosHumanos.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelSubMenuAdministracion.Visible == true)
                panelSubMenuAdministracion.Visible = false;
            if (panelSubMenuRecursosHumanos.Visible == true)
                panelSubMenuRecursosHumanos.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ocultarPanelLateral()
        {
            labelSiscadPyme2.Visible = true;
            labelSiscadPyme2.Text = "SISCAD-PYME";
            panelMenuLateral.Width = 10;
        }

        //Método para abrir formularios dentro del panel
        private void abrirFormulario<miForm>() where miForm : Form, new()
        {
            Form formulario;
            //Busca en la colección el formulario
            formulario = panelContenedor.Controls.OfType<miForm>().FirstOrDefault();
            //Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new miForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #region menuAdministracion
        private void buttonMenuAdministracion_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuAdministracion);
        }

        private void buttonEmpresa_Click(object sender, EventArgs e)
        {
            abrirFormulario <frmEmpresa>();
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmUsuario>();
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonSucursal_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmSucursal>();
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonCentroTrabajo_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonAreaTrabajo_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonTurnoTrabajo_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }
        #endregion

        #region recursoHumano
        private void buttonMenuRecursoHumano_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuRecursosHumanos);
        }

        private void buttonSeleccionPersonal_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonAfiliacion_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonVinculacion_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonAsistencia_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonNovedadLaboral_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonNomina_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonPrestacionSocial_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonPreliquidacionPila_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonCertificado_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }

        private void buttonMemorando_Click(object sender, EventArgs e)
        {
            //mi código
            ocultarSubMenu();
            ocultarPanelLateral();
        }
        #endregion

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width != 200)
            {
                labelSiscadPyme2.Visible = false;
                panelMenuLateral.Width = 200;
            }
            else
            {
                ocultarSubMenu();
                ocultarPanelLateral();
            }
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = "  Hora: " + DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToString("dddd, ") + DateTime.Now.ToShortDateString();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelMostrarMenuLateral_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelMenuLateral.Width != 200)
            {
                labelSiscadPyme2.Visible = false;
                panelMenuLateral.Width = 200;
            }
        }

        private void buttonCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            labelCerrarPrograma.Visible = true;
        }

        private void buttonCerrar_MouseLeave(object sender, EventArgs e)
        {
            labelCerrarPrograma.Visible = false;
        }

        private void buttonMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            labelMinimizarPrograma.Visible = true;
        }

        private void buttonMinimizar_MouseLeave(object sender, EventArgs e)
        {
            labelMinimizarPrograma.Visible = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            labelEmpresaUsuario.Text = "Empresa: " + EmpresaLogueada.razonSocial +
                ", Usuario: " + usuarioLogueado.nombre + " " + usuarioLogueado.apellido;
        }
    }
}
