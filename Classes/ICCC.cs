using StrategyTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyTest.Classes
{
    class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double resultado = 0;
            if (orcamento.Valor < 1000)
                resultado = orcamento.Valor * 0.05;
            else if (orcamento.Valor >= 1000 && orcamento.Valor < 3000)
                resultado = orcamento.Valor * 0.07;
            else if (orcamento.Valor >= 3000)
                resultado = (orcamento.Valor * 0.08) + 30;

            return resultado;
        }
    }
}
