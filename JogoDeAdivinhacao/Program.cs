using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int tentativas = 0;
        int palpite = 0;

        Console.WriteLine("Jogo de Adivinhação - Adivinhe o número de 1 a 100!");

        while (palpite != numeroAleatorio)
        {
            Console.Write("Digite seu palpite: ");
            palpite = Convert.ToInt32(Console.ReadLine());

            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("Tente um número maior.");
                tentativas++;
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("Tente um número menor.");
                tentativas++;
            }
        }

        Console.WriteLine("Parabéns! Você acertou o número em " + tentativas + " tentativas.");
    }
}