using System;
using StrategyTest.Classes;
using StrategyTest.Interfaces;

namespace StrategyTest.Classes
{
    public class CalculadorDeImposto
    {
        public void CalcularImposto(Orcamento orcamento, Imposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
