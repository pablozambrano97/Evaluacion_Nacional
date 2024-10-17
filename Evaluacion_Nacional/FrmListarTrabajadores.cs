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
        public FrmListarTrabajadores()
        {
            InitializeComponent();
            listaUsuario = new List<UsuarioDTO>();
            domain = new ListarSueldos();
        }
        private void FrmListarTrabajadores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            try
            {
                lvSueldos.Items.Clear();

                listaUsuario = domain.ListarUsuarios();
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


    }
}
