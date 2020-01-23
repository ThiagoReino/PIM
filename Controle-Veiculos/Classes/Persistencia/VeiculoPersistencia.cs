using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Modelo;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class VeiculoPersistencia : Conexao
    {

        MySqlCommand comando = null;

        //Metodo salvar
        public int salvar(VeiculoModelo veiculo)
        {
            MySqlTransaction transacao;
            try
            {
                AbrirConexao();

                transacao = conexao.BeginTransaction();
                comando = new MySqlCommand("INSERT INTO veiculo(codigo, marcamodelocodigo, placa, chassi, combustivel, anofabrica, anomodelo, codigorenavan, exercicio, situacao, datavenda, valorvenda, databaixa, motivobaixa, seguradoracodigo, datainiciovigencia, datafimvigencia) VALUES (@codigo, @marcamodelocodigo, @placa, @chassi, @combustivel, @anofabrica, @anomodelo, @codigorenavan, @exercicio, @situacao, @datavenda, @valorvenda, @databaixa, @motivobaixa, @seguradoracodigo, @datainiciovigencia, @datafimvigencia)", conexao);
                comando.Parameters.AddWithValue("@codigo", veiculo.codigo);
                comando.Parameters.AddWithValue("@marcamodelocodigo", veiculo.marcamodelocodigo);
                comando.Parameters.AddWithValue("@placa", veiculo.placa);
                comando.Parameters.AddWithValue("@chassi", veiculo.chassi);
                comando.Parameters.AddWithValue("@combustivel", veiculo.combustivel);
                comando.Parameters.AddWithValue("@anofabrica", veiculo.anofabrica);
                comando.Parameters.AddWithValue("@anomodelo", veiculo.anomodelo);
                comando.Parameters.AddWithValue("@codigorenavan", veiculo.codigorenavan);
                comando.Parameters.AddWithValue("@exercicio", veiculo.exercicio);
                comando.Parameters.AddWithValue("@situacao", veiculo.situacao);
                if (Convert.ToString(veiculo.datavenda) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datavenda", veiculo.datavenda);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datavenda", null);
                }
                comando.Parameters.AddWithValue("@valorvenda", veiculo.valorvenda);
                if (Convert.ToString(veiculo.databaixa) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@databaixa", veiculo.databaixa);
                }
                else
                {
                    comando.Parameters.AddWithValue("@databaixa", null);
                }
                comando.Parameters.AddWithValue("@motivobaixa", veiculo.motivobaixa);
                comando.Parameters.AddWithValue("@seguradoracodigo", veiculo.seguradoracodigo);
                if (Convert.ToString(veiculo.datainiciovigencia) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datainiciovigencia", veiculo.datainiciovigencia);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datainiciovigencia", null);
                }
                if (Convert.ToString(veiculo.datafimvigencia) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datafimvigencia", veiculo.datafimvigencia);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datafimvigencia", null);
                }
                comando.ExecuteNonQuery();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("SELECT LAST_INSERT_ID() as CONTROLE", conexao);
                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                // Verifica se retornou pelo menos um registro
                int codigogerado = 0;
                while (tabelaDados.Read()) // Lendo registro
                {
                    codigogerado = tabelaDados.GetInt32(0);
                }

                tabelaDados.Close();

                transacao.Commit();

                return codigogerado;

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

        //Metodo alterar
        public void alterar(VeiculoModelo veiculo)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update veiculo set marcamodelocodigo =@marcamodelocodigo, placa =@placa, chassi =@chassi, combustivel =@combustivel, anofabrica =@anofabrica, anomodelo = @anomodelo, codigorenavan =@codigorenavan, exercicio =@exercicio, situacao =@situacao, datavenda =@datavenda, valorvenda =@valorvenda, databaixa =@databaixa, motivobaixa =@motivobaixa, seguradoracodigo =@seguradoracodigo, datainiciovigencia =@datainiciovigencia, datafimvigencia =@datafimvigencia where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", veiculo.codigo);
                comando.Parameters.AddWithValue("@marcamodelocodigo", veiculo.marcamodelocodigo);
                comando.Parameters.AddWithValue("@placa", veiculo.placa);
                comando.Parameters.AddWithValue("@chassi", veiculo.chassi);
                comando.Parameters.AddWithValue("@combustivel", veiculo.combustivel);
                comando.Parameters.AddWithValue("@anofabrica", veiculo.anofabrica);
                comando.Parameters.AddWithValue("@anomodelo", veiculo.anomodelo);
                comando.Parameters.AddWithValue("@codigorenavan", veiculo.codigorenavan);
                comando.Parameters.AddWithValue("@exercicio", veiculo.exercicio);
                comando.Parameters.AddWithValue("@situacao", veiculo.situacao);
                if (Convert.ToString(veiculo.datavenda) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datavenda", veiculo.datavenda);
                }
                comando.Parameters.AddWithValue("@valorvenda", veiculo.valorvenda);
                if (Convert.ToString(veiculo.databaixa) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@databaixa", veiculo.databaixa);
                }
                comando.Parameters.AddWithValue("@motivobaixa", veiculo.motivobaixa);
                comando.Parameters.AddWithValue("@seguradoracodigo", veiculo.seguradoracodigo);
                if (Convert.ToString(veiculo.datainiciovigencia) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datainiciovigencia", veiculo.datainiciovigencia);
                }
                if (Convert.ToString(veiculo.datafimvigencia) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datafimvigencia", veiculo.datafimvigencia);
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

        public void excluir(VeiculoModelo veiculo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM VEICULO WHERE CODIGO = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", veiculo.codigo);

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

        public VeiculoModelo atualizatela(VeiculoModelo veiculo)
        {
            try
            {
                AbrirConexao();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from veiculo where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", veiculo.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                VeiculoModelo vei = new VeiculoModelo();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        vei.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("MARCAMODELOCODIGO")))
                    {
                        vei.marcamodelocodigo = tabelaDados.GetInt32("MARCAMODELOCODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("PLACA")))
                    {
                        vei.placa = tabelaDados.GetString("PLACA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CHASSI")))
                    {
                        vei.chassi = tabelaDados.GetString("CHASSI");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("COMBUSTIVEL")))
                    {
                        vei.combustivel = tabelaDados.GetString("COMBUSTIVEL");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("ANOFABRICA")))
                    {
                        vei.anofabrica = tabelaDados.GetInt32("ANOFABRICA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("ANOMODELO")))
                    {
                        vei.anomodelo = tabelaDados.GetInt32("ANOMODELO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("SITUACAO")))
                    {
                        vei.situacao = tabelaDados.GetString("SITUACAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGORENAVAN")))
                    {
                        vei.codigorenavan = tabelaDados.GetString("CODIGORENAVAN");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("EXERCICIO")))
                    {
                        vei.exercicio = tabelaDados.GetInt32("EXERCICIO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAVENDA")))
                    {
                        vei.datavenda = tabelaDados.GetDateTime("DATAVENDA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VALORVENDA")))
                    {
                        vei.valorvenda = tabelaDados.GetDecimal("VALORVENDA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATABAIXA")))
                    {
                        vei.databaixa = tabelaDados.GetDateTime("DATABAIXA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("MOTIVOBAIXA")))
                    {
                        vei.motivobaixa = tabelaDados.GetString("MOTIVOBAIXA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("SEGURADORACODIGO")))
                    {
                        vei.seguradoracodigo = tabelaDados.GetInt32("SEGURADORACODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAINICIOVIGENCIA")))
                    {
                        vei.datainiciovigencia = tabelaDados.GetDateTime("DATAINICIOVIGENCIA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAFIMVIGENCIA")))
                    {
                        vei.datafimvigencia = tabelaDados.GetDateTime("DATAFIMVIGENCIA");
                    }
                }

                tabelaDados.Close();
                return vei;

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
