using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Model;


namespace Controle_Veiculos.Classes.Interface
{
    public partial class FproLoc : Form
    {

        public String codigoretornado
        {

            get { return EDITPROCODIGO.Text; }

            set { EDITPROCODIGO.Text = value; }

        }

        public FproLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        public void listaGrid(ProdutoModelo produto)
        {
            string strSQL = "SELECT * FROM produto WHERE produto.codigo > 0 ";
            EDITPROCODIGO.Text = Convert.ToString(produto.codigo);
            codigoretornado = Convert.ToString(produto.codigo);
          
            if (produto.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
                //EDITPROCODIGO.Text = Convert.ToString(produto.codigo);
                //codigoretornado = Convert.ToString(produto.codigo);
            }
            if (produto.descricao != "" && produto.descricao != null)
            {
                strSQL = strSQL + "and descricao like @descricao";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (produto.codigo > 0) {
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

                gridProLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            
                //Dados da tabela cadastro
                ProdutoModelo produto = new ProdutoModelo();

                if (COMBOTIPOPESQUISA.Text == "CODIGO")
                {
                    produto.codigo = Int32.Parse(EDITPESQUISA.Text);
                    
                }
                else if (COMBOTIPOPESQUISA.Text == "DESCRICAO")
                {
                    produto.descricao = "%"+ EDITPESQUISA.Text +"%";
                   
                }
                listaGrid(produto);
        }

        private void tsbLimparTela_Click(object sender, EventArgs e)
        {
            COMBOTIPOPESQUISA.Text = "";
            EDITPESQUISA.Clear();
        }

        private void gridProLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoretornado = gridProLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
            this.Close();
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EDITPESQUISA_Click(object sender, EventArgs e)
        {
            if (COMBOTIPOPESQUISA.Text == "")
            {
                MessageBox.Show("Informe o tipo de pesquisa que deseja realizar");
            }
        }

        private void FproLoc_Load(object sender, EventArgs e)
        {
            COMBOTIPOPESQUISA.Text = "DESCRICAO";
        }
    }
}
