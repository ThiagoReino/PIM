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
    public partial class FmotoristaLoc : Form
    {
        public FmotoristaLoc()
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


        public void listaGrid(MotoristaModelo motorista)
        {

            string strSQL = "SELECT * FROM MOTORISTA WHERE motorista.codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(motorista.codigo);
            codigoretornado = Convert.ToString(motorista.codigo);

            if (motorista.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (motorista.nome != "" && motorista.nome != null)
            {
                strSQL = strSQL + "and nome like @nome";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (motorista.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", motorista.codigo);
            }
            if (motorista.nome != "" && motorista.nome != null)
            {
                objComando.Parameters.AddWithValue("@nome", motorista.nome);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridMotoristaLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        private void FmotoristaLoc_Load(object sender, EventArgs e)
        {

        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            if (validaFiltrosPesquisa())
            {
            //Dados da tabela cadastro
            MotoristaModelo motorista = new MotoristaModelo();

            if (COMBOTIPOPESQUISA.Text == "NOME")
            {
                motorista.nome = "%" + EDITPESQUISA.Text + "%";

            }
             else if (COMBOTIPOPESQUISA.Text == "CODIGO")
            {
                int WCodigo;
                if (int.TryParse(EDITPESQUISA.Text, out WCodigo))
                {
                    motorista.codigo = WCodigo;
                }
                else
                {
                    MessageBox.Show("O código informado não é um número válido.", "CONTEÚDO DA PESQUISA");
                }
            }
            listaGrid(motorista);
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

        private void EDITPESQUISA_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridMotoristaLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridMotoristaLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }
    }
}
