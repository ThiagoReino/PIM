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
    public class RotaControle
    {
        RotaPersistencia rotaPersistencia = new RotaPersistencia();

        public void salvar(RotaModelo rota)
        {
            try
            {
                rotaPersistencia.salvar(rota);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public void alterar(RotaModelo rota)
        {
            try
            {
                rotaPersistencia.alterar(rota);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(RotaModelo rota)
        {
            try
            {
                rotaPersistencia.excluir(rota);
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }

        public RotaModelo pesquisaRota(RotaModelo rota)
        {
            try
            {
                RotaModelo rotaModelo = new RotaModelo();

                rotaModelo = rotaPersistencia.pesquisaRota(rota);

                return rotaModelo;
            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
    }
}

