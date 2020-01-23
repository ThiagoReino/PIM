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
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class OcorrenciaPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public int salvar(OcorrenciaModelo ocorrencia)
        {
            MySqlTransaction transacao;

            try
            {
                AbrirConexao();
                transacao = conexao.BeginTransaction();

                comando = new MySqlCommand("INSERT INTO ocorrencia(controle, dataocorrencia, horaocorrencia, veiculocodigo, motoristacodigo, localocorrencia, tipoocorrencia) VALUES (@controle, @dataocorrencia, @horaocorrencia, @veiculocodigo, @motoristacodigo, @localocorrencia, @tipoocorrencia)", conexao);
                comando.Parameters.AddWithValue("@controle", ocorrencia.controle);
                if (Convert.ToString(ocorrencia.dataocorrencia) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@dataocorrencia", ocorrencia.dataocorrencia);
                }
                else
                {
                    comando.Parameters.AddWithValue("@dataocorrencia", null);
                }
                comando.Parameters.AddWithValue("@horaocorrencia", ocorrencia.horaocorrencia);
                comando.Parameters.AddWithValue("@veiculocodigo", ocorrencia.veiculocodigo);
                comando.Parameters.AddWithValue("@motoristacodigo", ocorrencia.motoristacodigo);
                comando.Parameters.AddWithValue("@localocorrencia", ocorrencia.localocorrencia);
                comando.Parameters.AddWithValue("@tipoocorrencia", ocorrencia.tipoocorrencia);
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

        public void alterar(OcorrenciaModelo ocorrencia)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update ocorrencia set  controle =@controle, dataocorrencia =@dataocorrencia, horaocorrencia =@horaocorrencia, veiculocodigo =@veiculocodigo, motoristacodigo =@motoristacodigo, localocorrencia =@localocorrencia, tipoocorrencia =@tipoocorrencia where controle=@controle", conexao);
                comando.Parameters.AddWithValue("@controle", ocorrencia.controle);
                if (Convert.ToString(ocorrencia.dataocorrencia) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@dataocorrencia", ocorrencia.dataocorrencia);
                }
                else
                {
                    comando.Parameters.AddWithValue("@dataocorrencia", null);
                }
                comando.Parameters.AddWithValue("@horaocorrencia", ocorrencia.horaocorrencia);
                comando.Parameters.AddWithValue("@veiculocodigo", ocorrencia.veiculocodigo);
                comando.Parameters.AddWithValue("@motoristacodigo", ocorrencia.motoristacodigo);
                comando.Parameters.AddWithValue("@localocorrencia", ocorrencia.localocorrencia);
                comando.Parameters.AddWithValue("@tipoocorrencia", ocorrencia.tipoocorrencia);
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

        public void excluir(OcorrenciaModelo ocorrencia)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM OCORRENCIA WHERE CONTROLE = @CONTROLE", conexao);
                comando.Parameters.AddWithValue("@controle", ocorrencia.controle);
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

        public OcorrenciaModelo pesquisaOcorrencia(OcorrenciaModelo ocorrencia)
        {
            try
            {
                AbrirConexao();
                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("SELECT * FROM OCORRENCIA WHERE CONTROLE = @CONTROLE", conexao);
                comando.Parameters.AddWithValue("@controle", ocorrencia.controle);
                // Executa a consulta
                tabelaDados = comando.ExecuteReader();
                MarcamodeloModelo marca = new MarcamodeloModelo();
                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CONTROLE")))
                    {
                        ocorrencia.controle = tabelaDados.GetInt32("CONTROLE");
                    }
                    
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAOCORRENCIA")))
                    {
                        ocorrencia.dataocorrencia = Convert.ToDateTime(tabelaDados.GetString("DATAOCORRENCIA"));
                    }

                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("HORAOCORRENCIA")))
                    {
                        ocorrencia.horaocorrencia = tabelaDados.GetString("HORAOCORRENCIA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VEICULOCODIGO")))
                    {
                        ocorrencia.veiculocodigo = tabelaDados.GetInt32("VEICULOCODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("MOTORISTACODIGO")))
                    {
                        ocorrencia.motoristacodigo = tabelaDados.GetInt32("MOTORISTACODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("LOCALOCORRENCIA")))
                    {
                        ocorrencia.localocorrencia = tabelaDados.GetString("LOCALOCORRENCIA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("TIPOOCORRENCIA")))
                    {
                        ocorrencia.tipoocorrencia = tabelaDados.GetString("TIPOOCORRENCIA");
                    }

                }
                tabelaDados.Close();
                return ocorrencia;

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
