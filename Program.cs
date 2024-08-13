bool loop = true;

do
{
    Console.WriteLine(@"Qual exercicio quer executar
Digite  1 para Exercicio 1
        2 para Exercicio 2
        3 para Exercicio 3
        4 para Exercicio 4
        5 para Exercicio 5

        6 para sair
");
    int escolha = Convert.ToInt32(Console.ReadLine());


    if (escolha == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------- EXERCICIO 1 -----------------------");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(@"
    
Digite um numero:");

        int numero = Convert.ToInt32(Console.ReadLine());

        bool isOdd = (numero % 2 == 0);

        if (isOdd)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
Seu numero e par
        ");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
Seu numero e impar
        ");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Precione enter para continuar...");
        Console.ReadLine();
    }


    else if (escolha == 2)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------- EXERCICIO 2 -----------------------");
        Console.ForegroundColor = ConsoleColor.White;

        string[] nomes = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(@"
Digite um nome:");
            nomes[i] = Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
Lista de nomes");

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Precione enter para continuar...");
        Console.ReadLine();
    }

    else if (escolha == 3)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------- EXERCICIO 3 -----------------------");
        Console.ForegroundColor = ConsoleColor.White;

        int[] numeros = new int[10];
        int soma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($@"
Digite dez numeros({i + 1}):");

            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                soma += numero;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($@"
Soma dos numeros pares: {soma}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Precione enter para continuar...");
        Console.ReadLine();

    }

    else if (escolha == 4)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------- EXERCICIO 4 -----------------------");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Digite um numero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{numero} x {i} = {i * numero} ");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Precione enter para continuar...");
        Console.ReadLine();
    }

    else if (escolha == 5)
    {
        // 
        // 10 capturar um texto readline
        // percoorer a string capturada
        // 
        //Foreach percorre cada letra da string
        //Pra cada letra, validar se ela esta no array de letras
        //Se nao tiver colocar no array de letras e colocar no array de contador
        //Se tiver 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------- EXERCICIO 4 -----------------------");
        Console.ForegroundColor = ConsoleColor.White;

        char[] alfabeto = new char[27];
        int[] quantidade = new int[27];
        int index = 0;

        Console.WriteLine("Digite um texto:");
        string? texto = Console.ReadLine();

        foreach (char letra in texto)
        {
            int indexFinder = 0;


            if (letra == ' ')
            {
                continue;
            }

            else
            {
                foreach (char l in alfabeto)
                {
                    if (letra == l)
                    {
                        indexFinder = Array.IndexOf(alfabeto, l);

                        quantidade.GetValue(indexFinder);

                        break;
                    }
                    else
                    {
                        alfabeto.SetValue(letra, index);
                        quantidade.SetValue(1, index);
                        index++;
                        break;
                    }
                }

            }

        }
        foreach (var letra in alfabeto)
        {
            int i = 0;

            Console.WriteLine($"{letra} apareceu {quantidade.GetValue(i)}");
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Precione enter para continuar...");
        Console.ReadLine();
    }
    else if (escolha == 6)
    {
        loop = false;
    }

} while (loop == true);