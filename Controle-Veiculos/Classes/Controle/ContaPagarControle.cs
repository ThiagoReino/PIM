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
    public class ContaPagarControle
    {
        ContaPagarPersistencia contapagardb = new ContaPagarPersistencia();

        public void salvar(ContapagarModelo contapagar)
        {
            try
            {
                contapagardb.salvar(contapagar);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void alterar(ContapagarModelo contapagar)
        {
            try
            {
                contapagardb.alterar(contapagar);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluir(ContapagarModelo contapagar)
        {
            try
            {
                contapagardb.excluir(contapagar);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
