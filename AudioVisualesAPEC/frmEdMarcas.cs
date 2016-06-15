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
using System.Data.Entity.Migrations;

namespace AudioVisualesAPEC
{
    public partial class frmEdMarcas : Form
    {
        dbAudiovisualesEntities entities = new dbAudiovisualesEntities();
        private Marcas marcas { get; set; }

        public frmEdMarcas(Marcas marca)
        {
            InitializeComponent();
            this.marcas = marca;
        }

        public frmEdMarcas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entities.Marcas.AddOrUpdate(new Marcas {
                IdMarca = Int32.Parse(txtIdMarca.Text),
                Descripcion = txtDescripcion.Text,
                Estado = txtEstado.Text,
            });
            entities.SaveChanges();
            MessageBox.Show("El Registro ha sido Actualizado!");
            this.Close();
        }

        private void frmEdMarcas_Load(object sender, EventArgs e)
        {
            if (marcas != null)
            {
                txtIdMarca.Text = marcas.IdMarca.ToString();
                txtDescripcion.Text = marcas.Descripcion;
                txtEstado.Text = marcas.Estado;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marcas marcas = entities.Marcas.Find(Int32.Parse(txtIdMarca.Text));

            if (marcas != null)
            {
                entities.Marcas.Remove(marcas);
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
