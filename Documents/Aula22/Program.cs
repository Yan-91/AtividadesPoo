using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Conversor.CotacaoLibras = 6.55f;
            Console.WriteLine(Conversor.ConverterLibrasParaReal(200));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Conversor.ConverterRealParaLibras(200));
            Console.ResetColor();
        }
    }
}
