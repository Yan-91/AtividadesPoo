using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Conversor.CotacaoDolar = 5.23f;
            Console.WriteLine(Conversor.ConverterDolarParaReal(200));
            Console.WriteLine(Conversor.ConverterRealParaDolar(200));
            Console.ResetColor();
        }
    }
}
