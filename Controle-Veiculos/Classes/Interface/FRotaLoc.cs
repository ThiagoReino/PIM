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
using Controle_Veiculos.Classes.Persistencia;


namespace Controle_Veiculos.Classes.Interface
{
    public partial class FRotaLoc : Form
    {
        public FRotaLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Faz o retorno para o form FRota com o resultado Grid
        public String codigoretornado
        {
            get { return EDITCODIGO.Text; }

            set { EDITCODIGO.Text = value; }
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        public void listaGrid(RotaModelo rota)
        {
            string strSQL = "SELECT * FROM ROTA WHERE controle > 0 ";
            EDITCODIGO.Text = Convert.ToString(rota.controle);
            codigoretornado = Convert.ToString(rota.controle);

            if (rota.controle > 0)
            {
                strSQL = strSQL + "and controle = @controle";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (rota.controle > 0)
            {
                objComando.Parameters.AddWithValue("@controle", rota.controle);
            }

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridRotaLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void FRotaLoc_Load(object sender, EventArgs e)
        {

        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            //Dados da tabela cadastro
            RotaModelo rotaModelo = new RotaModelo();

            if (COMBOTIPOPESQUISA.Text == "LOCALDESTINO")
            {
                rotaModelo.localdestino = "%" + EDITPESQUISA.Text + "%";
            }
            listaGrid(rotaModelo);
        }

        private void BOTAOSAIR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridRotaLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridRotaLoc.Rows[e.RowIndex].Cells["CONTROLE"].Value.ToString();
                this.Close();
            }
        }
    }
}
