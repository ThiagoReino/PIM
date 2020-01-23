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
    public class MotoristaControle
    {
        MotoristaPersistencia motoristadb = new MotoristaPersistencia();

        public void salvar(MotoristaModelo motorista)
        {
            try
            {
                motoristadb.salvar(motorista);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(MotoristaModelo motorista)
        {
            try
            {
                motoristadb.alterar(motorista);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(MotoristaModelo motorista)
        {
            try
            {
                motoristadb.excluir(motorista);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public MotoristaModelo atualizatela(MotoristaModelo codigo)
        {
            try
            {
                MotoristaModelo mot = new MotoristaModelo();

                mot = motoristadb.atualizatela(codigo);

                return mot;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
