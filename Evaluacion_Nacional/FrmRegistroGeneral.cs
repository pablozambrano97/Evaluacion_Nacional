using Evaluacion_Nacional_Data;
using Evaluacion_Nacional_Domain;
using Evaluacion_Nacional_Soporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_Nacional
{
    public partial class FrmRegistroGeneral : Form
    {
        private UsuarioDTO usuarioDTO { get; set; }
        private RegisterDomain registerDomain { get; set; }
        public FrmRegistroGeneral()
        {
            InitializeComponent();
            usuarioDTO = new UsuarioDTO();
            registerDomain = new RegisterDomain();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string validacionFormulario = ValidarDatos();
            if (validacionFormulario != string.Empty)
            {
                MessageBox.Show(validacionFormulario, "Faltan Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                usuarioDTO.Rut_Usuario = txtRutUsuario.Text;
                usuarioDTO.Password = txtPassword.Text;
                try
                {
                    registerDomain.ValidarUsuarioYPassword(usuarioDTO);

                    registerDomain.CrearUsuario(usuarioDTO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message, validacionFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = string.Empty;
                    txtRepetirPassword.Text = string.Empty;
                    txtRutUsuario.Text = string.Empty;
                }
            }
        }
        private string ValidarDatos()
        {

            string validacion = string.Empty;
            if (txtRutUsuario.Text == string.Empty)
                validacion += "Falta campo requerido: Nombre." + Environment.NewLine;

            if (txtPassword.Text == string.Empty)
                validacion += "Falta campo requerido: Username." + Environment.NewLine;

            if (txtPassword.Text != txtRepetirPassword.Text)
                validacion += "Las  contraseñas no coinciden." + Environment.NewLine;

            return validacion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Autenticacion FrmAutenticacion = new Autenticacion();
            FrmAutenticacion.Show();
            this.Hide();
        }
    }
}
