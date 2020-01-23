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
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Interface;



namespace Controle_Veiculos.Classes.Interface
{
    public partial class FmanutencaoStatus : Form
    {
        public FmanutencaoStatus()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        public void listaGrid(int veicodigo)
        {
            string strSQL = "select nome,placa,datainicial,datafinal,vlrtotal";
            strSQL = strSQL + " from manutencao inner join veiculo on manutencao.veicodigo = veiculo.codigo where manutencao.veicodigo > 0 ";
            
            if (veicodigo > 0)
            {
                strSQL = strSQL + " and veicodigo = @veicodigo";
            }
            
            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);
            if (veicodigo > 0)
            {
                objComando.Parameters.AddWithValue("@veicodigo", veicodigo);
            }
            
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gripStatusManutencao.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculoLoc manutencaoFrm = new frmVeiculoLoc();
            manutencaoFrm.ShowDialog();

            VeiculoModelo veiculo = new VeiculoModelo();
            VeiculoControle veicontrole = new VeiculoControle();
            if (manutencaoFrm.codigoretornado != "" && manutencaoFrm.codigoretornado != null)
            {
                veiculo.codigo = int.Parse(manutencaoFrm.codigoretornado);
                //veiculo = veicontrole.atualizatela(veiculo);
            }
            EDITVEICODIGO.Text = Convert.ToString(veiculo.codigo);
           // EDITVEINOME.Text = veiculo.nome;
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            int veicodigo = 0;
            if (EDITVEICODIGO.Text != "")
            {
                veicodigo = Int32.Parse(EDITVEICODIGO.Text);

            }
          
            listaGrid(veicodigo);
        }

        private void BOTASAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmanutencaoStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
