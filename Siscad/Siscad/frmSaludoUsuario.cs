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
    public partial class frmSaludoUsuario : Form
    {
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

        int conteo = 0;

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
            //Inicia temporizador
            this.Opacity = 0.0;
            timerIniciaSaludo.Start();
            //Se carga información en el formulario
            nombreUsuarioLabel.Text = usuarioLogueado.nombre + " " + usuarioLogueado.apellido;
            fechaIngresoLabel.Text = usuarioLogueado.ultimoIngreso.ToLongDateString() + " a las " + usuarioLogueado.ultimoIngreso.ToLongTimeString() + " horas";
            nombreEmpresaLabel.Text = empresaLogueada.razonSocial;
            if (CADUsuario.EstadoUsuario(usuarioLogueado.idUsuario, ("0")))
            {
                MessageBox.Show("No tiene permiso para ingresar al sistema, hable con su superior", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
        }

        private void timerIniciaSaludo_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.1;
            conteo += 1;
            if(conteo == 100)
            {
                timerIniciaSaludo.Stop();
                timerFinSaludo.Start();
            }
        }

        private void timerFinSaludo_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timerFinSaludo.Stop();
                this.Hide();
                //CADUsuario.UpdateUltimoIngreso(usuarioLogueado.idUsuario);
                frmPrincipal miForm = new frmPrincipal();
                miForm.UsuarioLogueado = this.usuarioLogueado;
                miForm.EmpresaLogueada = this.empresaLogueada;
                miForm.Show();
            }
        }
    }
}
