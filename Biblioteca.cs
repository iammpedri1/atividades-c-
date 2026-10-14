class Biblioteca
{
    public string Autor { get; set; }
    public string Titulo { get; set; }
    public bool Disponivel { get; set; }

    public static void Main()
    {
        Biblioteca livro = new Biblioteca
        {
            Autor = "J.K. Rowling",
            Titulo = "Harry Potter",
            Disponivel = true
        };

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("\nBIBLIOTECA");
            Console.WriteLine("1 - Listar Livro");
            Console.WriteLine("2 - Emprestar Livro");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Livro disponível: {livro.Titulo}");
                    Console.WriteLine($"Autor: {livro.Autor}");
                    break;

                case 2:
                    Console.WriteLine("Digite o nome do livro: ");
                    string livroEscolhido = Console.ReadLine();

                    if (livroEscolhido == livro.Titulo)
                    {
                        if (livro.Disponivel)
                        {
                            livro.Disponivel = false;
                            Console.WriteLine($"Livro {livro.Titulo} emprestado.");
                        }
                        else
                        {
                            Console.WriteLine("Livro já está emprestado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Saindo da biblioteca...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}