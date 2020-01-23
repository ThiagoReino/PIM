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
    public class CompraItemControle
    {
        CompraItemPersistencia compraitemdb = new CompraItemPersistencia();

        public void salvar(CompraitemModelo compraitem)
        {
            try
            {
                compraitemdb.salvar(compraitem);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void alterar(CompraitemModelo compraitem)
        {
            try
            {
                compraitemdb.alterar(compraitem);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluir(CompraitemModelo compraitem)
        {
            try
            {
                compraitemdb.excluir(compraitem);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
