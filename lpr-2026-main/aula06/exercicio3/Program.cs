using System;

class Program
{
    static void Main()
    {
        // Variáveis para os 5 Heróis Cadastrados
        string h1Nome = "", h1Poder = ""; int h1Pontos = 0;
        string h2Nome = "", h2Poder = ""; int h2Pontos = 0;
        string h3Nome = "", h3Poder = ""; int h3Pontos = 0;
        string h4Nome = "", h4Poder = ""; int h4Pontos = 0;
        string h5Nome = "", h5Poder = ""; int h5Pontos = 0;

        // Variáveis para os 3 Heróis da Equipe Selecionada
        string eq1Nome = "", eq1Poder = ""; int eq1Pontos = 0;
        string eq2Nome = "", eq2Poder = ""; int eq2Pontos = 0;
        string eq3Nome = "", eq3Poder = ""; int eq3Pontos = 0;

        menuPrincipal(
            ref h1Nome, ref h1Poder, ref h1Pontos,
            ref h2Nome, ref h2Poder, ref h2Pontos,
            ref h3Nome, ref h3Poder, ref h3Pontos,
            ref h4Nome, ref h4Poder, ref h4Pontos,
            ref h5Nome, ref h5Poder, ref h5Pontos,
            ref eq1Nome, ref eq1Poder, ref eq1Pontos,
            ref eq2Nome, ref eq2Poder, ref eq2Pontos,
            ref eq3Nome, ref eq3Poder, ref eq3Pontos
        );
    }

    static void menuPrincipal(
        ref string h1n, ref string h1p, ref int h1pts,
        ref string h2n, ref string h2p, ref int h2pts,
        ref string h3n, ref string h3p, ref int h3pts,
        ref string h4n, ref string h4p, ref int h4pts,
        ref string h5n, ref string h5p, ref int h5pts,
        ref string e1n, ref string e1p, ref int e1pts,
        ref string e2n, ref string e2p, ref int e2pts,
        ref string e3n, ref string e3p, ref int e3pts)
    {
        int opcao = 0;
        do
        {
            Console.WriteLine("\n--- SISTEMA AVENGERS ---");
            Console.WriteLine("1 - Cadastrar 5 Heróis");
            Console.WriteLine("2 - Selecionar Equipe (3 Heróis)");
            Console.WriteLine("3 - Exibir Equipe e Pontuação");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHerois(ref h1n, ref h1p, ref h1pts, ref h2n, ref h2p, ref h2pts, 
                                    ref h3n, ref h3p, ref h3pts, ref h4n, ref h4p, ref h4pts, 
                                    ref h5n, ref h5p, ref h5pts);
                    break;
                case 2:
                    selecionarEquipe(h1n, h1p, h1pts, h2n, h2p, h2pts, h3n, h3p, h3pts, 
                                     h4n, h4p, h4pts, h5n, h5p, h5pts,
                                     ref e1n, ref e1p, ref e1pts, ref e2n, ref e2p, ref e2pts, 
                                     ref e3n, ref e3p, ref e3pts);
                    break;
                case 3:
                    exibirEquipe(e1n, e1p, e1pts, e2n, e2p, e2pts, e3n, e3p, e3pts);
                    break;
            }
        } while (opcao != 4);
    }

    static void cadastrarHerois(ref string n1, ref string p1, ref int pt1, ref string n2, ref string p2, ref int pt2, 
                                 ref string n3, ref string p3, ref int pt3, ref string n4, ref string p4, ref int pt4, 
                                 ref string n5, ref string p5, ref int pt5)
    {
        // Exemplo simplificado: cadastrando os 5 de uma vez para seguir a regra de variáveis locais
        Console.WriteLine("\n--- Cadastro de 5 Heróis ---");
        
        Console.Write("Herói 1 - Nome: "); n1 = Console.ReadLine();
        Console.Write("Herói 1 - Poder: "); p1 = Console.ReadLine();
        Console.Write("Herói 1 - Pontos: "); pt1 = int.Parse(Console.ReadLine());

        Console.Write("Herói 2 - Nome: "); n2 = Console.ReadLine();
        Console.Write("Herói 2 - Poder: "); p2 = Console.ReadLine();
        Console.Write("Herói 2 - Pontos: "); pt2 = int.Parse(Console.ReadLine());

        Console.Write("Herói 3 - Nome: "); n3 = Console.ReadLine();
        Console.Write("Herói 3 - Poder: "); p3 = Console.ReadLine();
        Console.Write("Herói 3 - Pontos: "); pt3 = int.Parse(Console.ReadLine());

        Console.Write("Herói 4 - Nome: "); n4 = Console.ReadLine();
        Console.Write("Herói 4 - Poder: "); p4 = Console.ReadLine();
        Console.Write("Herói 4 - Pontos: "); pt4 = int.Parse(Console.ReadLine());

        Console.Write("Herói 5 - Nome: "); n5 = Console.ReadLine();
        Console.Write("Herói 5 - Poder: "); p5 = Console.ReadLine();
        Console.Write("Herói 5 - Pontos: "); pt5 = int.Parse(Console.ReadLine());
    }

    static void selecionarEquipe(string n1, string p1, int pt1, string n2, string p2, int pt2, 
                                 string n3, string p3, int pt3, string n4, string p4, int pt4, 
                                 string n5, string p5, int pt5,
                                 ref string en1, ref string ep1, ref int ept1, 
                                 ref string en2, ref string ep2, ref int ept2, 
                                 ref string en3, ref string ep3, ref int ept3)
    {
        Console.WriteLine("\n--- Selecione 3 Heróis para a Equipe ---");
        Console.WriteLine($"1. {n1} | 2. {n2} | 3. {n3} | 4. {n4} | 5. {n5}");

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Escolha o herói {i} (digite o número 1-5): ");
            int escolha = int.Parse(Console.ReadLine());

            // Lógica para atribuir os valores da escolha à variável da equipe correspondente
            string tempNome = ""; string tempPoder = ""; int tempPts = 0;

            if (escolha == 1) { tempNome = n1; tempPoder = p1; tempPts = pt1; }
            else if (escolha == 2) { tempNome = n2; tempPoder = p2; tempPts = pt2; }
            else if (escolha == 3) { tempNome = n3; tempPoder = p3; tempPts = pt3; }
            else if (escolha == 4) { tempNome = n4; tempPoder = p4; tempPts = pt4; }
            else if (escolha == 5) { tempNome = n5; tempPoder = p5; tempPts = pt5; }

            if (i == 1) { en1 = tempNome; ep1 = tempPoder; ept1 = tempPts; }
            else if (i == 2) { en2 = tempNome; ep2 = tempPoder; ept2 = tempPts; }
            else if (i == 3) { en3 = tempNome; ep3 = tempPoder; ept3 = tempPts; }
        }
    }

    static int calcularPontuacaoTotal(int pt1, int pt2, int pt3)
    {
        return pt1 + pt2 + pt3;
    }

    static void exibirEquipe(string n1, string p1, int pt1, string n2, string p2, int pt2, string n3, string p3, int pt3)
    {
        Console.WriteLine("\n--- SUA EQUIPE ---");
        Console.WriteLine($"Herói 1: {n1} - Poder: {p1} ({pt1} pts)");
        Console.WriteLine($"Herói 2: {n2} - Poder: {p2} ({pt2} pts)");
        Console.WriteLine($"Herói 3: {n3} - Poder: {p3} ({pt3} pts)");
        
        int total = calcularPontuacaoTotal(pt1, pt2, pt3);
        Console.WriteLine($"PONTUAÇÃO TOTAL: {total}");
    }
}