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
    public class ManutencaoPersistencia : Conexao
    {
        MySqlCommand comando = null;

        public int salvar(ManutencaoModelo manutencao)
        {
            int wcodigoretorno;
            wcodigoretorno = 0;
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO manutencao (codigo, veiculocodigo, datainiciomanutencao, datafinalmanutencao, vlrtotal) VALUES (@codigo, @veiculocodigo, @datainiciomanutencao, @datafinalmanutencao, @vlrtotal)", conexao);
                comando.Parameters.AddWithValue("@codigo", manutencao.codigo);
                comando.Parameters.AddWithValue("@veiculocodigo", manutencao.veiculocodigo);
                if (Convert.ToString(manutencao.datainiciomanutencao) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datainiciomanutencao", manutencao.datainiciomanutencao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datainiciomanutencao", null);
                }
                if (Convert.ToString(manutencao.datafinalmanutencao) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datafinalmanutencao", manutencao.datafinalmanutencao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@datafinalmanutencao", null);
                }
                comando.Parameters.AddWithValue("@vlrtotal", manutencao.vlrtotal);
                comando.ExecuteNonQuery();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("SELECT LAST_INSERT_ID() as CONTROLE", conexao);

                wcodigoretorno = Convert.ToInt32(comando.ExecuteScalar());

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
            return wcodigoretorno;
        }

        public void alterar(ManutencaoModelo manutencao)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update manutencao set codigo =@codigo, veiculocodigo =@veiculocodigo, datainiciomanutencao =@datainiciomanutencao, datafinalmanutencao =@datafinalmanutencao, vlrtotal =@vlrtotal where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", manutencao.codigo);
                comando.Parameters.AddWithValue("@veiculocodigo", manutencao.veiculocodigo);
                comando.Parameters.AddWithValue("@datainiciomanutencao", manutencao.datainiciomanutencao);
                comando.Parameters.AddWithValue("@datafinalmanutencao", manutencao.datafinalmanutencao);
                comando.Parameters.AddWithValue("@vlrtotal", manutencao.vlrtotal);
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

        public bool atualizavalormanutencao(ManutencaoModelo manutencao, String wtipo, Decimal wvalor)
        {
            int registrosafetados;
            bool retorno = false;
            try
            {
                AbrirConexao();
                if (wtipo == "entrada")
                {
                    comando = new MySqlCommand("update manutencao set vlrtotal = vlrtotal +  @valor where codigo = @codigo", conexao);
                }
                if (wtipo == "saida")
                {
                    comando = new MySqlCommand("update manutencao set vlrtotal = vlrtotal -  @valor where codigo = @codigo", conexao);
                }

                comando.Parameters.AddWithValue("@codigo", manutencao.codigo);
                comando.Parameters.AddWithValue("@valor", wvalor);
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
        
        public void excluir(ManutencaoModelo manutencao)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from manutencao where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", manutencao.codigo);

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


        public ManutencaoModelo atualizatela(ManutencaoModelo manutencao)
        {
            try
            {
                AbrirConexao();
                ManutencaoModelo manut = new ManutencaoModelo();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from manutencao where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", manutencao.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        manut.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VEICULOCODIGO")))
                    {
                        manut.veiculocodigo = tabelaDados.GetInt32("VEICULOCODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAINICIOMANUTENCAO")))
                    {
                        manut.datainiciomanutencao = tabelaDados.GetDateTime("DATAINICIOMANUTENCAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAFINALMANUTENCAO")))
                    {
                        manut.datafinalmanutencao = tabelaDados.GetDateTime("DATAFINALMANUTENCAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VLRTOTAL")))
                    {
                        manut.vlrtotal = tabelaDados.GetDecimal("VLRTOTAL");
                    }
                }
                tabelaDados.Close();
                return manut;

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
