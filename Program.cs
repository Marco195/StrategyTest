using System;
using StrategyTest.Interfaces;
using StrategyTest.Classes;

namespace StrategyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new ICMS();
            Imposto iss = new ISS();

            Orcamento orcamento = new Orcamento(50000);

            CalculadorDeImposto calculador = new CalculadorDeImposto();
            calculador.CalcularImposto(orcamento, icms);
            calculador.CalcularImposto(orcamento, iss);

            Console.ReadKey();
        }
    }
}
