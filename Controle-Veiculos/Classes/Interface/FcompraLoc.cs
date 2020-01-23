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
    public partial class FcompraLoc : Form
    {
        public FcompraLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            //Dados da tabela para pesquisa
            String tipo, valor;
            tipo = "";
            valor = "";
            if (COMBOTIPOPESQUISA.Text == "Nº compra")
            {
                tipo = "controle";
                valor = EDITPESQUISA.Text;
            }
            if (COMBOTIPOPESQUISA.Text == "Data da compra")
            {
                tipo = "datacompra";
                valor = EDITPESQUISA.Text;
            }
            if (COMBOTIPOPESQUISA.Text == "Código do fornecedor")
            {
                tipo = "codigofornecedor";
                valor = EDITPESQUISA.Text;
            }
            EDITCODIGO.Text = listaGrid(tipo, valor);

        }

        public String listaGrid(string tipo, string valor)
        {

            String strSQL;

            strSQL = "select compra.*,";
            strSQL = strSQL + "fornecedor.nomerazao as fornecedornomerazao from compra";
            strSQL = strSQL + " inner join fornecedor on fornecedor.codigo = compra.fornecedorcodigo";
            strSQL = strSQL + " where compra.controle is not null";

            LocacaoModelo locacao = new LocacaoModelo();

            if (tipo == "controle" && (valor != "" || valor != null))
            {
                strSQL = strSQL + "and compra.controle = @controle";
            }
            if (tipo == "datacompra" && (valor != "" || valor != null))
            {
                strSQL = strSQL + "and compra.datacompra = @datacompra";
            }
            if (tipo == "codigofornecedor" && (valor != "" || valor != null))
            {
                strSQL = strSQL + "and compra.fornecedorcodigo = @codigofornecedor";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);
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


        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLocacaoLoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void FcompraLoc_Load(object sender, EventArgs e)
        {

        }
    }
}
