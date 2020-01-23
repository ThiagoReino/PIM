using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Model
{
    public class SeguradoraControle
    {
        SeguradoraPersistencia seguradodb = new SeguradoraPersistencia();

        public void salvar(SeguradoraModelo seguradora)
        {
            try
            {
                seguradodb.salvar(seguradora);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(SeguradoraModelo seguradora)
        {
            try
            {
                seguradodb.alterar(seguradora);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(SeguradoraModelo seguradora)
        {
            try
            {
                seguradodb.excluir(seguradora);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public SeguradoraModelo atualizatela(SeguradoraModelo codigo)
        {
            try
            {
                SeguradoraModelo seg = new SeguradoraModelo();

                seg = seguradodb.atualizatela(codigo);

                return seg;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

    }
}
