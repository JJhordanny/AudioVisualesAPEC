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
    public partial class Reservacion : Form
    {
        public Reservacion()
        {
            InitializeComponent();
        }

        private void Reservacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAudiovisualesDataSet.TiposEquipos' table. You can move, or remove it, as needed.
            this.tiposEquiposTableAdapter.Fill(this.dbAudiovisualesDataSet.TiposEquipos);
            // TODO: This line of code loads data into the 'dbAudiovisualesDataSet.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter.Fill(this.dbAudiovisualesDataSet.Equipos);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
