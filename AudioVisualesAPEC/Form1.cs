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

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantTiposEquipos frmTiposEquipos = new frmMantTiposEquipos();
            frmTiposEquipos.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMarcas = new frmMantMarcas();
            frmMarcas.ShowDialog();
        }
    }
}
