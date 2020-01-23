using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Controle
{
    public class VeiculoControle
    {
        VeiculoPersistencia veiculoPersistencia = new VeiculoPersistencia();

        public void salvar(VeiculoModelo veiculo)
        {
            try
            {
                veiculoPersistencia.salvar(veiculo);

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void alterar(VeiculoModelo veiculo)
        {
            try
            {
                veiculoPersistencia.alterar(veiculo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(VeiculoModelo veiculo)
        {
            try
            {
                veiculoPersistencia.excluir(veiculo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public VeiculoModelo atualizatela(VeiculoModelo veiculo)
        {
            try
            {
                VeiculoModelo vei = new VeiculoModelo();

                vei = veiculoPersistencia.atualizatela(veiculo);

                return vei;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
