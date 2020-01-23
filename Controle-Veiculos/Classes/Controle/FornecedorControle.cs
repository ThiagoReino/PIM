using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos.Classes.Controle
{
    public class FornecedorControle
    {
        FornecedorPersistencia fornecedordb = new FornecedorPersistencia();

        public void salvar(FornecedorModelo fornecedor)
        {
            try
            {
                fornecedordb.salvar(fornecedor);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void alterar(FornecedorModelo fornecedor)
        {
            try
            {
                fornecedordb.alterar(fornecedor);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluir(FornecedorModelo fornecedor)
        {
            try
            {
                fornecedordb.excluir(fornecedor);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public FornecedorModelo atualizatela(FornecedorModelo codigo)
        {
            try
            {
                FornecedorModelo fornec = new FornecedorModelo();

               fornec = fornecedordb.atualizatela(codigo);

                return fornec;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

    }
}
