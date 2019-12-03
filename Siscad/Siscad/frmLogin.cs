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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == string.Empty)
            {
                errorProvider1.SetError(txtEmpresa, "Debe ingresar el Nit de la empresa");
                txtEmpresa.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuario, string.Empty);

            decimal cantidad;

            if (!decimal.TryParse(txtEmpresa.Text, out cantidad))
            {
                errorProvider1.SetError(txtEmpresa, "La información ingresada no corresponde a un Nit");
                return;
            }
            errorProvider1.SetError(txtEmpresa, string.Empty);

            //if (!CADEmpresa.ExisteEmpresa(Convert.ToInt32(txtEmpresa.Text)))
            //{
            //    errorProvider1.SetError(txtEmpresa, "No se encuentra el Nit de la empresa, verifíquelo");
            //    return;
            //}
            //errorProvider1.SetError(txtEmpresa, string.Empty);

            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar el nombre de usuario");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuario, string.Empty);

            if (txtClave.Text == string.Empty)
            {
                errorProvider1.SetError(txtClave, "Debe ingresar una clave");
                txtClave.Focus();
                return;
            }
            errorProvider1.SetError(txtClave, string.Empty);

            //if (!CADUsuario.ValidarUsuario(txtUsuario.Text, txtClave.Text))
            //{
            //    MessageBox.Show("Usuario o clave no válidos", "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtEmpresa.Text = string.Empty;
            //    txtUsuario.Text = string.Empty;
            //    txtClave.Text = string.Empty;
            //    txtEmpresa.Focus();
            //    return;
            //}
            this.Hide();

            frmSaludoUsuario miForm = new frmSaludoUsuario();
            //miForm.UsuarioLogueado = CADUsuario.GetUsuario(txtUsuario.Text);
            //miForm.EmpresaLogueada = CADEmpresa.GetEmpresa(Convert.ToInt32(txtEmpresa.Text));
            miForm.ShowDialog();
            //CADUsuario.UpdateUltimoIngreso(txtUsuario.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString() + "  Hora: " + DateTime.Now.ToLongTimeString();
        }
    }
}
