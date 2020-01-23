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
    public class CompraPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public int salvar(CompraModelo compra)
        {
            int wcodigoretorno;
            wcodigoretorno = 0;
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO compra(controle, datacompra, fornecedorcodigo, valorcompra) VALUES (@controle, @datacompra, @fornecedorcodigo, @valorcompra)", conexao);
                comando.Parameters.AddWithValue("@controle", compra.controle);
                comando.Parameters.AddWithValue("@datacompra", compra.datacompra);
                comando.Parameters.AddWithValue("@fornecedorcodigo", compra.fornecedorcodigo);
                comando.Parameters.AddWithValue("@valorcompra", compra.valorcompra);
                comando.ExecuteNonQuery();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("SELECT LAST_INSERT_ID() as CONTROLE", conexao);

                wcodigoretorno = Convert.ToInt32(comando.ExecuteScalar());

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
            return wcodigoretorno;  
        }

        public void alterar(CompraModelo compra)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update compra set controle =@controle, datacompra =@datacompra, forcodigo =@forcodigo, valorcompra =@valorcompra where controle=@controle", conexao);
                comando.Parameters.AddWithValue("@controle", compra.controle);
                comando.Parameters.AddWithValue("@datacompra", compra.datacompra);
                comando.Parameters.AddWithValue("@forcodigo", compra.fornecedorcodigo);
                comando.Parameters.AddWithValue("@valorcompra", compra.valorcompra);
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

        public void excluir(CompraModelo compra)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from compra where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@controle", compra.controle);

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


        public bool atualizavalorcompra(CompraModelo compra,String wtipo, Decimal wvalor)
        {
            int registrosafetados;
            bool retorno = false;
            try
            {
                AbrirConexao();
                if (wtipo == "entrada")
                {
                    comando = new MySqlCommand("update compra set valorcompra = valorcompra +  @valor where controle = @controle", conexao);
                }
                if (wtipo == "saida")
                {
                    comando = new MySqlCommand("update compra set valorcompra = valorcompra - @valor where controle = @controle", conexao);
                }
                
                comando.Parameters.AddWithValue("@controle", compra.controle);
                comando.Parameters.AddWithValue("@valor", wvalor);
                registrosafetados = comando.ExecuteNonQuery();
                if (registrosafetados > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }
        
        public CompraModelo atualizatela(CompraModelo compra)
        {
            try
            {
                AbrirConexao();
                CompraModelo comp = new CompraModelo();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from compra where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@controle", compra.controle);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CONTROLE")))
                    {
                        comp.controle = tabelaDados.GetInt32("CONTROLE");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DATACOMPRA")))
                    {
                        comp.datacompra = tabelaDados.GetDateTime("DATACOMPRA");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("FORNECEDORCODIGO")))
                    {
                        comp.fornecedorcodigo = tabelaDados.GetInt32("FORNECEDORCODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VALORCOMPRA")))
                    {
                        comp.valorcompra = tabelaDados.GetDecimal("VALORCOMPRA");
                    }
                }
                tabelaDados.Close();
                return comp;

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
