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
    public class SeguradoraPersistencia : Conexao
    {
        MySqlCommand comando = null;

        public int salvar(SeguradoraModelo seguradora)
        {
            MySqlTransaction transacao;

            try
            {
                AbrirConexao();
                transacao = conexao.BeginTransaction();

                comando = new MySqlCommand("INSERT INTO seguradora(codigo, nome, ddd, telefone ) VALUES (@codigo, @nome, @ddd, @telefone)", conexao);
                comando.Parameters.AddWithValue("@codigo", seguradora.codigo);
                comando.Parameters.AddWithValue("@nome", seguradora.nome);
                comando.Parameters.AddWithValue("@ddd", seguradora.ddd);
                comando.Parameters.AddWithValue("@telefone", seguradora.telefone);

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


        public SeguradoraModelo atualizatela(SeguradoraModelo seguradora)
        {
            try
            {
                AbrirConexao();
                SeguradoraModelo forn = new SeguradoraModelo();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from seguradora where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", seguradora.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        forn.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("NOME")))
                    {
                        forn.nome = tabelaDados.GetString("NOME");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DDD")))
                    {
                        forn.ddd = tabelaDados.GetString("DDD");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("TELEFONE")))
                    {
                        forn.telefone = tabelaDados.GetString("TELEFONE");
                    }
                }
                tabelaDados.Close();
                return forn;

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


        public void alterar(SeguradoraModelo seguradora)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update seguradora set  codigo =@codigo, nome =@nome, ddd =@ddd, telefone =@telefone where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", seguradora.codigo);
                comando.Parameters.AddWithValue("@nome", seguradora.nome);
                comando.Parameters.AddWithValue("@ddd", seguradora.ddd);
                comando.Parameters.AddWithValue("@telefone", seguradora.telefone);
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

        public void excluir(SeguradoraModelo seguradora)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM SEGURADORA WHERE CODIGO = @CODIGO", conexao);
                comando.Parameters.AddWithValue("@CODIGO", seguradora.codigo);
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
