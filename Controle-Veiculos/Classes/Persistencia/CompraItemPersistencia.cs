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
    public class CompraItemPersistencia: Conexao
    {
        MySqlCommand comando = null;

        public void salvar(CompraitemModelo compraitem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO compraitem(controle, compracontrole, produtocodigo, qtde, vlrunitario, vlrtotal) VALUES (@controle, @compracontrole, @produtocodigo, @qtde, @vlrunitario, @vlrtotal)", conexao);
                comando.Parameters.AddWithValue("@controle", compraitem.controle);
                comando.Parameters.AddWithValue("@compracontrole", compraitem.compracontrole);
                comando.Parameters.AddWithValue("@produtocodigo", compraitem.produtocodigo);
                comando.Parameters.AddWithValue("@qtde", compraitem.qtde);
                comando.Parameters.AddWithValue("@vlrunitario", compraitem.vlrunitario);
                comando.Parameters.AddWithValue("@vlrtotal", compraitem.vlrtotal);
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

        public void alterar(CompraitemModelo compraitem)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update contapagar set controle =@controle, compracontrole =@compracontrole, produtocodigo =@produtocodigo, qtde =@qtde, vlrunitario =@vlrunitario, vlrtotal =@vlrtotal where controle=@controle", conexao);
                comando.Parameters.AddWithValue("@controle", compraitem.controle);
                comando.Parameters.AddWithValue("@compracontrole", compraitem.compracontrole);
                comando.Parameters.AddWithValue("@produtocodigo", compraitem.produtocodigo);
                comando.Parameters.AddWithValue("@qtde", compraitem.qtde);
                comando.Parameters.AddWithValue("@vlrunitario", compraitem.vlrunitario);
                comando.Parameters.AddWithValue("@vlrtotal", compraitem.vlrtotal);
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

        public void excluir(CompraitemModelo compraitem)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from compraitem where controle = @controle", conexao);
                comando.Parameters.AddWithValue("@controle", compraitem.controle);

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
