using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FseguradoraLoc : Form
    {
        public FseguradoraLoc()
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

        private void gridfornecedorLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridseguradoraLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridseguradoraLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }

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
                SeguradoraModelo segur = new SeguradoraModelo();

                if (COMBOTIPOPESQUISA.Text == "Código") //Código
                {
                    int WCodigo;
                    if (int.TryParse(EDITPESQUISA.Text, out WCodigo))
                    {
                        segur.codigo = WCodigo;
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
                        segur.nome = "%" + EDITPESQUISA.Text + "%";
                    }
                    else
                    {
                        MessageBox.Show("Informe parte ou nome completo para pesquisar.", "CONTEÚDO DA PESQUISA");
                        statuscampos = false;
                    }

                }
                if (statuscampos == true)
                {
                    listaGrid(segur);
                }
            }
        }
        public void listaGrid(SeguradoraModelo seguradora)
        {

            string strSQL = "SELECT * FROM SEGURADORA WHERE codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(seguradora.codigo);
            codigoretornado = Convert.ToString(seguradora.codigo);

            if (seguradora.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (seguradora.nome != "" && seguradora.nome != null)
            {
                strSQL = strSQL + "and nome like @nome";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (seguradora.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", seguradora.codigo);
            }
            if (seguradora.nome != "" && seguradora.nome != null)
            {
                objComando.Parameters.AddWithValue("@nome", seguradora.nome);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridseguradoraLoc.DataSource = dtLista;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void FseguradoraLoc_Load(object sender, EventArgs e)
        {

        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
