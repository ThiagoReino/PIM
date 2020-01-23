using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Veiculos.Classes.Model;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Controle
{
    public class LoginControle
    {
        public bool tem;
        public String mensagem = "";

        LoginPersistencia loginbd = new LoginPersistencia();

        public void salvar(LoginModelo login)
        {
            try
            {
                loginbd.salvar(login);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(LoginModelo login)
        {
            try
            {
                loginbd.alterar(login);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(LoginModelo login)
        {
            try
            {
                loginbd.excluir(login);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public LoginModelo atualizatela(LoginModelo login)
        {
            try
            {
                LoginModelo log = new LoginModelo();

                login = loginbd.atualizatela(login);

                return log;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public bool verificarLogin(String logon, String senha)
        {
            tem = loginbd.verificarLogin(logon, senha);
            if (loginbd.Equals(""))
            {
                this.mensagem = loginbd.mensagem;
            }
            return tem;
        }

    }
}
