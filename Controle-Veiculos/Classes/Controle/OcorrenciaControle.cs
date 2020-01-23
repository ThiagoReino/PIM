using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Controle
{
    public class OcorrenciaControle
    {
        OcorrenciaPersistencia ocorrenciaPersistencia = new OcorrenciaPersistencia();

        public void salvar(OcorrenciaModelo ocorrencia)
        {
            try
            {
                ocorrenciaPersistencia.salvar(ocorrencia);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(OcorrenciaModelo ocorrencia)
        {
            try
            {
                ocorrenciaPersistencia.alterar(ocorrencia);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(OcorrenciaModelo ocorrencia)
        {
            try
            {
                ocorrenciaPersistencia.excluir(ocorrencia);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public OcorrenciaModelo pesquisaOcorrencia(OcorrenciaModelo ocorrencia)
        {
            try
            {
                OcorrenciaModelo ocorrenciaModelo = new OcorrenciaModelo();

                ocorrenciaModelo = ocorrenciaPersistencia.pesquisaOcorrencia(ocorrencia);

                return ocorrenciaModelo;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}
