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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        protected UsuarioDTO Usuario { get; set; }
        protected Autenticacion frmAutenticacion { get; set; }

        public FrmPrincipal(UsuarioDTO usuario, Autenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.Usuario = usuario;
            this.frmAutenticacion = frmAutenticacion;
            this.viewMenu.Visible = false;
        }

        #region Eventos

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@$"Hola, Usuario: '{Usuario.Rut_Usuario}'", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Perfilamiento();
        }
        private void Perfilamiento()
        {
            if (Usuario.Rol_Usuario != "ADMINISTRADOR")
            {
                this.toolsMenu.Visible = false;
                this.viewMenu.Visible = true;
            }
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioRegister frmUsuarios = new FrmUsuarioRegister();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void registrarSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarSueldo frmRegistrarSueldo = new FrmRegistrarSueldo();
            frmRegistrarSueldo.MdiParent = this;
            frmRegistrarSueldo.Show();
        }

        private void listarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarTrabajadores frmListar = new FrmListarTrabajadores();
            frmListar.MdiParent = this;
            frmListar.Show();
        }

        private void cerrarSesióntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmAutenticacion.Show();
            this.Close();
        }

        private void listarSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarTrabajadores frmListar = new FrmListarTrabajadores();
            frmListar.MdiParent = this;
            frmListar.Show();
        }
    }
}
