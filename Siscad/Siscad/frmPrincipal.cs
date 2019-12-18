using CADSiscad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private CADUsuario usuarioLogueado;

        //public CADUsuario UsuarioLogueado
        //{
        //    get { return usuarioLogueado; }
        //    set { usuarioLogueado = value; }
        //}

        //private CADEmpresa empresaLogueada;

        //public CADEmpresa EmpresaLogueada
        //{
        //    get { return empresaLogueada; }
        //    set { empresaLogueada = value; }
        //}

        #region Funcionalidad de los botones del menú lateral
        private void customizeDesign()
        {
            panelSubMenuArchivo.Visible = false;
            panelSubMenuComercio.Visible = false;
            panelSubMenuRrHh.Visible = false;
            panelSubMenuSiso.Visible = false;
            panelSubMenuHerramientaAnexo.Visible = false;
            panelSubMenuInformeReporte.Visible = false;
        }

        public void hideSubmenu()
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

        public void minimizarMenuLateral()
        {
            buttonArchivo.Text = string.Empty;
            buttonComercio.Text = string.Empty;
            buttonRrHh.Text = string.Empty;
            buttonSiso.Text = string.Empty;
            buttonHerramientaAnexo.Text = string.Empty;
            buttonConsultaInformacion.Text = string.Empty;
            buttonSalir.Text = string.Empty;
            panelMenuLateral.Width = 43;
        }

        private void restaurarMenuLateral()
        {
            panelMenuLateral.Width = 210;
            buttonArchivo.Text = "Archivo";
            buttonComercio.Text = "Comercio";
            buttonRrHh.Text = "Recursos humanos";
            buttonSiso.Text = "Salud ocupacional";
            buttonHerramientaAnexo.Text = "Herramientas y anexos";
            buttonConsultaInformacion.Text = "Consulta de información";
            buttonSalir.Text = "Salir";
        }
        #endregion

        #region Botones del menú lateral
        private void buttonArchivo_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width != 210)
            {
                restaurarMenuLateral();
            }
            else
            {
                showSubmenu(panelSubMenuArchivo);
            }
        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmProducto>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonSucursal_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmSucursal>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonTercero_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmTercero>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmUsuario>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonCambioClave_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmCambioClave>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonCambioUsuario_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmCambioUsuario>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonComercio_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width != 210)
            {
                restaurarMenuLateral();
            }
            else
            {
                showSubmenu(panelSubMenuComercio);
            }
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmVenta>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmCompra>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmSalida>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonTraslado_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmTraslado>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonDevolucion_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmDevolucion>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonRrHh_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width != 210)
            {
                restaurarMenuLateral();
            }
            else
            {
                showSubmenu(panelSubMenuRrHh);
            }
        }

        private void buttonAfiliacion_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmAfiliacion>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonContrato_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmVinculacion>();
            hideSubmenu(); 
            minimizarMenuLateral();
        }

        private void buttonNomina_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmNomina>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonSiso_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width != 210)
            {
                restaurarMenuLateral();
            }
            else
            {
                showSubmenu(panelSubMenuSiso);
            }
        }

        private void buttonIncidenteAccidente_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmIncidenteAccidente>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonHistorialMedico_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmHistorialMedico>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonVigilanciaControl_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmVigilanciaControl>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonHerramientaAnexo_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width != 210)
            {
                restaurarMenuLateral();
            }
            else
            {
                showSubmenu(panelSubMenuHerramientaAnexo);
            }
        }

        private void buttonEmpresa_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmEmpresa>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonActividadPendiente_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmActividadPendiente>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonAnexoProducto_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmAnexoProducto>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonAnexoTercero_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmAnexoTercero>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonAnexoRrHh_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmAnexoRrHh>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonAnexoSiso_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmAnexoSiso>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonConsultaInformacion_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width != 210)
            {
                restaurarMenuLateral();
            }
            else
            {
                showSubmenu(panelSubMenuInformeReporte);
            }
        }

        private void buttonInfoEmpresa_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmInfoEmpresa>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonInfoLaboral_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmInfoLaboral>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonInfoComercial_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmInfoComercial>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonInfoSiso_Click(object sender, EventArgs e)
        {
            //mi código
            abrirFormulario<frmInfoSiso>();
            hideSubmenu();
            minimizarMenuLateral();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Botones y funcionalidades del menú superior
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if(panelMenuLateral.Width==210)
            {
                hideSubmenu();
                minimizarMenuLateral();
            }
            else 
            {
                restaurarMenuLateral();
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

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //Método para abrir formularios dentro del panel
        private void abrirFormulario<miForm>() where miForm: Form, new()
        {
            Form formulario;
            //Busca en la colección el formulario
            formulario = panelContenedor.Controls.OfType<miForm>().FirstOrDefault();
            //Si el formulario/instancia no existe
            if(formulario==null)
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

        private void panelContenedor_MouseClick(object sender, MouseEventArgs e)
        {
            hideSubmenu();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Información que se muestra en el panel inferior
            //labelEmpresaUsuario.Text = "Empresa: "+ empresaLogueada.razonSocial + "  Usuario: " +usuarioLogueado.nombre + " " 
            //    + usuarioLogueado.apellido;
            
            //Información de alertas a tener en cuenta por la empresa
            //if (CADEmpresa.GetEmpresa(empresaLogueada.idEmpresa).fechaResolucionFacturacion != null)
            //{
            //    DateTime vencimientoResolucionDian = CADEmpresa.GetEmpresa(empresaLogueada.idEmpresa).fechaResolucionFacturacion.AddMonths(18);
            //    if (CADEmpresa.GetEmpresa(empresaLogueada.idEmpresa).fechaResolucionFacturacion.AddMonths(17) < DateTime.Now)
            //    {
            //        MessageBox.Show("La resolución de autorización para facturar debe ser renovada, fecha de vencimiento el día " +
            //            vencimientoResolucionDian.ToShortDateString(), "Atención",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    }
            //}
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = "  Fecha: " + DateTime.Now.ToString("dddd, ") 
                + DateTime.Now.ToShortDateString() + "  Hora: " + DateTime.Now.ToLongTimeString();
        }
    }
}
