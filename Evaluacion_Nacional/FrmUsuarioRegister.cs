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
    public partial class FrmUsuarioRegister : Form
    {
        private UsuarioDTO usuarioDTO { get; set; }
        private EmpleadosRegister empleadosRegister { get; set; }
        public FrmUsuarioRegister()
        {
            InitializeComponent();
            usuarioDTO = new UsuarioDTO();
            empleadosRegister = new EmpleadosRegister();
        }
        private string ValidarDatos()
        {

            string validacion = string.Empty;
            if (txtRutUsuario.Text == string.Empty)
                validacion += "Falta campo requerido: Rut Trabajador." + Environment.NewLine;

            if (txtNombre.Text == string.Empty)
                validacion += "Falta campo requerido: Nombre." + Environment.NewLine;

            if (txtDireccion.Text == string.Empty)
                validacion += "Falta campo requerido: Direccion." + Environment.NewLine;

            if (txtTelefono.Text == string.Empty)
                validacion += "Falta campo requerido: Telefono." + Environment.NewLine;

            if (txtValorHora.Text == string.Empty)
                validacion += "Falta campo requerido: Valor Hora." + Environment.NewLine;

            if (txtHoraExtra.Text == string.Empty)
                validacion += "Falta campo requerido: Valor Hora Extra." + Environment.NewLine;

            return validacion;
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
                usuarioDTO.Nombre = txtNombre.Text;
                usuarioDTO.Direccion = txtDireccion.Text;
                usuarioDTO.Telefono = txtTelefono.Text;
                usuarioDTO.Rut_Usuario = txtRutUsuario.Text;
                usuarioDTO.Valor_Hora = txtValorHora.Text;
                usuarioDTO.Valor_Hora_Extra = txtHoraExtra.Text;
                try
                {
                    empleadosRegister.ValidarUsuario(usuarioDTO); 
                    
                    empleadosRegister.CrearEmpleado(usuarioDTO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(validacionFormulario, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
