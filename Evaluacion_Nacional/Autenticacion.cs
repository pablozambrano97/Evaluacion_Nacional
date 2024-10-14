using Evaluacion_Nacional_Domain;
using Evaluacion_Nacional_Soporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_Nacional
{
    public partial class Autenticacion : Form
    {
        LoginDomain domain;
        public Autenticacion()
        {
            InitializeComponent();
            domain = new LoginDomain();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO usuario = domain.ValidarUsuarioYPassword(txtUsuario.Text, txtPassword.Text);
                FrmPrincipal principal = new FrmPrincipal(usuario, this );
                txtUsuario.Text = string.Empty;
                txtPassword.Text = string.Empty;
                principal.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistroGeneral registro = new FrmRegistroGeneral();
            registro.Show();
            this.Hide();
        }
    }
}
