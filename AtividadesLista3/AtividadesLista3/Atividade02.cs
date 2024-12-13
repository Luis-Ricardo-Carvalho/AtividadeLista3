using System;

class LivrosBiblioteca
{
    public string titulo;
    public string autor;
    public int ano;
    public int prateleira;

}

class Atividade2
{
    static void addLivros(List<LivrosBiblioteca> listadeLivros)
    {
        LivrosBiblioteca novoLivro = new LivrosBiblioteca();
        Console.WriteLine("*** Dados para Livro ***");
        Console.WriteLine("Título: ");
        novoLivro.titulo = Console.ReadLine();
        Console.WriteLine("Autor: ");
        novoLivro.autor = Console.ReadLine();
        Console.WriteLine("Ano: ");
        novoLivro.ano = int.Parse(Console.ReadLine());
        Console.WriteLine("Prateleira: ");
        novoLivro.prateleira = int.Parse(Console.ReadLine());
        listadeLivros.Add(novoLivro);
        Console.WriteLine("Dados adicionados com sucesso!");

    }

    static void mostraLivros(List<LivrosBiblioteca> listadeLivros)
    {
        Console.WriteLine("*** Dados para Livro ***");
        for (int i = 0; i < listadeLivros.Count; i++)
        {
            Console.WriteLine($"*** Livro {i + 1} ***");
            Console.WriteLine($"Titulo {listadeLivros[i].titulo}");
            Console.WriteLine($"Autor {listadeLivros[i].autor}");
            Console.WriteLine($"Ano {listadeLivros[i].ano}");
            Console.WriteLine($"Prateleira {listadeLivros[i].prateleira}");
            Console.WriteLine("------------------------------------");
        }
    }
    static void buscaLivros(List<LivrosBiblioteca> listadeLivros,
                                           string tituloBusca)
    {
        for (int i = 0; i < listadeLivros.Count; i++)
        {
            string nomeAtual = listadeLivros[i].titulo.ToUpper();

            if (nomeAtual.Contains(tituloBusca.ToUpper()))
            {
                Console.WriteLine($"*** Livro {i + 1} ***");
                Console.WriteLine($"Titulo {listadeLivros[i].titulo}");
                Console.WriteLine($"Autor {listadeLivros[i].autor}");
                Console.WriteLine($"Ano {listadeLivros[i].ano}");
                Console.WriteLine($"Prateleira {listadeLivros[i].prateleira}");
                Console.WriteLine("------------------------------------");
            }// fim if
        }// fim for

    }
    static void buscaAno(List<LivrosBiblioteca> listadeLivros,
                                           int anoBusca)
    {
        for (int i = 0; i < listadeLivros.Count; i++)
        {
            int anoAtual = listadeLivros[i].ano;

            if (anoAtual < anoBusca)
            {
                Console.WriteLine($"*** Livro {i + 1} ***");
                Console.WriteLine($"Titulo {listadeLivros[i].titulo}");
                Console.WriteLine($"Autor {listadeLivros[i].autor}");
                Console.WriteLine($"Ano {listadeLivros[i].ano}");
                Console.WriteLine($"Prateleira {listadeLivros[i].prateleira}");
                Console.WriteLine("------------------------------------");
            }// fim if
        }// fim for

    }



    static int munu()
    {
        Console.WriteLine("*** Sistema de Cadastro ***");
        Console.WriteLine("0-Sair");
        Console.WriteLine("1-Inserir");
        Console.WriteLine("2-Mostrar");
        Console.WriteLine("3-Busca Título");
        Console.WriteLine("4-Buscar Ano");
        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<LivrosBiblioteca> listadeLivros = new List<LivrosBiblioteca>();
        int op;
        do
        {
            op = munu();
            switch (op)
            {
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                case 1:
                    addLivros(listadeLivros);
                    break;
                case 2:
                    mostraLivros(listadeLivros);
                    break;
                case 3:
                    Console.WriteLine("O Título para Buscar: ");
                    String tituloBusca = Console.ReadLine();
                    buscaLivros(listadeLivros, tituloBusca);
                    break;
                case 4:
                    Console.WriteLine("O Ano para Buscar: ");
                    String anoBusca = Console.ReadLine();
                    buscaLivros(listadeLivros, anoBusca);
                    break;
            }//fim switch
            Console.ReadKey(); //pausa
            Console.Clear(); //limpa tela

        } while (op != 0);

        Console.ReadKey();
    }
}