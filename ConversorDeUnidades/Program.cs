class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("==== Conversor de Unidades ====");
            Console.WriteLine("1. Converter Temperatura");
            Console.WriteLine("2. Converter Comprimento");
            Console.WriteLine("3. Converter Peso");
            Console.WriteLine("4. Converter Volume");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    ConverterTemperatura();
                    break;
                case "2":
                    ConverterComprimento();
                    break;
                case "3":
                    ConverterPeso();
                    break;
                case "4":
                    ConverterVolume();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ConverterTemperatura()
    {
        Console.WriteLine("==== Conversão de Temperatura ====");
        Console.WriteLine("1. Celsius para Fahrenheit");
        Console.WriteLine("2. Fahrenheit para Celsius");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        Console.WriteLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
                break;
            case "2":
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double fahrenheit2 = Convert.ToDouble(Console.ReadLine());
                double celsius2 = (fahrenheit2 - 32) * 5 / 9;
                Console.WriteLine("Temperatura em Celsius: " + celsius2);
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
    }

    static void ConverterComprimento()
    {
        Console.WriteLine("==== Conversão de Comprimento ====");
        Console.WriteLine("1. Metro para Polegada");
        Console.WriteLine("2. Polegada para Metro");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        Console.WriteLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite o valor em metros: ");
                double metro = Convert.ToDouble(Console.ReadLine());
                double polegada = metro * 39.37;
                Console.WriteLine("Valor em Polegada: " + polegada);
                break;
            case "2":
                Console.Write("Digite o valor em polegadas: ");
                double polegada2 = Convert.ToDouble(Console.ReadLine());
                double metro2 = polegada2 / 39.37;
                Console.WriteLine("Valor em Metro: " + metro2);
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
    }

    static void ConverterPeso()
    {
        Console.WriteLine("==== Conversão de Peso ====");
        Console.WriteLine("1. Quilograma para Libra");
        Console.WriteLine("2. Libra para Quilograma");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        Console.WriteLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite o valor em quilogramas: ");
                double quilograma = Convert.ToDouble(Console.ReadLine());
                double libra = quilograma * 2.205;
                Console.WriteLine("Valor em Libra: " + libra);
                break;
            case "2":
                Console.Write("Digite o valor em libras: ");
                double libra2 = Convert.ToDouble(Console.ReadLine());
                double quilograma2 = libra2 / 2.205;
                Console.WriteLine("Valor em Quilograma: " + quilograma2);
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
    }

    static void ConverterVolume()
    {
        Console.WriteLine("==== Conversão de Volume ====");
        Console.WriteLine("1. Litro para Galão");
        Console.WriteLine("2. Galão para Litro");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        Console.WriteLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite o valor em litros: ");
                double litro = Convert.ToDouble(Console.ReadLine());
                double galao = litro * 0.264;
                Console.WriteLine("Valor em Galão: " + galao);
                break;
            case "2":
                Console.Write("Digite o valor em galões: ");
                double galao2 = Convert.ToDouble(Console.ReadLine());
                double litro2 = galao2 / 0.264;
                Console.WriteLine("Valor em Litro: " + litro2);
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
    }
}