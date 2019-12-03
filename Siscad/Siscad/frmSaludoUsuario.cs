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
    public partial class frmSaludoUsuario : Form
    {
        //private CADUsuario usuarioLogueado;

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

        //private string idUsuario;

        //public string IDUsuario
        //{
        //    get { return idUsuario; }
        //    set { idUsuario = value; }
        //}

        //private int idEmpresa;

        //public int IDEmpresa
        //{
        //    get { return idEmpresa; }
        //    set { idEmpresa = value; }
        //}

        public frmSaludoUsuario()
        {
            InitializeComponent();
        }

        private void frmSaludoUsuario_Load(object sender, EventArgs e)
        {
            //nombreUsuarioLabel.Text = usuarioLogueado.nombre + " " + usuarioLogueado.apellido;
            //fechaIngresoLabel.Text = usuarioLogueado.ultimoIngreso.ToLongDateString() + " a las " + usuarioLogueado.ultimoIngreso.ToLongTimeString() + " horas";
            //nombreEmpresaLabel.Text = empresaLogueada.razonSocial;
            //if (CADUsuario.EstadoUsuario(usuarioLogueado.idUsuario, ("0")))
            //{
            //    MessageBox.Show("No tiene permiso para ingresar al sistema, hable con su superior", "Atención",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    Application.Exit();
            //}

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

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //CADUsuario.UpdateUltimoIngreso(usuarioLogueado.idUsuario);
            frmPrincipal miForm = new frmPrincipal();
            //miForm.UsuarioLogueado = this.usuarioLogueado;
            //miForm.EmpresaLogueada = this.empresaLogueada;
            miForm.Show();
        }
    }
}
