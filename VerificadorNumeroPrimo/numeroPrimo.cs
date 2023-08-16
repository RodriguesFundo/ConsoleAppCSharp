using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime && num > 1)
            Console.WriteLine("O numero e primo.");
        else
            Console.WriteLine("O numero nao e primo.");
    }
}