using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace Controle_Veiculos.Classes.ConexaoBanco
{
    public class Conexao
    {
        string conexaoBancoDados = System.Configuration.ConfigurationManager.ConnectionStrings["conexaoPim"].ConnectionString;
        //string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        protected MySqlConnection conexao = null;

        //Metodo para conectar no banco
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conexaoBancoDados);
                conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro de Conexao com o banco de dados!");
                //throw erro;
            }
        }

        public void iniciatransacao(MySqlTransaction transacao)
        {
           
            transacao = conexao.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void finalizatransacao(MySqlTransaction transacao)
        {
          
            transacao.Commit();
            
        }

        public void anulatransacao(MySqlTransaction transacao)
        {

            transacao.Rollback();

        }

        
        //Metodo para fechar a conexao com o banco
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conexaoBancoDados);
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
