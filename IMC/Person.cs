using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
     public class PessoaMain
    {
        
            public double Peso { get; }
            public double AlturaCm { get; }

            public PessoaMain(double peso, double alturaCm)
            {
                Peso = peso;
                AlturaCm = alturaCm;
            }

            public double CalcularAlturaMetros()
            {
                return AlturaCm / 100;
            }
    }
}

