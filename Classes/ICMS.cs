using System;
using StrategyTest.Interfaces;

namespace StrategyTest.Classes
{
    class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
