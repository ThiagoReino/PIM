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
    public partial class FveiculoStatus : Form
    {
        public FveiculoStatus()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public String codigoretornado;

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        public void listaGrid(int veicodigo, int cadcodigo)
        {
            string strSQL = "select razaosocial,datainicioRota,datafimRota,nome,placa from Rota,cadastro,veiculo";
            strSQL = strSQL + " where Rota.cadcodigo = cadastro.codigo";
            strSQL = strSQL + " and veiculo.codigo = Rota.veicodigo ";

            //Linha adicionada
            if (veicodigo > 0)
            {
                strSQL = strSQL + " and veicodigo = @veicodigo";
            }
            if (cadcodigo > 0)
            {
                strSQL = strSQL + " and cadcodigo = @cadcodigo";
            }
            if (CHECKPESQUISA.Checked == true)
            {
                strSQL = strSQL + " and datafimRota between @dataini and @datafim";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);
            if (veicodigo > 0)
            {
                objComando.Parameters.AddWithValue("@veicodigo", veicodigo);
            }
            if (cadcodigo > 0)
            {
                objComando.Parameters.AddWithValue("@cadcodigo", cadcodigo);
            }
            if (CHECKPESQUISA.Checked == true)
            {
                objComando.Parameters.AddWithValue("@dataini", MASKDATAINICIO.Value);
                objComando.Parameters.AddWithValue("@datafim", MASKDATAFIM.Value);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gripStatusRota.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void btnCondutor_Click(object sender, EventArgs e)
        {
            //            FpessoaLoc pessoaLocFrm = new FpessoaLoc();
            //            pessoaLocFrm.ShowDialog();
            /*
            Cadastro cadastro = new Cadastro();
            CadastroController cadcontroller = new CadastroController();
            if (pessoaLocFrm.codigoretornado != "" && pessoaLocFrm.codigoretornado != null)
            {
                cadastro.codigo = int.Parse(pessoaLocFrm.codigoretornado);
                cadastro = cadcontroller.atualizatela(cadastro);

                EDITCADCODIGO.Text = Convert.ToString(cadastro.codigo);
                EDITCADNOME.Text = cadastro.razaosocial;
            }*/
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculoLoc manutencaoFrm = new frmVeiculoLoc();
            manutencaoFrm.ShowDialog();

            // veiculo = new VeiculoModelo();
            VeiculoControle veicontrole = new VeiculoControle();
            if (manutencaoFrm.codigoretornado != "" && manutencaoFrm.codigoretornado != null)
            {
                //veiculo.codigo = int.Parse(manutencaoFrm.codigoretornado);
                //veiculo = veicontrole.atualizatela(veiculo);
            }
            //EDITCODIGO.Text = Convert.ToString(veiculo.codigo);
            // EDITVEINOME.Text = veiculo.nome;
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            int veicodigo = 0;
            int cadcodigo = 0;
            if (EDITVEICODIGO.Text != "")
            {
                veicodigo = Int32.Parse(EDITVEICODIGO.Text);

            }
            else if (EDITCADCODIGO.Text != "")
            {
                cadcodigo = Int32.Parse(EDITCADCODIGO.Text);

            }
            listaGrid(veicodigo, cadcodigo);

            EDITCADCODIGO.Clear();
            EDITCADNOME.Clear();
            EDITVEICODIGO.Clear();
            EDITVEINOME.Clear();
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
