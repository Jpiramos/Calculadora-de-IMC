using Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    public class CalcularIMC
    {
            public double CalculadoraIMC(PessoaMain pessoa)
            {
                double alturaMetros = pessoa.CalcularAlturaMetros();
                return pessoa.Peso / (alturaMetros * alturaMetros);
            }

            public string ClassificarIMC(double imc)
            {
                if (imc < 18.5)
                {
                    return "Abaixo do peso";
                }
                else if (imc < 24.9)
                {
                    return "Peso saudável";
                }
                else if (imc < 29.9)
                {
                    return "Sobrepeso";
                }
                else if (imc < 34.9)
                {
                    return "Obesidade grau I";
                }
                else if (imc < 39.9)
                {
                    return "Obesidade grau II";
                }
                else
                {
                    return "Obesidade grau III (mórbida)";
                }
            }

        internal double CalculdoraIMC(PessoaMain pessoaMain)
        {
            throw new NotImplementedException();
        }
    }
    }



