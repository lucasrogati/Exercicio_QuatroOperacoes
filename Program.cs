string opcao = "";

while (opcao != "S")
{
    Console.Clear();

    Console.WriteLine("===== MENU DA CALCULADORA =====");
    Console.WriteLine();
    Console.WriteLine("+ - Adição");
    Console.WriteLine("- - Subtração");
    Console.WriteLine("* - Multiplicação");
    Console.WriteLine("/ - Divisão");
    Console.WriteLine("S - Encerrar");
    Console.Write("\nDigite a opção desejada: ");

    opcao = Console.ReadLine().ToUpper();

    if (opcao == "+")
    {
        Console.Clear();

        Console.WriteLine(">>> OPERAÇÃO DE ADIÇÃO <<<");

        Console.Write("Informe o primeiro valor: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o segundo valor: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double resultado = n1 + n2;

        Console.WriteLine("\nO resultado da soma é: " + resultado);

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    else if (opcao == "-")
    {
        Console.Clear();

        Console.WriteLine(">>> OPERAÇÃO DE SUBTRAÇÃO <<<");

        Console.Write("Informe o primeiro valor: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o segundo valor: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double resultado = n1 - n2;

        Console.WriteLine("\nO resultado da subtração é: " + resultado);

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    else if (opcao == "*")
    {
        Console.Clear();

        Console.WriteLine(">>> OPERAÇÃO DE MULTIPLICAÇÃO <<<");

        Console.Write("Informe o primeiro valor: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o segundo valor: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double resultado = n1 * n2;

        Console.WriteLine("\nO resultado da multiplicação é: " + resultado);

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    else if (opcao == "/")
    {
        Console.Clear();

        Console.WriteLine(">>> OPERAÇÃO DE DIVISÃO <<<");

        Console.Write("Informe o primeiro valor: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o segundo valor: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        if (n2 == 0)
        {
            Console.WriteLine("\nErro! Não existe divisão por zero.");
        }
        else
        {
            double resultado = n1 / n2;
            Console.WriteLine("\nO resultado da divisão é: " + resultado);
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    else if (opcao == "S")
    {
        Console.WriteLine("\nPrograma encerrado.");
    }
    else
    {
        Console.WriteLine("\nA opção digitada não existe.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}

Console.WriteLine("\nObrigado por utilizar a calculadora!");