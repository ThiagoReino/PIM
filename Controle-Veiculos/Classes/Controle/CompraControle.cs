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
    public class CompraControle
    {
        CompraPersistencia compradb = new CompraPersistencia();

        public int salvar(CompraModelo compra)
        {
            int wretorno = 0;
            try
            {
                wretorno = compradb.salvar(compra);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return wretorno;
        }

        public void alterar(CompraModelo compra)
        {
            try
            {
                compradb.alterar(compra);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public bool atualizavalorcompra(CompraModelo compra,String wtipo,Decimal wvalor)
        {
            bool retorno = false;
            try
            {
                retorno = compradb.atualizavalorcompra(compra, wtipo, wvalor);
            }
            catch (Exception erro)
            {

                throw erro;
            }
            return retorno;
        }

        public void excluir(CompraModelo compra)
        {
            try
            {
                compradb.excluir(compra);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public CompraModelo atualizatela(CompraModelo controle)
        {
            try
            {
                CompraModelo compra = new CompraModelo();

                compra = compradb.atualizatela(controle);

                return compra;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

    }
}
