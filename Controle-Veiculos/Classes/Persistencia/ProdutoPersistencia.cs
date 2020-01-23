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
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class ProdutoPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public int salvar(ProdutoModelo produto)
        {
            MySqlTransaction transacao;

            try
            {
                AbrirConexao();
                transacao = conexao.BeginTransaction();

                comando = new MySqlCommand("INSERT INTO produto(codigo, descricao, unidade, situacao, grupocodigo, custo, customedio, dataultimacompra, dataultimasaida, estoque ) VALUES (@codigo, @descricao, @unidade, @situacao, @grupocodigo, @custo, @customedio, @dataultimacompra, @dataultimasaida, @estoque)", conexao);
                comando.Parameters.AddWithValue("@codigo", produto.codigo);
                comando.Parameters.AddWithValue("@descricao", produto.descricao);
                comando.Parameters.AddWithValue("@unidade", produto.unidade);
                comando.Parameters.AddWithValue("@situacao", produto.situacao);
                comando.Parameters.AddWithValue("@grupocodigo", produto.grupocodigo);
                comando.Parameters.AddWithValue("@custo", produto.custo);
                comando.Parameters.AddWithValue("@customedio", produto.customedio);
                if (Convert.ToString(produto.dataultimacompra) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@dataultimacompra", produto.dataultimacompra);
                }
                else
                {
                    comando.Parameters.AddWithValue("@dataultimacompra", null);
                }
                if (Convert.ToString(produto.dataultimasaida) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@dataultimasaida", produto.dataultimasaida);
                }
                else
                {
                    comando.Parameters.AddWithValue("@dataultimasaida", null);
                }
                comando.Parameters.AddWithValue("@estoque", produto.estoque);
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

        public void alterar(ProdutoModelo produto)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update produto set  codigo =@codigo, descricao =@descricao, unidade =@unidade, situacao =@situacao, grupocodigo =@grupocodigo, custo =@custo, customedio =@customedio, dataultimacompra =@dataultimacompra, dataultimasaida =@dataultimasaida, estoque =@estoque where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", produto.codigo);
                comando.Parameters.AddWithValue("@descricao", produto.descricao);
                comando.Parameters.AddWithValue("@unidade", produto.unidade);
                comando.Parameters.AddWithValue("@situacao", produto.situacao);
                comando.Parameters.AddWithValue("@grupocodigo", produto.grupocodigo);
                comando.Parameters.AddWithValue("@custo", produto.custo);
                comando.Parameters.AddWithValue("@customedio", produto.customedio);
                comando.Parameters.AddWithValue("@dataultimacompra", produto.dataultimacompra);
                comando.Parameters.AddWithValue("@dataultimasaida", produto.dataultimasaida);
                comando.Parameters.AddWithValue("@estoque", produto.estoque);
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

        public void excluir(ProdutoModelo produto)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM PRODUTO WHERE CODIGO = @CODIGO", conexao);
                comando.Parameters.AddWithValue("@codigo", produto.codigo);
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

        public ProdutoModelo atualizatela(ProdutoModelo produto)
        {
            try
            {
                AbrirConexao();
                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from produto where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", produto.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();
                ProdutoModelo prod = new ProdutoModelo();
                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        prod.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DESCRICAO")))
                    {
                        prod.descricao = tabelaDados.GetString("DESCRICAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("UNIDADE")))
                    {
                        prod.unidade = tabelaDados.GetString("UNIDADE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("SITUACAO")))
                    {
                        prod.situacao = tabelaDados.GetString("SITUACAO");
                    }

                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("GRUPOCODIGO")))
                    {
                        prod.grupocodigo = tabelaDados.GetInt32("GRUPOCODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CUSTO")))
                    {
                        prod.custo = tabelaDados.GetDecimal("CUSTO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CUSTOMEDIO")))
                    {
                        prod.customedio = tabelaDados.GetDecimal("CUSTOMEDIO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAULTIMACOMPRA")))
                    {
                        prod.dataultimacompra = tabelaDados.GetDateTime("DATAULTIMACOMPRA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAULTIMASAIDA")))
                    {
                        prod.dataultimacompra = tabelaDados.GetDateTime("DATAULTIMASAIDA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("ESTOQUE")))
                    {
                        prod.customedio = tabelaDados.GetDecimal("ESTOQUE");
                    }
                }

                tabelaDados.Close();
                return prod;

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

        public bool atualizaestoque(String wproduto, String wtipo, Decimal wqtde)
        {
            int registrosafetados;
            bool retorno = false;
            try
            {
                AbrirConexao();
                if (wtipo == "entrada")
                {
                    comando = new MySqlCommand("UPDATE PRODUTO SET ESTOQUE = ESTOQUE + @QTDE WHERE CODIGO = @CODIGO", conexao);
                }
                if (wtipo == "saida")
                {
                    comando = new MySqlCommand("UPDATE PRODUTO SET ESTOQUE = ESTOQUE - @QTDE WHERE CODIGO = @CODIGO", conexao);
                }
                comando.Parameters.AddWithValue("@codigo", wproduto);
                comando.Parameters.AddWithValue("@qtde", wqtde);
                registrosafetados = comando.ExecuteNonQuery();
                if (registrosafetados > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }

        public bool atualizacusto(String wproduto, DateTime datadacompra, Decimal wqtde, Decimal wvlrunitario)
        {
            int registrosafetados;
            bool retorno = false;
            decimal wcustoantes,westoqueantes,wcustomedioatual,wcustototalantes, wcustototalatual = 0;
            try
            {
                AbrirConexao();

                MySqlDataReader tabelaDados;

                comando = new MySqlCommand("SELECT COALESCE(CUSTO,0) AS CUSTO,COALESCE(ESTOQUE,0) AS ESTOQUE FROM PRODUTO WHERE CODIGO = @CODIGO", conexao);

                comando.Parameters.AddWithValue("@codigo", wproduto);
                
                wcustoantes = 0;
                westoqueantes = 0;
                wcustomedioatual = 0;
                wcustototalantes = 0;
                wcustototalatual = 0;
                // Executa a consulta
                tabelaDados = comando.ExecuteReader();
                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CUSTO")))
                    {
                        wcustoantes = tabelaDados.GetDecimal("CUSTO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("ESTOQUE")))
                    {
                        westoqueantes = tabelaDados.GetDecimal("ESTOQUE");
                    }
                }
                if (wcustoantes > 0 || westoqueantes > 0)
                {
                    wcustototalantes = wcustoantes * westoqueantes;
                }
                if (wqtde > 0 || wvlrunitario > 0)
                {
                    wcustototalatual = wqtde * wvlrunitario;
                }

                if (wcustototalantes > 0 || wcustototalatual > 0)
                {
                    wcustomedioatual = (wcustototalantes + wcustototalatual) / (westoqueantes + wqtde);
                }

                if (wcustomedioatual <= 0) 
                {
                    wcustomedioatual = wvlrunitario;
                }
                tabelaDados.Close();

                comando = new MySqlCommand("UPDATE PRODUTO SET CUSTO = @CUSTO, CUSTOMEDIO = @CUSTOMEDIO, DATAULTIMACOMPRA = @DATAULTIMACOMPRA WHERE CODIGO = @CODIGO", conexao);

                comando.Parameters.AddWithValue("@codigo", wproduto);
                comando.Parameters.AddWithValue("@custo", wvlrunitario);
                if (Convert.ToString(datadacompra) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@dataultimacompra", datadacompra);
                }
                else
                {
                    comando.Parameters.AddWithValue("@dataultimacompra", null);
                }
                if (wcustomedioatual > 0)
                {
                    comando.Parameters.AddWithValue("@customedio", wcustomedioatual);
                }
                else
                {
                    comando.Parameters.AddWithValue("@customedio", wvlrunitario);
                }
                registrosafetados = comando.ExecuteNonQuery();
                if (registrosafetados > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }
    }
}
