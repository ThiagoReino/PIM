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
    public class GrupoControle
    {
        GrupoPersistencia grupodb = new GrupoPersistencia();

        public void salvar(GrupoModelo grupo)
        {
            try
            {
                grupodb.salvar(grupo);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void alterar(GrupoModelo grupo)
        {
            try
            {
                grupodb.alterar(grupo);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluir(GrupoModelo grupo)
        {
            try
            {
                grupodb.excluir(grupo);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public GrupoModelo atualizatela(GrupoModelo codigo)
        {
            try
            {
                GrupoModelo grupo = new GrupoModelo();

                grupo = grupodb.atualizatela(codigo);

                return grupo;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
