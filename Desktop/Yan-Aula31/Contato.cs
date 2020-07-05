using System;

namespace Yan_Aula31
{
    public class Contato : IAgenda
    {
      public string Nome { get; set; }
        public string Telefone { get; set; }
        
        public Contato(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;

        }

        public Contato()
        {
        }

        internal void Cadastrar(Contato p1)
        {
            throw new NotImplementedException();
        }
    }
    
}