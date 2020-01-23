using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Veiculos.Classes.Modelo
{
    public class VeiculoModelo
    {
        public int codigo { get; set; }

        public int marcamodelocodigo { get; set; }

        public string placa { get; set; }

        public string chassi { get; set; }

        public string combustivel { get; set; }

        public int anofabrica { get; set; }

        public int anomodelo { get; set; }

        public string codigorenavan { get; set; }

        public int exercicio { get; set; }

        public string situacao { get; set; }

        public DateTime datavenda { get; set; }

        public decimal valorvenda { get; set; }

        public DateTime databaixa { get; set; }
        
        public string motivobaixa { get; set; }

        public int seguradoracodigo { get; set; }

        public DateTime datainiciovigencia { get; set; }

        public DateTime datafimvigencia { get; set; }

    }
}

