using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int fatorial = 1;

        for (int i = 2; i <= num; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine("O fatorial de " + num + " é: " + fatorial);
    }
}