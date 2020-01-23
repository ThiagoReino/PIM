using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Model;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.View;
using System.IO;


namespace Controle_Veiculos.Classes.View
{
    public partial class FpessoaLoc : Form
    {
        
        public FpessoaLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            frmMotorista pessoa = new frmMotorista();
        }

        public String codigoretornado
        {

            get { return EDITCODIGO.Text; }

            set { EDITCODIGO.Text = value; }

        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

       /* public void listaGrid(Cadastro cadastro)
        {
            string strSQL = "SELECT * FROM cadastro WHERE codigo > 0 ";

            if (cadastro.codigo > 0)
            {
                strSQL = strSQL + " and codigo = @codigo";

            }
            if (cadastro.razaosocial != "" && cadastro.razaosocial != null)
            {
                strSQL = strSQL + " and razaosocial like @razaosocial";
            }
            if (cadastro.cpfcnpj != "" && cadastro.cpfcnpj != null)
            {
                strSQL = strSQL + "and cpfcnpj like @cpfcnpj";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (cadastro.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", cadastro.codigo);
            }
            if (cadastro.razaosocial != "" && cadastro.razaosocial != null)
            {
                objComando.Parameters.AddWithValue("@razaosocial", cadastro.razaosocial);
            }
            if (cadastro.cpfcnpj != "" && cadastro.cpfcnpj != null)
            {
                objComando.Parameters.AddWithValue("@cpfcnpj", cadastro.cpfcnpj);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridPessoaLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {

                //Dados da tabela cadastro
                Cadastro cadastro = new Cadastro();

                if (COMBOTIPOPESQUISA.Text == "CODIGO")
                {
                    cadastro.codigo = Int32.Parse(EDITPESQUISA.Text);
                }
                else if (COMBOTIPOPESQUISA.Text == "NOME")
                {
                    cadastro.razaosocial = "%" + EDITPESQUISA.Text + "%";
                   
                }
                else if (COMBOTIPOPESQUISA.Text == "CPF")
                {
                    cadastro.cpfcnpj = "%" + EDITPESQUISA.Text + "%";
                   
                }
                listaGrid(cadastro);

        }
        */
        private void tsbLimparTela_Click(object sender, EventArgs e)
        {
            COMBOTIPOPESQUISA.Text = " ";
            EDITPESQUISA.Clear();
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FpessoaLoc_Load(object sender, EventArgs e)
        {
            COMBOTIPOPESQUISA.Text = "NOME";
        }

        private void EDITPESQUISA_Click(object sender, EventArgs e)
        {
            if (COMBOTIPOPESQUISA.Text == "")
            {
                MessageBox.Show("Informe o tipo de pesquisa que deseja realizar", "Selecione Tipo Pesquisa");
            }
        }

        private void gridPessoaLoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            codigoretornado = gridPessoaLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
            this.Close();
        }
    }
}
