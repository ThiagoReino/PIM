using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class Femail : Form
    {
        public Femail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public bool ValidaEnderecoEmail()
        {
            //Define a expressão regular para validar o email
            string texto_Validar = EDITDESTINATARIO.Text;
            Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

            //Testa o email com a expressão
            if (expressaoRegex.IsMatch(texto_Validar))
                return true;
            else
                return false;
        }

        private void BOTAOENVIAR_Click(object sender, EventArgs e)
        {
            try
            {
                string remetente = "rodosystem@bol.com.br";
                string senha = "@p4rt201805";

                if (ValidaEnderecoEmail() == false)
                    MessageBox.Show("Destinatário inválido!");
                else
                {
                    MailMessage enviarEmail = new MailMessage();
                    enviarEmail.From = new MailAddress(remetente);
                    enviarEmail.To.Add(EDITDESTINATARIO.Text);
                    enviarEmail.Priority = MailPriority.Normal;
                    enviarEmail.IsBodyHtml = true;
                    enviarEmail.Subject = EDITASSUNTO.Text;
                    enviarEmail.Body = EDITMENSAGEM.Text;
                    enviarEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
                    enviarEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

                    NetworkCredential credencial = new NetworkCredential(remetente, senha);

                    SmtpClient client = new SmtpClient();
                    client.Host = "smtps.bol.com.br";
                    client.EnableSsl = true;
                    client.Port = 587;
                    client.UseDefaultCredentials = true;
                    client.Credentials = credencial;
                    client.Send(enviarEmail);

                    MessageBox.Show("Email enviado!", "Email");
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Email não enviado!");
            }
        }

        private void Femail_Load(object sender, EventArgs e)
        {
            EDITDESTINATARIO.Enabled = false;
            EDITASSUNTO.Enabled = false;
            EDITMENSAGEM.Enabled = false;
            BOTAOENVIAR.Enabled = false;
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            EDITDESTINATARIO.Enabled = true;
            EDITASSUNTO.Enabled = true;
            EDITMENSAGEM.Enabled = true;
            BOTAOENVIAR.Enabled = true;
        }
    }
}
