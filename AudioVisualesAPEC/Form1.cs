using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioVisualesAPEC
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void préstamoYDevoluciónDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MDIParent proceso = new MDIParent();
            //proceso.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTiposEquipos = new frmMantTiposEquipos();
            //frmMantTiposEquipos frmTiposEquipos = new frmMantTiposEquipos();
            frmTiposEquipos.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMarcas = new frmMantMarcas();
            frmMarcas.ShowDialog();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmModelos = new frmMantModelos();
            frmModelos.ShowDialog();
        }

        private void tecnologíasConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTecnologiasConexion = new frmMantTecnologiasConexion();
            frmTecnologiasConexion.ShowDialog();
        }

        private void equiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmEquipos = new frmMantEquipos();
            frmEquipos.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new frmMantUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEmpleados = new frmMantEmpleados();
            frmEmpleados.ShowDialog();
        }

        private void crearReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmReportes = new VistaReporte();
            frmReportes.ShowDialog();
        }

        private void pbEquipo_Click(object sender, EventArgs e)
        {
            var frmTiposEquipos = new frmMantTiposEquipos();
            //frmMantTiposEquipos frmTiposEquipos = new frmMantTiposEquipos();
            frmTiposEquipos.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frmMarcas = new frmMantMarcas();
            frmMarcas.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var frmModelos = new frmMantModelos();
            frmModelos.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new frmMantUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
