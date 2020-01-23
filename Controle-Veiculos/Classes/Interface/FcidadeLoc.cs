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
    public partial class FcidadeLoc : Form
    {
        public FcidadeLoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public String codigoretornado
        {

            get { return EDITPROCODIGO.Text; }

            set { EDITPROCODIGO.Text = value; }

        }


        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        public void listaGrid(CidadeModelo cidade)
        {
            string strSQL = "SELECT * FROM CIDADE WHERE cidade.controle > 0 ";
            EDITPROCODIGO.Text = Convert.ToString(cidade.controle);
            codigoretornado = Convert.ToString(cidade.controle);

            if (cidade.controle > 0)
            {
                strSQL = strSQL + "and controle = @controle";
            }
            if (cidade.nome != "" && cidade.nome != null)
            {
                strSQL = strSQL + "and nome like @nome";
            }

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);

            if (cidade.controle > 0)
            {
                objComando.Parameters.AddWithValue("@controle", cidade.controle);
            }
            if (cidade.nome != "" && cidade.nome != null)
            {
                objComando.Parameters.AddWithValue("@nome", cidade.nome);
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
            CidadeModelo cidade = new CidadeModelo();

            cidade.nome = "%" + EDITPESQUISA.Text + "%";

            listaGrid(cidade);
        }

        private void EDITPESQUISA_TextChanged(object sender, EventArgs e)
        {
            CidadeModelo cidade = new CidadeModelo();

            cidade.nome = "%" + EDITPESQUISA.Text + "%";

            listaGrid(cidade);
        }

        private void gridMotoristaLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoretornado = gridMotoristaLoc.Rows[e.RowIndex].Cells["CONTROLE"].Value.ToString();
            this.Close();
        }
    }
}
