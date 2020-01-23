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
using MySql.Data;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FocorrenciaLoc : Form
    {
        public FocorrenciaLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FocorrenciaLoc_Load(object sender, EventArgs e)
        {

        }

        public String codigoretornado
        {

            get { return EDITCODIGO.Text; }

            set { EDITCODIGO.Text = value; }

        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null; //tirei porque compilador disse que nunca foi usado (analisar pq colocou)

        MySqlCommand objComando = null;

        public void listaGrid(OcorrenciaModelo ocorrencia)
        {
            string strSQL = "SELECT * FROM OCORRENCIA WHERE controle > 0 ";
            EDITCODIGO.Text = Convert.ToString(ocorrencia.controle);
            codigoretornado = Convert.ToString(ocorrencia.controle);

            if (ocorrencia.controle > 0)
            {
                strSQL = strSQL + "and controle = @controle";
            }
            /*
            if (ocorrencia.dataocorrencia != null)
            {
                strSQL = strSQL + "and dataocorrencia like @dataocorrencia";
            }*/

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (ocorrencia.controle > 0)
            {
                objComando.Parameters.AddWithValue("@controle", ocorrencia.controle);
            }
            /*if (ocorrencia.dataocorrencia != null)
            {
                objComando.Parameters.AddWithValue("@dataocorrencia", ocorrencia.dataocorrencia);
            }*/
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridOcorrenciaLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void gridOcorrenciaLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridOcorrenciaLoc.Rows[e.RowIndex].Cells["CONTROLE"].Value.ToString();
                this.Close();
            }
        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            //Dados da tabela cadastro
            OcorrenciaModelo ocorrencia = new OcorrenciaModelo();
            
            if (COMBOTIPOPESQUISA.Text == "CONTROLE")
            {
                ocorrencia.controle = Convert.ToInt32("%" + EDITPESQUISA.Text + "%");
            }
            listaGrid(ocorrencia);
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
