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
    public class MensagemPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public void salvar(MensagemModelo mensagem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO mensagem(controle, datamensagem, horamensagem, motcodigo, texto) VALUES (@controle, @datamensagem, @horamensagem, @motcodigo, @texto)", conexao);
                comando.Parameters.AddWithValue("@controle", mensagem.controle);
                comando.Parameters.AddWithValue("@datamensagem", mensagem.datamensagem);
                comando.Parameters.AddWithValue("@horamensagem", mensagem.horamensagem);
                comando.Parameters.AddWithValue("@motcodigo", mensagem.motcodigo);
                comando.Parameters.AddWithValue("@texto", mensagem.texto);
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

        public void alterar(MensagemModelo mensagem)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update mensagem set controle =@controle, datamensagem =@datamensagem, horamensagem =@horamensagem, motcodigo =@motcodigo, texto =@texto where controle=@controle", conexao);
                comando.Parameters.AddWithValue("@controle", mensagem.controle);
                comando.Parameters.AddWithValue("@datamensagem", mensagem.datamensagem);
                comando.Parameters.AddWithValue("@horamensagem", mensagem.horamensagem);
                comando.Parameters.AddWithValue("@motcodigo", mensagem.motcodigo);
                comando.Parameters.AddWithValue("@texto", mensagem.texto);
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

        public void excluir(MensagemModelo mensagem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from mensagem where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@controle", mensagem.controle);

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
