using System;

class TipoBanda
{
    public string nome;
    public string genero;
    public int integrantes;
    public int ranking;

}

class Program
{
    static void addBanda(List<TipoBanda> listadeBandas)
    {
        TipoBanda novaBanda = new TipoBanda();
        Console.WriteLine("*** Dados para Banda ***");
        Console.WriteLine("Nome: ");
        novaBanda.nome = Console.ReadLine();
        Console.WriteLine("Gênero: ");
        novaBanda.genero = Console.ReadLine();
        Console.WriteLine("Integrantes: ");
        novaBanda.integrantes = int.Parse(Console.ReadLine());
        Console.WriteLine("Ranking: ");
        novaBanda.ranking = int.Parse(Console.ReadLine());
        listadeBandas.Add(novaBanda);
        Console.WriteLine("Dados adicionados com sucesso!");

    }

    static void mostraBanda(List<TipoBanda> listadeBandas)
    {
        Console.WriteLine("*** Dados para Banda ***");
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            Console.WriteLine($"*** Banda {i + 1} ***");
            Console.WriteLine($"Nome {listadeBandas[i].nome}");
            Console.WriteLine($"Genero {listadeBandas[i].genero}");
            Console.WriteLine($"Integrantes {listadeBandas[i].integrantes}");
            Console.WriteLine($"Ranking {listadeBandas[i].ranking}");
            Console.WriteLine("------------------------------------");
        }
    }
    static void buscaBanda(List<TipoBanda> listadeBandas,
                                           string nomeBusca)
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            string nomeAtual = listadeBandas[i].nome.ToUpper();

            if (nomeAtual.Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome:{listadeBandas[i].nome}");
                Console.WriteLine($"Gênero:{listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes:{listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking:{listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------");
                break;
            }// fim if
        }// fim for

    }

    static void alteraBanda(List<TipoBanda> listadeBandas,
                                            string nomeBusca)
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            string nomeAtual = listadeBandas[i].nome.ToUpper();

            if (nomeAtual.Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome:{listadeBandas[i].nome}");
                Console.WriteLine($"Gênero:{listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes:{listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking:{listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Tem certeza que deseja alterar [S/N]?");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 'S' || resp == 's')
                {
                    TipoBanda novaBanda = new TipoBanda();
                    Console.WriteLine("*** Dados para alterar a Banda ***");
                    Console.Write("Nome:");
                    novaBanda.nome = Console.ReadLine();
                    Console.Write("Gênero:");
                    novaBanda.genero = Console.ReadLine();
                    Console.Write("Integrantes:");
                    novaBanda.integrantes = int.Parse(Console.ReadLine());
                    Console.Write("Ranking:");
                    novaBanda.ranking = int.Parse(Console.ReadLine());
                    listadeBandas[i] = novaBanda;
                    Console.WriteLine("Banda alterada com sucesso!");
                }
                else
                    Console.WriteLine("Operação cancelada");
                break;
            }// fim if
        }// fim for

    }

    static void mostraBandaGenero(List<TipoBanda> listadeBandas, String generoBanda)
    {
        bool encontrado = false;
        Console.WriteLine("*** Dados para Banda ***");
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].genero.Equals(generoBanda))
            {
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome {listadeBandas[i].nome}");
                Console.WriteLine($"Genero {listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes {listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking {listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------------");
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("Genero não encontrado");
        }
    }

    static void mostraBandRanking(List<TipoBanda> listadeBandas, int rankingBanda)
    {
        Console.WriteLine("*** Dados para Banda ***");
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].ranking == rankingBanda)
            {
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome {listadeBandas[i].nome}");
                Console.WriteLine($"Genero {listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes {listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking {listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------------");
                break;
            }
        }
    }

    static void removeBanda(List<TipoBanda> listadeBandas, String nomeBanda)
    {
        Console.WriteLine("*** Dados para Banda ***");
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].nome.Equals(nomeBanda))
            {
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome {listadeBandas[i].nome}");
                Console.WriteLine($"Genero {listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes {listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking {listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Tem certeza que deseja excluir [S/N]");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 'S')
                {
                    listadeBandas.RemoveAt(i);
                    Console.WriteLine("Banda excluída com sucesso!");
                }
                else
                {
                    Console.WriteLine("Operação cancelada");
                }
                break;
            }
        }
    }

    static void salvarDados(List<TipoBanda> listadeBandas, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (TipoBanda banda in listadeBandas)
        {
            writer.WriteLine($"{banda.nome},{banda.genero},{banda.integrantes},{banda.ranking}");
        }

        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }



    static void carregarDados(List<TipoBanda> listadeBandas, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                TipoBanda banda = new TipoBanda();
                banda.nome = campos[0];
                banda.genero = campos[1];
                banda.integrantes = int.Parse(campos[2]);
                banda.ranking = int.Parse(campos[3]);
                listadeBandas.Add(banda);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }


    static int munu()
    {
        Console.WriteLine("*** Sistema de Cadastro ***");
        Console.WriteLine("0-Sair");
        Console.WriteLine("1-Inserir");
        Console.WriteLine("2-Mostrar");
        Console.WriteLine("3-Busca banda");
        Console.WriteLine("4-Busca genero");
        Console.WriteLine("5-Busca ranking");
        Console.WriteLine("6-Remover Banda");
        Console.WriteLine("7-Altera Banda");
        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<TipoBanda> listadeBandas = new List<TipoBanda>();
        int op;
        carregarDados(listadeBandas, "dados.txt");
        do
        {
            op = munu();
            switch (op) 
            { 
                case 0: Console.WriteLine("Saindo...");
                    salvarDados(listadeBandas, "dados.txt");
                    break;
                case 1:
                    addBanda(listadeBandas);
                    break;
                case 2:
                    mostraBanda(listadeBandas);
                    break;
                case 3:
                    Console.WriteLine("Banda para buscar: ");
                    String nomeBanda = Console.ReadLine();
                    buscaBanda(listadeBandas,nomeBanda);
                    break;
                case 4:
                    Console.WriteLine("Genero para buscar: ");
                    String generoBanda = Console.ReadLine();
                    mostraBandaGenero(listadeBandas, generoBanda);
                    break;
                case 5:
                    Console.WriteLine("Ranking para buscar: ");
                    int rankingBanda = int.Parse(Console.ReadLine());
                    mostraBandRanking(listadeBandas, rankingBanda);
                    break;
                case 6:
                    Console.WriteLine("Banda para remover: ");
                    nomeBanda = Console.ReadLine();
                    removeBanda(listadeBandas, nomeBanda);
                    break;
                case 7:
                    Console.WriteLine("Banda para alterar: ");
                    nomeBanda = Console.ReadLine();
                    alteraBanda(listadeBandas, nomeBanda);
                    break;
            }//fim switch
            Console.ReadKey(); //pausa
            Console.Clear(); //limpa tela

        }while( op != 0 );

        Console.ReadKey();
    }
}