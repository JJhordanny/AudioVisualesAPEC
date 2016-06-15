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
    public partial class frmMantModelos : Form
    {
        dbAudiovisualesEntities entities = new dbAudiovisualesEntities();
        public frmMantModelos()
        {
            InitializeComponent();
        }

        private void frmMantModelos_Load(object sender, EventArgs e)
        {
            consultarModelos();
        }

        private void consultarModelos()
        {
            dgvModelos.DataSource = entities.Modelos.ToList();
        }
    }
}
