using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos_Web.Views
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GrupoModelo grupo = new GrupoModelo();

            if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
            {
                grupo.codigo = Convert.ToInt32(EDITCODIGO.Text);
            }
            grupo.descricao = EDITDESCRICAO.Text;

            GrupoControle grupocontrole = new GrupoControle();
            if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
            {
                grupocontrole.alterar(grupo);
            }
            else
            {
                grupocontrole.salvar(grupo);
            }
        }

        protected void SairLogon_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logon.aspx");
        }
    }
}