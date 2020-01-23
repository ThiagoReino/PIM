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
    public class ServicoPersistencia : Conexao
    {
        MySqlCommand comando = null;

        public int salvar(ServicoModelo servico)
        {
            MySqlTransaction transacao;

            try
            {
                AbrirConexao();
                transacao = conexao.BeginTransaction();

                comando = new MySqlCommand("INSERT INTO servico (codigo, descricao) VALUES (@codigo, @descricao)", conexao);
                comando.Parameters.AddWithValue("@codigo", servico.codigo);
                comando.Parameters.AddWithValue("@descricao", servico.descricao);

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

        public void alterar(ServicoModelo servico)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update servico set  codigo =@codigo, descricao =@descricao where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", servico.codigo);
                comando.Parameters.AddWithValue("@descricao", servico.descricao);
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

        public void excluir(ServicoModelo servico)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM SERVICO WHERE CODIGO = @CODIGO", conexao);
                comando.Parameters.AddWithValue("@codigo", servico.codigo);
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

        public ServicoModelo atualizatela(ServicoModelo servico)
        {
            try
            {
                AbrirConexao();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from servico where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", servico.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                ServicoModelo srv = new ServicoModelo();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        srv.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DESCRICAO")))
                    {
                        srv.descricao = tabelaDados.GetString("DESCRICAO");
                    }
                }

                tabelaDados.Close();
                return srv;

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
