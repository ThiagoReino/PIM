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
    public class ServicoControle
    {
        ServicoPersistencia servicodb = new ServicoPersistencia();

        public void salvar(ServicoModelo servico)
        {
            try
            {
                servicodb.salvar(servico);
            }
            catch (Exception erro)
            {

                throw erro;

            }
        }

        public void alterar(ServicoModelo servico)
        {
            try
            {
                servicodb.alterar(servico);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(ServicoModelo servico)
        {
            try
            {
                servicodb.excluir(servico);
            }
            catch (Exception erro)
            {

                throw erro;

            }
        }

        public ServicoModelo atualizatela(ServicoModelo servico)
        {
            try
            {
                ServicoModelo srv = new ServicoModelo();

                srv = servicodb.atualizatela(servico);

                return srv;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
