using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace AudioVisualesAPEC
{
    public partial class frmRestaurarCredenciales : Form
    {
        public frmRestaurarCredenciales()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("your mail here", "your password heres");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Timeout = 100000;

                string to = txtUser.Text;
                MailMessage msj = new MailMessage();
                msj.To.Add(to);
                msj.From = new MailAddress("j.jhordannyhd@gmail.com");
                msj.Subject = "Restablecer Contraseña";
                msj.Body = "Su contraseña sera restablecida en unos instantes";
                smtp.Send(msj);
                MessageBox.Show("Contraseña Restaurada con Éxito");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingresar un correo valido");
                this.Hide();
            }
        }
    }
}
