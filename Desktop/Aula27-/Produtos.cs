using System.IO;

namespace Aula27
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        

        private const string PATH = "Database/produtos.csv";

        public Produto(){
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH))
            {
              File.Create(PATH).Close();
            }
        }
        public void Cadastrar(Produto prod)
        {
            var Linha = new string[]{ PrepararLinha(prod) };
            

            File.AppendAllLines(PATH , Linha);
        }
        public string PrepararLinha(Produto p){
            return $"codigo={p.Codigo};nome={p.Nome};preco={p.Preco}";
        }
    }
}