using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos.Classes.Controle
{
    public class MarcaControle
    {
        MarcaPersistencia marcapesistencia = new MarcaPersistencia();

        public void salvar(MarcaModelo marcamodelo)
        {
            try
            {
                marcapesistencia.salvar(marcamodelo);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void alterar(MarcaModelo marcamodelo)
        {
            try
            {
                marcapesistencia.alterar(marcamodelo);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluir(MarcaModelo marcamodelo)
        {
            try
            {
                marcapesistencia.excluir(marcamodelo);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public MarcaModelo pesquisaMarca(MarcaModelo marcamodelo)
        {
            try
            {
                MarcaModelo marca = new MarcaModelo();

                marca = marcapesistencia.pesquisaMarca(marcamodelo);

                return marca;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
