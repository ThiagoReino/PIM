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
    public class OsControle
    {
        OsPersistencia osdb = new OsPersistencia();

        public void salvar(Os os)
        {
            try
            {
                osdb.salvar(os);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(Os os)
        {
            try
            {
                osdb.alterar(os);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(Os os)
        {
            try
            {
                osdb.excluir(os);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
