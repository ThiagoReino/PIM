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
using Controle_Veiculos.Classes.Controller;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class OsItemPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public int salvar(Ositem ositem)
        {
            MySqlTransaction transacao;

            try
            {
                AbrirConexao();
                transacao = conexao.BeginTransaction();

                comando = new MySqlCommand("INSERT INTO ositem(codigo, manutencaocodigo, procodigo, srvcodigo, qtde, vlrunitario, vlrtotal) VALUES (@codigo, @manutencaocodigo, @procodigo, @srvcodigo, @qtde, @vlrunitario, @vlrtotal)", conexao);
                comando.Parameters.AddWithValue("@codigo", ositem.codigo);
                comando.Parameters.AddWithValue("@manutencaocodigo", ositem.manutencaocodigo);
                comando.Parameters.AddWithValue("@procodigo", ositem.procodigo);
                comando.Parameters.AddWithValue("@srvcodigo", ositem.srvcodigo);
                comando.Parameters.AddWithValue("@qtde", ositem.qtde);
                comando.Parameters.AddWithValue("@vlrunitario", ositem.vlrunitario);
                comando.Parameters.AddWithValue("@vlrtotal", ositem.vlrtotal);
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

        public void alterar(Ositem ositem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update ositem set  codigo =@codigo, manutencaocodigo =@manutencaocodigo, procodigo =@procodigo, srvcodigo =@srvcodigo, qtde =@qtde, vlrunitario =@vlrunitario, vlrtotal =@vlrtotal where controle=@controle", conexao);
                comando.Parameters.AddWithValue("@codigo", ositem.codigo);
                comando.Parameters.AddWithValue("@manutencaocodigo", ositem.manutencaocodigo);
                comando.Parameters.AddWithValue("@procodigo", ositem.procodigo);
                comando.Parameters.AddWithValue("@srvcodigo", ositem.srvcodigo);
                comando.Parameters.AddWithValue("@qtde", ositem.qtde);
                comando.Parameters.AddWithValue("@vlrunitario", ositem.vlrunitario);
                comando.Parameters.AddWithValue("@vlrtotal", ositem.vlrtotal);
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

        public void excluir(Ositem ositem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM OSITEM WHERE CODIGO = @CODIGO", conexao);
                comando.Parameters.AddWithValue("@codigo", ositem.codigo);
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
