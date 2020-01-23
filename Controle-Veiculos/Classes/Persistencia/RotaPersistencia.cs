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
    public class RotaPersistencia : Conexao
    {

        MySqlCommand comando = null;

        public void salvar(RotaModelo rota)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO Rota(controle,datainicio, horainicio, datafim, horafim,motoristacodigo,nrpassageiros,veiculocodigo,localorigem,localdestino,kmpercorrido,descricaoatendimento) VALUES (@controle,@datainicio,@horainicio,@datafim,@horafim,@motoristacodigo,@nrpassageiros,@veiculocodigo,@localorigem,@localdestino,@kmpercorrido,@descricaoatendimento)", conexao);
                comando.Parameters.AddWithValue("@controle", rota.controle);
                comando.Parameters.AddWithValue("@datainicio", rota.datainicio);
                comando.Parameters.AddWithValue("@horainicio", rota.horainicio);
                comando.Parameters.AddWithValue("@datafim", rota.datafim);
                comando.Parameters.AddWithValue("@horafim", rota.horafim);
                comando.Parameters.AddWithValue("@motoristacodigo", rota.motoristacodigo);
                comando.Parameters.AddWithValue("@nrpassageiros", rota.nrpassageiros);
                comando.Parameters.AddWithValue("@veiculocodigo", rota.veiculocodigo);
                comando.Parameters.AddWithValue("@localorigem", rota.localorigem);
                comando.Parameters.AddWithValue("@localdestino", rota.localdestino);
                comando.Parameters.AddWithValue("@kmpercorrido", rota.kmpercorrido);
                comando.Parameters.AddWithValue("@descricaoatendimento", rota.descricaoatendimento);
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

        public void alterar(RotaModelo Rota)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update Rota set codigo =@codigo, datainicioRota =@datainicioRota, datafimRota =@datafimRota, valorRota =@valorRota  where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", Rota.controle);
                //comando.Parameters.AddWithValue("@veicodigo", Rota.veicodigo);
                //comando.Parameters.AddWithValue("@datainicioRota", Rota.datainicioRota);
                //comando.Parameters.AddWithValue("@datafimRota", Rota.datafimRota);
                // comando.Parameters.AddWithValue("@valorRota", Rota.valorRota);
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

        public void excluir(RotaModelo Rota)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from Rota where veicodigo = @veicodigo", conexao);
                comando.Parameters.AddWithValue("@veicodigo", Rota.controle);

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

        public RotaModelo pesquisaRota(RotaModelo rota)
        {
            try
            {
                AbrirConexao();
                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("SELECT * FROM ROTA WHERE CONTROLE = @CONTROLE", conexao);
                comando.Parameters.AddWithValue("@controle", rota.controle);
                // Executa a consulta
                tabelaDados = comando.ExecuteReader();
                MarcamodeloModelo marca = new MarcamodeloModelo();
                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CONTROLE")))
                    {
                        rota.controle = tabelaDados.GetInt32("CONTROLE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAINICIO")))
                    {
                        rota.datainicio = Convert.ToDateTime(tabelaDados.GetString("DATAINICIO"));
                    }

                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("HORAINICIO")))
                    {
                        rota.horainicio = tabelaDados.GetTimeSpan("HORAINICIO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAFIM")))
                    {
                        rota.datafim = Convert.ToDateTime(tabelaDados.GetString("DATAFIM"));
                    }

                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("HORAFIM")))
                    {
                        rota.horafim = tabelaDados.GetTimeSpan("HORAFIM");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("MOTORISTACODIGO")))
                    {
                        rota.motoristacodigo = tabelaDados.GetInt32("MOTORISTACODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("NRPASSAGEIROS")))
                    {
                        rota.nrpassageiros = tabelaDados.GetInt32("NRPASSAGEIROS");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VEICULOCODIGO")))
                    {
                        rota.veiculocodigo = tabelaDados.GetInt32("VEICULOCODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("LOCALORIGEM")))
                    {
                        rota.localorigem = tabelaDados.GetString("LOCALORIGEM");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("LOCALDESTINO")))
                    {
                        rota.localdestino = tabelaDados.GetString("LOCALDESTINO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("KMPERCORRIDO")))
                    {
                        rota.kmpercorrido = Convert.ToDecimal(tabelaDados.GetString("KMPERCORRIDO"));
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DESCRICAOATENDIMENTO")))
                    {
                        rota.descricaoatendimento = tabelaDados.GetString("DESCRICAOATENDIMENTO");
                    }

                }
                tabelaDados.Close();
                return rota;

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
/*
        public RotaModelo verificaveiculo(RotaModelo Rota)
        {
            try
            {
                AbrirConexao();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from Rota where veicodigo = @veicodigo", conexao);
                comando.Parameters.AddWithValue("@veicodigo", Rota.veicodigo);

                // Executa a consulta

                tabelaDados = comando.ExecuteReader();

                RotaModelo loc = new RotaModelo();

                while (tabelaDados.Read()) // Lendo registro
                {
                    loc.codigo = tabelaDados.GetInt32(0);
                    loc.veicodigo = tabelaDados.GetInt32(1);
                    loc.datainicioRota = tabelaDados.GetDateTime(2);
                    if (!tabelaDados.IsDBNull(4))
                    {
                        loc.datafimRota = tabelaDados.GetDateTime(3);
                    }
                    loc.valorRota = tabelaDados.GetDecimal(4);
                }

                tabelaDados.Close();
                return loc;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }*/

        public RotaModelo atualizatela(RotaModelo Rota)
        {
            try
            {
                AbrirConexao();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from Rota where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@controle", Rota.controle);

                // Executa a consulta

                tabelaDados = comando.ExecuteReader();

                RotaModelo loc = new RotaModelo();

                while (tabelaDados.Read()) // Lendo registro
                {
                    //loc.codigo = tabelaDados.GetInt32(0);
                    //loc.veicodigo = tabelaDados.GetInt32(1);
                    //loc.datainicioRota = tabelaDados.GetDateTime(2);
                    if (!tabelaDados.IsDBNull(4))
                    {
                        // loc.datafimRota = tabelaDados.GetDateTime(3);
                    }
                    // loc.valorRota = tabelaDados.GetDecimal(4);
                }

                tabelaDados.Close();
                return loc;

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

        public RotaModelo verificaCondutor(RotaModelo Rota)
        {
            try
            {
                AbrirConexao();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from Rota where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@controle", Rota.controle);

                // Executa a consulta

                tabelaDados = comando.ExecuteReader();

                RotaModelo loc = new RotaModelo();

                while (tabelaDados.Read()) // Lendo registro
                {
                    loc.controle = tabelaDados.GetInt32(0);
                    loc.veiculocodigo = tabelaDados.GetInt32(1);
                    //loc.datainicioRota = tabelaDados.GetDateTime(2);
                    if (!tabelaDados.IsDBNull(4))
                    {
                        //loc.datafimRota = tabelaDados.GetDateTime(3);
                    }
                    //loc.valorRota = tabelaDados.GetDecimal(4);
                }

                tabelaDados.Close();
                return loc;

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

