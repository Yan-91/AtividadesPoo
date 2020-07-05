using System;

namespace Yan_Aula31
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda contacts = new Agenda();
            Contato p1 = new Contato();
            
            p1.Nome = "Kaua";
            p1.Telefone = "(11) 2932-4595";




            Mensagem texto = new Mensagem();
            texto.Texto = "Olá!";
            texto.Destinatario = p1;


            contacts.Cadastrar(p1);
            contacts.Excluir("linha");
            System.Console.WriteLine(texto.Enviar(texto.Destinatario));       
            

    }
    }
}