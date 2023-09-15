using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número decimal: ");
        int numDecimal = Convert.ToInt32(Console.ReadLine());

        string numBinario = Convert.ToString(numDecimal, 2);

        Console.WriteLine("O número em binário é: " + numBinario);
    }
}