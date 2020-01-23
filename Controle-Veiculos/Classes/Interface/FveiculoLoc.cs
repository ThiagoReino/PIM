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
using Controle_Veiculos.Classes.Modelo;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class frmVeiculoLoc : Form
    {

        public frmVeiculoLoc()
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

        MySqlConnection objConexao = null; //tirei porque compilador disse que nunca foi usado (analisar pq colocou)

        MySqlCommand objComando = null;

        public void listaGrid(VeiculoModelo modelo)
        {
            string strSQL = "SELECT * FROM VEICULO WHERE codigo > 0 ";
            EDITCODIGO.Text = Convert.ToString(modelo.codigo);
            codigoretornado = Convert.ToString(modelo.codigo);

            if (modelo.codigo > 0)
            {
                strSQL = strSQL + "and codigo = @codigo";
            }
            if (modelo.placa != "" && modelo.placa != null)
            {
                strSQL = strSQL + "and placa like @placa";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (modelo.codigo > 0)
            {
                objComando.Parameters.AddWithValue("@codigo", modelo.codigo);
            }
            if (modelo.placa != "" && modelo.placa != null)
            {
                objComando.Parameters.AddWithValue("@placa", modelo.placa);
            }
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridVeiculoLoc.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void BOTAOPESQUISA_Click(object sender, EventArgs e)
        {
            //Dados da tabela cadastro
            VeiculoModelo veiculoModelo = new VeiculoModelo();

            if (COMBOTIPOPESQUISA.Text == "PLACA")
            {
                veiculoModelo.placa = "%" + EDITPESQUISA.Text + "%";
            }
            listaGrid(veiculoModelo);
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridVeiculoLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para selecionar um registro clique sobre o dado desejado na tabela.");
            }
            else
            {
                codigoretornado = gridVeiculoLoc.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
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

        private void frmVeiculoLoc_Load(object sender, EventArgs e)
        {

        }
    }
}
