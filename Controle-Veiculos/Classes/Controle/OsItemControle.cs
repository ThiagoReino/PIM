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
    public class OsItemControle
    {
        OsItemPersistencia osItemDb = new OsItemPersistencia();

        public void salvar(Ositem ositem)
        {
            try
            {
                osItemDb.salvar(ositem);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(Ositem ositem)
        {
            try
            {
                osItemDb.alterar(ositem);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(Ositem ositem)
        {
            try
            {
                osItemDb.excluir(ositem);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
