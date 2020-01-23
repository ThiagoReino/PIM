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
    public class ManutencaoControle
    {
        ManutencaoPersistencia manutencaodb = new ManutencaoPersistencia();

        public int salvar(ManutencaoModelo manutencao)
        {
            int wretorno = 0;
            try
            {
                wretorno = manutencaodb.salvar(manutencao);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return wretorno;
        }

        public void alterar(ManutencaoModelo manutencao)
        {
            try
            {
                manutencaodb.alterar(manutencao);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public bool atualizavalormanutencao(ManutencaoModelo manutencao, String wtipo, Decimal wvalor)
        {
            bool retorno = false;
            try
            {
                retorno = manutencaodb.atualizavalormanutencao(manutencao, wtipo, wvalor);
            }
            catch (Exception erro)
            {

                throw erro;
            }
            return retorno;
        }

        public void excluir(ManutencaoModelo manutencao)
        {
            try
            {
                manutencaodb.excluir(manutencao);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public ManutencaoModelo atualizatela(ManutencaoModelo controle)
        {
            try
            {
                ManutencaoModelo manutencao = new ManutencaoModelo();

                manutencao = manutencaodb.atualizatela(controle);

                return manutencao;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

    }
}
