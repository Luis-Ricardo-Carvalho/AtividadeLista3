using System;

class TipoJogos
{
    public string tituloJ;
    public string consoleJ;
    public int ano;
    public int ranking;
    public int emprestimo;

}

class EmprestimoJogos
{
    public string data;
    public string nome;
    public bool emprestado;

}

class Atividade4
{
    static void addJogo(List<TipoJogos> listadeTipoJogos)
    {
        TipoJogos novoJogo = new TipoJogos();
        Console.WriteLine("*** Dados para Jogo ***");
        Console.WriteLine("Título: ");
        novoJogo.tituloJ = Console.ReadLine();
        Console.WriteLine("Console: ");
        novoJogo.consoleJ = Console.ReadLine();
        Console.WriteLine("Ano: ");
        novoJogo.ano = int.Parse(Console.ReadLine());
        Console.WriteLine("Ranking: ");
        novoJogo.ranking = int.Parse(Console.ReadLine());
        Console.WriteLine("Emprestimo: ");
        novoJogo.emprestimo = int.Parse(Console.ReadLine());
        listadeTipoJogos.Add(novoJogo);
        Console.WriteLine("Dados adicionados com sucesso!");

    }

    static void mostraJogo(List<TipoJogos> listadeTipoJogos)
    {
        Console.WriteLine("*** Dados para Jogo ***");
        for (int i = 0; i < listadeTipoJogos.Count; i++)
        {
            Console.WriteLine($"*** Livro {i + 1} ***");
            Console.WriteLine($"Titulo {listadeTipoJogos[i].tituloJ}");
            Console.WriteLine($"Console {listadeTipoJogos[i].consoleJ}");
            Console.WriteLine($"Ano {listadeTipoJogos[i].ano}");
            Console.WriteLine($"Ranking {listadeTipoJogos[i].ranking}");
            Console.WriteLine($"Emprestimo {listadeTipoJogos[i].emprestimo}");
            Console.WriteLine("------------------------------------");
        }
    }/*
    static void buscaJogo(List<TipoJogos> listadeTipoJogos,
                                           string tituloBusca)
    {
        for (int i = 0; i < listadeTipoJogos.Count; i++)
        {
            string nomeAtual = listadeTipoJogos[i].titulo.ToUpper();

            if (nomeAtual.Contains(tituloBusca.ToUpper()))
            {
                Console.WriteLine($"*** Livro {i + 1} ***");
                Console.WriteLine($"Titulo {listadeTipoJogos[i].titulo}");
                Console.WriteLine($"Autor {listadeTipoJogos[i].autor}");
                Console.WriteLine($"Ano {listadeTipoJogos[i].ano}");
                Console.WriteLine($"Prateleira {listadeTipoJogos[i].prateleira}");
                Console.WriteLine("------------------------------------");
            }// fim if
        }// fim for

    }*//*
    static void buscaAno(List<TipoJogos> listadeTipoJogos,
                                           int anoBusca)
    {
        for (int i = 0; i < listadeTipoJogos.Count; i++)
        {
            int anoAtual = listadeTipoJogos[i].ano;

            if (anoAtual < anoBusca)
            {
                Console.WriteLine($"*** Livro {i + 1} ***");
                Console.WriteLine($"Titulo {listadeTipoJogos[i].titulo}");
                Console.WriteLine($"Autor {listadeTipoJogos[i].autor}");
                Console.WriteLine($"Ano {listadeTipoJogos[i].ano}");
                Console.WriteLine($"Prateleira {listadeTipoJogos[i].prateleira}");
                Console.WriteLine("------------------------------------");
            }// fim if
        }// fim for

    }

    */

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
        List<TipoJogos> listadeLivros = new List<TipoJogos>();
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
                    addJogo(listadeLivros);
                    break;
                case 2:
                    mostraJogo(listadeLivros);
                    break;/*
                case 3:
                    Console.WriteLine("O Título para Buscar: ");
                    String tituloBusca = Console.ReadLine();
                    buscaJogo(listadeLivros, tituloBusca);
                    break;
                case 4:
                    Console.WriteLine("O Ano para Buscar: ");
                    String anoBusca = Console.ReadLine();
                    buscaJogo(listadeLivros, anoBusca);
                    break;*/
            }//fim switch
            Console.ReadKey(); //pausa
            Console.Clear(); //limpa tela

        } while (op != 0);

        Console.ReadKey();
    }
}