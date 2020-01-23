using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Model;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class ContaPagarPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public void salvar(ContapagarModelo contapagar)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO contapagar(controle, compracontrole, parcela, dataemissao, datavencimento, datapagamento, vlrfatura, vlrparcela) VALUES (@controle, @compracontrole, @parcela, @dataemissao, @datavencimento, @datapagamento, @vlrfatura, @vlrparcela)", conexao);
                comando.Parameters.AddWithValue("@controle", contapagar.controle);
                comando.Parameters.AddWithValue("@compracontrole", contapagar.compracontrole);
                comando.Parameters.AddWithValue("@parcela", contapagar.parcela);
                if (Convert.ToString(contapagar.dataemissao) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@dataemissao", contapagar.dataemissao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@dataemissao", null);
                }
                if (Convert.ToString(contapagar.datavencimento) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datavencimento", contapagar.datavencimento);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datavencimento", null);
                }
                if (Convert.ToString(contapagar.datapagamento) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datapagamento", contapagar.datapagamento);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datapagamento", null);
                }
                comando.Parameters.AddWithValue("@vlrfatura", contapagar.vlrfatura);
                comando.Parameters.AddWithValue("@vlrparcela", contapagar.vlrparcela);
                comando.ExecuteNonQuery();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("SELECT LAST_INSERT_ID() as CONTROLE", conexao);


                // Executa a consulta

                tabelaDados = comando.ExecuteReader();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void alterar(ContapagarModelo contapagar)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update contapagar set controle =@controle, compracontrole =@compracontrole, parcela =@parcela, dataemissao =@dataemissao, datavencimento =@datavencimento, datapagamento =@datapagamento, vlrfatura =@vlrfatura, vlrparcela =@vlrparcela  where controle=@controle", conexao);
                comando.Parameters.AddWithValue("@controle", contapagar.controle);
                comando.Parameters.AddWithValue("@compracontrole", contapagar.compracontrole);
                comando.Parameters.AddWithValue("@parcela", contapagar.parcela);
                comando.Parameters.AddWithValue("@dataemissao", contapagar.dataemissao);
                comando.Parameters.AddWithValue("@datavencimento", contapagar.datavencimento);
                comando.Parameters.AddWithValue("@datapagamento", contapagar.datapagamento);
                comando.Parameters.AddWithValue("@vlrfatura", contapagar.vlrfatura);
                comando.Parameters.AddWithValue("@vlrparcela", contapagar.vlrparcela);
                comando.ExecuteNonQuery();
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void excluir(ContapagarModelo contapagar)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from controle where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@controle", contapagar.controle);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
