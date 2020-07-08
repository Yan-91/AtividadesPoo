using System.Collections.Generic;
using Aula34.Models;

namespace Aula34.Views
{
    public class ProdutoView
    {
                public void MostrarNoConsole(List<Produto> lista)
        {
            foreach(Produto item in lista){
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome} ");
            }
        }

    }
}