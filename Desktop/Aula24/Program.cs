using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            rec.GerarSequenciaFibonacci(0,1,20);
            
            Console.WriteLine( rec.GerarFatorial(8));

        }
    }
}
