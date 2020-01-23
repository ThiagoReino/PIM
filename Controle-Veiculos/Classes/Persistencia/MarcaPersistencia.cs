﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.ConexaoBanco;


namespace Controle_Veiculos.Classes.Persistencia
{
    public class MarcaPersistencia : Conexao
    {
        MySqlCommand comando = null;

        public void salvar(MarcaModelo marcamodelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO marcamodelo(codigo, descricao) VALUES (@codigo, @descricao)", conexao);
                comando.Parameters.AddWithValue("@codigo", marcamodelo.codigo);
                comando.Parameters.AddWithValue("@descricao", marcamodelo.descricao);
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

        public void alterar(MarcaModelo marcamodelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update marcamodelo set  codigo =@codigo, descricao =@descricao where codigo =@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", marcamodelo.codigo);
                comando.Parameters.AddWithValue("@descricao", marcamodelo.descricao);
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

        public void excluir(MarcaModelo marcamodelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM MARCAMODELO WHERE CODIGO = @CODIGO", conexao);
                comando.Parameters.AddWithValue("@codigo", marcamodelo.codigo);
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

        public MarcaModelo pesquisaMarca(MarcaModelo marcamodelo)
        {
            try
            {
                AbrirConexao();
                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("SELECT * FROM MARCAMODELO WHERE CODIGO = @CODIGO", conexao);
                comando.Parameters.AddWithValue("@codigo", marcamodelo.codigo);
                // Executa a consulta
                tabelaDados = comando.ExecuteReader();
                MarcaModelo marca = new MarcaModelo();
                while (tabelaDados.Read()) // Lendo registro
                {
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("CODIGO")))
                    {
                        marca.codigo = tabelaDados.GetInt32("CODIGO");
                    }
                    if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("DESCRICAO")))
                    {
                        marca.descricao = tabelaDados.GetString("DESCRICAO");
                    }
                }
                tabelaDados.Close();
                return marca;

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
