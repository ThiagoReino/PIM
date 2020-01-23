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
    public class GrupoPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public void salvar(GrupoModelo grupo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO grupo(codigo,descricao) VALUES (@codigo,@descricao)", conexao);
                comando.Parameters.AddWithValue("@codigo", grupo.codigo);
                comando.Parameters.AddWithValue("@descricao", grupo.descricao);
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

        public GrupoModelo atualizatela(GrupoModelo grupo)
        {
            try
            {
                AbrirConexao();
                GrupoModelo gru = new GrupoModelo();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from grupo where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", grupo.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        gru.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DESCRICAO")))
                    {
                        gru.descricao = tabelaDados.GetString("DESCRICAO");
                    }
                }
                tabelaDados.Close();
                return gru;

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

        public void alterar(GrupoModelo grupo)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update grupo set codigo =@codigo, descricao =@descricao where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", grupo.codigo);
                comando.Parameters.AddWithValue("@descricao", grupo.descricao);
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

        public void excluir(GrupoModelo grupo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from grupo where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", grupo.codigo);

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
