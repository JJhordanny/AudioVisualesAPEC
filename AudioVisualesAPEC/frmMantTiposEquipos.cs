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
    public partial class frmMantTiposEquipos : Form
    {
        public TiposEquipos tiposEquipos { get; set; }
        private dbAudiovisualesEntities entities = new dbAudiovisualesEntities();
        public frmMantTiposEquipos()
        {
            InitializeComponent();
        }

        private void frmMantTiposEquipos_Load(object sender, EventArgs e)
        {
            consultarTiposEquipos();
        }

        private void consultarTiposEquipos()
        {
            dgvTiposEquipos.DataSource = entities.TiposEquipos.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        //Metodo para consultar por criterio a la base de datos
        private void consultarPorCriterio()
        {
            var tipoEquipos = from te in entities.TiposEquipos
                              where (te.IdTipoEquipo.ToString().Contains(txtTextoBuscar.Text) ||
                                    te.Descripcion.ToString().Contains(txtTextoBuscar.Text) ||
                                    te.Estado.ToString().Contains(txtTextoBuscar.Text)
                              )
                              select te;
            dgvTiposEquipos.DataSource = tipoEquipos.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEdTiposEquipos fte = new frmEdTiposEquipos();
            fte.ShowDialog();
            //dgvTiposEquipos.DataSource = new BindingSource { DataSource = entities.TiposEquipos.ToList() };
            //dgvTiposEquipos.Refresh();
        }

        private void frmMantTiposEquipos_Activated(object sender, EventArgs e)
        {
            dgvTiposEquipos.DataSource = new BindingSource { DataSource = entities.TiposEquipos.ToList() };
            dgvTiposEquipos.Refresh();
        }

        //Metodo para ver campo seleccionado
        private void dgvTiposEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvTiposEquipos.SelectedRows[0].DataBoundItem as TiposEquipos;
            frmEdTiposEquipos fte = new frmEdTiposEquipos(row);
            fte.ShowDialog();
        }
    }
}
