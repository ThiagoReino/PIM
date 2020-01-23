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
    public partial class FGrupoLoc : Form
    {
        public FGrupoLoc()
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
                GrupoModelo gru = new GrupoModelo();

                if (COMBOTIPOPESQUISA.Text == "Código") //Código
                {
                    int WCodigo;
                    if (int.TryParse(EDITPESQUISA.Text, out WCodigo))
                    {
                        gru.codigo = WCodigo;
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
                        gru.descricao = "%" + EDITPESQUISA.Text + "%";
                    }
                    else
                    {
                        MessageBox.Show("Informe um Nome ou Razão social para pesquisar.", "CONTEÚDO DA PESQUISA");
                        statuscampos = false;
                    }

                }
                if (statuscampos == true)
                {
                    listaGrid(gru);
                }


            }
        }


        public void listaGrid(GrupoModelo grupo)
        {

            string strSQL = "SELECT * FROM GRUPO WHERE codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(grupo.codigo);
            codigoretornado = Convert.ToString(grupo.codigo);

            if (grupo.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (grupo.descricao != "" && grupo.descricao != null)
            {
                strSQL = strSQL + "and descricao like @descricao";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (grupo.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", grupo.codigo);
            }
            if (grupo.descricao != "" && grupo.descricao != null)
            {
                objComando.Parameters.AddWithValue("@descricao", grupo.descricao);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridgrupoLoc.DataSource = dtLista;

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
                codigoretornado = gridgrupoLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }

        private void FGrupoLoc_Load(object sender, EventArgs e)
        {

        }
    }
}

