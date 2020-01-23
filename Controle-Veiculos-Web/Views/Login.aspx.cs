using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controle_Veiculos.Classes.Controle;

namespace ControleVeiculoWeb.Interface
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void limpaTela()
        {
            EditUsuario.Text = "";
            EditSenha.Text = "";
        }

        protected void BotaoEntrar_Click(object sender, EventArgs e)
        {
            LoginControle logincontrole = new LoginControle();
            logincontrole.verificarLogin(EditUsuario.Text, EditSenha.Text);
            if (logincontrole.mensagem.Equals(""))
            {

                if (logincontrole.tem)
                {
                    
                    Response.Redirect("Menu.aspx");
                }
                else
                {
                    LabelErro.Text = "LoginModelo nao encontrado, verifique login e senha";
                }
            }
            else
            {
                //MessageBox.Show(logincontrole.mensagem);
            }
        }
    }
}