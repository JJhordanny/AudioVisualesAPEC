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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLoging_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbAudiovisuales;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Login where UserName ='" + txtUser.Text + "' and Password = '" + txtPass.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter("Select Rol from Login Where Username='" + txtUser.Text + "' and Password ='" + txtPass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //if (dt.Rows.Count == 1)
            //{

            //}
            if (dt.Rows[0][0].ToString() == "administrador")
            {
                this.Hide();
                var frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Por favor revisar su Usuario y Contraseña");
            }
        }

        private void lnkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmRecuperarDatos = new frmRestaurarCredenciales();
            frmRecuperarDatos.ShowDialog();
        }
    }
}
