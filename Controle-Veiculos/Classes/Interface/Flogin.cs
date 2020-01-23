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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Flogin_Load(object sender, EventArgs e)
        {
            EDITLOGIN.Focus();
        }

        private void BOTAOENTRAR_Click(object sender, EventArgs e)
        {
            LoginControle logincontrole = new LoginControle();
            logincontrole.verificarLogin(EDITLOGIN.Text, EDITSENHA.Text);
            if (logincontrole.mensagem.Equals(""))
            {

                if (logincontrole.tem)
                {
                    this.Hide();
                    frmPrincipal principalFrm = new frmPrincipal();
                    principalFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("LoginModelo nao encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(logincontrole.mensagem);
            }
            
        }

        private void BOTAOCADASTRESE_Click(object sender, EventArgs e)
        {
            Fcadastro cadastroFrm = new Fcadastro();
            cadastroFrm.ShowDialog();
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EDITLOGIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDITSENHA.Focus();
            }
        }

        private void EDITSENHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BOTAOENTRAR.Focus();
            }
        }
    }
}
