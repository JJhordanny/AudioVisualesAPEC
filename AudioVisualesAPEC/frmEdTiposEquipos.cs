using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace AudioVisualesAPEC
{
    public partial class frmEdTiposEquipos : Form
    {
        private TiposEquipos tiposEquipos { get; set; }
        private dbAudiovisualesEntities entities = new dbAudiovisualesEntities();

        public frmEdTiposEquipos(TiposEquipos tiposEquipos)
        {
            InitializeComponent();
            this.tiposEquipos = tiposEquipos;
        }
        public frmEdTiposEquipos()
        {
            InitializeComponent();
        }
        
        private void frmEdTiposEquipos_Load(object sender, EventArgs e)
        {
            if (tiposEquipos != null)
            {
                txtIdTipoEquipo.Text = tiposEquipos.IdTipoEquipo.ToString();
                txtDescripcion.Text = tiposEquipos.Descripcion;
                txtEstado.Text = tiposEquipos.Estado;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entities.TiposEquipos.AddOrUpdate(new TiposEquipos {
                IdTipoEquipo = Int32.Parse(txtIdTipoEquipo.Text),
                Descripcion = txtDescripcion.Text,
                Estado = txtEstado.Text,
            });
            entities.SaveChanges();
            MessageBox.Show("El Registro ha sido Actualizado!");
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TiposEquipos tiposEquipos = entities.TiposEquipos.Find(Int32.Parse(txtIdTipoEquipo.Text));

            if (tiposEquipos != null)
            {
                entities.TiposEquipos.Remove(tiposEquipos);
                entities.SaveChanges();
                MessageBox.Show("El registro ha sido Eliminado!");
                this.Close();
            }
            else
            {
                MessageBox.Show("El registro no Existe!");
                this.Close();
            }
        }
    }
}
