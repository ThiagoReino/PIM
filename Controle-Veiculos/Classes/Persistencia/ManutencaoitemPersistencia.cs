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
    public class ManutencaoitemPersistencia : Conexao
    {
        MySqlCommand comando = null;

        public void salvar(ManutencaoitemModelo manutencaoitem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO manutencaoitem(codigo,manutencaocodigo,produtocodigo,servicocodigo,qtde,vlrunitario,vlrtotal) VALUES (@codigo, @manutencaocodigo,@produtocodigo,@servicocodigo,@qtde,@vlrunitario,@vlrtotal)", conexao);
                comando.Parameters.AddWithValue("@codigo", manutencaoitem.codigo);
                comando.Parameters.AddWithValue("@manutencaocodigo", manutencaoitem.manutencaocodigo);
                comando.Parameters.AddWithValue("@produtocodigo", manutencaoitem.produtocodigo);
                comando.Parameters.AddWithValue("@servicocodigo", manutencaoitem.servicocodigo);
                comando.Parameters.AddWithValue("@qtde", manutencaoitem.qtde);
                comando.Parameters.AddWithValue("@vlrunitario", manutencaoitem.vlrunitario);
                comando.Parameters.AddWithValue("@vlrtotal", manutencaoitem.vlrtotal);
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

        public void alterar(ManutencaoitemModelo manutencaoitem)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update manutencaoitem set codigo =@codigo, manutencaocodigo =@manutencaocodigo, produtocodigo =@produtocodigo, servicocodigo =@servicocodigo, qtde =@qtde, vlrunitario =@vlrunitario, vlrtotal =@vlrtotal where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", manutencaoitem.codigo);
                comando.Parameters.AddWithValue("@manutencaocodigo", manutencaoitem.manutencaocodigo);
                comando.Parameters.AddWithValue("@produtocodigo", manutencaoitem.produtocodigo);
                comando.Parameters.AddWithValue("@servicocodigo", manutencaoitem.servicocodigo);
                comando.Parameters.AddWithValue("@qtde", manutencaoitem.qtde);
                comando.Parameters.AddWithValue("@vlrunitario", manutencaoitem.vlrunitario);
                comando.Parameters.AddWithValue("@vlrtotal", manutencaoitem.vlrtotal);
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

        public void excluir(ManutencaoitemModelo manutencaoitem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from manutencaoitem where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", manutencaoitem.codigo);

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
