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
using Controle_Veiculos.Classes.Interface;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class LoginPersistencia : Conexao
    {
        public bool tem = false;

        public String mensagem = "";
         
        MySqlCommand comando = null;

        MySqlDataReader dr;

        public void salvar(LoginModelo login)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO login(logon, senha) values (@logon, MD5(@senha))", conexao);
                comando.Parameters.AddWithValue("@logon", login.logon);
                comando.Parameters.AddWithValue("@senha", login.senha);

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

        public void alterar(LoginModelo login)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update login set codigo =@codigo, login =@login, senha =@senha where codigo=@codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", login.codigo);
                comando.Parameters.AddWithValue("@login", login.logon);
                comando.Parameters.AddWithValue("@senha", login.senha);

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

        public void excluir(LoginModelo login)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("delete from login where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", login.codigo);

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

        public LoginModelo atualizatela(LoginModelo login)
        {
            try
            {
                AbrirConexao();

                MySqlDataReader tabelaDados;
                comando = new MySqlCommand("select * from login where codigo = @codigo", conexao);
                comando.Parameters.AddWithValue("@codigo", login.codigo);

                // Executa a consulta
                tabelaDados = comando.ExecuteReader();

                LoginModelo log = new LoginModelo();

                while (tabelaDados.Read()) // Lendo registro
                {
                    log.codigo = tabelaDados.GetInt32(0);
                    log.logon = tabelaDados.GetString(1);
                    log.senha = tabelaDados.GetString(2);
                }

                tabelaDados.Close();
                return log;


            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public bool verificarLogin(String logon, String senha)
        {
            AbrirConexao();

            comando = new MySqlCommand("select * from login where logon =@logon and senha = MD5(@senha)", conexao);
            comando.Parameters.AddWithValue("@logon", logon);
            comando.Parameters.AddWithValue("@senha", senha);

            try
            {
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
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
            return tem;
        }
    }
}
