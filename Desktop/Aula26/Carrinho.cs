using System;
using System.Collections.Generic;

namespace Aula26
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal {get;set;}
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
             carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;

        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach(Produto p in carrinho){
                Console.WriteLine($"R$ {p.Preco,2} - {p.Nome}");
            }

        }
         public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine($"Valor Total da compra R$: {ValorTotal}");
            Console.ResetColor();
    }
    }
}