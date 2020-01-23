using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Modelo;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class LocacaoPersistencia : Conexao
    {
        MySqlCommand comando = null;

        public void salvar(LocacaoModelo locacao)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO locacao (controle,veiculocodigo,datainiciolocacao,datafimlocacao,valorlocacao) VALUES (@controle,@veiculocodigo,@datainiciolocacao,@datafimlocacao,@valorlocacao)", conexao);
                comando.Parameters.AddWithValue("@controle", locacao.controle);
                comando.Parameters.AddWithValue("@veiculocodigo", locacao.veiculocodigo);
                if (Convert.ToString(locacao.datainiciolocacao) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datainiciolocacao", locacao.datainiciolocacao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datainiciolocacao", null);
                }
                if (Convert.ToString(locacao.datafimlocacao) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datafimlocacao", locacao.datafimlocacao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datafimlocacao", null);
                }
                if (Convert.ToString(locacao.valorlocacao) != "" && Convert.ToString(locacao.valorlocacao) != null)
                {
                    comando.Parameters.AddWithValue("@valorlocacao", locacao.valorlocacao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@valorlocacao", null);
                }

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

        public LocacaoModelo atualizatela(LocacaoModelo locacao)
        {
            try
            {
                string sql;

                AbrirConexao();

                LocacaoModelo loc = new LocacaoModelo();

                MySqlDataReader tabelaDados;

                sql = "select locacao.*,";
                sql = sql + " veiculo.marcamodelocodigo, veiculo.placa, veiculo.chassi, veiculo.anofabrica, veiculo.anomodelo, veiculo.combustivel,";
                sql = sql + " marcamodelo.codigo, marcamodelo.descricao from locacao";
                sql = sql + " inner join veiculo on veiculo.codigo = locacao.veiculocodigo";
                sql = sql + " inner join marcamodelo on marcamodelo.codigo = veiculo.marcamodelocodigo";

                comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@controle", locacao.controle);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CONTROLE")))
                    {
                        loc.controle = tabelaDados.GetInt32("CONTROLE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VEICULOCODIGO")))
                    {
                        loc.veiculocodigo = tabelaDados.GetInt32("VEICULOCODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAINICIOLOCACAO")))
                    {
                        loc.datainiciolocacao = tabelaDados.GetDateTime("DATAINICIOLOCACAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAFIMLOCACAO")))
                    {
                        loc.datafimlocacao = tabelaDados.GetDateTime("DATAFIMLOCACAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VALORLOCACAO")))
                    {
                        loc.valorlocacao = tabelaDados.GetInt32("VALORLOCACAO");
                    }
                }
                tabelaDados.Close();
                return loc;

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

        public void alterar(LocacaoModelo locacao)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update locacao set controle =@controle, veiculocodigo =@veiculocodigo, datainiciolocacao =@datainiciolocacao, datafimlocacao =@datafimlocacao, valorlocacao =@valorlocacao where controle= @controle", conexao);
                comando.Parameters.AddWithValue("@controle", locacao.controle);
                comando.Parameters.AddWithValue("@veiculocodigo", locacao.veiculocodigo);
                if (Convert.ToString(locacao.datainiciolocacao) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datainiciolocacao", locacao.datainiciolocacao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datainiciolocacao", null);
                }
                if (Convert.ToString(locacao.datafimlocacao) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datafimlocacao", locacao.datafimlocacao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datafimlocacao", null);
                }
                if (Convert.ToString(locacao.valorlocacao) != "" && Convert.ToString(locacao.valorlocacao) != null)
                {
                    comando.Parameters.AddWithValue("@valorlocacao", locacao.valorlocacao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@valorlocacao", null);
                }
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

        public void excluir(LocacaoModelo locacao)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from locacao where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@codigo", locacao.controle);
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

