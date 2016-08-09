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
    public partial class VistaReporte : Form
    {
        public VistaReporte()
        {
            InitializeComponent();
        }

        private void VistaReporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbAudiovisualesEntities db = new dbAudiovisualesEntities())
                {
                    EquiposBindingSource.DataSource = db.Equipos.ToList();
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
