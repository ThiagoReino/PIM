using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.ConexaoBanco;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FservicosLoc : Form
    {
        public FservicosLoc()
        {
            InitializeComponent();
        }

        public String codigoretornado
        {

            get { return EDITCODIGO.Text; }

            set { EDITCODIGO.Text = value; }

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
                Boolean statusmanutencao;
                //Dados da tabela cadastro
                ServicoModelo srv = new ServicoModelo();

                if (COMBOTIPOPESQUISA.Text == "Código") //Código
                {
                    int WCodigo;
                    if (int.TryParse(EDITPESQUISA.Text, out WCodigo))
                    {
                        srv.codigo = WCodigo;
                    }
                    else
                    {
                        MessageBox.Show("O código informado não é um número válido.", "CONTEÚDO DA PESQUISA");
                        statusmanutencao = false;
                    }
                }
                else if (COMBOTIPOPESQUISA.Text == "Descrição") //Nome / razão
                {
                    if (EDITPESQUISA.Text != "" && EDITPESQUISA.Text != null)
                    {
                        srv.descricao = "%" + EDITPESQUISA.Text + "%";
                    }
                    else
                    {
                        MessageBox.Show("Informe uma descrição do serviço para pesquisar.", "CONTEÚDO DA PESQUISA");
                        statusmanutencao = false;
                    }
                }
                else
                {
                    statusmanutencao = true;
                    listaGrid(srv);
                }

            }
        }

        public void listaGrid(ServicoModelo servico)
        {

            string strSQL = "SELECT * FROM SERVICO WHERE codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(servico.codigo);
            codigoretornado = Convert.ToString(servico.codigo);

            if (servico.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (servico.descricao != "" && servico.descricao != null)
            {
                strSQL = strSQL + "and descricao like @descricao";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (servico.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", servico.codigo);
            }
            if (servico.descricao != "" && servico.descricao != null)
            {
                objComando.Parameters.AddWithValue("@descricao", servico.descricao);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridservicoLoc.DataSource = dtLista;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridgrupoLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridservicoLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }
    }
}
