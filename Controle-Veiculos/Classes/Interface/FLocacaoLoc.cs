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
    public partial class FLocacaoLoc : Form
    {
        public FLocacaoLoc()
        {
            InitializeComponent();
        }

        public string codigoretornado
        {

            get { return EDITCODIGO.Text; }
            set { EDITCODIGO.Text = value; }
        
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            //Dados da tabela cadastro
            String tipo, valor;
            tipo = "";
            valor = "";
            if (COMBOTIPOPESQUISA.Text == "Placa")
            {
                tipo = "placa";
                valor = EDITPESQUISA.Text;
            }
            if (COMBOTIPOPESQUISA.Text == "Chassi")
            {
                tipo = "chassi";
                valor = EDITPESQUISA.Text;
            }
            if (COMBOTIPOPESQUISA.Text == "Modelo")
            {
                tipo = "modelo";
                valor = EDITPESQUISA.Text;
            }
            EDITCODIGO.Text = listaGrid(tipo, valor);

        }

        public String listaGrid(string tipo, string valor)
        {

            String strSQL;

            strSQL = "select locacao.*,";
            strSQL = strSQL + " veiculo.marcamodelocodigo, veiculo.placa, veiculo.chassi, veiculo.anofabrica, veiculo.anomodelo, veiculo.combustivel,";
            strSQL = strSQL + " marcamodelo.codigo, marcamodelo.descricao from locacao";
            strSQL = strSQL + " inner join veiculo on veiculo.codigo = locacao.veiculocodigo";
            strSQL = strSQL + " inner join marcamodelo on marcamodelo.codigo = veiculo.marcamodelocodigo";
            strSQL = strSQL + " where locacao.controle is not null";

            LocacaoModelo locacao = new LocacaoModelo();

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

                gridLocacaoLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            return codigoretornado;
        }

        private void gridLocacaoLoc_Click(object sender, EventArgs e)
        {
        }

        private void gridLocacaoLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridLocacaoLoc.Rows[e.RowIndex].Cells["CONTROLE"].Value.ToString();
                this.Close();
            }
        }


    }
}
