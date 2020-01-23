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
using Controle_Veiculos.Classes.Interface;
using Controle_Veiculos.Classes.Persistencia;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Controle_Veiculos.Classes.Interface
{
    public partial class Fcompracp : Form
    {
        public Fcompracp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public String Wcompracontrole;
        public String Wdatacompra;
        public String Wfornecedorcodigo;
        public String Wfornecedornome;
        public String Wvalorcompra;
        public int Wparcela = 0;

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        private void Fcompracp_Load(object sender, EventArgs e, CompraModelo cp)
        {
        }

        private void Fcompracp_Load(object sender, EventArgs e)
        {

        }

        private void Fcompracp_Load_1(object sender, EventArgs e)
        {
           
            EDITCOMPRACONTROLE.Text = Wcompracontrole;
            EDITCOMPRAFORNECEDORCODIGO.Text = Wfornecedorcodigo;
            EDITCOMPRAFORNECEDORNOMERAZAO.Text = Wfornecedornome;
            EDITCOMPRADATADACOMPRA.Text = Wdatacompra;
            EDITCOMPRAVALORCOMPRA.Text = Wvalorcompra;

            EDITDATAVENCIMENTO.Focus();
        }

        private void EDITDATAVENCIMENTO_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATAVENCIMENTO.Text) == false)
            {
                EDITDATAVENCIMENTO.Clear();
                EDITDATAVENCIMENTO.Focus();
            }

        }

        private void EDITVLRPARCELA_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(EDITVLRPARCELA.Text) && !EDITVLRPARCELA.Text.All(char.IsNumber))
            {
                if (Convert.ToDecimal(EDITVLRPARCELA.Text) <0)
                {
                    MessageBox.Show("O valor informado está inválido");
                    EDITVLRPARCELA.Clear();
                    EDITVLRPARCELA.Focus();
                }
            }
        }

        private void BOTAOGRAVARITEM_Click(object sender, EventArgs e)
        {
            bool werro = false;

            ContapagarModelo contapagar = new ContapagarModelo();

            if (EDITDATAVENCIMENTO.Text != "" && EDITDATAVENCIMENTO.Text != null)
            {
                contapagar.compracontrole = Convert.ToInt32(EDITCOMPRACONTROLE.Text);
            }
            else
            {
                werro = true;
            }
            if (EDITCOMPRAVALORCOMPRA.Text != "" && EDITCOMPRAVALORCOMPRA.Text != null)
            {
                contapagar.vlrfatura = Convert.ToDecimal(EDITCOMPRAVALORCOMPRA.Text);
            }
            else
            {
                werro = true;
            }
            if (EDITVLRPARCELA.Text != "" && EDITVLRPARCELA.Text != null)
            {
                contapagar.vlrparcela = Convert.ToDecimal(EDITVLRPARCELA.Text);
            }
            else
            {
                werro = true;
            }
            if (EDITCOMPRADATADACOMPRA.Text != "" && EDITCOMPRADATADACOMPRA.Text != null)
            {
                contapagar.dataemissao = Convert.ToDateTime(EDITCOMPRADATADACOMPRA.Text);
            }
            else
            {
                werro = true;
            }
            if (EDITDATAVENCIMENTO.Text != "" && EDITDATAVENCIMENTO.Text != null)
            {
                contapagar.datavencimento = Convert.ToDateTime(EDITDATAVENCIMENTO.Text);
            }
            else
            {
                werro = true;
            }
            Wparcela = Wparcela + 1;
            contapagar.parcela = Wparcela;
            if (werro == false)
            {

                ContaPagarControle contapagarcontrole = new ContaPagarControle();
                contapagarcontrole.salvar(contapagar);
                limpaTelaContaPagar();
                AtualizaGridCP();
            }
        }
           public void limpaTelaContaPagar()
        {
            EDITVLRPARCELA.Clear();
            EDITDATAVENCIMENTO.Clear();
        }

                public void AtualizaGridCP()
        {
            String strSQLItem;

            strSQLItem = "select * from contapagar";
            strSQLItem = strSQLItem + " where compracontrole = @compracontrole";
            strSQLItem = strSQLItem + " order by controle desc";
            
            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQLItem, objConexao);

            objComando.Parameters.AddWithValue("@compracontrole", Convert.ToInt32(EDITCOMPRACONTROLE.Text));

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                GridContaPagar.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

                private void button1_Click(object sender, EventArgs e)
                {
                    this.Close();
                }


        }



    }

