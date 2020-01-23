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
    public class MensagemControle
    {
        MensagemControle mensagemdb = new MensagemControle();

        public void salvar(MensagemModelo mensagem)
        {
            try
            {
                mensagemdb.salvar(mensagem);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
        public void alterar(MensagemModelo mensagem)
        {
            try
            {
                mensagemdb.alterar(mensagem);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
        public void excluir(MensagemModelo mensagem)
        {
            try
            {
                mensagemdb.excluir(mensagem);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
    }
}
