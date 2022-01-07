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
            Imposto iccc = new ICCC();


            Orcamento orcamento = new Orcamento(1000);

            CalculadorDeImposto calculador = new CalculadorDeImposto();
            Console.WriteLine("ICMS:");
            calculador.CalcularImposto(orcamento, icms);
            Console.WriteLine("ISS:");
            calculador.CalcularImposto(orcamento, iss);
            Console.WriteLine("ICCC:");
            calculador.CalcularImposto(orcamento, iccc);


            Console.ReadKey();
        }
    }
}
