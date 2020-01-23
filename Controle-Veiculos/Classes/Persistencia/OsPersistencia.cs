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
    public class OsPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public int salvar(Os os)
        {
            MySqlTransaction transacao;

            try
            {
                AbrirConexao();
                transacao = conexao.BeginTransaction();

                comando = new MySqlCommand("INSERT INTO ositem(codigo, veicodigo, datainicial, datafinal, vlrtotal) VALUES (@codigo, @veicodigo, @datainicial, @datafinal, @vlrtotal)", conexao);
                comando.Parameters.AddWithValue("@codigo", os.codigo);
                comando.Parameters.AddWithValue("@veicodigo", os.veicodigo);
                comando.Parameters.AddWithValue("@datainicial", os.datainicial);
                comando.Parameters.AddWithValue("@datafinal", os.datafinal);
                comando.Parameters.AddWithValue("@vlrtotal", os.vlrtotal);
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

        public void alterar(Os os)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update rota set  codigo =@codigo, veicodigo =@veicodigo, datainicial =@datainicial, datafinal =@datafinal, vlrtotal =@vlrtotal where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", os.codigo);
                comando.Parameters.AddWithValue("@veicodigo", os.veicodigo);
                comando.Parameters.AddWithValue("@datainicial", os.datainicial);
                comando.Parameters.AddWithValue("@datafinal", os.datafinal);
                comando.Parameters.AddWithValue("@vlrtotal", os.vlrtotal);
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

        public void excluir(Os os)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM OS WHERE CODIGO = @CODIGO", conexao);
                comando.Parameters.AddWithValue("@codigo", os.codigo);
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
