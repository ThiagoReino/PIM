using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.Modelo;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FMarcamodeloLoc : Form
    {
        public FMarcamodeloLoc()
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

        public void listaGrid(MarcamodeloModelo marcamodelo)
        {
            string strSQL = "SELECT * FROM MARCAMODELO WHERE codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(marcamodelo.codigo);
            codigoretornado = Convert.ToString(marcamodelo.codigo);

            if (marcamodelo.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (marcamodelo.descricao != "" && marcamodelo.descricao != null)
            {
                strSQL = strSQL + "and descricao like @descricao";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (marcamodelo.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", marcamodelo.codigo);
            }
            if (marcamodelo.descricao != "" && marcamodelo.descricao != null)
            {
                objComando.Parameters.AddWithValue("@descricao", marcamodelo.descricao);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridMarcaLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro de Leitura da Tabela Marca!");
                //throw erro;
            }
        }
            
        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            MarcamodeloModelo marcamodelo = new MarcamodeloModelo();

            if (COMBOTIPOPESQUISA.Text == "NOME")
            {
                marcamodelo.descricao = "%" + EDITPESQUISA.Text + "%";
            }
            else if(COMBOTIPOPESQUISA.Text == "CODIGO")
            {
                int WCodigo;
                if (int.TryParse(EDITPESQUISA.Text, out WCodigo))
                {
                    marcamodelo.codigo = WCodigo;
                }
                else
                {
                    MessageBox.Show("O código informado não é um número válido.", "CONTEÚDO DA PESQUISA");
                }
            }
            listaGrid(marcamodelo);
        }

        private void FMarcaLoc_Load(object sender, EventArgs e)
        {

        }

        private void gridMarcaLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridMarcaLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
