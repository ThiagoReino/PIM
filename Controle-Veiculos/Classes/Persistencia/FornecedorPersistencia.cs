using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.ConexaoBanco;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class FornecedorPersistencia : Conexao
    {
        MySqlCommand comando = null;

        public int salvar(FornecedorModelo fornecedor)
        {
            MySqlTransaction transacao;
            try
            {
                AbrirConexao();

                transacao = conexao.BeginTransaction();

                comando = new MySqlCommand("INSERT INTO fornecedor(codigo, nomerazao, nomefantasia, cpf, rg, cnpj, ie, logradouro, numero, complemento, bairro, cidadecontrole, cep, ddd, telefone, dddcelular, celular, contato, email) VALUES (@codigo, @nomerazao, @nomefantasia, @cpf, @rg, @cnpj, @ie, @logradouro, @numero, @complemento, @bairro, @cidadecontrole, @cep, @ddd, @telefone, @dddcelular, @celular, @contato, @email)", conexao);
                comando.Parameters.AddWithValue("@codigo", fornecedor.codigo);
                comando.Parameters.AddWithValue("@nomerazao", fornecedor.nomerazao);
                comando.Parameters.AddWithValue("@nomefantasia", fornecedor.nomefantasia);
                comando.Parameters.AddWithValue("@cpf", fornecedor.cpf);
                comando.Parameters.AddWithValue("@rg", fornecedor.rg);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                comando.Parameters.AddWithValue("@ie", fornecedor.ie);
                comando.Parameters.AddWithValue("@logradouro", fornecedor.logradouro);
                comando.Parameters.AddWithValue("@numero", fornecedor.numero);
                comando.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                comando.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                comando.Parameters.AddWithValue("@cidadecontrole", fornecedor.cidadecontrole);
                comando.Parameters.AddWithValue("@cep", fornecedor.cep);
                comando.Parameters.AddWithValue("@ddd", fornecedor.ddd);
                comando.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                comando.Parameters.AddWithValue("@dddcelular", fornecedor.dddcelular);
                comando.Parameters.AddWithValue("@celular", fornecedor.celular);
                comando.Parameters.AddWithValue("@contato", fornecedor.contato);
                comando.Parameters.AddWithValue("@email", fornecedor.email);
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

        public FornecedorModelo atualizatela(FornecedorModelo fornecedor)
        {
            try
            {
                AbrirConexao();
                FornecedorModelo forn = new FornecedorModelo();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from fornecedor where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", fornecedor.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        forn.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("NOMERAZAO")))
                    {
                        forn.nomerazao = tabelaDados.GetString("NOMERAZAO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("NOMEFANTASIA")))
                    {
                        forn.nomefantasia = tabelaDados.GetString("NOMEFANTASIA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CPF")))
                    {
                        forn.cpf = tabelaDados.GetString("CPF");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("RG")))
                    {
                        forn.rg = tabelaDados.GetString("RG");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CNPJ")))
                    {
                        forn.cnpj = tabelaDados.GetString("CNPJ");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("IE")))
                    {
                        forn.ie = tabelaDados.GetString("IE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("LOGRADOURO")))
                    {
                        forn.logradouro = tabelaDados.GetString("LOGRADOURO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("NUMERO")))
                    {
                        forn.numero = tabelaDados.GetString("NUMERO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("COMPLEMENTO")))
                    {
                        forn.complemento = tabelaDados.GetString("COMPLEMENTO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("BAIRRO")))
                    {
                        forn.bairro = tabelaDados.GetString("BAIRRO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CIDADECONTROLE")))
                    {
                        forn.cidadecontrole = tabelaDados.GetInt32("CIDADECONTROLE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CEP")))
                    {
                        forn.cep = tabelaDados.GetString("CEP");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DDD")))
                    {
                        forn.ddd = tabelaDados.GetString("DDD");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("TELEFONE")))
                    {
                        forn.telefone = tabelaDados.GetString("TELEFONE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DDDCELULAR")))
                    {
                        forn.dddcelular = tabelaDados.GetString("DDDCELULAR");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CELULAR")))
                    {
                        forn.celular = tabelaDados.GetString("CELULAR");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CONTATO")))
                    {
                        forn.contato = tabelaDados.GetString("CONTATO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("EMAIL")))
                    {
                        forn.email = tabelaDados.GetString("EMAIL");
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

        //Metodo alterar
        public void alterar(FornecedorModelo fornecedor)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update fornecedor set codigo =@codigo, nomerazao =@nomerazao, nomefantasia =@nomefantasia, cpf =@cpf, rg =@rg, cnpj =@cnpj, ie =@ie, logradouro =@logradouro, numero =@numero, complemento =@complemento, bairro =@bairro, cidadecontrole =@cidadecontrole, cep =@cep, ddd =@ddd, telefone =@telefone, dddcelular =@dddcelular, celular =@celular, contato =@contato, email =@email where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", fornecedor.codigo);
                comando.Parameters.AddWithValue("@nomerazao", fornecedor.nomerazao);
                comando.Parameters.AddWithValue("@nomefantasia", fornecedor.nomefantasia);
                comando.Parameters.AddWithValue("@cpf", fornecedor.cpf);
                comando.Parameters.AddWithValue("@rg", fornecedor.rg);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                comando.Parameters.AddWithValue("@ie", fornecedor.ie);
                comando.Parameters.AddWithValue("@logradouro", fornecedor.logradouro);
                comando.Parameters.AddWithValue("@numero", fornecedor.numero);
                comando.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                comando.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                comando.Parameters.AddWithValue("@cidadecontrole", fornecedor.cidadecontrole);
                comando.Parameters.AddWithValue("@cep", fornecedor.cep);
                comando.Parameters.AddWithValue("@ddd", fornecedor.ddd);
                comando.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                comando.Parameters.AddWithValue("@dddcelular", fornecedor.dddcelular);
                comando.Parameters.AddWithValue("@celular", fornecedor.celular);
                comando.Parameters.AddWithValue("@contato", fornecedor.contato);
                comando.Parameters.AddWithValue("@email", fornecedor.email);
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

        public void excluir(FornecedorModelo fornecedor)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM FORNECEDOR WHERE CODIGO = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", fornecedor.codigo);

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
