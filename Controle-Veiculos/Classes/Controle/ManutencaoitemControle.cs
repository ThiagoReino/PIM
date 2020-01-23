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
    public class ManutencaoItemControle
    {
        ManutencaoitemPersistencia manutencaoitemdb = new ManutencaoitemPersistencia();

        public void salvar(ManutencaoitemModelo manutencaoitem)
        {
            try
            {
                manutencaoitemdb.salvar(manutencaoitem);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void alterar(ManutencaoitemModelo manutencaoitem)
        {
            try
            {
                manutencaoitemdb.alterar(manutencaoitem);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluir(ManutencaoitemModelo manutencaoitem)
        {
            try
            {
                manutencaoitemdb.excluir(manutencaoitem);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
