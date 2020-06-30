using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 5;
            p.Nome = "Lee";
            p.Preco = 32f;

            p.Inserir(p);

            List<Produto> lista = p.Ler();

            foreach(Produto item in lista){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"R$:{item.Preco} - {item.Nome}");
            }

            //Buscar por Nome através da expressão lambda
            Produto riven = lista.Find(x => x.Nome == "Yasuo");

            System.Console.WriteLine(riven.Nome);

            

            
        }
        
        
    }
}