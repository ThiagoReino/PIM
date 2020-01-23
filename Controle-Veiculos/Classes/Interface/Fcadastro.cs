using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Model;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Interface;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class Fcadastro : Form
    {
        public Fcadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public bool validaDado()
        {
            bool validaDado;
            validaDado = true;

            if (String.IsNullOrEmpty(EDITLOGIN.Text))
            {
                MessageBox.Show("Favor informar o LoginModelo", "LoginModelo");
               validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITSENHA.Text))
            {
                MessageBox.Show("Favor informar a senha", "Senha");
                validaDado = false;
            }
            return validaDado;
        }

        public void limpaTela()
        {
            EDITLOGIN.Clear();
            EDITSENHA.Clear();
            EDITSENHACONFIRMAR.Clear();
        }

        private void BOTAOCADASTRAR_Click(object sender, EventArgs e)
        {
            if (validaDado())
            {
                LoginModelo log = new LoginModelo();
                log.logon = EDITLOGIN.Text;
                log.senha = EDITSENHA.Text;
                log.senha = EDITSENHACONFIRMAR.Text;
                if (EDITSENHA.Text == EDITSENHACONFIRMAR.Text)
                {

                    LoginControle logincontrole = new LoginControle();
                    logincontrole.salvar(log);
                    MessageBox.Show("LoginModelo criado com sucesso.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senhas nao conferem.");
                }
            }
        }

        private void Fcadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
