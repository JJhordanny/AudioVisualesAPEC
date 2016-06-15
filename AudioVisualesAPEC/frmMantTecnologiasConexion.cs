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
    public partial class frmMantTecnologiasConexion : Form
    {
        dbAudiovisualesEntities entities = new dbAudiovisualesEntities();
        public frmMantTecnologiasConexion()
        {
            InitializeComponent();
        }

        private void frmMantTecnologiasConexion_Load(object sender, EventArgs e)
        {
            dgvTecnoConex.DataSource = entities.Tecnologias.ToList();
        }
    }
}
