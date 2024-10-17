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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evaluacion_Nacional
{
    public partial class FrmRegistrarSueldo : Form
    {
        private UsuarioDTO usuarioDTO { get; set; }
        private SueldoRegister RegistrarSueldo { get; set; }
        private FrmListarTrabajadores frmListarTrabajadores { get; set; }

        public FrmRegistrarSueldo()
        {
            InitializeComponent();
            usuarioDTO = new UsuarioDTO();
            RegistrarSueldo = new SueldoRegister();
            frmListarTrabajadores = new FrmListarTrabajadores();
        }

        private string ValidarDatos()
        {

            string validacion = string.Empty;
            if (txtRut.Text == string.Empty)
                validacion += "Falta campo requerido: Rut Trabajador." + Environment.NewLine;

            if (txtHorasTrabajadas.Text == string.Empty)
                validacion += "Falta campo requerido: Horas Trabajadas." + Environment.NewLine;

            if (txtHorasExtras.Text == string.Empty)
                validacion += "Falta campo requerido: Horas Extras." + Environment.NewLine;

            if (cbbAFP.SelectedItem == null)
                validacion += "Falta campo requerido: AFP." + Environment.NewLine;
            if (cbbSalud.SelectedItem == null)
                validacion += "Falta campo requerido: Prestador de salud." + Environment.NewLine;

            return validacion;
        }
        private double CalcularDescuentoAFP(double sueldoBruto)
        {
            switch (cbbAFP.SelectedItem.ToString())
            {
                case "CUPRUM": return sueldoBruto * 0.07;
                case "MODELO": return sueldoBruto * 0.09;
                case "CAPITAL": return sueldoBruto * 0.12;
                case "PROVIDA": return sueldoBruto * 0.13;
                default: return 0;
            }
        }

        private double CalcularDescuentoSalud(double sueldoBruto)
        {
            switch (cbbSalud.SelectedItem.ToString())
            {
                case "FONASA": return sueldoBruto * 0.12;
                case "CONSALUD": return sueldoBruto * 0.13;
                case "MASVIDA": return sueldoBruto * 0.14;
                case "BANMEDICA": return sueldoBruto * 0.15;
                default: return 0;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string validacionFormulario = ValidarDatos();
            if (validacionFormulario != string.Empty)
            {
                MessageBox.Show(validacionFormulario, "Faltan Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                usuarioDTO.Rut_Usuario = txtRut.Text;
                try
                {
                    usuarioDTO = RegistrarSueldo.ConsultarValorHoras(usuarioDTO);
                    usuarioDTO.SueldoBruto = (usuarioDTO.Valor_Hora * Convert.ToInt32(txtHorasTrabajadas.Text) + (usuarioDTO.Valor_Hora_Extra * Convert.ToInt32(txtHorasExtras.Text)));
                    double DescuentoAfp = CalcularDescuentoAFP(usuarioDTO.SueldoBruto);
                    double DescuentoSalud = CalcularDescuentoSalud(usuarioDTO.SueldoBruto);
                    usuarioDTO.SueldoLiquido = (usuarioDTO.SueldoBruto) - (DescuentoAfp + DescuentoSalud);
                    txtSueldoBruto.Text = usuarioDTO.SueldoBruto.ToString();
                    txtSueldoLiquido.Text = usuarioDTO.SueldoLiquido.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, validacionFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string validacionFormulario = ValidarDatos();
            if (validacionFormulario != string.Empty)
            {
                MessageBox.Show(validacionFormulario, "Faltan Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    usuarioDTO.Horas_Trabajadas = Convert.ToInt32(txtHorasTrabajadas.Text);
                    usuarioDTO.Horas_Extras_Trabajadas = Convert.ToInt32(txtHorasExtras.Text);
                    usuarioDTO.AFP = cbbAFP.Text;
                    usuarioDTO.Salud = cbbSalud.Text;
                    usuarioDTO = RegistrarSueldo.RegistrarSueldoByEmpleado(usuarioDTO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, validacionFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtRut.Text = string.Empty;
            txtSueldoBruto.Text = string.Empty;
            txtHorasExtras.Text = string.Empty;
            txtHorasTrabajadas.Text = string.Empty;
            txtSueldoLiquido.Text = string.Empty;
            cbbAFP.Text = string.Empty;
            cbbSalud.Text = string.Empty;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListarTrabajadores.Show();
        }
    }
}
