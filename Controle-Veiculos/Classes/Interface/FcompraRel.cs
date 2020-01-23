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
using System.Configuration;
using Microsoft.Reporting.WinForms;
using Controle_Veiculos.Classes.ConexaoBanco;


namespace Controle_Veiculos.Classes.Interface
{
    public partial class FcompraRel : Form
    {
        public FcompraRel()
        {
            InitializeComponent();
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        private void FcompraRel_Load(object sender, EventArgs e)
        {
            /*
            String strSQL;

            strSQL = "select * from compra";
            //strSQL = strSQL + "fornecedor.nomerazao as fornecedornomerazao from compra";
            //strSQL = strSQL + " inner join fornecedor on fornecedor.codigo = compra.fornecedorcodigo";
            //strSQL = strSQL + " where compra.controle is not null";

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQL, objConexao);
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);
                
                //DataSet dados = new DataSet();
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                //dados = dtLista;
                ReportDataSource source = new ReportDataSource("DataSetCompraModelo", dtLista);
                //reportViewer1.LocalReport.DataSources.Clear();
                //reportViewer1.LocalReport.DataSources.Add(source);
                //reportViewer1.LocalReport.ReportEmbeddedResource = "RelatorioCompra.rdlc";
                //reportViewer1.Refresh();
                CompraModeloBindingSource.DataSource = source;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no relatorio");
            }*/

            objConexao = new MySqlConnection(conexaoBancoDados);
            objConexao.Open();

            MySqlCommand comando = null;
            MySqlDataReader tabelaDados;
            comando = new MySqlCommand("select * from compra", objConexao);
            tabelaDados = comando.ExecuteReader();
            CompraModelo comp = new CompraModelo();
            while (tabelaDados.Read()) // Lendo registro
            {
            if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CONTROLE")))
            {
               comp.controle = tabelaDados.GetInt32("CONTROLE");
            }
            if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATACOMPRA")))
            {
               comp.datacompra = tabelaDados.GetDateTime("DATACOMPRA");
            }
            if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("FORNECEDORCODIGO")))
            {
               comp.fornecedorcodigo = tabelaDados.GetInt32("FORNECEDORCODIGO");
            }
            if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VALORCOMPRA")))
            {
               comp.valorcompra = tabelaDados.GetDecimal("VALORCOMPRA");
            }
         }
            CompraModeloBindingSource.DataSource = tabelaDados;
            this.reportViewer1.RefreshReport();
            tabelaDados.Close();
         }

        }
    }


