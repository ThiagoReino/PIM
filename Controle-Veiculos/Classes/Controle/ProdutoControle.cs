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
    public class ProdutoControle
    {
        ProdutoPersistencia produtobd = new ProdutoPersistencia();

        public void salvar(ProdutoModelo produto)
        {
            try
            {
                produtobd.salvar(produto);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(ProdutoModelo produto)
        {
            try
            {
                produtobd.alterar(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(ProdutoModelo produto)
        {
            try
            {
                produtobd.excluir(produto);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public ProdutoModelo atualizatela(ProdutoModelo produto)
        {
            try
            {
                ProdutoModelo pro = new ProdutoModelo();

                pro = produtobd.atualizatela(produto);

                return pro;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public bool atualizaestoque(String wproduto, String wtipo, Decimal wqtde)
        {
            bool retorno = true;
            try
            {

                retorno = produtobd.atualizaestoque(wproduto, wtipo, wqtde);

                return retorno;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
        public bool atualizacusto(String wproduto, DateTime datadacompra, Decimal wqtde, Decimal wvlrunitario)
        {
            bool retorno = true;
            try
            {

                retorno = produtobd.atualizacusto(wproduto, datadacompra, wqtde, wvlrunitario);

                return retorno;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
