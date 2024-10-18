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
    public partial class FrmListarTrabajadores : Form
    {
        private List<UsuarioDTO> listaUsuario { get; set; }
        private ListarSueldos domain;
        private UsuarioDTO usuarioDTO { get; set; }
        public FrmListarTrabajadores(UsuarioDTO usuario)
        {
            InitializeComponent();
            this.usuarioDTO = usuario;
            listaUsuario = new List<UsuarioDTO>();
            domain = new ListarSueldos();
        }
        private void FrmListarTrabajadores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            if (usuarioDTO.EsAdmin)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
        public void CargarDatos()
        {
            try
            {
                lvSueldos.Items.Clear();
                listaUsuario = domain.ListarUsuarios(usuarioDTO);
                foreach (var usuario in listaUsuario)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(usuario.Rut_Usuario);
                    item.SubItems.Add(usuario.AFP);
                    item.SubItems.Add(usuario.Salud);
                    item.SubItems.Add(usuario.SueldoBruto.ToString());
                    item.SubItems.Add(usuario.SueldoLiquido.ToString());
                    lvSueldos.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar los Datos: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvSueldos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSueldos.SelectedItems.Count > 0)
            {
                usuarioDTO.Rut_Usuario = lvSueldos.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            usuarioDTO.FlagEdicion = true;
            FrmRegistrarSueldo frmUsuarioDetalle = new FrmRegistrarSueldo(usuarioDTO);
            frmUsuarioDetalle.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                domain.EliminarSueldo(usuarioDTO);
                CargarDatos();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Eliminado con exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
