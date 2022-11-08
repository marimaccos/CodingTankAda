using System;

namespace CodingTankCSharp {
    class CadastroLivro {
        static void Main(string[] args) {
            
            Console.WriteLine("---CADASTRO---");
            Console.WriteLine("Digite o título: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o subtítulo: ");
            string subtitulo = Console.ReadLine();

            Console.WriteLine("Digite o autor: ");
            string autor = Console.ReadLine();
            
            Console.WriteLine("Digite o editora: ");
            string editora = Console.ReadLine();

            Console.WriteLine("Digite o número de páginas: ");
            int.TryParse(Console.ReadLine(), out int numPaginas );

            Console.WriteLine("Digite a data de publicacao: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime dataPublicacao); 

            Console.WriteLine("Digite o idioma: ");
            string idioma = Console.ReadLine();
            
            Console.Clear();

            Console.WriteLine("-------------------");
            Console.WriteLine("Livro cadastrado com sucesso!");
            Console.WriteLine($"Livro: {titulo} - {subtitulo}");
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Editora: " + editora);
            Console.WriteLine($"Detalhes: Publicado em {dataPublicacao.ToShortDateString} com {numPaginas} paginas em {idioma}.");
            Console.WriteLine("-------------------");
        }
    }
}