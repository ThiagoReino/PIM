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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FfornecedorLoc : Form
    {
        public FfornecedorLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public String codigoretornado
        {

            get { return EDITCODIGO.Text; }

            set { EDITCODIGO.Text = value; }

        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;


        public void listaGrid(FornecedorModelo fornecedor)
        {

            string strSQL = "SELECT * FROM FORNECEDOR WHERE codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(fornecedor.codigo);
            codigoretornado = Convert.ToString(fornecedor.codigo);

            if (fornecedor.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (fornecedor.nomerazao != "" && fornecedor.nomerazao != null)
            {
                strSQL = strSQL + "and nomerazao like @nomerazao";
            }
            if (fornecedor.nomefantasia != "" && fornecedor.nomefantasia != null)
            {
                strSQL = strSQL + "and nomefantasia like @nomefantasia";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (fornecedor.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", fornecedor.codigo);
            }
            if (fornecedor.nomerazao != "" && fornecedor.nomerazao != null)
            {
                objComando.Parameters.AddWithValue("@nomerazao", fornecedor.nomerazao);
            }
            if (fornecedor.nomefantasia != "" && fornecedor.nomefantasia != null)
            {
                objComando.Parameters.AddWithValue("@nomefantasia", fornecedor.nomefantasia);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridfornecedorLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            Boolean statuscampos;
            statuscampos = true;

            if (validaFiltrosPesquisa())
            {
                //Dados da tabela cadastro
                FornecedorModelo fornecedor = new FornecedorModelo();

                if (COMBOTIPOPESQUISA.Text == "Código") //Código
                {
                    int WCodigo;
                    if (int.TryParse(EDITPESQUISA.Text, out WCodigo))
                    {
                        fornecedor.codigo = WCodigo;
                    }
                    else
                    {
                        MessageBox.Show("O código informado não é um número válido.", "CONTEÚDO DA PESQUISA");
                        statuscampos = false;
                    }
                }
                else if (COMBOTIPOPESQUISA.Text == "Nome/Razão Social") //Nome / razão
                {
                    if (EDITPESQUISA.Text != "" && EDITPESQUISA.Text != null)
                    {
                        fornecedor.nomerazao = "%" + EDITPESQUISA.Text + "%";
                    }
                    else
                    {
                        MessageBox.Show("Informe um Nome ou Razão social para pesquisar.", "CONTEÚDO DA PESQUISA");
                        statuscampos = false;
                    }
                    
                }
                else if (COMBOTIPOPESQUISA.Text == "Nome Fantasia") //Nome fantasia
                {
                    if (EDITPESQUISA.Text != "" && EDITPESQUISA.Text != null)
                    {
                        fornecedor.nomefantasia = "%" + EDITPESQUISA.Text + "%";
                    }
                    else
                    {
                        MessageBox.Show("Informe um nome fantasia ou apelido para pesquisar.", "CONTEÚDO DA PESQUISA"); 
                        statuscampos = false;
                    }
                }
                if (statuscampos == true)
                {
                    listaGrid(fornecedor);
                }
            }
        }

        public Boolean validaFiltrosPesquisa()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITPESQUISA.Text) && !string.IsNullOrEmpty(COMBOTIPOPESQUISA.Text))
            {
                MessageBox.Show("Informe o conteúdo para pesquisa ou deixar em branco para todos.", "CONTEÚDO DO CAMPO PESQUISA");
                resultado = false;
            }
            else if (!String.IsNullOrEmpty(EDITPESQUISA.Text) && string.IsNullOrEmpty(COMBOTIPOPESQUISA.Text))
            {
                MessageBox.Show("Selecione o tipo de campo a pesquisar.", "SELECIONE TIPO PESQUISA");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridfornecedorLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridfornecedorLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }

        private void FfornecedorLoc_Load(object sender, EventArgs e)
        {

        }
    }
}
