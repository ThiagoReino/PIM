using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Model;
using Controle_Veiculos.Classes.Persistencia;
using System.Data;

namespace Controle_Veiculos.Classes.Controle
{
    public class CidadeControle
    {
        CidadeControle cidadePersistencia = new CidadeControle();
        public void salvar(CidadeControle cidade)
        {
            try
            {
                cidadePersistencia.salvar(cidade);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(CidadeControle cidade)
        {
            try
            {
                cidadePersistencia.alterar(cidade);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public void excluir(CidadeControle cidade)
        {
            try
            {
                cidadePersistencia.excluir(cidade);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public CidadeControle atualizatela(CidadeControle cidade)
        {
            try
            {
                CidadeControle cid = new CidadeControle();

                cid = cidadePersistencia.atualizatela(cidade);

                return cid;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
        public CidadeControle PesquisaPorNome(CidadeControle cidade)
        {
            try
            {
                CidadeControle cid = new CidadeControle();

                cid = cidadePersistencia.PesquisaPorNome(cidade);

                return cid;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
