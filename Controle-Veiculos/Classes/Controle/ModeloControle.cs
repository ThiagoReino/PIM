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
    public class ModeloControle
    {
        ModeloModelo modelodb = new ModeloModelo();

        public void salvar(Modelo modelo)
        {
            try
            {
                modelodb.salvar(modelo);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(Modelo modelo)
        {
            try
            {
                modelodb.alterar(modelo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(Modelo modelo)
        {
            try
            {
                modelodb.excluir(modelo);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
