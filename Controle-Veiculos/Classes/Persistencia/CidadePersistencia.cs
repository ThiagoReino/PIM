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
using Controle_Veiculos.Classes.Persistencia;
using System.Data;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class CidadePersistencia : Conexao
    {
        MySqlCommand comando = null;

        public void salvar(CidadeModelo cidademodelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO cidade(controle, codigoibge, nome, uf) values (@controle, @codigoibge, @nome, @uf)", conexao);
                comando.Parameters.AddWithValue("@controle", cidademodelo.controle);
                comando.Parameters.AddWithValue("@codigoibge", cidademodelo.codigoibge);
                comando.Parameters.AddWithValue("@nome", cidademodelo.nome);
                comando.Parameters.AddWithValue("@uf", cidademodelo.uf);
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

        public void alterar(CidadeModelo cidademodelo)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update cidade set nome =@nome where cadcodigo=@cadcodigo", conexao);
                comando.Parameters.AddWithValue("@controle", cidademodelo.controle);
                comando.Parameters.AddWithValue("@codigoibge", cidademodelo.codigoibge);
                comando.Parameters.AddWithValue("@nome", cidademodelo.nome);
                comando.Parameters.AddWithValue("@uf", cidademodelo.uf);
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

        public void excluir(CidadeModelo cidademodelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from cidade where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@controle", cidademodelo.controle);

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


        public CidadeModelo atualizatela(CidadeModelo cidademodelo)
        {
            try
            {
                AbrirConexao();

                String sql;
                sql = "";

                sql ="select * from cidade where controle > 0";
                if (cidademodelo.controle > 0)
                {
                    sql = sql + " and controle = @controle";
             
                }
                if (cidademodelo.nome != "" && cidademodelo.nome != null)
                {
                    sql = sql + " and nome = @nome";
                   
                }

                MySqlDataReader tabelaDados;


                comando = new MySqlCommand(sql, conexao);
                if (cidademodelo.controle > 0)
                {

                    comando.Parameters.AddWithValue("@controle", cidademodelo.controle);
                }
                if (cidademodelo.nome != "")
                {

                    comando.Parameters.AddWithValue("@nome", cidademodelo.nome);
                }              
                
               

                // Executa a consulta

                tabelaDados = comando.ExecuteReader();

                CidadeModelo cid = new CidadeModelo();

                while (tabelaDados.Read()) // Lendo registro
                {
                    cid.controle = tabelaDados.GetInt32(0);
                    cid.codigoibge = tabelaDados.GetInt32(1);
                    cid.nome = tabelaDados.GetString(2);
                    cid.uf = tabelaDados.GetString(3);
                    cid.ufnome = tabelaDados.GetString(4);
                    cid.ufcod = tabelaDados.GetString(5);
                    cid.paisnome = tabelaDados.GetString(6);
                    cid.paiscod = tabelaDados.GetString(7);
                }

                tabelaDados.Close();
                return cid;


            }
            catch (Exception erro)
            {

                throw erro;
            }
        }


    }
}
