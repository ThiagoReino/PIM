using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Modelo;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FmanutencaoLoc : Form
    {
        public FmanutencaoLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public String codigoretornado
        {
            get { return EDITPROCODIGO.Text; }

            set { EDITPROCODIGO.Text = value; }
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        private void gridLocLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridManutencao.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            //Dados da tabela cadastro
            String tipo, valor;
            tipo = "";
            valor = "";
            if (COMBOTIPOPESQUISA.Text == "Código")
            {
                tipo = "codigo";
                valor = EDITPESQUISA.Text;
            }
            if (COMBOTIPOPESQUISA.Text == "Placa")
            {
                tipo = "placa";
                valor = EDITPESQUISA.Text;
            }
            if (COMBOTIPOPESQUISA.Text == "Modelo")
            {
                tipo = "modelo";
                valor = EDITPESQUISA.Text;
            }
            EDITPROCODIGO.Text = listaGrid(tipo, valor);

        }


        public String listaGrid(string tipo, string valor)
        {

            String strSQL;

            strSQL = "select manutencao.*,";
            strSQL = strSQL + " veiculo.marcamodelocodigo, veiculo.placa, veiculo.chassi, veiculo.anofabrica, veiculo.anomodelo, veiculo.combustivel,";
            strSQL = strSQL + " marcamodelo.codigo, marcamodelo.descricao from manutencao";
            strSQL = strSQL + " inner join veiculo on veiculo.codigo = manutencao.veiculocodigo";
            strSQL = strSQL + " inner join marcamodelo on marcamodelo.codigo = veiculo.marcamodelocodigo";
            strSQL = strSQL + " where manutencao.codigo is not null";

            LocacaoModelo locacao = new LocacaoModelo();

            if (tipo == "codigo" && (valor != "" || valor != null))
            {
                strSQL = strSQL + "and manutencao.codigo = @codigo";
            }
            if (tipo == "placa" && (valor != "" || valor != null))
            {
                strSQL = strSQL + "and veiculo.placa = @placa";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);
            /*
            if (locacao.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", locacao.codigo);
            }
            if (locacao.descricao != "" && locacao.descricao != null)
            {
                objComando.Parameters.AddWithValue("@descricao", locacao.descricao);
            }
             */
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridManutencao.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            return codigoretornado;
        }

        
        
        private void BOTAOSAIR_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void FmanutencaoLoc_Load(object sender, EventArgs e)
         {
             COMBOTIPOPESQUISA.Text = "NOME";
         }
     }
    }

