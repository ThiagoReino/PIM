using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Model;


namespace Controle_Veiculos.Classes.Persistencia
{
    public class MotoristaPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public void salvar(MotoristaModelo motorista)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO motorista(codigo, nome, cpf, rg, logradouro, numero, complemento, bairro, cidadecontrole, cep, ddd, telefone, dddcelular, celular, habilitacao, categoria, datavalidade, sexo, email) VALUES (@codigo, @nome, @cpf, @rg, @logradouro, @numero, @complemento, @bairro, @cidadecontrole, @cep, @ddd, @telefone, @dddcelular, @celular, @habilitacao, @categoria, @datavalidade, @sexo, @email)", conexao);
                comando.Parameters.AddWithValue("@codigo", motorista.codigo);
                comando.Parameters.AddWithValue("@nome", motorista.nome);
                comando.Parameters.AddWithValue("@cpf", motorista.cpf);
                comando.Parameters.AddWithValue("@rg", motorista.rg);
                comando.Parameters.AddWithValue("@logradouro", motorista.logradouro);
                comando.Parameters.AddWithValue("@numero", motorista.numero);
                comando.Parameters.AddWithValue("@complemento", motorista.complemento);
                comando.Parameters.AddWithValue("@bairro", motorista.bairro);
                comando.Parameters.AddWithValue("@cidadecontrole", motorista.cidadecontrole);
                comando.Parameters.AddWithValue("@cep", motorista.cep);
                comando.Parameters.AddWithValue("@ddd", motorista.ddd);
                comando.Parameters.AddWithValue("@telefone", motorista.telefone);
                comando.Parameters.AddWithValue("@dddcelular", motorista.dddcelular);
                comando.Parameters.AddWithValue("@celular", motorista.celular);
                comando.Parameters.AddWithValue("@habilitacao", motorista.habilitacao);
                comando.Parameters.AddWithValue("@categoria", motorista.categoria);
                if (Convert.ToString(motorista.datavalidade) != "01/01/0001 00:00:00")
                {
                    comando.Parameters.AddWithValue("@datavalidade", motorista.datavalidade);
                }
                comando.Parameters.AddWithValue("@sexo", motorista.sexo);
                comando.Parameters.AddWithValue("@email", motorista.email);
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

        public void alterar(MotoristaModelo motorista)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update motorista set  codigo =@codigo, nome =@nome, cpf =@cpf, rg =@rg, logradouro =@logradouro, numero =@numero, complemento =@complemento, bairro =@bairro, cidadecontrole =@cidadecontrole,cep =@cep, ddd =@ddd, telefone =@telefone, dddcelular =@dddcelular, celular =@celular, habilitacao =@habilitacao, categoria =@categoria, datavalidade =@datavalidade, email =@email where codigo =@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", motorista.codigo);
                comando.Parameters.AddWithValue("@nome", motorista.nome);
                comando.Parameters.AddWithValue("@cpf", motorista.cpf);
                comando.Parameters.AddWithValue("@rg", motorista.rg);
                comando.Parameters.AddWithValue("@logradouro", motorista.logradouro);
                comando.Parameters.AddWithValue("@numero", motorista.numero);
                comando.Parameters.AddWithValue("@complemento", motorista.complemento);
                comando.Parameters.AddWithValue("@bairro", motorista.bairro);
                comando.Parameters.AddWithValue("@cidadecontrole", motorista.cidadecontrole);
                comando.Parameters.AddWithValue("@cep", motorista.cep);
                comando.Parameters.AddWithValue("@ddd", motorista.ddd);
                comando.Parameters.AddWithValue("@telefone", motorista.telefone);
                comando.Parameters.AddWithValue("@dddcelular", motorista.dddcelular);
                comando.Parameters.AddWithValue("@celular", motorista.celular);
                comando.Parameters.AddWithValue("@habilitacao", motorista.habilitacao);
                comando.Parameters.AddWithValue("@categoria", motorista.categoria);
                comando.Parameters.AddWithValue("@datavalidade", motorista.datavalidade);
                comando.Parameters.AddWithValue("@email", motorista.email);
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

        public void excluir(MotoristaModelo motorista)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM MOTORISTA WHERE CODIGO = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", motorista.codigo);

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

       public MotoristaModelo atualizatela(MotoristaModelo motorista)
        {
            try
            {
                AbrirConexao();
                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from motorista where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", motorista.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();
                MotoristaModelo mot = new MotoristaModelo();
                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        mot.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("NOME")))
                    {
                        mot.nome = tabelaDados.GetString("NOME");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CPF")))
                    {
                        mot.cpf = tabelaDados.GetString("CPF");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("RG")))
                    {
                        mot.rg = tabelaDados.GetString("RG");
                    }
                    
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("LOGRADOURO")))
                    {
                        mot.logradouro = tabelaDados.GetString("LOGRADOURO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("NUMERO")))
                    {
                        mot.numero = tabelaDados.GetString("NUMERO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("COMPLEMENTO")))
                    {
                        mot.complemento = tabelaDados.GetString("COMPLEMENTO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("BAIRRO")))
                    {
                        mot.bairro = tabelaDados.GetString("BAIRRO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CIDADECONTROLE")))
                    {
                        mot.cidadecontrole = tabelaDados.GetInt32("CIDADECONTROLE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CEP")))
                    {
                        mot.cep = tabelaDados.GetString("CEP");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DDD")))
                    {
                        mot.ddd = tabelaDados.GetString("DDD");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("TELEFONE")))
                    {
                        mot.telefone = tabelaDados.GetString("TELEFONE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DDDCELULAR")))
                    {
                        mot.dddcelular = tabelaDados.GetString("DDDCELULAR");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CELULAR")))
                    {
                        mot.celular = tabelaDados.GetString("CELULAR");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("HABILITACAO")))
                    {
                        mot.habilitacao = tabelaDados.GetString("HABILITACAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CATEGORIA")))
                    {
                        mot.categoria = tabelaDados.GetString("CATEGORIA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATAVALIDADE")))
                    {
                        mot.datavalidade = tabelaDados.GetDateTime("DATAVALIDADE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("SEXO")))
                    {
                        mot.sexo = tabelaDados.GetString("SEXO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("EMAIL")))
                    {
                        mot.email = tabelaDados.GetString("EMAIL");
                    }
                }

                tabelaDados.Close();
                return mot;

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
