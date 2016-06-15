using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AudioVisualesAPEC
{
    public partial class frmMantMarcas : Form
    {
        private Marcas marcas { get; set; }
        private dbAudiovisualesEntities entities = new dbAudiovisualesEntities();
        public frmMantMarcas()
        {
            InitializeComponent();
        }

        private void frmMantMarcas_Load(object sender, EventArgs e)
        {
            consultarMarcas();
        }

        private void consultarMarcas()
        {
            dgvMarcas.DataSource = entities.Marcas.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void consultarPorCriterio()
        {
            var marcas = from ma in entities.Marcas
                         where (ma.IdMarca.ToString().Contains(txtTextoBuscar.Text) ||
                         ma.Descripcion.ToString().Contains(txtTextoBuscar.Text) ||
                         ma.Estado.ToString().Contains(txtTextoBuscar.Text)   
                         )
                         select ma;
            dgvMarcas.DataSource = marcas.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frmEdMarcas = new frmEdMarcas();
            frmEdMarcas.ShowDialog();
        }

        private void frmMantMarcas_Activated(object sender, EventArgs e)
        {
            dgvMarcas.DataSource = entities.Marcas.ToList();
        }

        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvMarcas.SelectedRows[0].DataBoundItem as Marcas;
            var fm = new frmEdMarcas(row);
            fm.ShowDialog();
        }
    }
}
