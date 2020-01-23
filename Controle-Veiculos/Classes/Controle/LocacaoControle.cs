using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Controle
{
    public class LocacaoControle
    {
        LocacaoPersistencia locacaoPersistencia = new LocacaoPersistencia();
        public void salvar(LocacaoModelo locacao)
        {
            try
            {
                locacaoPersistencia.salvar(locacao);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(LocacaoModelo locacao)
        {
            try
            {
                locacaoPersistencia.alterar(locacao);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public void excluir(LocacaoModelo locacao)
        {
            try
            {
                locacaoPersistencia.excluir(locacao);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public LocacaoModelo atualizatela(LocacaoModelo locacao)
        {
            try
            {
                LocacaoModelo loc = new LocacaoModelo();

                locacao = locacaoPersistencia.atualizatela(locacao);

                return locacao;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
        public LocacaoModelo PesquisaPorNome(LocacaoModelo locacao)
        {
            try
            {
                LocacaoModelo loc = new LocacaoModelo();

                loc = locacaoPersistencia.atualizatela(locacao);

                return loc;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}

