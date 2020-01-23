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
    public class FabricantePersistencia: Conexao
    {
        MySqlCommand comando = null;

        public void salvar(FabricanteModelo fabricante)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO fabricante(codigo,descricao) VALUES (@codigo,@descricao)", conexao);
                comando.Parameters.AddWithValue("@codigo", fabricante.codigo);
                comando.Parameters.AddWithValue("@descricao", fabricante.descricao);
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

        public void alterar(FabricanteModelo fabricante)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update fabricante set codigo =@codigo, descricao =@descricao where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", fabricante.codigo);
                comando.Parameters.AddWithValue("@descricao", fabricante.descricao);
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

        public void excluir(FabricanteModelo fabricante)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from fabricante where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", fabricante.codigo);

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
