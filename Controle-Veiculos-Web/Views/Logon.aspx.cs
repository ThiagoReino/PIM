using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos_Web.Views
{
    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginControle logincontrole = new LoginControle();
            logincontrole.verificarLogin(EDITLOGIN.Text, EDITSENHA.Text);
            if (logincontrole.mensagem.Equals(""))
            {

                if (logincontrole.tem)
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    //MessageBox.Show("LoginModelo nao encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK);
                }
            }
            else
            {
               // MessageBox.Show(logincontrole.mensagem);
            }
        }
    }
}