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
using Controle_Veiculos.Classes.Persistencia;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FprodutoLoc : Form
    {
        public String codigoretornado
        {

            get { return EDITCODIGO.Text; }

            set { EDITCODIGO.Text = value; }

        }

        public FprodutoLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            Boolean wsts;
            wsts = funcoes.validaFiltrosPesquisa(COMBOTIPOPESQUISA.Text, EDITPESQUISA.Text);
            if (wsts == true)
            {
                Boolean statuscampos;
                statuscampos = true;
                //Dados da tabela cadastro
                ProdutoModelo prod = new ProdutoModelo();

                if (COMBOTIPOPESQUISA.Text == "Código") //Código
                {
                    int WCodigo;
                    if (int.TryParse(EDITPESQUISA.Text, out WCodigo))
                    {
                        prod.codigo = WCodigo;
                    }
                    else
                    {
                        MessageBox.Show("O código informado não é um número válido.", "CONTEÚDO DA PESQUISA");
                        statuscampos = false;
                    }
                }
                else if (COMBOTIPOPESQUISA.Text == "Descrição") //Nome / razão
                {
                    if (EDITPESQUISA.Text != "" && EDITPESQUISA.Text != null)
                    {
                        prod.descricao = "%" + EDITPESQUISA.Text + "%";
                    }
                    else
                    {
                        MessageBox.Show("Informe um Nome ou Razão social para pesquisar.", "CONTEÚDO DA PESQUISA");
                        statuscampos = false;
                    }

                }
                if (statuscampos == true)
                {
                    listaGrid(prod);
                }
            }
        }

        public void listaGrid(ProdutoModelo produto)
        {

            string strSQL = "SELECT * FROM PRODUTO WHERE codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(produto.codigo);
            codigoretornado = Convert.ToString(produto.codigo);

            if (produto.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (produto.descricao != "" && produto.descricao != null)
            {
                strSQL = strSQL + "and descricao like @descricao";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (produto.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", produto.codigo);
            }
            if (produto.descricao != "" && produto.descricao != null)
            {
                objComando.Parameters.AddWithValue("@descricao", produto.descricao);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridprodutoLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }


        private void FprodutoLoc_Load(object sender, EventArgs e)
        {

        }

        private void gridprodutoLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridprodutoLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
