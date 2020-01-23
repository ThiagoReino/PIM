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
    public class MarcamodeloControle
    {
        MarcamodeloPersistencia marcapesistencia = new MarcamodeloPersistencia();

        public void salvar(MarcamodeloModelo marcamodelo)
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

        public void alterar(MarcamodeloModelo marcamodelo)
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

        public void excluir(MarcamodeloModelo marcamodelo)
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

        public MarcamodeloModelo pesquisaMarca(MarcamodeloModelo marcamodelo)
        {
            try
            {
                MarcamodeloModelo marca = new MarcamodeloModelo();

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
