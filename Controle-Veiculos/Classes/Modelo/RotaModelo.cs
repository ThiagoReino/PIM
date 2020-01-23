using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RotaModelo
{
    public int controle { get; set; }

    public DateTime datainicio { get; set; }

    public TimeSpan horainicio { get; set; }

    public DateTime datafim { get; set; }

    public TimeSpan horafim { get; set; }

    public int motoristacodigo { get; set; }

    public int nrpassageiros { get; set; }

    public int veiculocodigo { get; set; }

    public string localorigem { get; set; }

    public string localdestino { get; set; }

    public decimal kmpercorrido { get; set; }

    public string descricaoatendimento { get; set; }
}
