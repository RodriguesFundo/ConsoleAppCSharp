using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        char[] array = palavra.ToCharArray();
        Array.Reverse(array);
        string palavraInvertida = new string(array);

        if (palavra.Equals(palavraInvertida, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("A palavra é um palíndromo.");
        else
            Console.WriteLine("A palavra não é um palíndromo.");
    }
}